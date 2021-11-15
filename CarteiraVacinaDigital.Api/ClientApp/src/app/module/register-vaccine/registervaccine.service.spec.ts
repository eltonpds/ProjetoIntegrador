import { TestBed, inject } from '@angular/core/testing';

import { RegisterVaccineService } from './registervaccine.service';

describe('RegistervaccineService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [RegistervaccineService]
    });
  });

  it('should be created', inject([RegisterVaccineService], (service: RegisterVaccineService) => {
    expect(service).toBeTruthy();
  }));
});
