using System;
using Practica_POO;

class PracticaPOO
{
    static void Main()
    {
        Garaje garaje = new Garaje();

        Coche coche1 = new Coche("Ford", "Explorer");
        Coche coche2 = new Coche("Honda", "Accord");

        Random rnd = new Random();

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("--------------");
            Console.WriteLine("Ciclo {0}", i + 1);
            Console.WriteLine("--------------");

            if (garaje.AceptarCoche(coche1, "cambio de aceite"))
            {
                Console.WriteLine("El coche {0} {1} ha entrado en el garaje para cambio de aceite.", coche1.Marca, coche1.Modelo);
                coche1.AcumularAveria(rnd.NextDouble());
                coche1.AcumularLitrosDeAceite(10);
                garaje.DevolverCoche();
                Console.WriteLine("El coche {0} {1} ha salido del garaje.", coche1.Marca, coche1.Modelo);
            }
            else
            {
                Console.WriteLine("El garaje está ocupado, el coche {0} {1} tendrá que esperar.", coche1.Marca, coche1.Modelo);
            }

            if (garaje.AceptarCoche(coche2, "revisión"))
            {
                Console.WriteLine("El coche {0} {1} ha entrado en el garaje para revisión.", coche2.Marca, coche2.Modelo);
                coche2.AcumularAveria(rnd.NextDouble());
                garaje.DevolverCoche();
                Console.WriteLine("El coche {0} {1} ha salido del garaje.", coche2.Marca, coche2.Modelo);
            }
            else
            {
                Console.WriteLine("El garaje está ocupado, el coche {0} {1} tendrá que esperar.", coche2.Marca, coche2.Modelo);
            }
        }

        Console.WriteLine("--------------");
        Console.WriteLine("Información de los coches");
        Console.WriteLine("--------------");
        Console.WriteLine($"Coche 1 - Marca: {coche1.Marca}, Modelo: {coche1.Modelo}, Precio averías acumulado: {coche1.PrecioAverias:C2}, Litros de aceite: {coche1.LitrosdeAceite}");
     
        Console.WriteLine("Coche 2 - Marca: {0}, Modelo: {1}, Precio averías acumulado: {2:C2}",
            coche2.Marca, coche2.Modelo, coche2.PrecioAverias);

        Console.ReadLine();
    }
}
