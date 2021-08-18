using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class TextoClass
    {
        public string AjuntarNome(string nome, string sobre)
        {
            return nome + " " + sobre;

        }

        public string DeixarMaiuscula(string nome)
        {
            return nome.ToUpper();
        }
    }
}
