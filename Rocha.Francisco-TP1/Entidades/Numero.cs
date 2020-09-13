using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public Numero()
        {
            this.numero = 0;
        }



        public Numero(double numero)
        {
            this.numero = numero;
        }



        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        

        public static double operator +(Numero n1, Numero n2)
        {
            double resultado;

            resultado = n1.numero + n2.numero;

            return resultado;
        }



        public static double operator -(Numero n1, Numero n2)
        {
            double resultado;

            resultado = n1.numero - n2.numero;

            return resultado;
        }



        public static double operator *(Numero n1, Numero n2)
        {
            double resultado;

            resultado = n1.numero * n2.numero;

            return resultado;
        }



        public static double operator /(Numero n1, Numero n2)
        {
            double resultado;

            if (n1.numero == 0 || n2.numero == 0)
            {
                resultado = double.MinValue;
            }
            else
            {
                resultado = n1.numero / n2.numero;
            }

            return resultado;
        }



        public string BinarioDecimal(string binario)
        {
            bool esBinario;

            esBinario = EsBinario(binario);

            if (esBinario)
            {
                char[] array = binario.ToCharArray();
                Array.Reverse(array);

                int suma = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == '1')
                    {
                        if (i == 0)
                        {
                            suma += 1;
                        }
                        else
                        {
                            suma += (int)Math.Pow(2, i);
                        }
                    }
                }
                return Convert.ToString(suma);

            }
            else
            {
                return "Valir invalido";
            }
        }



        public string DecimalBinario(double numero)
        {
            bool esNumero;
            string retorno = "";

            esNumero = int.TryParse(numero.ToString(), out int auxNumero);

            if (esNumero)
            {
                if (auxNumero > 0)
                {
                    int aux;
                    string auxString;

                    while (auxNumero > 0)
                    {
                        aux = auxNumero % 2;
                        auxString = Convert.ToString(aux);
                        retorno = auxString + retorno;
                        auxNumero /= 2;
                    }
                    return retorno;
                }
                else
                {
                    retorno = "0";
                }
            }
            else
            {
                retorno = "Valir invalido";
            }

            return retorno;
        }



        public string DecimalBinario(string numero)
        {
            bool esNumero;
            string retorno = "";

            esNumero = int.TryParse(numero.ToString(), out int auxNumero);

            if (esNumero)
            {
                if (auxNumero > 0)
                {
                    int aux;
                    string auxString;

                    while (auxNumero > 0)
                    {
                        aux = auxNumero % 2;
                        auxString = Convert.ToString(aux);
                        retorno = auxString + retorno;
                        auxNumero /= 2;
                    }
                    return retorno;
                }
                else
                {
                    retorno = "0";
                }
            }
            else
            {
                retorno = "Valir invalido";
            }

            return retorno;
        }



        private bool EsBinario(string binario)
        {
            bool retorno = false;

            foreach (var caracteres in binario)
            {
                if (caracteres == '0' || caracteres == '1')
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }



        private double ValidarNumero(string strNumero)
        {
            if (!double.TryParse(strNumero, out double NumeroAux))
            {
                NumeroAux = 0;
            }

            return NumeroAux;
        }



        public String SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
    }
}
