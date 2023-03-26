namespace Exemple_Plugin.Commands
{
    using CommandSystem;
    using System;

    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class PingCommand : ICommand
    {
        public string Command => "test";
        public string[] Aliases => new string[] { "tst" };
        public string Description => "Test command";

        //A method that is called when a command is used.
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            //response - The text to be returned to the console.
            //return true/false - if the command was executed successfully, we return true, if not, false.
            response = "Hello world!";
            return true;
        }
    }
}
