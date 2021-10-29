import { CalendarioModule } from './calendario.module';

describe('CalendarioModule', () => {
  let calendarioModule: CalendarioModule;

  beforeEach(() => {
    calendarioModule = new CalendarioModule();
  });

  it('should create an instance', () => {
    expect(calendarioModule).toBeTruthy();
  });
});
