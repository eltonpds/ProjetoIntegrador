import { PacientVaccineModule } from './pacientVaccine.module';

describe('PacientVaccineModule', () => {
  let pacientVaccineModule: PacientVaccineModule;

  beforeEach(() => {
    pacientVaccineModule = new PacientVaccineModule();
  });

  it('should create an instance', () => {
    expect(pacientVaccineModule).toBeTruthy();
  });
});
