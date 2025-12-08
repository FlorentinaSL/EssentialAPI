using System;
using EssentialAPI.API.Features.CustomLog;
using EssentialAPI.API.Features.Server;
using EssentialAPI.API.Features.Timing;
using EssentialAPI.API.Players.BroadCast;
using EssentialAPI.API.Players.Inventory;
using EssentialAPI.API.Players.Teleport;
using EssentialAPI.API.SpawnSchematic;
using LabApi.Events.Arguments.PlayerEvents;
using LabApi.Loader.Features.Plugins;
using UnityEngine;

namespace EssentialAPI.ExamplePlugin;

/// <summary>
/// You can also do Exiled if you want to.
/// </summary>
public class Plugin : Plugin<Config>
{
    /// <summary>
    /// metadata for your plugin.
    /// </summary>
    public override string Name { get; } = "ExamplePlugin";
    public override string Description { get; } = "Example plugin for EssentialAPI.";
    public override string Author { get; } = "Florentina <3";
    public override Version Version { get; } = new Version(1,0,0);
    public override Version RequiredApiVersion { get; } = new Version(1,1,4);
    
    /// <summary>
    /// Your registration code goes here.
    /// </summary>
    public override void Enable()
    {
        LabApi.Events.Handlers.PlayerEvents.Spawned += Functions;
    }

    public override void Disable()
    {
        LabApi.Events.Handlers.PlayerEvents.Spawned -= Functions;
    }
    

    /// <summary>
    /// Let's test here some of the functions from the API!
    /// </summary>
    private void Functions(PlayerSpawnedEventArgs ev)
    {
        //Player functions (DO NOT TRY IT ONLY TO SEE HOW TO USE IT):
        BroadCastUtility.Popup(ev.Player, "You just spawned!", 5);
        ItemUtility.ClearInventory(ev.Player);
        ItemUtility.GiveItem(ev.Player, ItemType.Adrenaline, 2);
        ItemUtility.ReplaceItem(ev.Player, ItemType.Adrenaline, ItemType.Ammo9x19);
        TeleportUtility.TeleportPlayertoPosition(ev.Player, Vector3.zero);
        TeleportUtility.TeleportToPlayer(ev.Player, null);
        //API Features:
        CustomLogUtility.SendCustomLog("Hi!", ConsoleColor.Cyan);
        CustomLogUtility.SendError("ERROR!!");
        CustomLogUtility.SendSuccess("SUCCESS!!");
        ServerUtility.RestartServer(1);
        ServerUtility.ShutdownServer(1);
        SpawnSchematicUtility.LoadSchematic("ExampleSchematic", 0,0,0);
        TimingUtility.SetInterval(1);
    }
}