using LabApi.Features.Wrappers;
using UnityEngine;

namespace EssentialAPI.API.Players.Teleport
{
    public static class TeleportUtility
    {
        /// <summary>
        /// There are two utilities, one: Teleport a Player to a position, two: Teleport a Player to another player.
        /// </summary>
        public static void TeleportPlayertoPosition(Player player, Vector3 position)
        {
            player.Position = position;
        }
        public static void TeleportToPlayer(Player player, Player target)
        {
            player.Position = target.Position;
        }
    }
}