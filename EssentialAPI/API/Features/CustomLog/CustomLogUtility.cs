using System;
using LabApi.Features.Console;

namespace EssentialAPI.API.Features.CustomLog;

/// <summary>
/// Sends a custom message with color.
/// </summary>
public static class CustomLogUtility
{
    public static void SendCustomLog(string message, ConsoleColor color)
    {
        Logger.Raw(message, color);
    }
    public static void SendError(string message)
    {
        Logger.Raw("[Error - Log]: " + message, ConsoleColor.Red);
    }
    public static void SendSuccess(string message)
    {
        Logger.Raw("[Success - Log]: " + message, ConsoleColor.Green);
    }
}