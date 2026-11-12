using SmartCampus.Core.Entities;
using SmartCampus.Core.Interfaces;

namespace SmartCampus.Core.Services;

public class PassGenerator : ISecurityService
{
    public Task<SmartPass> GenerateDynamicPassAsync(Guid userId)
    {
        var pass = new SmartPass
        {
            Id = Guid.NewGuid(),
            UserId = userId,
            DynamicToken = Convert.ToBase64String(Guid.NewGuid().ToByteArray()),
            CreatedAt = DateTime.UtcNow,
            ExpiresAt = DateTime.UtcNow.AddSeconds(60)
        };
        return Task.FromResult(pass);
    }

    public Task<bool> ValidateTokenAsync(string token, string checkpointId)
    {
        return Task.FromResult(!string.IsNullOrWhiteSpace(token));
    }

    public Task RevokeAllUserPassesAsync(Guid userId)
    {
        return Task.CompletedTask;
    }
}
