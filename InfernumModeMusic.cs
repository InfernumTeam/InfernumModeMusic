using System;
using System.Collections.Generic;
using System.Reflection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace InfernumModeMusic
{
    public class InfernumModeMusic : Mod
    {
        internal static Mod Infernum;

        internal static Mod Calamity;

        internal static Mod CalamityMusic;

        internal static Mod MusicDisplay;

        public static bool InfernumActive
        {
            get
            {
                if (Infernum != null)
                    return (bool)Infernum.Call("GetInfernumActive");
                return false;
            }
        }

        public static bool BossRushActive
        {
            get
            {
                if (Calamity != null)
                    return (bool)Calamity.Call("GetDifficultyActive", "bossrush");
                return false;
            }
        }

        public static bool CanPlayMusic(int npcID)
        {
            bool result = !BossRushActive;
            if (Infernum != null && InfernumActive)
                result &= (bool)Infernum.Call("CanPlayMusicForNPC", npcID);
            else
                result &= NPC.AnyNPCs(npcID);
            return result;
        }


        public override void Load()
        {
            Infernum = null;
            ModLoader.TryGetMod("InfernumMode", out Infernum);
            Calamity = null;
            ModLoader.TryGetMod("CalamityMod", out Calamity);
            CalamityMusic = null;
            ModLoader.TryGetMod("CalamityModMusic", out CalamityMusic);
		}

		public override void PostSetupContent()
		{
			MusicDisplay = null;
			if (ModLoader.TryGetMod("MusicDisplay", out MusicDisplay))
				MusicDisplayModCalls();
		}

		public override object Call(params object[] args)
        {
            if (args is null || args.Length <= 0)
                return new ArgumentException(Language.GetTextValue("Mods.InfernumModeMusic.Errors.1"));
            if (args[0] is not string)
                return new ArgumentException(Language.GetTextValue("Mods.InfernumModeMusic.Errors.2"));

            if (typeof(InfernumMusicConfig).GetProperty(args[0].ToString(), BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public) is PropertyInfo ThemeOverride && ThemeOverride != null)
                return ThemeOverride.GetValue(InfernumMusicConfig.Instance);

            return null;
        }

        private void MusicDisplayModCalls()
        {
			void AddMusic(string path, string name)
			{
				LocalizedText author = Language.GetText("Mods.InfernumModeMusic.MusicDisplay." + name + ".Author");
				LocalizedText displayName = Language.GetText("Mods.InfernumModeMusic.MusicDisplay." + name + ".DisplayName");
				MusicDisplay.Call("AddMusic", (short)MusicLoader.GetMusicSlot(this, path), displayName, author, DisplayName);
			}

            AddMusic("Sounds/Music/AdultEidolonWyrm", "AdultEidolonWyrm");
			AddMusic("Sounds/Music/BrainOfCthulhu", "BrainOfCthulhu");
			AddMusic("Sounds/Music/Calamitas", "Calamitas");
			AddMusic("Sounds/Music/LunaticCultist", "LunaticCultist");
			AddMusic("Sounds/Music/DukeFishron", "DukeFishron");
			AddMusic("Sounds/Music/EaterOfWorlds", "EaterOfWorlds");
			AddMusic("Sounds/Music/EmpressOfLight", "EmpressOfLight");
			AddMusic("Sounds/Music/EyeOfCthulhu", "EyeOfCthulhu");
			AddMusic("Sounds/Music/Golem", "Golem");
			AddMusic("Sounds/Music/KingSlime", "KingSlime");
			AddMusic("Sounds/Music/MechBosses", "MechBosses");
			AddMusic("Sounds/Music/Minibosses", "Minibosses");
			AddMusic("Sounds/Music/MoonLord", "MoonLord");
			AddMusic("Sounds/Music/Plantera", "Plantera");
			AddMusic("Sounds/Music/QueenBee", "QueenBee");
			AddMusic("Sounds/Music/QueenSlime", "QueenSlime");
			AddMusic("Sounds/Music/Skeletron", "Skeletron");
			AddMusic("Sounds/Music/WallOfFlesh", "WallOfFlesh");
			AddMusic("Sounds/Music/Draedon", "Draedon");
			AddMusic("Sounds/Music/ExoMechBosses", "ExoMechBosses");
			AddMusic("Sounds/Music/ZenithFabrications", "ZenithFabrications");
			AddMusic("Sounds/Music/TitleScreen", "TitleScreen");
			AddMusic("Sounds/Music/StormBeforeDawn", "StormBeforeDawn");
		}
	}
}