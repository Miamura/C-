using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Sample
    {
        private static Sample mp_Smp;
        private int m_Data;

        protected Sample()
        {

        }

        public static Sample CreateObject()
        {
            if (mp_Smp == null)
            {
                mp_Smp = new Sample();
            }
            return mp_Smp;
        }
    
    public int GetData()
    {
        return m_Data;
    }

    public void SetData(int val)
    {
        m_Data = val;
    }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sample obj1 = Sample.CreateObject();
            Sample obj2 = Sample.CreateObject();
            Sample obj3 = Sample.CreateObject();

            obj1.SetData(7877);

            Console.Write("obj1-Data {0} \n", obj1.GetData());
            Console.Write("obj2-Data {0} \n", obj2.GetData());
            Console.Write("obj3-Data {0} \n", obj3.GetData());

            Console.WriteLine("----------");

            Console.ReadKey();
            
            obj1.SetData(1999);

            Console.Write("obj1-Data {0} \n", obj1.GetData());
            Console.Write("obj2-Data {0} \n", obj2.GetData());
            Console.Write("obj3-Data {0} \n", obj3.GetData());
            Console.ReadKey();
        }
    }
}
