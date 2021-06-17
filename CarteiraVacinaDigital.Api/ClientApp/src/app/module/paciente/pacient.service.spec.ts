import { TestBed, inject } from '@angular/core/testing';

import { PacientService } from './pacient.service';

describe('PacientService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PacientService]
    });
  });

  it('should be created', inject([PacientService], (service: PacientService) => {
    expect(service).toBeTruthy();
  }));
});
