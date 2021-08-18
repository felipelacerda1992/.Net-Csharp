using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    public class VerificarClass
    {
        public string VerificarMaior(int n1, int n2)
        {
            string semN = "Números iguais";
            
            if (n1 > n2)
                return Convert.ToString(n1);
            else if (n1 < n2)
                return Convert.ToString(n2);
            else
                return semN;
        }

        public string VerificarParouimpar(int n)
        {
            string par = "Numero par";
            string impar = "Numero impar";

            if (n % 2 == 0)
                return par;
            else
                return impar;

        }

        public Decimal VerificaPreco(Decimal q5, Decimal q6, Decimal q7, bool c5, bool c6, bool c7)
        {
            Decimal p1;
            Decimal p2;
            Decimal p3;
            Decimal p4;
            Decimal p5;
            Decimal p6;
            Decimal p7;
            if (c5 == true && c6 == false && c7 == false)
            {
                p1 = q5 * Convert.ToDecimal(0.5);
                return p1;
            }
            else if (c6 == true && c5 == false && c7 == false)
            {
                p2 = q6 * Convert.ToDecimal(0.6);
                return p2;

            }
            else if (c7 == true && c5 == false && c6 == false)
            {
                p3 = q7 * Convert.ToDecimal(0.75);
                return p3;
            }
            else if (c5 == true && c6 == true && c7 == false)
            {
                p4 = (q5 * Convert.ToDecimal(0.5)) + (q6 * Convert.ToDecimal(0.6));
                return p4;
            }
            else if (c5 == true && c6 == false && c7 == true)
            {
                p5 = (q5 * Convert.ToDecimal(0.5)) + (q7 * Convert.ToDecimal(0.75));
                return p5;
            }
            else if (c5 == false && c6 == true && c7 == true)
            {
                p6 = (q6 * Convert.ToDecimal(0.6)) + (q7 * Convert.ToDecimal(0.75));
                return p6;
            }
            else
            {
                p7 = (q5 * Convert.ToDecimal(0.5)) + (q6 * Convert.ToDecimal(0.6)) + (q7 * Convert.ToDecimal(0.75));
                return p7;
            }

        }
    }
}
