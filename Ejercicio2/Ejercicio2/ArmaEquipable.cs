using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    internal class ArmaEquipable : Item
    {

        public int Danio { get; set; }

        public ArmaEquipable(int Danio, string nombre, float peso) 
        : base(nombre, peso)
        { 
            this.Danio = Danio;

        }

        public override void Usar()
        {
            base.Usar();
            Console.WriteLine("El daño que inflinge el arma es: " + Danio);

        }



    }
}
