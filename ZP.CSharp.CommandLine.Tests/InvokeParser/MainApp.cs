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
    public class MainApp : ICommandLineAppComponent
    {
        public Command Command
        {
            get => new RootCommand()
                .WithOption(new Option<bool>(new[]{"-v", "--verbose"}, "verbose"), true)
                .WithCommand(new Command("ha", "To ha or not to ha, that's the question.")
                    .WithArgument(new Argument<int>("times", "times to ha"))
                    .WithOption(new Option<string>("--lang", "language to ha in"))
                    .WithHandler(MainApp.Ha))
                .ToRoot();
        }
        public CommandLineBuilder Builder
        {
            get => new CommandLineBuilder(this.Command);
        }
        public Parser Parser
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
        public int Invoke(string[] args)
        {
            return this.Parser.Invoke(args);
        }
        public async Task<int> InvokeAsync(string[] args)
        {
            return await new Task<int>(() => 0);
        }
    }
}