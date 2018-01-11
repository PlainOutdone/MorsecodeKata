using Morsecode.Domain;
using Morsecode.Domain.CodeReader;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Morsecode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your morse code and press enter.");
            var input = Console.ReadLine();
            ICodeReader reader = IoC.Container.GetService<ICodeReader>();
            var output = "";
            try
            {
                output = reader.DecryptMessage(input);
                Console.WriteLine($"That translates to: {output}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong... {ex.ToString()}");
            }
            Console.ReadKey();
        }
    }
}
