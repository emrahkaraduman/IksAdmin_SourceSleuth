using CounterStrikeSharp.API.Core;

namespace IksAdmin_SourceSleuth;

public class PluginConfig : BasePluginConfig
{
    public bool BanNewPlayerAccount { get; set; } = false;
    public bool NotifyAllAboutBan { get; set; } = true;
    public List<string> WhitelistSteamIDs { get; set; } = new List<string>();
    public List<string> WhitelistIPAddresses { get; set; } = new List<string>();
}