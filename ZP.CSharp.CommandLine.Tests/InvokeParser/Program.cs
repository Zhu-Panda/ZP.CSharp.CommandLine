using System;
using ZP.CSharp.CommandLine.Tests.InvokeParser;
namespace ZP.CSharp.CommandLine.Tests.InvokeParser
{
    public class Program
    {
        public static void Main(string[] args) => MainApp.FromArgs(args).Invoke();
    }
    
}