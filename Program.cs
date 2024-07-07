using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using Interfaces;
using Classpersona;
using Classcola;
using Classpila;
using Classalumno;
using Classnumero;
using Classcoleccion;

namespace Clase1
{
    class Program
//CLASE1
    {
        
        private static Random rdm = new Random();
        private const int RangoMin= 1;
        private const int RangoMax = 50;
        private const int DNImin= 10000000;
        private const int DNImax= 99999999;
        private const int LegajoMin= 1;
        private const int LegajoMax= 10000;
        private const int PromedioMin= 1;
        private const int PromedioMax= 10;

        //EJERCICIO 5
        public static void llenar (Coleccionable c)
        {
            int cont=0;
            while (cont<20)
            {
                c.agregar(new Numero(rdm.Next(RangoMin, RangoMax)));
                cont++;
            }
            
        }

        //EJERCICIO 6
        public static void informar(Coleccionable c)
        {
            Console.WriteLine("La cantidad de elementos  que contiene son: " + "\n" + c.cuantos());
            Console.WriteLine("El elemento minimo es: " +"\n" + c.minimo());
            Console.WriteLine("El elemento maximo es: " + "\n" + c.maximo());
            int alt= int.Parse(Console.ReadLine() ?? "0");
            //Comparable num= new Numero(rdm.Next(RangoMin, RangoMax));
            //Comparable num= new Persona("",alt);
            Comparable num= new Alumno("",00,alt,00);
            if (c.contiene (num))
            {
                Console.WriteLine("El elemento leido esta en la coleccion");
            }
            else
            {
                Console.WriteLine("El elemento leido no esta en la coleccion");
            }


        }
        //EJERCICIO 12
        public static void llenarPersonas (Coleccionable c)
        {
            int cont=0;
            while (cont<20)
            {
                string nombre= NombreAleatorio();
                int dni= rdm.Next(DNImin,DNImax);                
                c.agregar(new Persona(nombre, dni));
                cont++;
            }           
        }

        //EJERCICIO 16

        public static void llenarAlumnos (Coleccionable c)
        {
            int cont=0;
            while (cont<20)
            {
                string nombre = NombreAleatorio();
                int dni = rdm.Next(DNImin, DNImax);
                int legajo = rdm.Next(LegajoMin, LegajoMax);
                int promedio = rdm.Next(PromedioMin, PromedioMax);
                Alumno alumno= new Alumno(nombre, dni, legajo, promedio);
                c.agregar(alumno);
                cont++;
            }  
        }

        //Funcion adicional para generar nombre aleatorio
        public static string NombreAleatorio()
        {
            List<string> nombre= new List<string>{"Tomas","Ramon","Felipe","Julian","Benjamin","Sam","Sarah","Jazmin","Tamara","Melody","Joel"};
            return nombre[rdm.Next(nombre.Count)];
        }
    

        
        static void Main(string[] args)
        {
            //Actividad 1 EJERCICIO 7,9, 13,17
            Pila pila= new Pila();
            Cola cola= new Cola();
            ColeccionMultiple cm= new ColeccionMultiple(pila, cola);

            //llenar(pila);
            //informar(pila);

            //llenar(cola);
            //informar(cola);

            //llenarPersonas(pila);
            //llenarPersonas(cola);

            llenarAlumnos(pila);
            llenarAlumnos(cola);


            informar (cm);


        }
    }


}