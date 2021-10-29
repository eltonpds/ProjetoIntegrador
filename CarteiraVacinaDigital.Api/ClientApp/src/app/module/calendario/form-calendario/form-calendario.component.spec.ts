import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FormCalendarioComponent } from './form-calendario.component';

describe('FormCalendarioComponent', () => {
  let component: FormCalendarioComponent;
  let fixture: ComponentFixture<FormCalendarioComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FormCalendarioComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormCalendarioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
