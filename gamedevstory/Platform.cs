using System;

namespace GameDevClone
{
	public abstract class Platform
	{
        public Owner LicenseOwner;
        public int LicensingCost;
        public bool IsLicensed;
        public DateTime ReleaseDate;
        public int UnitsSold;
        public float MarketShare;
        public int TimesUsed;
        public float DifficultyMultiplier;
    }
}
