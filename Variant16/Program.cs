﻿using Microsoft.VisualBasic;
using System;
using System.Data.Common;
using System.Net;
using System.Xml.Linq;

namespace Variant16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer ("Лисичников", "Алексей", "Алексеевич", "Шуист", 89876543211, 7876542300008756, 0001),
                new Customer ("Антипкин", "Денис", "Павлович", "Телегино", 89875102996, 0040320878560000, 0002),
                new Customer ("Тупицин", "Илья", "Алексеевич", "Кургановка", 89560234501, 6700880823043498, 0003),
                new Customer ("Панькин", "Данила", "Сергеевич", "Kamenka", 89876590123, 4500300020207856, 0004)
            };
            

            var sorted = customers.OrderBy(ob => ob.familyname).ToArray();
                Console.WriteLine("Привет дружище, вот тебе список покупателей в алфавитном порядке: " );
                Console.WriteLine("------------------------------------------------");
            Array.ForEach(sorted, Console.WriteLine);
                Console.WriteLine("------------------------------------------------");

            


        }
    }
}