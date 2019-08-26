using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaVideo
{
    class clsPila
    {
        private int Max;
        private int Top;
        int[] pila;


        public clsPila(int tamaño)
        {
            Max = tamaño;
            Top = 0;
            pila = new int[tamaño];
        }

        private bool EstaLlena()
        {
            if (Top == Max) return true;
            return false;
        }
        private bool EstaVacia()
        {
            if (Top == 0) return true;
            return false;
        }

        public bool Push(int dato)
        {
            if (!EstaLlena())
            {
                pila[Top] = dato;
                Top++;
                return true;
            }
            else return false;
        }
        
        public bool Pop()
        {
            if (!EstaVacia())
            {
                Top--;
                return true;
            }
            else return false;
        }

        public string Mostrar()
        {
            string resultado = "";
            if (!EstaVacia())
            {
                for (int i = 0; i < Top; i++)
                {
                    resultado += "Posicion: " + i + " Dato: " + pila[i] + "\n";
                }
                resultado += "Top: " + Top;
                resultado += "Maximo: " + Max;
                return resultado;
            }
            else return resultado = "Pila vacia";
        }

        public void Vaciar()
        {
            Top = 0;
        }

    }
}
