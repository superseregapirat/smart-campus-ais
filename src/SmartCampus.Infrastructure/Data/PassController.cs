using SmartCampus.Core.Entities;
using SmartCampus.Core.Interfaces;

namespace SmartCampus.WebAPI.Controllers;

public class PassController
{
    private readonly ISecurityService _securityService;

    public PassController(ISecurityService securityService)
    {
        _securityService = securityService;
    }

    public async Task<SmartPass> GetNewPass(Guid userId)
    {
        return await _securityService.GenerateDynamicPassAsync(userId);
    }
}
