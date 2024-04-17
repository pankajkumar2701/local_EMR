import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AppConfigService } from '../app-config.service';

@Injectable({
    providedIn: 'root'
})
export class EntityDataService {
    constructor(private http: HttpClient) { }

    public addRecord(entityName: string, data: any): Observable<any> {
        return this.http.post<any>(`${this.route}/${entityName}`, data);
    }

    public deleteRecordById(entityName: string, id: string): Observable<any> {
        return this.http.delete(`${this.route}/${entityName}/${id}`);
    }

    public editRecordById(entityName: string, id: string, data: any): Observable<any> {
        return this.http.put<any>(`${this.route}/${entityName}/${id}`, data);
    }

    public getRecords(entityName: string, filters: any[] = [], searchTerm: string = '', pageNumber: number = 1, pageSize: number = 10, sortField: string = '', sortOrder: string = 'asc'): Observable<any[]> {
        const params: any = {};

        if (filters.length > 0) {
            params.filters = JSON.stringify(filters);
        }
        if (searchTerm) {
            params.searchTerm = searchTerm;
        }
        if (pageNumber > 0) {
            params.pageNumber = pageNumber;
            if (pageSize > 0) {
                params.pageSize = pageSize;
            }
        }
        if (sortField) {
            params.sortField = sortField;
            if (sortOrder) {
                params.sortOrder = sortOrder;
            }
        }
        return this.http.get<any[]>(`${this.route}/${entityName}`, { params });
    }

    public getRecordById(entityName: string, id: string): Observable<any> {
        return this.http.get<any>(`${this.route}/${entityName}/${id}`);
    }

    private get route(): string {
        const baseUrl = AppConfigService.appConfig ? AppConfigService.appConfig.api.url : '';
        return `${baseUrl}/api`;
    }
}
