import { TestBed, inject } from '@angular/core/testing';

import { CalendarioService } from './calendario.service';

describe('CalenderserviceService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [CalendarioService]
    });
  });

  it('should be created', inject([CalendarioService], (service: CalendarioService) => {
    expect(service).toBeTruthy();
  }));
});
