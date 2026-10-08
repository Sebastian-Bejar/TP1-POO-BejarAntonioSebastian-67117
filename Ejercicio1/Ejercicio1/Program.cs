using System;
using Ejercicio1;

class Ej1
{
    static void Main()
    {
        Guerrero miGuerrero = new Guerrero(100, "Kratos", 20);
        Mago miMago = new Mago(80, "Gandalf", 30);

        Personaje[] grupo = new Personaje[] { miGuerrero, miMago };

        miMago.Atacar(miGuerrero);
        Console.WriteLine("Gandalf ataca a Kratos");
        if (miGuerrero.EstaVivo())
        {
            Console.WriteLine("Kratos sigue vivo");
        }
        else
        {
            Console.WriteLine("Kratos murio");
        }
        Console.ReadKey();
        Console.Clear(); 


        miGuerrero.Atacar(miMago); 
        Console.WriteLine("Kratos ataca a Gandalf");
        if (miMago.EstaVivo())
        {
            Console.WriteLine("Gandalf sigue vivo");
        }
        else
        {
            Console.WriteLine("Gandalf murio");
        }




    }
}
