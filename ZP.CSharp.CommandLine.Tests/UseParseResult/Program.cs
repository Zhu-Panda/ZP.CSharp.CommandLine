using System;
using ZP.CSharp.CommandLine.Tests.UseParseResult;
namespace ZP.CSharp.CommandLine.Tests.UseParseResult
{
    public class Program
    {
        public static void Main(string[] args) => MainApp.FromArgs(args).Invoke();
    }
}