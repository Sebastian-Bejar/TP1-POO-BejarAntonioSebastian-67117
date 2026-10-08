using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    internal class CofreBotin
    {
        private bool _abierto = false;
        private Item[] itemsContenidos = new Item[2];

        public CofreBotin(Item item1, Item item2)
        {
            itemsContenidos[0] = item1;
            itemsContenidos[1] = item2;
        }

        public void Abrir()
        {
                if (_abierto == false)
                {
                    _abierto=true;

                    for (int i = 0; i < 2;  i++)
                    {
                        itemsContenidos[i].Usar();
                    }
                    
                }


        }



    }
}
