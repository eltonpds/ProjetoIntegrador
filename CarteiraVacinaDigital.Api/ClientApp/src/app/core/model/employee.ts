import { State } from './enum/stateEnum';
import { Office } from './enum/office';

export class Employee {
  id: number;
  name: string;
  email: string;
  password: string;
  cpf: string;
  adress: string;
  city: string;
  state: State;
  cep:string;
  coren: string;
  office: Office;
  officeName: string;
}
