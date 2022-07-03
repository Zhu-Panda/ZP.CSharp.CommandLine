using System;
using System.CommandLine;
using System.CommandLine.Builder;
using ZP.CSharp.CommandLine.Builder;
namespace ZP.CSharp.CommandLine.Builder
{
    public static class CommandLineBuilderExtensions
    {
        public static CommandLineBuilder UseDefaultsWithHelp(
            this CommandLineBuilder builder,
            params string[] helpAliases) =>
            builder.UseHelp(helpAliases)
                .UseDefaults();
        public static CommandLineBuilder UseDefaultsWithVersion(
            this CommandLineBuilder builder,
            params string[] versionAliases) =>
            builder.UseHelp()
                .UseVersionOption(versionAliases)
                .UseDefaults();
        public static CommandLineBuilder UseDefaultsWithHelpAndVersion(
            this CommandLineBuilder builder,
            string[] helpAliases,
            string[] versionAliases) =>
            builder.UseHelp(helpAliases)
                .UseVersionOption(versionAliases)
                .UseDefaults();
        public static CommandLineBuilder UseDefaultsWithHelpAndVersion(
            this CommandLineBuilder builder,
            string helpAlias,
            string versionAlias) =>
            builder.UseDefaultsWithHelpAndVersion(
                new[]{helpAlias},
                new[]{versionAlias}
            );
        public static CommandLineBuilder UseDefaultsWithHelpAndVersion(
            this CommandLineBuilder builder,
            string helpAlias,
            params string[] versionAliases) =>
            builder.UseDefaultsWithHelpAndVersion(
                new[]{helpAlias},
                versionAliases
            );
        public static CommandLineBuilder UseDefaultsWithHelpAndVersionWithVersionFirst(
            this CommandLineBuilder builder,
            string versionAlias,
            params string[] helpAliases) =>
            builder.UseDefaultsWithHelpAndVersion(
                helpAliases,
                new[]{versionAlias}
            );
    }
}
