using System;
using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using ZP.CSharp.CommandLine;
namespace ZP.CSharp.CommandLine
{
    public static class CommandFactory
    {
        public static Command NewRoot(string description = "") => new RootCommand(description);
        public static Command New(string name = "", string description = "") => new Command(name, description);
        public static RootCommand ToRoot(this Command command)
        {
            if (command is RootCommand commandAsRoot)
            {
                return commandAsRoot;
            }
            else
            {
                try
                {
                    var rootCommand = (RootCommand) command;
                }
                catch (InvalidCastException)
                {
                    throw new InvalidOperationException("Cannot cast command to RootCommand.");
                }
                return null!;
            }
        }
        public static Command WithCommand(this Command command, Command subCommand)
        {
            command.AddCommand(subCommand);
            return command;
        }
        public static Command WithArgument(this Command command, Argument argument)
        {
            command.AddArgument(argument);
            return command;
        }
        public static Command WithOption(this Command command, Option option, bool global = false)
        {
            if (global)
            {
                command.AddGlobalOption(option);
            }
            else
            {
                command.AddOption(option);
            }
            return command;
        }
        public static Command WithHandler(this Command command, Delegate handler)
        {
            command.Handler = CommandHandler.Create(handler);
            return command;
        } 
    }
}