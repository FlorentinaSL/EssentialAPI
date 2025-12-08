using LabApi.Features.Wrappers;

namespace EssentialAPI.API.Players.BroadCast;

public static class BroadCastUtility
{
    public static void Popup(Player player, string message, ushort duration)
    {
        player.SendBroadcast(message, duration, Broadcast.BroadcastFlags.Normal);
    }
    
}