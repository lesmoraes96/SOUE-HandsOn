using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpComSQLServer
{
    public class Validacoes
    {
        public static bool validarCPF(string cpf)
        {
            string valor = cpf.Replace(".", "");
            valor = valor.Replace("-", "");

            if (valor.Length != 11)
                return false;

            if (igual || valor == "00000000000")
                return false;

            return true;
        }
    }
}
