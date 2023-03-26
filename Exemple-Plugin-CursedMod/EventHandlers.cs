namespace Exemple_Plugin
{
    using CursedMod.Events.Arguments.Player;
    using CursedMod.Features.Logger;

    public class EventHandlers
    {
        //Called when the player has joined the server.
        public void OnPlayerJoined(PlayerJoinedEventArgs ev)
        {
            //Displays the text from the config on the player's screen.
            //.Replace("%nickname%", ev.Player.DisplayNickname)); - Replaces the old text (%nickname%) with the new one (ev.Player.DisplayNickname).
            ev.Player.ShowBroadcast(Plugin.Instance.Config.JoinMessage.Replace("%nickname%", ev.Player.DisplayNickname));
            //Sends a debug message to the server console
            CursedLogger.LogDebug($"Player {ev.Player.DisplayNickname} has joined the server.");
        }

        //Called when the player has disconnected from the server.
        public void OnPlayerLeft(PlayerDisconnectedEventArgs ev)
        {
            //Sends a debug message to the server console.
            CursedLogger.LogDebug($"Player {ev.Player.DisplayNickname} has disconnected from the server");
        }
    }
}
