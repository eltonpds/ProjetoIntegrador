export enum Office {
  Administrador = 'Administrador',
  Tecnico = 'Tecnico',
  Enfermeiro = 'Enfermeiro',
  Medico = 'Medico',
  Aprendiz = 'Aprendiz',
  Estagiario = 'Estagiario'
}

export const OfficeLabelMapping: Record<Office, string> = {
  [Office.Administrador]: "Administrador",
  [Office.Tecnico]: "Técnico(a)",
  [Office.Enfermeiro]: "Enfermeiro(a)",
  [Office.Medico]: "Dr(a)",
  [Office.Aprendiz]: "Jovem Aprendiz",
  [Office.Estagiario]: "Estagiário(a)"
};

export enum OfficeEnum {
  Administrador,
  Tecnico,
  Enfermeiro,
  Medico,
  Aprendiz,
  Estagiario
}