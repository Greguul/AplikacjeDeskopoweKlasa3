﻿using SchoolApp.Database;
using SchoolApp.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    CRUD
    C - create  - insert into
    R - read    - select
    U - update  - update
    D - delete  - delete
  
 */

namespace SchoolApp
{
    class School
    {
        private SchoolDatabaseContext schoolDatabaseContext = new SchoolDatabaseContext();

        public void Run()
        {
            while(true)
            {
                ShowMenu();

                int chosenOption = GetOption();

                switch (chosenOption)
                {
                    case 1:
                        CreateNewSchoolClass();
                        break;
                    case 0:
                        return;
                    default:
                        break;
                }
            }
        }

        private int GetOption()
        {
            int option;

            //Console.WriteLine("Wybierz opcję:");
            //option = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Wybierz opcję:");
            } while (!int.TryParse(Console.ReadLine(), out option));

            return option;
        }

        private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Wybierz opcje:");
            Console.WriteLine("1. Dodaj nową klasę w szkole");
            Console.WriteLine("2. Wyświetl wszystkie klasy w szkole");

            Console.WriteLine("0. Koniec programu");
        }

        private void CreateNewSchoolClass()
        {
            Console.WriteLine("Podaj nazwę klasy:");
            string className = Console.ReadLine();

            SchoolClass schoolClass = new SchoolClass()
            {
                Name = className
            };
            schoolDatabaseContext.SchoolClasses.Add(schoolClass);
            schoolDatabaseContext.SaveChanges();
        }

        private void ReadAllSchoolClasses()
        {
            /*
             select *
               from nazwaBazy.SchoolClasses
             */

            foreach (SchoolClass schoolClass in schoolDatabaseContext.SchoolClasses)
            {
                Console.WriteLine("Id: " + schoolClass.Id + " Nazwa: " + schoolClass.Name);
            }
            Console.ReadKey();
        }
    }
}
