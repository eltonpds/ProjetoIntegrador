using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CarteiraVacinaDigital.Model.Entities.Enums
{
    public enum OfficeEnum : int
    {
        Administrador,
        [Description("Tecnico")]
        Tecnico,
        Enfermeiro,
        Medico,
        Aprendiz,
        Estagiario
    }
}
