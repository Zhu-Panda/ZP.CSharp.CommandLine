using System;
using System.CommandLine.Parsing;
using ZP.CSharp.CommandLine.UseParseResult;
namespace ZP.CSharp.CommandLine.UseParseResult
{
    public interface IParseResultHandler : ICommandLineAppComponent
    {
        public ParseResult ParseResult {get; set;}
    }
}