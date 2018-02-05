﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        // Поля данных.
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        
        //Конструкторы.
        public Employee () { }
        public Employee (string name, int id, float pay)
            :this(name, 0, id, pay) {}
        public Employee (string name, int age, int id, float pay)
        {
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
        }
        
        //Методы.
        public void GiveBonus (float amout)
        {
            Pay += amout;
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Age: {0}", empAge);
            Console.WriteLine("Pay: {0}", currPay);
        }

        // Свойства.
        public int Age
        {
            get
            {
                return empAge;
            }
            set
            {
                empAge = value;
            }
        }
        public string Name
        {
            get
            {
                return empName;
            }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name must be than 16 characters!");
                }
                else
                {
                    empName = value;
                }
            }
        }
        // Можно было бы добавить дополнительные бизнес-правила для установки 
        // этих свойств, но в данном примере в этом нет необходимости.
        public int ID
        {
            get
            {
                return empID;
            }
            set
            {
                currPay = value;
            }
        }

        public float Pay
        {
            get
            {
                return currPay;
            }
            set
            {
                currPay = value;
            }
        }
      
    }
}
