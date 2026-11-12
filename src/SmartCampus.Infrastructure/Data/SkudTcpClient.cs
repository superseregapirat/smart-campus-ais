namespace SmartCampus.Infrastructure.ScrudIntegration;

public class SkudTcpClient
{
    public Task<bool> SendUnlockCommandAsync(string turnstileId)
    {
        return Task.FromResult(true);
    }
}
