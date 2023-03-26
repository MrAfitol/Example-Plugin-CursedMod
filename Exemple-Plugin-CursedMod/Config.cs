namespace Exemple_Plugin
{
    using System.ComponentModel;

    public class Config
    {
        //A parameter for the config in which we specify what text will be displayed to the player.
        //[Description("...")] - Description of our parameter.
        [Description("The message that is shown to players who have joined the server. (%nickname% - player's nickname)")]
        public string JoinMessage { get; set; } = "Hi %nickname%, read the rules!";
    }
}
