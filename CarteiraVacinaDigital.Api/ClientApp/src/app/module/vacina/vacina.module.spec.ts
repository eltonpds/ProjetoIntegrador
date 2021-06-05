import { VacinaModule } from './vacina.module';

describe('VacinaModule', () => {
  let vacinaModule: VacinaModule;

  beforeEach(() => {
    vacinaModule = new VacinaModule();
  });

  it('should create an instance', () => {
    expect(vacinaModule).toBeTruthy();
  });
});
