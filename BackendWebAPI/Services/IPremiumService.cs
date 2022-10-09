using BackendWebAPI.Models;

namespace BackendWebAPI.Services
{
    public interface IPremiumService
    {
        double CalculatePremium(PremiumDetail premiumDetail);
    }
}
