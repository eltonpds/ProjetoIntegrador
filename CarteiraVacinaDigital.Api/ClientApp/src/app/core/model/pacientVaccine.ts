import { Pacient } from "./pacient";
import { Vaccine } from "./vaccine";

export class PacientVaccine {
    id: number;
    pacientId: number;
    vaccineId: number;
    vaccines: Vaccine[];
    pacients: Pacient[];
}