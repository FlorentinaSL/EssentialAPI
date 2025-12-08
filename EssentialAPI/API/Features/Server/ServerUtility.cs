using LabApi.Features.Console;

namespace EssentialAPI.API.Features.Server;

public static class ServerUtility
{
    public static void RestartServer(ushort delaySeconds)
    {
        Logger.Warn("[WARN - Log]: Server will restart in " + delaySeconds + " seconds.");
        LabApi.Features.Wrappers.Server.Restart(delaySeconds);
    }
    public static void ShutdownServer(ushort delaySeconds)
    {
        Logger.Warn("[WARN - Log]: Server will shutdown in " + delaySeconds + " seconds.");
        LabApi.Features.Wrappers.Server.Shutdown(delaySeconds);
    }
}