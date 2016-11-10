using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola
{
    class Metodos
    {
        int turnoC = 1;
        int frenteC = -1;
        int finalC = 1;
        int [] ArregloC = new int[100];

        

        //Agregar elemento cliente
        public bool EntraCliente()
        {
            bool resultado = false;

            if(!EstaLlenoCliente())
            {
                if (EstaVacioCliente())
                {
                    ArregloC[0] = turnoC;
                    resultado = true;
                    turnoC++;
                    frenteC++;
                }
                else
                {
                    ArregloC[finalC] = turnoC;
                    finalC++;
                    turnoC++;
                    resultado = true;
                }
            }
            
            return resultado;
        }
               

        //Valida si esta lleno Arreglo cliente
        private bool EstaLlenoCliente()
        {
            bool resultado = false;

           if(turnoC==ArregloC.Length)
            {
                resultado = true;
            }           

            return resultado;
        }
        
        //Verificacion si la cola circular esta vacia
        private bool EstaVacioCliente()
        {
            bool resultado = false;

            if (frenteC == -1)
            {
                resultado = true;
            }
            return resultado;
        }


        //Metodo para eliminar el primer dato
        public string EliminarCliente()
        {
            string resultado = null;
            frenteC++;
            return resultado;
        }


        //Metodo para mostrar el primer dato
        public string MPCliente()
        {
            string resultado = null;
            if (frenteC < turnoC-1)
            {
                resultado = ArregloC[frenteC].ToString();
                frenteC++;
            }
            return resultado;
            
        }

    }

}
