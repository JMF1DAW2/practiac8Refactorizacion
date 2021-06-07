using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoConsola
{
    class JMFFecha
    {
        private int dia;
        private int mes;
        private int anyo;

        public int Dia 
        { 
            get => dia; 
            set => dia = value; 
        }
        public int Mes 
        { 
            get => mes; 
            set => mes = value; 
        }
        public int Anyo 
        { 
            get => anyo;
            set => anyo = value; 
        }

        //TODO validar los valores introducidos
        /// <summary>
        /// Constructor de JMFFecha sin parámetros
        /// Se establecen los valores anyo 1
        /// </summary>
        public JMFFecha()
        {
            Dia = 1;
            Mes = 1;
            Anyo = 1;
        }

        /// <summary>
        /// Constructor de JMFFecha con 3 parámetros
        /// Si algún parámetro no es correcto se establece anyo 1
        /// </summary>
        /// <param name="dia">Dia</param>
        /// <param name="mes">Mes</param>
        /// <param name="anyo">Anyo (entre 1 y 2500)</param>
        /// 
        /// 
        public JMFFecha(int dia, int mes, int anyo)
        {
            SetFecha(dia, mes, anyo);
        }

        public void SetFecha(int dia, int mes, int anyo)
        {
            if (anyo >= 1 && anyo <= 2500)
            {
                Anyo = anyo;
            }
            else
            {
                Anyo = 1;
            }


            if (mes >= 1 && mes <= 12)
            {
                Mes = mes;
            }
            else
            {
                Mes = 1;
            }

            int diasMes = 0;

            switch (Mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    diasMes = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    diasMes = 30;
                    break;
                case 2: // verificación de año bisiesto
                    if (EsBisiesto())
                    {
                        diasMes = 29;
                    }
                    else
                    {
                        diasMes = 28;
                    }
                    break;
            }
            if (dia >= 1 && dia <= diasMes)
            {
                Dia = dia;
            }

            else
            {
                Dia = 1;
            }
        }

        public bool EsBisiesto()
        {
            bool bisiesto;
            if ((Anyo % 400 == 0) || ((Anyo % 4 == 0) && (Anyo % 100 != 0)))
            {
                bisiesto = true;
            }
            else
            {
                bisiesto = false;
            }
            
            return bisiesto;
        }

        /// <summary>
        /// Devuelve un string con la fecha en formato dia/mes/anyo
        /// </summary>
        /// <remarks> la palabra clave override indica que se sobreescribe el metodo ToString</remarks>
        /// <returns>un string con la fecha en formato dia/mes/anyo</returns> 
        public override string ToString()
        {
            return Dia + "/" + Mes + "/" + Anyo;
        }
    }
}