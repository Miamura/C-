using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Dwarwen
    {
        private static Dwarwen Dwarwen_nerede;
        private int Dwrwn_Attack;

        protected Dwarwen()
        {
            Console.WriteLine("Cüceler oluşturuldu");
        }

        public static Dwarwen GetInstance()
        {
            if (Dwarwen_nerede == null)
            {
                Dwarwen_nerede = new Dwarwen();
            }
            return Dwarwen_nerede;
        }


        public int VeriGir()
        {
            return Dwrwn_Attack;
        }

        public void VeriAl(int val)
        {
            Dwrwn_Attack = val;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*crate object yerine getınstance vardı kaynaklarda getınstanceyi arattığımda 
              sadece singleton ile ilgili olduğunu gördüm*/

            Dwarwen Thorin = Dwarwen.GetInstance();
            Dwarwen Gimli = Dwarwen.GetInstance();
            Dwarwen Gloin = Dwarwen.GetInstance();

            Thorin.SetData(1500);

            Console.WriteLine("Yeni cüceler oluşturuluyor");

            Console.WriteLine("Thorin verisi {0} \n", Thorin.Verigir());
            Console.WriteLine("Gimli verisi {0} \n", Gimli.Verigir());
            Console.WriteLine("Gloin verisi {0} \n", Gloin.Verigir());

            Console.ReadKey();
            
            Thorin.SetData(3000);

            Console.WriteLine("Thorin verisi {0} \n", Thorin.Verigir());
            Console.WriteLine("Gimli verisi {0} \n", Gimli.Verigir());
            Console.WriteLine("Gloin verisi {0} \n", Gloin.Verigir());
            Console.ReadKey();
        }
    }
}