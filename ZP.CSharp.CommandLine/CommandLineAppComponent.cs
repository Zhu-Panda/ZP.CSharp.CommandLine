using System;
using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Parsing;
using ZP.CSharp.CommandLine;
namespace ZP.CSharp.CommandLine
{
    public abstract class CommandLineAppComponent<T> : ICommandLineAppComponent
        where T : CommandLineAppComponent<T>, new()
    {
        #pragma warning disable CS8618
        public string[] CommandLineArgs {get; init;}
        #pragma warning restore CS8618
        public abstract Command Command {get;}
        public abstract CommandLineBuilder Builder {get;}
        public abstract Parser Parser {get;}
        public static T FromArgs(string[] args) => new T(){CommandLineArgs = args};
        public virtual int Invoke() => this.Invoke(this.CommandLineArgs);
        public virtual int Invoke(string[] args) => this.Parser.Invoke(args);
        public virtual Task<int> InvokeAsync() => this.InvokeAsync(this.CommandLineArgs);
        public virtual Task<int> InvokeAsync(string[] args) => this.Parser.InvokeAsync(args);
    }
}