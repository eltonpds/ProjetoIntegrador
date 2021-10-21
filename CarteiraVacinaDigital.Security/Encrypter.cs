using CarteiraVacinaDigital.Model.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

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

        //public bool VerifyString(string newText, string oldText)
        //{
        //    if (string.IsNullOrEmpty(oldText))
        //        throw new NullReferenceException("Campo vazio. Favor inserir texto a ser criptografado.");

        //    var decryptedOldText = DecryptString(oldText);
        //    var decryptNewText = DecryptString(newText);

        //    bool isEqual = oldText.Equals(newText);

        //    return isEqual;
        //}

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
                item.Password = DecryptString(item.Password);
                item.Cpf = DecryptString(item.Cpf);
            }

            return employees;
        }

    }
}
