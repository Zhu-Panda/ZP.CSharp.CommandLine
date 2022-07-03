using System;
using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Parsing;
using ZP.CSharp.CommandLine;
namespace ZP.CSharp.CommandLine
{
    public interface ICommandLineAppComponent : ICommandProvider
    {
        public string[] CommandLineArgs {get; init;}
        public CommandLineBuilder Builder {get;}
        public Parser Parser {get;}
        public int Invoke(string[] args);
        public Task<int> InvokeAsync(string[] args);
    }
}