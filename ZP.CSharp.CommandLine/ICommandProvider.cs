using System;
using System.CommandLine;
using ZP.CSharp.CommandLine;
namespace ZP.CSharp.CommandLine
{
    public interface ICommandProvider
    {
        public Command Command {get;}
    }
}