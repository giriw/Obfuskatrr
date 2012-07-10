using System;
using Mono.Cecil;
namespace Obfuskatr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type the path to the file: ");
            var path = Console.ReadLine();
            var asmDef = AssemblyDefinition.ReadAssembly(path);
            Console.WriteLine("[-] Assembly loaded: {0}", path);
            Core.FullProtect(asmDef);
            Core.WriteAssembly(asmDef);
            Console.Write("Done!");
            Console.ReadLine();
        }
    }
}
