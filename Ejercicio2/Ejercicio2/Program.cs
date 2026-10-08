using System;
using Ejercicio2;

class Ej2
{
     static void Main()
    {
        Pocion pocion = new Pocion(50, "Poti" , 10f);
        ArmaEquipable espada = new ArmaEquipable(50 , "Excalibur" , 100f);
        CofreBotin cofre = new CofreBotin(pocion, espada);

        cofre.Abrir();
        Console.ReadKey();






    }
}