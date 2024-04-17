import { Component, Input } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Option } from './layout-models';
import { TooltipService } from 'src/app/angular-app-services/tooltip.service';

@Component({
  selector: 'app-dynamic-layout',
  templateUrl: './dynamic-layout.component.html',
  styleUrl: './dynamic-layout.component.scss'
})

export class DynamicLayoutComponent {
  @Input() fieldOptions: { [key: string]: Option[]; } = {};
  @Input() form!: FormGroup;
  @Input() formFields!: any[];

  constructor(
    private tooltipService: TooltipService
  ) { }

  public isTooltipDisabled(element: HTMLElement): boolean {
    return this.tooltipService.isTooltipDisabled(element);
  }
}