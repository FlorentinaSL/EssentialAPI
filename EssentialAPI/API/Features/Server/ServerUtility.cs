using LabApi.Features.Console;

namespace EssentialAPI.API.Features.Server;

/// <summary>
/// Some server utilities.
/// </summary>
public static class ServerUtility
{
    /// <summary>
    /// Here you can restart the server with a delay in seconds.
    /// </summary>
    public static void RestartServer(ushort delaySeconds)
    {
        Logger.Warn("[WARN - Log]: Server will restart in " + delaySeconds + " seconds.");
        LabApi.Features.Wrappers.Server.Restart(delaySeconds);
    }
    /// <summary>
    /// Here you can shutdown the server with a delay in seconds.
    /// </summary>
    public static void ShutdownServer(ushort delaySeconds)
    {
        Logger.Warn("[WARN - Log]: Server will shutdown in " + delaySeconds + " seconds.");
        LabApi.Features.Wrappers.Server.Shutdown(delaySeconds);
    }
}