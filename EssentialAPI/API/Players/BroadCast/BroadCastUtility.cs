using LabApi.Features.Wrappers;

namespace EssentialAPI.API.Players.BroadCast;

public static class BroadCastUtility
{
    /// <summary>
    /// Here it sends a popup message to a player for a specific duration in seconds.
    /// </summary>
    public static void Popup(Player player, string message, ushort duration)
    {
        player.SendBroadcast(message, duration, Broadcast.BroadcastFlags.Normal);
    }
    
}