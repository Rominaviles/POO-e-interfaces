using System;
using System.Collections.Generic;
using Interfaces;
using Classpersona;
using Clase1;

namespace Classalumno
{//Actividad 1, ejercicio 15
    public class Alumno : Persona 
    {
        private int legajo;
        private int promedio;

        public Alumno(string n, int d, int l, int p) : base (n, d)
        {
            this.legajo=l;
            this.promedio=p;
        }

        public int getLegajo()
        {
            return this.legajo;
        }

        public int getPromedio()
        {
            return this.promedio;
        }

        
        public override string ToString()
        {
            return "Nombre: "+ getNombre() + ", Dni: " + getDNI() + ", Legajo: " + getLegajo() + ", Promedio: " + getPromedio();
        }

        //EJERCICIO 18 (Implementacion de la interface comparable)
        public override bool sosIgual(Comparable c)
        {
            return this.legajo == ((Alumno)c).getLegajo();
        }

        public override bool sosMenor(Comparable c)
        {
            return this.legajo < ((Alumno)c).getLegajo();
        }

        public override bool SosMayor(Comparable c)
        {
            return this.legajo >((Alumno)c).getLegajo();
        }

    }

}