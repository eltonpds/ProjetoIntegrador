import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PacientVaccineComponent } from './pacient-vaccine.component';

describe('PacientVaccineComponent', () => {
  let component: PacientVaccineComponent;
  let fixture: ComponentFixture<PacientVaccineComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PacientVaccineComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PacientVaccineComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
