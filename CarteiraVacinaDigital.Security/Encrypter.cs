using CarteiraVacinaDigital.Model.Entities;
using System;
using System.Collections.Generic;

namespace CarteiraVacinaDigital.Security
{
    public class Encrypter
    {
        public static string EncryptString(string valor)
        {
            string chaveCripto;

            Byte[] cript = System.Text.ASCIIEncoding.ASCII.GetBytes(valor);
            chaveCripto = Convert.ToBase64String(cript);

            return chaveCripto;
        }

        public static string DecryptString(string valor)
        {
            string chaveCripto;

            Byte[] cript = Convert.FromBase64String(valor);
            chaveCripto = System.Text.ASCIIEncoding.ASCII.GetString(cript);
            return chaveCripto;

        }

        public static IEnumerable<Employee> DecryptManyEmployees(IEnumerable<Employee> employees)
        {
            foreach (var item in employees)
            {
                item.Cpf = DecryptString(item.Cpf);
            }

            return employees;
        }

        public static IEnumerable<Pacient> DecryptManyPacients(IEnumerable<Pacient> pacients)
        {
            foreach (var item in pacients)
            {
                item.Cpf = DecryptString(item.Cpf);
            }

            return pacients;
        }

    }
}
