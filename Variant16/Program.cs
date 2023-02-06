using System;
using System.Data.Common;

namespace Variant16
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[4];
            customers[0] = new Customer("Antipkin", "Denis", "Pavlovich", "Telegino", 89876543211, 7876542300008756, 0001);
            customers[1] = new Customer("Lisichnikov", "Alexey", "Alexeevich", "Shuist", 89875102996, 0040320878560000, 0002);
            customers[2] = new Customer("Tupicin", "Ilya", "Alexeevich", "Kurganovka", 89560234501, 6700880823043498, 0003);
            customers[3] = new Customer("Pankin", "Danila", "Sergeevich", "Kamenka", 89876590123, 4500300020207856, 0004);

            Customer youngestCat = FindYoungestCat(customers);
            Console.WriteLine(youngestCat.familyname);

            static Customer FindYoungestCat(Customer[] customers)
            {
                Customer result = customers[0];
                for(int i = 1; i< customers.Length; i++)
                {
                    if (customers[i].phonenumber < result.phonenumber)
                    {
                        result = customers[i];
                    }
                }
                return result;
            }










            //for(int i = 0; i < customers.Length; i++)
                //Console.WriteLine("AS[{0}] = {1}", i, customers[i]);

            //Array.Sort(customer);
           
            //for (int i = 0; i <= 4; i++)
            //{
            //    Console.WriteLine(customer[0]);
            //}
        }
    }
}
