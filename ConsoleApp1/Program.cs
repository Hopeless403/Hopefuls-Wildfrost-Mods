using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var decompiler = new ICSharpCode.Decompiler.CSharp.CSharpDecompiler(
            fileName: "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Wildfrost\\Modded\\Wildfrost_Data/Managed/Assembly-CSharp.dll",
            settings: new ICSharpCode.Decompiler.DecompilerSettings(ICSharpCode.Decompiler.CSharp.LanguageVersion.Latest)
            );

            string contents = decompiler.DecompileTypeAsString(new(typeof(Console).FullName));
            File.WriteAllText(
                path: Path.Combine(Application.persistentDataPath, $"{typeof(Console).Name}.txt"),
                contents: contents
                );
            System.Console.WriteLine(contents);

            do
            {
                while (!System.Console.KeyAvailable)
                {
                    Bootstrap.Count++;
                    //Debug.Log("owo");
                }
            } while (System.Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
