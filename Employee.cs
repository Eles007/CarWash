﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarWash
{
    class Employee
    {
        public int WorkCount;
        public string FIO;
        public Employee(string FullName)
        {
            FIO = FullName;
        }
        public void PrintEmployee()
        {
            Console.WriteLine(FIO + "выполнил услуг: " + WorkCount);
        }
    }
}