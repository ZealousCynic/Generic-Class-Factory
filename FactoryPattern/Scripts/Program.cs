using System;

namespace FactoryPattern.Scripts
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = "a";
            byte c = 1;
            int d = 5;
            byte e = 1;

            //Create instances of classes through generic class factory.
            ShipFighter ship1 = (ShipFighter)ClassFactory<ShipFighter>.CreateInstance(typeof(ShipFighter), b, c, d, e);
            ShipShipper ship2 = (ShipShipper)ClassFactory<ShipShipper>.CreateInstance(typeof(ShipShipper), b, c, d, e);
            ShipEnemy ship3 = (ShipShipper)ClassFactory<ShipShipper>.CreateInstance(typeof(ShipShipper));


            Console.WriteLine(ship2.ShipsShipped);
            Console.WriteLine(((ShipShipper)ship3).ShipsShipped);
            Console.WriteLine(ship1.Name);

            Console.ReadLine();
        }
    }
}
