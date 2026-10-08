using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Ejercicio1
{
    internal class Guerrero : Personaje
    {
        private int fuerzaFisica;

        public Guerrero(int vida, string nombre, int fuerzaFisica) 
            : base(nombre, vida)
        {
            this.fuerzaFisica = fuerzaFisica;
        }

        public override void Atacar(Personaje objetivo)
        {
            objetivo.RecibirDanio(fuerzaFisica);
        }

    }
}
