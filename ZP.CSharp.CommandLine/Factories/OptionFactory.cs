using System;
using System.CommandLine;
using System.CommandLine.Parsing;
using ZP.CSharp.CommandLine.Factories;
namespace ZP.CSharp.CommandLine.Factories
{
    public static class OptionFactory
    {
        public static Option WithAliases(this Option option, params string[] aliases)
        {
            foreach (var alias in aliases)
            {
                option.AddAlias(alias);
            }
            return option;
        }
        public static Option WithCompletions(this Option option, params string[] completions)
        {
            option.AddCompletions(completions);
            return option;
        }
        public static Option WithValidators(this Option option, params ValidateSymbolResult<OptionResult>[] validators)
        {
            foreach (var validator in validators)
            {
                option.AddValidator(validator);
            }
            return option;
        }
    }
}