using LabApi.Features.Wrappers;

namespace EssentialAPI.API.Players.Inventory;

public static class ItemUtility
{
    public static void GiveItem(Player player, ItemType type, int ammount)
    {
        for (ammount -= 1; ammount > 0; ammount--)
        {
            player.AddItem(type);
        }
    }

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
    public static void ClearInventory(Player player)
    {
        player.ClearInventory();
    }
}