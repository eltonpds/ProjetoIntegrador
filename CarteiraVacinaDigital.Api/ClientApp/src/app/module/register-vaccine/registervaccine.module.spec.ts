import { RegistervaccineModule } from './registervaccine.module';

describe('RegistervaccineModule', () => {
  let registervaccineModule: RegistervaccineModule;

  beforeEach(() => {
    registervaccineModule = new RegistervaccineModule();
  });

  it('should create an instance', () => {
    expect(registervaccineModule).toBeTruthy();
  });
});
