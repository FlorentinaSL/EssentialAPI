using LabApi.Features.Wrappers;

namespace EssentialAPI.API.Players.Inventory;

public static class ItemUtility
{
    /// <summary>
    /// Utility to give items to players.
    /// </summary>
    public static void GiveItem(Player player, ItemType type, int ammount)
    {
        for (ammount -= 1; ammount > 0; ammount--)
        {
            player.AddItem(type);
        }
    }
    /// <summary>
    /// Replace an Item in a player's inventory with another item.
    /// </summary>
    public static void ReplaceItem(Player player, ItemType oldType, ItemType newItemType)
    {
        foreach (var item in player.Items)
        {
            if (item.Type == oldType)
            {
                player.RemoveItem(item);
                player.AddItem(newItemType);
            }
        }
    }
    /// <summary>
    /// Clear a player's inventory.
    /// </summary>
    public static void ClearInventory(Player player)
    {
        player.ClearInventory();
    }
}