namespace EssentialAPI.API.Features.Timing;

public static class TimingUtility
{
    /// <summary>
    /// Set an interval with seconds.
    /// </summary>
    public static void SetInterval(float intervalSeconds)
    {
        MEC.Timing.WaitForSeconds(intervalSeconds);
    }
}   