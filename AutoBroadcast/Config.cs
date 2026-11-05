## Use manuel api if second row crashes
using Exiled.API.Interfaces;
using System.ComponentModel;

namespace AutoBroadcast
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        [Description("Enable or disable welcome broadcast on player join.")]
        public bool EnableWelcomeBroadcast { get; set; } = true;

        [Description("Duration of the broadcast message in seconds.")]
        public ushort BroadcastDuration { get; set; } = 7;

        [Description("Text displayed to the player.")]
        public string WelcomeMessage { get; set; } = "<color=red>Welcome to the SCP:SL Server!</color> Press ~ for console.";
    }
}
