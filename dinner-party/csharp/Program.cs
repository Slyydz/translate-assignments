using System;
using System.Collections.Generic;
namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Guests> guests = getGuests();


            List<Guests> table1 = new List<Guests>();
            List<Guests> table2 = new List<Guests>();






            foreach (var guest in guests)
            {
                // Console.WriteLine(guest.Occupation);
                table1.Add(guest);
                if (table1.Contains(guest.Occupation.ToString()))
                {
                    table2.Add(guest);
                }
                else
                {
                    table1.Add(guest);
                }
            }

            foreach (var item in table1)
            {
                Console.WriteLine(item.Name);
            }
            foreach (var item in table2)
            {
                Console.WriteLine(item.Name);
            }



            List<Guests> getGuests()
            {
                List<Guests> retList = new List<Guests>(){

                new Guests{
      Name = "Marilyn Monroe",
      Occupation = "entertainer",
      Bio = "(1926 - 1962) American actress, singer, model"
    },

            new Guests{
      Name = "Abraham Lincoln",
      Occupation = "politician",
      Bio = "(1809 - 1865) US President during American civil war"
    }

            };
                return retList;

            }
        }
    }

    public class Guests
    {
        public string Name { get; set; }

        public string Occupation { get; set; }

        public string Bio { get; set; }

    }


}
