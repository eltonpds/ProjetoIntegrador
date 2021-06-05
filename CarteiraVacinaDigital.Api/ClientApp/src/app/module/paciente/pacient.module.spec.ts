import { PacientModule } from './pacient.module';

describe('PacientModule', () => {
  let pacientModule: PacientModule;

  beforeEach(() => {
    pacientModule = new PacientModule();
  });

  it('should create an instance', () => {
    expect(pacientModule).toBeTruthy();
  });
});
