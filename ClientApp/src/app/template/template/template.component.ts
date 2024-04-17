import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Observable, Subject, forkJoin, takeUntil } from 'rxjs';
import { EntityDataService } from 'src/app/angular-app-services/entity-data.service';
import { LayoutService } from 'src/app/angular-app-services/layout.service';
import { DEFAULT_PAGESIZE, _camelCase } from 'src/app/library/utils';
import { Option } from '../dynamic-layout/layout-models';
import { FormControl, FormGroup } from '@angular/forms';
import { IDataState } from '../tempale-list/idata-state.interface';

@Component({
  selector: 'app-template',
  templateUrl: './template.component.html',
  styleUrl: './template.component.scss'
})
export class TemplateComponent implements OnInit, OnDestroy {
  entityName: string = '';
  form?: FormGroup;
  fieldOptions: { [key: string]: Option[]; } = {};
  filterFields: any[] = [];
  isLoading: boolean = false;
  isLoadMore: boolean = true;
  mappedListData: any[] = [];
  mappedPreviewData: any[] = [];
  selectedId: string = '';
  selectedIndex: number | null = null;

  private destroy = new Subject();
  private editLayout: any[] = [];
  private filterLayout: any;
  private filters: any[] = [];
  private listLayout: any;
  private pageNumber: number = 1;
  private pageSize: number = DEFAULT_PAGESIZE;
  private searchTerm: string = '';
  private sortField: string = '';
  private sortOrder: string = 'asc';
  private records: any[] = [];

  constructor(
    private route: ActivatedRoute,
    private entityDataService: EntityDataService,
    private layoutService: LayoutService
  ) { }

  ngOnInit(): void {
    this.getEntityName();
  }

  ngOnDestroy(): void {
    this.destroy.next(true);
    this.destroy.complete();
  }

  public onLoadNext(emitedData: IDataState): void {
    this.pageNumber = emitedData.pageNumber;
    this.searchTerm = emitedData.searchTerm;
    this.filters = emitedData.filter;
    if (this.pageNumber === 1) {
      this.onRefreshData();
    }
    this.loadData();
  }

  public onRefreshData(): void {
    this.records = [];
    this.mappedListData = [];
    this.mappedPreviewData = [];
  }

  public onFilterChange(filters: any[] = [], selectedId: string = ''): void {
    this.selectedId = selectedId;
    this.records = [];
    this.mappedListData = [];
    this.mappedPreviewData = [];
    this.filters = filters;
    this.pageNumber = 1;
    this.loadData();
  }

  public onRefresh(): void {
    this.onFilterChange([], this.selectedId);
  }

  public previewRecord(index: number): void {
    if (this.records?.length > index) {
      this.mapPreviewData(this.records[index]);
    }
  }

  private getEntityName(): void {
    this.route.params
      .pipe(takeUntil(this.destroy))
      .subscribe(params => {
        this.entityName = params['entityName'];
        this.selectedIndex = null;
        this.resetData();
        this.getList();
      });
  }

  private getFormattedData(record: any, fieldInfo: any): any {
    if (!fieldInfo?.dataType || !fieldInfo?.fieldName || !record) return '';
    const fieldName = _camelCase(fieldInfo.fieldName),
      data = record[fieldName] || '';
    switch (fieldInfo.dataType.toLowerCase()) {
      case 'datetime': {
        const date = Date.parse(data + 'Z');
        return isNaN(date) ? data : new Date(data + 'Z').toLocaleDateString();
      }
      case 'numeric':
        return record[fieldName] !== undefined && record[fieldName] !== null ? new Intl.NumberFormat().format(Number(data)) : '';
      case 'boolean':
        return data ? 'Yes' : 'No';
      case 'guid': {
        const refProp = `${fieldName}_${fieldInfo.dataSource}`.toLowerCase(),
          refPropertyName = record[refProp] || Object.keys(record)?.find(o => o.toLowerCase() === refProp),
          refObject = refPropertyName ? record[refPropertyName] : null;
        return refObject?.name || this.getRefData(refObject?.$ref, this.records)?.name || data;
      }
      default:
        return data;
    }
  }

  private getList(): void {
    this.resetData();
    const apis = [
      this.layoutService.getLayout(this.entityName, 'List'),
      this.layoutService.getLayout(this.entityName, 'Edit')
    ];
    forkJoin(apis)
      .pipe(takeUntil(this.destroy))
      .subscribe({
        next: ([listLayout, editLayout]) => {

          this.editLayout = editLayout;
          this.listLayout = listLayout?.grid;
          this.filterLayout = listLayout?.filter;
          this.sortField = this.listLayout?.cardTitle?.fields?.[0]?.fieldName ?? '';
          this.prepareFilterFields();
          this.loadData();
        }
      });
  }

  private getRefData(ref: string, records: any): any {
    if (Array.isArray(records)) {
      for (const record of records) {
        if (typeof record === 'object') {
          const val = this.getRefData(ref, record);
          if (val) return val;
        }
      }
    } else {
      for (const [key, value] of Object.entries(records)) {
        if (key === '$id' && value === ref) {
          return records;
        } else if (typeof value === 'object') {
          const val = this.getRefData(ref, value);
          if (val) return val;
        }
      }
    }
  }

  private loadData(): void {
    this.isLoading = true;
    this.entityDataService.getRecords(this.entityName, this.filters, this.searchTerm, this.pageNumber, this.pageSize, this.sortField, this.sortOrder)
      .pipe(takeUntil(this.destroy))
      .subscribe({
        next: (records) => {
          this.isLoadMore = this.pageSize === records.length;

          if (!Array.isArray(this.records))
            this.records = [];

          if (records?.length > 0) {
            records.forEach(record => {
              this.records.push(record);
            });
          }

          this.prepareMappedData();

          const selectedRecordIndex = this.records?.findIndex(x => x.id === this.selectedId) || -1;
          this.selectedIndex = selectedRecordIndex > -1 ? selectedRecordIndex : 0;
          this.mapPreviewData(this.records?.[this.selectedIndex]);
        },
        complete: () => {
          this.isLoading = false;
        }
      });
  }

  private mapPreviewData(record: any): void {
    if (record && this.editLayout) {
      this.selectedId = record.id;
      this.mappedPreviewData = this.editLayout.map(node => {
        return {
          id: record.id,
          name: node.name,
          icon: node.icon,
          type: node.type,
          column: node.column,
          fields: node.fields.map((field: any) => {
            return {
              label: field.label,
              icon: field.icon,
              value: this.getFormattedData(record, field),
              column: field.column
            };
          })
        };
      });
    }
    else {
      this.selectedId = '';
      this.mappedPreviewData = [];
    }
  }

  private prepareFilterFields(): void {
    this.filterFields = [];
    this.form = new FormGroup({});
    if (this.filterLayout) {
      this.filterFields = this.filterLayout.fields;
    }

    this.filterFields.forEach(field => {
      const value = field.dataType.toLowerCase() === 'boolean' ? false : '';
      this.form?.addControl(field.fieldName, new FormControl(value));
    });

    const fields: string[] = [],
      apis: Array<Observable<any[]>> = [];
    this.filterFields?.forEach(field => {
      if (field.dataType.toLowerCase() === 'guid') {
        fields.push(field.fieldName);
        if (field.dataSource)
          apis.push(this.entityDataService.getRecords(field.dataSource));
      }
    });

    if (!apis || apis.length === 0) return;

    forkJoin(apis)
      .pipe(takeUntil(this.destroy))
      .subscribe({
        next: data => {
          fields.forEach((fieldName, index) => {
            this.fieldOptions[fieldName] = data[index].map(item => { return { value: item.id, text: item.name }; });
          });
        }
      });
  }

  private prepareMappedData(): void {
    if (this.records?.length > 0 && this.listLayout) {
      this.mappedListData = this.records.map(record => {
        const titles = this.listLayout.cardTitle?.fields?.map(
          (title: any) => {
            return {
              label: title.label,
              value: this.getFormattedData(record, title)
            };
          }) || [],
          details = this.listLayout.cardDetail?.fields?.map(
            (detail: any) => {
              return {
                label: detail.label,
                icon: detail.icon,
                value: this.getFormattedData(record, detail)
              };
            }) || [],
          status = this.listLayout.cardStatus?.fields?.map(
            (status: any) => {
              return {
                label: status.label,
                icon: status.icon,
                value: this.getFormattedData(record, status)
              };
            }) || [];
        return {
          id: record.id,
          cardTitle: titles ? { fields: titles } : null,
          cardDetail: details ? { fields: details } : null,
          cardStatus: status ? { fields: status } : null
        };
      });
    }
    else
      this.mappedListData = [];
  }

  private resetData(): void {
    this.records = [];
    this.isLoadMore = true;
    this.mappedListData = [];
    this.selectedIndex = 0;
    this.selectedId = '';
    this.pageNumber = 1;
    this.searchTerm = '';
    this.editLayout = [];
    this.listLayout = undefined;
    this.filterFields = [];
    this.filters = [];
    this.mappedPreviewData = [];
  }
}
