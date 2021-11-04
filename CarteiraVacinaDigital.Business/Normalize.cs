using CarteiraVacinaDigital.Model.Entities;
using System.Collections.Generic;

namespace CarteiraVacinaDigital.Business
{
    public class Normalize
    {
        public static string NormalizeCpf (string cpf)
        {
            string start = cpf.Substring(0, 3);
            string final = cpf.Substring(9,2);
            string newString = start + ".***.***-" + final;
            return newString;
        }

        public static IEnumerable<Employee> NormalizeManyCpfEmployee (IEnumerable<Employee> employees)
        {
            foreach(var item in employees)
            {
                item.Cpf = NormalizeCpf(item.Cpf);
            }

            return employees;
        }

        public static IEnumerable<Pacient> NormalizeManyCpfPacient(IEnumerable<Pacient> pacients)
        {
            foreach (var item in pacients)
            {
                item.Cpf = NormalizeCpf(item.Cpf);
            }

            return pacients;
        }
    }
}
