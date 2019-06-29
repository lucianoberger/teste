using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Product[] vect = new Product[10];

            Console.Write("Quantos quartos irâo ser alugados?");
            int n = int.Parse(Console.ReadLine());



            for (int i = 0; i < n; i++) {

                Console.WriteLine($"Rent #{ i}:");
                Console.Write("Nome:");
                string name = Console.ReadLine();
                Console.Write("Email:");
                string email = Console.ReadLine();
                Console.Write("Quarto:");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Product { Name = name, Email = email };
            }


            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }


        }
    }
}

