using System;
using System.CommandLine;
using ZP.CSharp.CommandLine.Strategies.InvokeParser;
namespace ZP.CSharp.CommandLine.Strategies.InvokeParser
{
    public interface IParserInvoker : ICommandLineAppComponent
    {
        public int Invoke(string[] args);
        public Task<int> InvokeAsync(string[] args);
    }
}