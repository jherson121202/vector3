using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppVector
{
    class clsVector
    {
        private int[] vector;
        private int lg;
        //constructor
        public clsVector() { 
        vector= new int [100];
        lg = 0;
        }
        //metodos (procedimiento y funciones)
        public void adicionar(int valor) {
            vector[lg] = valor;
            lg = lg + 1;
        }
        //obtener el valor en la posicion pos
        public int obtenervalor(int pos) {
            return vector[pos];
        }
        // Longitud del vector
        public int longitud() {
            return lg;
        }
        // invertir los elementosdel vector
        public void invertir() {
            int fin = lg - 1;
            int mitad = lg / 2;
            int i = 0;
            int aux = 0;
            while (i < mitad) {
                aux = vector[lg - i];
                vector[lg-i]= vector[i];
                vector[i]=aux;
                i++;
            }
        }

        // cantidad de elementos pares
        public int cantPares() {
            int cont = 0;
            for(int i=0; i <lg; i++){
            if (vector[i] % 2==0)
                cont++;
            }
            return cont;
        }
        // ordenar los elementos del vector de menor a mayor
        public void OrdenarMenorAmayor() {
            int aux = 0;
            for (int i = 0; i < lg; i++) {
                for (int j = i; j < lg; j++) {
                    if (vector[i] > vector[j]) {
                        aux = vector[j];
                        vector[j] = vector[i];
                        vector[i] = aux;
                    }
                }
            }
        }
        // Eliminar el elemento en la posicion p
        public void EliminarElementoPos(int p) {
            for (int i = p - 1; i < lg; i++) {
                vector[i] = vector[i + 1];
            }
            lg = lg - 1;
        }

        // Ivertir cada elemento del vector
        public void InvertirCadaElemento()
        {
            for (int i = 0; i < lg; i++)
            {
                int num = vector[i];
                int numinvertido = 0;

                while (num > 0)
                {
                    int dig = num % 10;
                    numinvertido = numinvertido * 10 + dig;
                    num = num / 10;
                }

                vector[i] = numinvertido;
            }
        }
        // Cantidad elementos capicúa.
        public int CantCapicua()
        {
            int cantCapicua = 0;
            for (int i = 0; i < lg; i++)
            {
                int num = vector[i];
                int numOriginal = num;
                int numInvertido = 0;

                while (num > 0)
                {
                    int digito = num % 10;
                    numInvertido = numInvertido * 10 + digito;
                    num = num / 10;
                }

                if (numOriginal == numInvertido)
                {
                    cantCapicua++;
                }
            }
            return cantCapicua;
        }
        // Cantidad de elementos primos.
         public int CantPrimos()
        {
            int cantPrimos = 0;
            for (int i = 0; i < lg; i++)
            {
                int num = vector[i];
                if (num > 1)
                {
                    bool primo = true;
                    for (int j = 2; j * j <= num; j++)
                    {
                        if (num % j == 0)
                        {
                            primo = false;
                            break;
                        }
                    }
                    if (primo)
                        cantPrimos++;
                }
            }
            return cantPrimos;
        }
    }
}


