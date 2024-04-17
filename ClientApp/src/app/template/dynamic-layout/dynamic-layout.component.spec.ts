import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DynamicLayoutComponent } from './dynamic-layout.component';
import { HttpClientTestingModule } from '@angular/common/http/testing';
import { NO_ERRORS_SCHEMA, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';

describe('DefaultLayoutComponent', () => {
  let component: DynamicLayoutComponent;
  let fixture: ComponentFixture<DynamicLayoutComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      declarations: [DynamicLayoutComponent],
      schemas: [
        NO_ERRORS_SCHEMA,
        CUSTOM_ELEMENTS_SCHEMA
      ],
    })
      .compileComponents();

    fixture = TestBed.createComponent(DynamicLayoutComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
