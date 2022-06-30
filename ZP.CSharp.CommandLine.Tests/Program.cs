using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Parsing;
using ZP.CSharp.CommandLine.Builder;
using ZP.CSharp.CommandLine.Tests;
namespace ZP.CSharp.CommandLine.Tests
{
    public class Program
    {
        public static RootCommand Command = new RootCommand();
        public static CommandLineBuilder Builder = new CommandLineBuilder(Command);
        public static Parser Parser = Builder.UseDefaultsWithHelp("-?", "--help").Build();
        public static void Main(string[] args) => Parser.Invoke("-?");
    }
}