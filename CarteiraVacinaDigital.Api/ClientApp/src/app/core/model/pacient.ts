import { State } from './enum/stateEnum';

export class Pacient {
  id: number;
  name: string;
  email: string;
  password: string;
  cpf: string;
  telefone:string;
  cartaoSus: string;
  motherName: string;
  fatherNamme: string;
  adress: string;
  district: string;
  city: string;
  state: State;
  cep: string;
}
