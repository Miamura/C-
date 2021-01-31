using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Gold
    {
        private int cryptomoney;//nominal değer para çek senet değeri demekmiş

        protected Gold(int cryptomoneyprice)
        {
            cryptomoney = cryptomoneyprice;
        }
        public string forcryptomoney
        {
            get
            {
                return cryptomoney.ToString() + " BTC";
            }
        }
    }

    public class SeventeenCaratGold : Gold
    {
        internal SeventeenCaratGold(int cryptomoney)
        : base(cryptomoney)
        {

        }
    }

    public abstract class Atölye
    {
        public abstract Gold AltınÜret(int cryptomoney);
    }
    public class KemeraltıAtölye : Atölye
    {
        public override Gold AltınÜret(int cryptomoney)
        {
            return new SeventeenCaratGold(cryptomoney);
        }

    }

    class Program
    {
        private static void Main(string[] args)
        {
            KemeraltıAtölye Atölye = new KemeraltıAtölye();
            SeventeenCaratGold seventeenCaratGold = (SeventeenCaratGold)Atölye.AltınÜret(276);
            Console.WriteLine(seventeenCaratGold.forcryptomoney);
            Console.ReadKey();
        }
    }
    
}
