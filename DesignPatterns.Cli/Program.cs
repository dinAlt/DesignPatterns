using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using DesignPatterns.Patterns.Strategy;

namespace DesignPatterns.Cli
{
  class Program
  {
    static int Main(params string[] args)
    {
      var cmd = new RootCommand {
        new Argument<string>("command", "Command"),
        // new Option<string>("--describe", "Describe pattern")
       };

      cmd.Handler = CommandHandler.Create<string, IConsole>(HandleRootCmd);
      return cmd.Invoke(args);
    }

    private static void HandleRootCmd(string command, IConsole console)
    {
      var pattern = new StrategyPatternSample();
      switch (command)
      {
        case "run":
          pattern.Run();
          break;
        case "describe":
          console.Out.Write($"{pattern.Description}\n\n");
          break;
        default:
          throw new ArgumentException($"bad command: {command}");
      }
    }
  }
}
