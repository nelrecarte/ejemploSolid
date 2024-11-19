using System;

namespace NoInterfaceSegregation
{
    public interface IVehiculo
    {
        void Conducir();
        void Volar();
        void Navegar();
    }

    public class Auto : IVehiculo
    {
        public void Conducir()
        {
            Console.WriteLine("El auto está conduciendo.");
        }

        public void Volar()
        {
            throw new NotImplementedException("El auto no puede volar.");
        }

        public void Navegar()
        {
            throw new NotImplementedException("El auto no puede navegar.");
        }
    }

    public class Avion : IVehiculo
    {
        public void Conducir()
        {
            throw new NotImplementedException("El avión no puede conducir.");
        }

        public void Volar()
        {
            Console.WriteLine("El avión está volando.");
        }

        public void Navegar()
        {
            throw new NotImplementedException("El avión no puede navegar.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IVehiculo auto = new Auto();
            auto.Conducir();
            auto.Volar();
        }
    }
}
