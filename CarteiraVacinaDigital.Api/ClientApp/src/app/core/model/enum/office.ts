export enum Office {
  Administrador = 'Administrador',
  Tecnico = 'Técnico',
  Enfermeiro = 'Enfermeiro',
  Medico = 'Medico',
  Estagiario = 'Estagiario'
}

export const OfficeLabelMapping: Record<Office, string> = {
  [Office.Administrador]: "Administrador",
  [Office.Tecnico]: "Técnico(a)",
  [Office.Enfermeiro]: "Enfermeiro(a)",
  [Office.Medico]: "Dr(a)",
  [Office.Estagiario]: "Estagiário(a)"
};