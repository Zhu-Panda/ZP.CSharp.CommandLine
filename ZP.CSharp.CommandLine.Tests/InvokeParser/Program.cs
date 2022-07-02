using System;
using ZP.CSharp.CommandLine.Tests.InvokeParser;
namespace ZP.CSharp.CommandLine.Tests.InvokeParser
{
    public class Program
    {
        public static async Task Main(string[] args) => await MainApp.FromArgs(args).InvokeAsync();
    }
    
}