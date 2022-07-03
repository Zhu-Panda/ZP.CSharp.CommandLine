using System;
using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Parsing;
using ZP.CSharp.CommandLine.UseParseResult;
namespace ZP.CSharp.CommandLine.UseParseResult
{
    public abstract class ParseResultHandler<T> : CommandLineAppComponent<T>, IParseResultHandler
        where T : ParseResultHandler<T>, new()
    {
        #pragma warning disable CS8618
        public ParseResult ParseResult {get; set;}
        #pragma warning restore CS8618
        public static new T FromArgs(string[] args)
        {
            return new T(){CommandLineArgs = args}.SetParseResult();
        }
        private T SetParseResult()
        {
            this.ParseResult = this.Parser.Parse(this.CommandLineArgs);
            return ((T) this);
        }
        public override int Invoke(string[] args) => this.CommandLineArgs == args ? this.ParseResult.Invoke() : FromArgs(args).Invoke();
        public override Task<int> InvokeAsync(string[] args) => this.CommandLineArgs == args ? this.ParseResult.InvokeAsync() : FromArgs(args).SetParseResult().InvokeAsync();
    }
}