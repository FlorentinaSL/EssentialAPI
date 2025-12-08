using System;
using LabApi.Features.Console;

namespace EssentialAPI.API.Features.CustomLog;

/// <summary>
/// Custom Log
/// </summary>
public static class CustomLogUtility
{
    /// <summary>
    /// Here you can send a custom log with your desired color.
    /// </summary>
    public static void SendCustomLog(string message, ConsoleColor color)
    {
        Logger.Raw(message, color);
    }
    /// <summary>
    /// In this method, you can send an Error log.
    /// </summary>
    public static void SendError(string message)
    {
        Logger.Raw("[Error - Log]: " + message, ConsoleColor.Red);
    }
    /// <summary>
    /// Send a SUCCESS log of your message.
    /// </summary>
    public static void SendSuccess(string message)
    {
        Logger.Raw("[Success - Log]: " + message, ConsoleColor.Green);
    }
}