using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    internal class Mago : Personaje
    {
        private int mana;
        public Mago(int vida, string nombre, int mana) : base(nombre, vida)
        {
            this.mana = mana;
        }

        public override void Atacar(Personaje objetivo)
        {
            if(mana >= 10)
            {
                mana = mana - 10;
                objetivo.RecibirDanio(30);
            }
            else
            {
                objetivo.RecibirDanio(5);
            }
            
            

        }



    }
}
