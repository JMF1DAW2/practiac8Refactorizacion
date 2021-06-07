using System;

namespace ProyectoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //JMFFecha correcta, año bisiesto
            JMFFecha fecha1 = new JMFFecha(4, 12, 2012);
            Console.WriteLine("JMFFecha 1: " + fecha1.ToString());
            ComprobarBisiesto(fecha1);

            //JMFFecha correcta, año no bisiesto
            JMFFecha fecha2 = new JMFFecha(4, 10, 2013);
            Console.WriteLine("JMFFecha 2: " + fecha2.ToString());
            ComprobarBisiesto(fecha2);

            //JMFFecha con valores incorrectos
            JMFFecha fecha3 = new JMFFecha(4, 13, -4);
            Console.WriteLine("JMFFecha 3: " + fecha3.ToString());

            //JMFFecha con asignación incorrecta de valores erroneos
            JMFFecha fecha4 = new JMFFecha
            {
                Dia = 67,
                Mes = 80,
                Anyo = 3678
            };

            fecha4.SetFecha(fecha4.Dia, fecha4.Mes, fecha4.Anyo);
            Console.WriteLine("JMFFecha 4: " + fecha4.ToString());
            //MAL!!
        }

        private static void ComprobarBisiesto(JMFFecha fecha)
        {
            if (fecha.EsBisiesto())
                Console.WriteLine("El año " + fecha.Anyo + " es bisiesto");
            else
                Console.WriteLine("El año " + fecha.Anyo + " no es bisiesto");
        }
    }
}
