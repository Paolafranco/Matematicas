using System;
using System.Collections.Generic;

namespace Educacion.Negocio.Entidades
{
    public class Estudiante : Persona
    {      
        public int EstudianteId { get; set; }
        public List<EstudianteAsignatura> EstudianteAsignaturas { get; set; } = new List<EstudianteAsignatura>();
        
        public void Estudiar()
        {
            base.Leer();
        }
         
        public int Id { get; set; }

        //Metodos
        public int Fibonacci(bool valor)
        {

            int x = 1, y = 0;
            int resultado = 1;
            Console.Out.WriteLine($"El Calculo Fibonacci : {1}");
            for (int contador = 0; contador < 25; contador++)
            {

                resultado = x + y;
                Console.Out.WriteLine($"El Calculo Fibonacci : {resultado}");
                y = x;
                x = resultado;
            }

            return Convert.ToInt32(resultado);
        }
    }
}