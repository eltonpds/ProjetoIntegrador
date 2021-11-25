import { Pacient } from "./pacient";
import { Vaccine } from "./vaccine";

export class PacientVaccine {
    id: number;
    PacientId: number;
    VaccineId: number;
    DateVaccined: Date;
    UniqueDose: boolean;
    Dose: number;
    Vaccines: Vaccine[];
    Pacients: Pacient[];
}