using System;
using System.Collections.Generic;
using System.Text;

namespace CarWash
{
    class Employee : Person
    {
        public int WorkCount;
        public Employee(string FullName)
        {
            FIO = FullName;
        }
    }
}
