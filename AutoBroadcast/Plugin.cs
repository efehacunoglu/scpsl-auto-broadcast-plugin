## You can able to use subject instead of class
using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;

namespace AutoBroadcast
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "AutoBroadcast";
        public override string Author => "Technical Support";
        public override Version Version => new Version(1, 0, 0);

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.Verified += OnPlayerVerified;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Verified -= OnPlayerVerified;
            base.OnDisabled();
        }

        private void OnPlayerVerified(VerifiedEventArgs ev)
        {
            if (Config.EnableWelcomeBroadcast)
            {
                ev.Player.Broadcast(Config.BroadcastDuration, Config.WelcomeMessage);
            }
        }
    }
}
