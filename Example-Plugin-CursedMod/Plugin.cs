namespace Example_Plugin
{
    using CursedMod.Events.Handlers.Player;
    using CursedMod.Loader;
    using CursedMod.Loader.Modules;
    using CursedMod.Loader.Modules.Enums;

    public class Plugin : CursedModule
    {
        public override string ModuleName => "Example Plugin";
        public override string ModuleAuthor => "Nickname";
        public override byte LoadPriority => (byte)ModulePriority.Medium;
        public override string ModuleVersion => "1.0.0";
        public override string CursedModVersion => CursedModInformation.Version;

        public static Plugin Instance;

        public Config Config;
        public EventHandlers EventHandlers;

        public override void OnLoaded()
        {
            //Set the static variable of our plugin.
            Instance = this;
            //Get the configuration or create it if it doesn't exist.
            Config = GetConfig<Config>("config");
            EventHandlers = new EventHandlers();
            //Subscriptions to events.
            PlayerEventsHandler.Joined += EventHandlers.OnPlayerJoined;
            PlayerEventsHandler.Disconnected += EventHandlers.OnPlayerLeft;

            base.OnLoaded();
        }

        public override void OnUnloaded()
        {
            //Unsubscribes from the events.
            PlayerEventsHandler.Joined -= EventHandlers.OnPlayerJoined;
            PlayerEventsHandler.Disconnected -= EventHandlers.OnPlayerLeft;

            //Clean up our variables.
            EventHandlers = null;
            Config = null;
            Instance = null;

            base.OnUnloaded();
        }
    }
}
