using System;

namespace ParsiranjeTeksta
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string text = "John.Davidson/Belgrade Michael.Barton/Krakow Ivan.Perkinson/Moscow";

            string[] data = text.Split(". ");

            Person[] person = new Person[data.Length];

           
                {
                    Person person1 = new Person("John", "Davidson", "Belgrade");
                    Person person2 = new Person("Michael", "Barton", "Krakow");
                    Person person3 = new Person("Ivan", " Perkinson", "Moscow");


                    foreach (var persons in person)

                        Console.WriteLine(person1);
                        Console.WriteLine(person2);
                        Console.WriteLine(person3);
                }

            }

        }
     }
