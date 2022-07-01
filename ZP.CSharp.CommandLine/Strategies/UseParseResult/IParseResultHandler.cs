using System;
using System.CommandLine.Parsing;
using ZP.CSharp.CommandLine.Strategies.UseParseResult;
namespace ZP.CSharp.CommandLine.Strategies.UseParseResult
{
    public interface IParseResultHandler : ICommandLineAppComponent
    {
        public int Parse(string[] args);
        public Task<int> ParseAsync(string[] args);
        public void ConfigureFromParseResult(ParseResult result);
        public int Run();
        public Task<int> RunAsync();
    }
}