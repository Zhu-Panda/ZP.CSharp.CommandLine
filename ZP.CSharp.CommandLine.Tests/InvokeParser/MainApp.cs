using System;
using System.Text;
using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Parsing;
using ZP.CSharp.CommandLine.Factories;
using ZP.CSharp.CommandLine.Builder;
using ZP.CSharp.CommandLine.Tests.InvokeParser;
namespace ZP.CSharp.CommandLine.Tests.InvokeParser
{
    public class MainApp : CommandLineAppComponent<MainApp>
    {
        public override Command Command
        {
            get => new RootCommand()
                .WithOption(new Option<bool>(new[]{"-v", "--verbose"}, "verbose"), true)
                .WithCommand(new Command("ha", "To ha or not to ha, that's the question.")
                    .WithArgument(new Argument<int>("times", "times to ha"))
                    .WithOption(new Option<string>("--lang", "language to ha in"))
                    .WithHandler(MainApp.Ha))
                .ToRoot();
        }
        public override CommandLineBuilder Builder
        {
            get => new CommandLineBuilder(this.Command);
        }
        public override Parser Parser
        {
            get => this.Builder.UseDefaultsWithHelp("-?", "--help").Build();
        }
        public static void Ha(int times, string lang)
        {
            Console.WriteLine($"Language: {lang}\n");
            StringBuilder hahahas = new();
            for (int i = 0; i < times; i++)
            {
                hahahas.Append("ha ");
            };
            Console.WriteLine(hahahas);
        }
        public override int Invoke(string[] args) => this.Parser.Invoke(args);
        public override Task<int> InvokeAsync(string[] args)
        {
            throw new NotSupportedException();
        }
    }
}