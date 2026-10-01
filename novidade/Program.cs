
using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Security;
using System.Formats.Tar;
using System.IO.Pipelines;
using System.Security.Cryptography.X509Certificates;
using System.Data.Common;
namespace novidade
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Email of people whose salary is more than ");
            double wr = double.Parse(Console.ReadLine());




            string path = @"C:\Users\rafael\Desktop\jklmn.csv.txt";

            List<Employee> list = new List<Employee>();

            using StreamReader sr = new StreamReader(path);
            {

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] partes = line.Split(',');

                    string Name = partes[0];
                    string email = partes[1];
                    double salary = double.Parse(partes[2]);

                    Employee employee = new Employee(Name,email,salary);



                    list.Add(employee);



                }

            }
           
           
            var resultado = list.Where(p => p.salary > wr).OrderBy(p => p.email).Select(p => p.email);

            var pessoasM = list.Where(p => p.Name.StartsWith("M")); 
            var trt = pessoasM.Sum(o => o.salary);



            foreach ( string p in resultado) 
            {

                Console.WriteLine(p);



               

            }


            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + trt);




            Console.WriteLine("cocozin");




        }


    }


}
















































