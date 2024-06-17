using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManager
{
    public class Student
    {
        public enum Branch
        {
            CS = 101,
            IT = 102,
            ECE = 103,
            ME = 104,
            EE = 105,
            EI = 106,
            CIVIL = 107,
            CHEM = 108,
            ENV = 109
        }

       public  enum Section
        {
            A,
            B,
            C,
            D,
            E,
            F,
            G,
            H
        }

        public static int id;
        public string Name { get; set; }
        public int Age { get; set; }
        public int Branches { get; set; }
        public int Sections { get; set; }

        public int value;

        public int increment()
        {
            id = id + 1;
            return id;
        }
    }

}
