import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FormVaccineComponent } from './form-vaccine.component';

describe('FormVaccineComponent', () => {
  let component: FormVaccineComponent;
  let fixture: ComponentFixture<FormVaccineComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FormVaccineComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormVaccineComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
