using System;
namespace MetodyPomocniczeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert input : ");

           var userInput =Console.ReadLine();



#pragma warning disable CS8604 // Możliwy argument odwołania o wartości null.
            //Substring(userInput);
#pragma warning restore CS8604 // Możliwy argument odwołania o wartości null.

#pragma warning disable CS8604 // Możliwy argument odwołania o wartości null.
            //Repalce(userInput);
#pragma warning restore CS8604 // Możliwy argument odwołania o wartości null.
#pragma warning disable CS8604 // Możliwy argument odwołania o wartości null.
            Modify(userInput);
#pragma warning restore CS8604 // Możliwy argument odwołania o wartości null.
                              //Split(userInput);
                              //CheckString(userInput);


        }

        static void Substring(string userInput)
        {
            if(userInput.Length > 10)
            {
                string startSubstring = userInput.Substring(0,10);
                string endSubstring = userInput.Substring(userInput.Length-10);
                Console.WriteLine($"{startSubstring}...,... {endSubstring} ");
                Console.WriteLine(userInput);

            }

        }

        static void Repalce(string userInput)
        {
            string template = "hello {name}, how are you {name}?";
            string output = template.Replace("{name}", userInput);
            Console.WriteLine(output);
        }

        static void Modify(string userInput)
        {
            string removedString = userInput.Remove(5); // zwroci elementy do 5 a dalsze usunie
            string subString = userInput.Substring(5); // zwroci od 5 w góre
            string insertedString = userInput.Insert(5, "insert"); // pod index nr 5 została wstawiona wartość "insert" nie mozna podać wiekszego indexu niż posiada wyraz 
            Console.WriteLine(insertedString);
            Console.WriteLine(removedString);
            Console.WriteLine(subString);


            string trimmedString = userInput.Trim(); // usuwa białe znaki np spacji ,tab
            Console.WriteLine(trimmedString);


        }

        static void AlterTextCase(string userInput)
        {

            string upperCased = userInput.ToUpper();
            string lowerCased = userInput.ToLower();


        }

        static void Split(string userInput)
        {                                           
            string[] inputParts = userInput.Split(" ");  // metoda zwraca tablice string - spacja jest separatorem - 
            string firstName = inputParts[0]; // ile wyrazów zostanie znalezionych na podstawie rozdzielenia
            string surName = inputParts[inputParts.Length-1];
            Console.WriteLine($"Hello {firstName}{surName}");
        }

        static void CheckString(string userInput)
        {
            bool isTextFile = userInput.EndsWith(".txt", StringComparison.CurrentCultureIgnoreCase);
            bool startsWithDocPrefix = userInput.StartsWith("doc-", StringComparison.CurrentCultureIgnoreCase);

            bool containText = userInput.Contains("text",StringComparison.CurrentCultureIgnoreCase); // sprawdza czy zawiera "text" nie zwraca uwagi na wielkość liter
            Console.WriteLine($"containText : {containText}");
            Console.WriteLine($"is text file :{isTextFile}");
            Console.WriteLine($"startsWithDocPrefix :{startsWithDocPrefix}");
        }


    }
}