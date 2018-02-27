namespace GameDevClone.Platforms
{
	public class PC : Platform
	{
		public PC()
		{
            LicenseOwner = Owner.None;
			LicensingCost = 0;
			DifficultyMultiplier = 1.0f;
		}
	}
}
