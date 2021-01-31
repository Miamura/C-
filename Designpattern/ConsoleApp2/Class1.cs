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

}
