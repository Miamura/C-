using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeMethod
{
    public class Veri : ICloneable
    {
        private string isim;
    
        private ArrayList Nan = null;
    
    public string Isim
        {
            get
            {
                return isim;
            }
            set
            {
                isim = value;
            }
        }
        public Veri ()
        {
            isim = "Maheshavara";
            string[] Irklarinadları = { "Cüceler", "Elfler", "Goblinler" };

            Nan = new Arraylist();
            Nan.AddRange(Irklarinadları);
        }
        
        public void Irkekle(string isim)
        {
            Nan.Add(isim);
        }

        public void IrklarınListesi()
        {
            for(int i=0;i < Nan.Count-1 ;++i)
            {
                Console.WriteLine(Nan[i]);
            }
        }
        
        public object Clone()
        {
            return new Veri();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Veri cingu = new Veri();

            Veri IL = (Veri)cingu.Clone();
            IL.Isim = "İnsanlar";
            IL.Irkekle("Haladrim");
            Console.WriteLine(IL.Isim);
            IL.IrklarınListesi();
            Veri IL2 = (Veri)cingu.Clone();
            IL2.Isim = "Uruk Hai";
            IL2.Irkekle("Orclar");
            Console.WriteLine(IL2.Isim);
            IL2.IrklarınListesi();
        }
    }
}
