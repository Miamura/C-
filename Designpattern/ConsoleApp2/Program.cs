using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Dwarwen
    {
        private static Dwarwen mp_Smp;
        private int m_Data;

        protected Dwarwen()
        {

        }

        public static Dwarwen GetInstance()
        {
            if (mp_Smp == null)
            {
                mp_Smp = new Dwarwen();
            }
            return mp_Smp;
        }
    }

    public int GetData()
    {
        return m_Data;
    }

    public void SetData(int val)
    {
        m_Data = val;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dwarwen obj1 = Dwarwen.GetInstance();
            Dwarwen obj2 = Dwarwen.GetInstance();
            Dwarwen obj3 = Dwarwen.GetInstance();

            obj1.SetData(7877);

            Console.Write("obj1-Data {0} \n", obj1.GetData());
            Console.Write("obj2-Data {0} \n", obj2.GetData());
            Console.Write("obj3-Data {0} \n", obj3.GetData());

            Console.WriteLine("----------");

            obj1.SetData(1999);

            Console.Write("obj1-Data {0} \n", obj1.GetData());
            Console.Write("obj2-Data {0} \n", obj2.GetData());
            Console.Write("obj3-Data {0} \n", obj3.GetData());
        }
    }
}
