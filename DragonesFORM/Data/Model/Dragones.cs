using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonesFORM.Data.Model
{
    internal class Dragones
    {
        public int numD { get; set; }
        public string nombre { get; set; }
        public string tipo { get; set; }
        public string habitat { get; set; }
        public string activo { get; set; }
        public int fuerza { get; set; }
        public int agilidad { get; set; }
        public int resistencia { get; set; }
        public int velocidad { get; set; }
        public int inteligencia { get; set; }
        public int carisma { get; set; }
        public int defensa { get; set; }
        public int experiencia { get; set; }
        public string descripcion { get; set; }


        public Dragones (int numD,string nombre, string tipo, string habitat, string activo, int fuerza, int agilidad, int resistencia,int velocidad,int inteligencia, int carisma, int defensa, int experiencia, string descripcion) 
        {
            numD= numD;
            nombre = nombre;
            tipo = tipo;
            habitat=habitat;
            activo=activo;
            fuerza = fuerza;
            agilidad = agilidad;
            resistencia = resistencia;
            velocidad = velocidad;
            inteligencia=inteligencia;
            carisma = carisma;
            defensa=defensa;
            experiencia=experiencia;
            descripcion = descripcion;
         }


        public Dragones()
        {
        }
    }
}