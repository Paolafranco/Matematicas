using Educacion.Negocio;
using Educacion.AccesoDatos;
using Educacion.Inplementacion;
using Educacion.Negocio.Entidades;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace Educacion.Consola
{
    class Program
    {
        private static bool valores = true;
        static void Main(string[] args)
        {

            Secretaria secretaria3 = new Secretaria
            {
                Nombre = "Paola",
                Apellido = "Franco"

            };

            var docente = new Secretaria
            {
                Nombre = "Cecilia",
                Apellido = "Franco"
            };

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------Bienvenidos al Instituto----------------------");
            Estudiante estudiante = new Estudiante
            {
                Nombre = "Paola",
                Apellido = "Franco",
                Nacimiento = new DateTime(1997, 10, 13)
            };
            Asignatura asignatura = new Asignatura
            {
                Nombre = "Programacion"
            };

            Secretaria secretaria = new Secretaria();
            secretaria.Matricular(estudiante, asignatura);

            Asignatura asignatura1 = new Asignatura
            {
                Nombre = "Base de Datos"
            };

            Secretaria secretaria1 = new Secretaria();
            secretaria1.Matricular(estudiante, asignatura);

            Asignatura asignatura2 = new Asignatura
            {
                Nombre = "Ingles"
            };

            Secretaria secretaria2 = new Secretaria();
            secretaria2.Matricular(estudiante, asignatura);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(secretaria3.Saludar(docente));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Quisiera por favor saber cuantos alumnos se Matricularon el día de hoy de 9:00 am a 12:00 pm");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Hay {Secretaria.Matriculados} estudiantes matriculados a esas horas");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Muchas gracias, deme por favor sus nombres y el semestre en el que se encuentran");
            Console.WriteLine();

            //
            EstudianteAntiguo estudianteAntiguo = new EstudianteAntiguo()
            {
                Nombre = "Victor",
                Apellido = "Lara"
            };

            string estudiante0 = estudianteAntiguo.Matricular();
            Console.WriteLine(estudianteAntiguo.Matricular());

            EstudianteAplicado estudianteAplicado = new EstudianteAplicado()
            {
                Nombre = "Andrea",
                Apellido = "Franco"
            };

            string estudiant1 = estudianteAplicado.Matricular();
            Console.WriteLine(estudianteAplicado.Matricular());

            EstudianteMallaNueva estudianteMallaNueva = new EstudianteMallaNueva()
            {
                Nombre = "Mateo",
                Apellido = "Campos"
            };

            string estudiant2 = estudianteMallaNueva.Matricular();
            Console.WriteLine(estudianteMallaNueva.Matricular());

            Console.WriteLine();
            
            Matriculas matriculasE = new Matriculas();
            int[,] matrizA = matriculasE.CrearMatriz(3, 5);
            int[,] matrizB = matriculasE.CrearMatriz(10, 10);
            var watch = Stopwatch.StartNew();
            int[,] matrizAxB = matriculasE.Ematricular(matrizA, matrizB);
            watch.Stop();
            var secondsTranscurridos = watch.ElapsedMilliseconds;
            var seconds = watch.Elapsed;
            var ticksTranscurridos = watch.ElapsedTicks;


            // Do the parallel loop.
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Por favor {secretaria3.Nombre} { secretaria3.Apellido} ,mandele los tiempos en tickes, seconds y en elapsed a la Ingeniera de Sistemas");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Buenos días, { secretaria2.Nombre} { secretaria2.Apellido} aquí le mando la lista de los tiempo que me solicito");

            Console.WriteLine();
            Console.WriteLine($"El tiempo en parallel de los 3 estudiantes es de: {ticksTranscurridos} , en tickes");
            Console.WriteLine($"El tiempo en parallel de los 3 estudiantes es de: {secondsTranscurridos} , en seconds");
            Console.WriteLine($"El tiempo en parallel de los 3 estudiantes es de: {seconds} , en elapsed");
           

            for (int i = 0; i < matrizAxB.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < matrizAxB.GetLength(1); j++)
                {
                    Console.Write($"{matrizAxB[i, j]}\t");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----FIBONACCI-----");
            Console.WriteLine();
            Estudiante estudianteMatri = new Estudiante();
            Console.ForegroundColor = ConsoleColor.White;
            estudiante.Fibonacci(valores);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("---------------HILOS---------------");
            int numerosHilos = 0;

            //hilos multiples
            for (numerosHilos = 0; numerosHilos < 5; numerosHilos++)
            {
                Thread hiloPrimero = new Thread(HiloPrincipal);
                hiloPrimero.Start(numerosHilos);
            }

            // Hilo número 1
            int numero = 0;
            while (valores)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Acción realizada desde el Hilo 1 - número : {0}", numero);
                numero++;

                if (numero == 15)
                    valores = false;
            }


        }
        // Hilos
        static void HiloPrincipal(object entrada)
        {
            int incrementar = 0;
            while (valores)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Acción realizada desde el Hilo {0} con {1}", entrada, incrementar);
                incrementar++;
            }
        }

    }
}
