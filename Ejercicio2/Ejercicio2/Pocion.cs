using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    internal class Pocion : Item
    {
        public int PuntosRecuperacion { get; set; }
        public Pocion(int PuntosRecuperacion, string nombre, float peso)
            : base(nombre, peso)
        {
            this.PuntosRecuperacion = PuntosRecuperacion;
        }

        public override void Usar()
        {
            base.Usar();
            Console.WriteLine("Se restauro " + PuntosRecuperacion + " puntos de salud");


        }



    }
}
