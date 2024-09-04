using System.Diagnostics.Contracts;

namespace Grunleggende_C__oppagve;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        

        //Oppgave 2
        
        int kaffeTall = 20;
        string kaffePrat = "Skal man ha kaffe latte eller cappuchino?";
        double presiseKaffeTall = 20.5;
        char k = '+';

        
            Console.WriteLine(kaffeTall);
            Console.WriteLine(kaffePrat);
            Console.WriteLine(presiseKaffeTall);
            Console.WriteLine(k);
        
        int[] myNumbers = [3, 6, 9];
        for(int i = 0; i < myNumbers.Length; i = i + 1)
        {
            Console.WriteLine(myNumbers[i]);
        }
        string[] kaffeFjas = ["Monte Cristo", "eller", "Kenneths snop", "?"];
        foreach (string tekst in kaffeFjas)
        {
            Console.WriteLine(tekst);
        }

        List<string> kaffeMeny = new List<string>();
        kaffeMeny.Add("Kaffe Latte");
        kaffeMeny.Add("Cortado");
        kaffeMeny.Add("Espresso");
        kaffeMeny.Add("Kaffe Mocca");
        foreach (string item in kaffeMeny)
        {
            Console.WriteLine(item);    
        }
        
        //Oppgave 3

        Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        myDictionary.Add(4, "four");
        myDictionary.Add(8, "eight");
        myDictionary.Add(12, "twelve");

        foreach (var items in myDictionary)
        {
            Console.WriteLine(items);
        }


        int a = 5;
        int b = 8;
        int sum = a + b;
        {
            Console.WriteLine(sum);
        }


        string? mname = Console.ReadLine();
        Console.WriteLine("\n" + mname + "," + " snart er det helg" + "\n");



        
    }
    
    
    

    

}
