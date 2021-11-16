import { VaccineModule } from './vaccine.module';

describe('VaccineModule', () => {
  let vaccineModule: VaccineModule;

  beforeEach(() => {
    vaccineModule = new VaccineModule();
  });

  it('should create an instance', () => {
    expect(vaccineModule).toBeTruthy();
  });
});
