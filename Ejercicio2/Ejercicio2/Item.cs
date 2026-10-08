using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    internal class Item
    {
        public string Nombre { get; set; }
        private float _peso;
        public float Peso
        {
            get { return _peso; }
            set { 
                if(value <= 0)
                {
                    _peso = 0.5f;
                }
                else
                {
                    _peso = value;
                }
                }
        }

        public Item(string nombre, float peso)
        {
            this.Nombre = nombre;
            this.Peso = peso;
        }

        public virtual void Usar()
        {

            Console.WriteLine("Se uso el item: " + Nombre);
        }

    }
}
