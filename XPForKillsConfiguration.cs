using Rocket.API;
using System.Xml.Serialization;

namespace PhaserArray.XPForKills
{
	public class XPForKillsConfiguration : IRocketPluginConfiguration
	{

		public bool CheckSteamGroupTeamkill;
		public bool DisableMessages;
		public string NoTeamkillPenaltyPermission;
		[XmlArrayItem("PermissionGroup")]
		public string[] TeamPermissionGroups;

		public int KillXP;
		public float HeadModifier;
		public float TorsoModifier;
		public float ArmModifier;
		public float LegModifier;

		public int TeamkillXP;
		public int SuicideXP;
		public int DeathXP;
        public int BreathXP;
        public int ZombieXP;
        public int FireXP;

		public void LoadDefaults()
		{
			CheckSteamGroupTeamkill = true;
			DisableMessages = true;
			NoTeamkillPenaltyPermission = "XPForKills.NoTeamkillPenalty";
			TeamPermissionGroups = new string[]
			{
				"Axis",
				"Allies"
			};

			KillXP = 26;
			HeadModifier = 1.5f;
			TorsoModifier = 1.0f;
			ArmModifier = 0.75f;
			LegModifier = 0.5f;

			TeamkillXP = -300;
			SuicideXP = -10;
			DeathXP = -10;
			BreathXP = -10;
            ZombieXP = -50;
            FireXP = -10;
		}
	}
}
