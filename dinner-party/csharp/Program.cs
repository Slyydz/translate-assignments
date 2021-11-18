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
            List<string> checkTable = new List<string>();





            foreach (var guest in guests)
            {

                if (!checkTable.Contains(guest.Occupation))
                {
                    table1.Add(guest);
                    checkTable.Add(guest.Occupation);
                }
                else
                {
                    table2.Add(guest);
                }
            }

            Console.WriteLine("---------");
            Console.WriteLine("Table 1: ");
            Console.WriteLine("---------");
            foreach (var item in table1)
            {
                Console.WriteLine($"{item.Name} {item.Occupation} {item.Bio}");
            }

            Console.WriteLine("---------");
            Console.WriteLine("Table 2: ");
            Console.WriteLine("---------");
            foreach (var item in table2)
            {
                Console.WriteLine($"{item.Name} {item.Occupation} {item.Bio}");
            }



            List<Guests> getGuests()
            {
                List<Guests> retList = new List<Guests>(){

                new Guests {
      Name  = "Marilyn Monroe",
      Occupation  = "entertainer",
      Bio  = "(1926 - 1962) American actress, singer, model"
    },

            new Guests {
      Name  = "Abraham Lincoln",
      Occupation  = "politician",
      Bio  = "(1809 - 1865) US President during American civil war"
    },

    new Guests {
      Name = "Martin Luther King",
      Occupation = "activist",
      Bio = "(1929 - 1968)  American civil rights campaigner"
    },
    new Guests {
      Name = "Rosa Parks",
      Occupation = "activist",
      Bio = "(1913 - 2005)  American civil rights activist"
    },
    new Guests {
      Name = "Peter Sellers",
      Occupation = "entertainer",
      Bio = "(1925 - 1980) British actor and comedian"
    },
    new Guests {
Name = "Alan Turing",
      Occupation = "computer scientist",
      Bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
    },
    new Guests {
Name = "Admiral Grace Hopper",
      Occupation = "computer scientist",
      Bio = "(1906–1992) - developed early compilers = FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
    },
    new Guests {
Name = "Indira Gandhi",
      Occupation = "politician",
      Bio = "(1917 - 1984) Prime Minister of India 1966 - 1977",
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
