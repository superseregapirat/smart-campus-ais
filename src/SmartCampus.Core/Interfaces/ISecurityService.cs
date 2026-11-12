using SmartCampus.Core.Entities;

namespace SmartCampus.Core.Interfaces;

public interface ISecurityService
{
    Task<SmartPass> GenerateDynamicPassAsync(Guid userId);
    Task<bool> ValidateTokenAsync(string token, string checkpointId);
    Task RevokeAllUserPassesAsync(Guid userId);
}
