using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuriTiras1453
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar bilgisayar = new Bilgisayar();
            bilgisayar.marka = "Lenovo";
            bilgisayar.model = "Desktop";
            bilgisayar.fiyat = 1500;
            double kdvliFiyat=bilgisayar.KDVlFiyat(bilgisayar.fiyat);
            Console.WriteLine("KDV li fiyat:"+kdvliFiyat);

            Laptop  laptop = new Laptop();
            laptop.HEKarti = true;
            laptop.BataryaSuresi = 30;
            laptop.fiyat = 2000;
            double laptopkdvlifiyat=laptop.KDVlFiyat(laptop.fiyat);
            Console.WriteLine("Laptop KDV li Fiyat:"+laptopkdvlifiyat);

        }
    }
    public class Bilgisayar 
    {
        public string marka;
        public string model;
        public uint RAMMiktari { get; set; }
        public bool HEKarti { get; set; }
        public double fiyat { get; set; }
        public virtual double KDVlFiyat(double asilFiyat)
        {
            return asilFiyat + asilFiyat * 18 / 100;
        }
    }
    public class Laptop : Bilgisayar
    {
        public uint BataryaSuresi { get; set; }
        public uint Agirlik { get; set; }
        public Laptop()
        {
            Console.WriteLine("En iyi Laptop markası MAC dir.");
        }
        public override double KDVlFiyat(double asilFiyat)
        {
            return asilFiyat + asilFiyat * 25 / 100;
        }
    }
    

}
