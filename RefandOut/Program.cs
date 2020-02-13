using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefandOut
{
  class Program
  {
    static void Main(string[] args)
    {
      // all very obvious. 
      Console.WriteLine("May I have your name? ");
      String name = Console.ReadLine();
      String message = makeGreating(name);
      Console.WriteLine(message);

      // makes a new string, completeName, based on the out variable of makeFullName
      // Also returns a number, distinct from the out call.
      Console.WriteLine("Your last name as well? ");
      string lastname = Console.ReadLine();
      int nameLength = makeFullname(name, lastname, out string completeName);
      Console.WriteLine("You are named " + completeName + ". It has " + nameLength + " letters.");

      // Sends capitalizeName a already exsting variable to capitalize.
      capitalizeName(ref completeName);
      Console.WriteLine("Your name made big: " + completeName);

      Console.WriteLine("Press a key to leyve");
      Console.ReadKey();
    }

    static string makeGreating(string name)
    {
      return "Hello " + name + ".";
    }

    static int makeFullname(string firstname, string lastname, out string fullname)
    {
      //sends out fullname and returns its length.
      fullname = firstname + " " + lastname;
      return fullname.Length;
    }

    static void capitalizeName(ref string makeBigger)
    {
      // despite modifying a variable from another scope the names are still unique to their respective scopes.
      makeBigger = makeBigger.ToUpper();
    }
  }
}
