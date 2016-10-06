using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Scripting;

namespace RoslynFail
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var options =
                ScriptOptions.Default
                .WithReferences("System.Runtime")
                .WithReferences("System.Runtime, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")
                .WithReferences(typeof(object).GetTypeInfo().Assembly);

            Microsoft.CodeAnalysis.CSharp.Scripting.CSharpScript.RunAsync("System.Console.WriteLine(Foo);", options, new { Foo ="Hello World!" } );
        }
    }
}
