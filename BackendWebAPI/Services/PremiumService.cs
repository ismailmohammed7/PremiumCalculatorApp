using BackendWebAPI.Models;

namespace BackendWebAPI.Services
{
    public class PremiumService : IPremiumService
    {
        public double CalculatePremium(PremiumDetail premiumDetail)
        {
            double premium;

            double occupationRatingFactor = 0.00d;

            switch (premiumDetail.Occupation)
            {
                case "Doctor":
                    occupationRatingFactor = OccupationRating.PROFESSIONAL;
                    break;

                case "Cleaner":
                case "Florist":
                    occupationRatingFactor = OccupationRating.LIGHTMANUAL;
                    break;

                case "Farmer":
                case "Mechanic":
                    occupationRatingFactor = OccupationRating.HEAVYMANUAL;
                    break;

                case "Author":
                    occupationRatingFactor = OccupationRating.WHITECOLLAR;
                    break;

                default:
                    occupationRatingFactor = OccupationRating.DEFAULT;
                    break;
            }

            //calculate the premium from the given formula and return
            premium = (premiumDetail.SumInsured * occupationRatingFactor * premiumDetail.Age) / (1000 * 12);

            return Math.Round(premium, 3);
        }
    }
}
