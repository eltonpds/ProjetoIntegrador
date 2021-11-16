import { TestBed, inject } from '@angular/core/testing';

import { PacientVaccineService } from './pacientVaccine.service';

describe('RegistervaccineService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PacientVaccineService]
    });
  });

  it('should be created', inject([PacientVaccineService], (service: PacientVaccineService) => {
    expect(service).toBeTruthy();
  }));
});
