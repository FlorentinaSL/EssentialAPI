namespace EssentialAPI.API.Features.Timing;

public static class TimingUtility
{
    public static void SetInterval(float intervalSeconds)
    {
        MEC.Timing.WaitForSeconds(intervalSeconds);
    }
}   