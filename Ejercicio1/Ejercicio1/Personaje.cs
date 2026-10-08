using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ejercicio1
{
    internal class Personaje
    {
        protected string nombre;
        protected int vida;

        public Personaje(string nombre, int vida)
        {
            this.nombre = nombre;
            this.vida = vida;
        }

        public void RecibirDanio(int cantidad)
        {
            vida = vida - cantidad;
            if (vida < 0)
            {
                vida = 0;
            }
        }

        public bool EstaVivo()
        {
            return vida > 0;
        }

        public virtual void Atacar(Personaje objetivo)
        {
            objetivo.RecibirDanio(10);
        }

    }

}
