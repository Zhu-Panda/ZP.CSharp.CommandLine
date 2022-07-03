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
        public static Option<bool> InfoOption = new Option<bool>("--info", "print info");
        public override Command Command
        {
            get => new RootCommand()
                .WithOption(InfoOption, true)
                .WithCommand(new Command("ha", "To ha or not to ha, that's the question.")
                    .WithArgument(new Argument<int>("times", "times to ha"))
                    .WithOption(new Option<string>("--lang", "language to ha in"))
                    .WithHandler(MainApp.Ha))
                .WithHandler(this.Main)
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
        public void Main(bool info)
        {
            if (info)
            {
                PrintInfo();
            }
            else
            {
                this.Invoke(new[]{"-?"});
            }
        }
        public static void Ha(int times, string lang, bool info)
        {
            if (info)
            {
                PrintInfo();
            }
            else
            {
                Console.WriteLine($"Language: {lang}\n");
                StringBuilder hahahas = new();
                for (int i = 0; i < times; i++)
                {
                    hahahas.Append("ha ");
                };
                Console.WriteLine(hahahas);
            }
        }
        public static void PrintInfo()
        {
            Console.WriteLine("This is a test info delivered to you using basic handlers.");
        }
        public override Task<int> InvokeAsync(string[] args)
        {
            throw new NotSupportedException();
        }
    }
}