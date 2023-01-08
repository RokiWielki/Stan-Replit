using System;
namespace Stan_Replit
{
    interface Stan
    {

        void alert();

    }

    class Powiadomienia
    {

        private Stan aktualnyStan;

        public Powiadomienia()
        {
            aktualnyStan = new Wibracja();
  }

        public void alert()
        {
            aktualnyStan.alert();
        }
        public void ustawStan(Stan stan)
        {
            this.aktualnyStan=stan;
        }

    }

    class Dzwonek : Stan
    {
        public void alert()
        {
            Console.WriteLine("dzwonek...");
        }
    }
    class Wibracja : Stan
    {
        public void alert()
        {
            Console.WriteLine("wibracja...");
        }
    }
    class Wyciszenie : Stan
    {
        public void alert()
        {
            Console.WriteLine("wyciszenie...");
        }
    }



    class Program
    {
        public static void Main(string[] args)
        {
            Powiadomienia powiadomienia= new Powiadomienia();
            powiadomienia.alert();
            powiadomienia.ustawStan(new Dzwonek());
            powiadomienia.alert();
            powiadomienia.ustawStan(new Wyciszenie());
            powiadomienia.alert();
            powiadomienia.alert();
            powiadomienia.ustawStan(new Wibracja());
            powiadomienia.alert();
        }
    }
}