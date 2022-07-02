using System;
using System.CommandLine.Parsing;
using ZP.CSharp.CommandLine.Strategies.UseParseResult;
namespace ZP.CSharp.CommandLine.Strategies.UseParseResult
{
    public interface IParseResultHandler : ICommandLineAppComponent
    {
        public ParseResult ParseResult {get; set;}
    }
}