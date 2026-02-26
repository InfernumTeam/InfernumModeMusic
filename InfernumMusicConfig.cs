using System.ComponentModel;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace InfernumModeMusic
{
    [BackgroundColor(96, 30, 53, 216)]
    public class InfernumMusicConfig : ModConfig
    {
        public static InfernumMusicConfig Instance => ModContent.GetInstance<InfernumMusicConfig>();

        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Header("$Mods.InfernumModeMusic.Configs.InfernumMusicConfig.Headers.MusicOverrides")]

        [BackgroundColor(0, 125, 255, 0)]
        [DefaultValue(true)]
        public bool OverrideKingSlimeTheme
        {
            get; set;
        }

        [BackgroundColor(224, 49, 49, 126)]
        [DefaultValue(true)]
        public bool OverrideEyeOfCthulhuTheme
        {
            get; set;
        }

        [BackgroundColor(109, 0, 255, 126)]
        [DefaultValue(true)]
        public bool OverrideEaterOfWorldsTheme
        {
            get; set;
        }

        [BackgroundColor(226, 75, 75, 126)]
        [DefaultValue(true)]
        public bool OverrideBrainOfCthulhuTheme
        {
            get; set;
        }

        [BackgroundColor(255, 255, 0, 126)]
        [DefaultValue(true)]
        public bool OverrideQueenBeeTheme
        {
            get; set;
        }

        [BackgroundColor(198, 187, 157, 126)]
        [DefaultValue(true)]
        public bool OverrideSkeletronTheme
        {
            get; set;
        }

        [BackgroundColor(178, 105, 112, 126)]
        [DefaultValue(true)]
        public bool OverrideWallOfFleshTheme
        {
            get; set;
        }

        [BackgroundColor(211, 229, 222, 126)]
        [DefaultValue(true)]
        public bool OverrideMinibossTheme
        {
            get; set;
        }

        [BackgroundColor(216, 93, 82, 126)]
        [DefaultValue(true)]
        public bool OverrideDreadnautilusTheme
        {
            get; set;
        }

        [BackgroundColor(255, 105, 180, 126)]
        [DefaultValue(true)]
        public bool OverrideQueenSlimeTheme
        {
            get; set;
        }

        [BackgroundColor(192, 192, 192, 126)]
        [DefaultValue(true)]
        public bool OverrideTwinsTheme
        {
            get; set;
        }

        [BackgroundColor(192, 192, 192, 126)]
        [DefaultValue(true)]
        public bool OverrideDestroyerTheme
        {
            get; set;
        }

        [BackgroundColor(192, 192, 192, 126)]
        [DefaultValue(true)]
        public bool OverrideSkeletronPrimeTheme
        {
            get; set;
        }

        [BackgroundColor(0, 199, 0, 126)]
        [DefaultValue(true)]
        public bool OverridePlanteraTheme
        {
            get; set;
        }

        [BackgroundColor(130, 68, 8, 126)]
        [DefaultValue(true)]
        public bool OverrideGolemTheme
        {
            get; set;
        }

        [BackgroundColor(58, 205, 120, 126)]
        [DefaultValue(true)]
        public bool OverrideDukeFishronTheme
        {
            get; set;
        }

        [BackgroundColor(225, 0, 225, 126)]
        [DefaultValue(true)]
        public bool OverrideEmpressOfLightTheme
        {
            get; set;
        }

        [BackgroundColor(0, 0, 255, 126)]
        [DefaultValue(true)]
        public bool OverrideLunaticCultistTheme
        {
            get; set;
        }

        [BackgroundColor(0, 193, 193, 126)]
        [DefaultValue(true)]
        public bool OverrideMoonLordTheme
        {
            get; set;
        }

        [BackgroundColor(255, 215, 0, 126)]
        [DefaultValue(true)]
        public bool OverrideAdultEidolonWyrmTheme
        {
            get; set;
        }

        [BackgroundColor(255, 0, 0, 126)]
        [DefaultValue(true)]
        public bool OverrideCalTheme
        {
            get; set;
        }

        [Header("$Mods.InfernumModeMusic.Configs.InfernumMusicConfig.Headers.ExoMechs")]

        [BackgroundColor(80, 89, 103, 126)]
        [DefaultValue(true)]
        public bool PlayCatastrophicFabrications
        {
            get; set;
        }

        [BackgroundColor(80, 89, 103, 126)]
        [DefaultValue(true)]
        public bool PlayZenithFabrications
        {
            get; set;
        }

        [BackgroundColor(155, 255, 255, 126)]
        [DefaultValue(true)]
        public bool PlayTheirFabricator
        {
            get; set;
        }

        [BackgroundColor(224, 127, 180, 192)]
        [DefaultValue(true)]
        public bool ToggleAllMusic
        {
            get
            {
                return
                OverrideKingSlimeTheme &&
                OverrideEyeOfCthulhuTheme &&
                OverrideEaterOfWorldsTheme &&
                OverrideBrainOfCthulhuTheme &&
                OverrideQueenBeeTheme &&
                OverrideSkeletronTheme &&
                OverrideWallOfFleshTheme &&
                OverrideMinibossTheme &&
                OverrideDreadnautilusTheme &&
                OverrideQueenSlimeTheme &&
                OverrideTwinsTheme &&
                OverrideDestroyerTheme &&
                OverrideSkeletronPrimeTheme &&
                OverridePlanteraTheme &&
                OverrideGolemTheme &&
                OverrideDukeFishronTheme &&
                OverrideEmpressOfLightTheme &&
                OverrideLunaticCultistTheme &&
                OverrideMoonLordTheme &&
                OverrideAdultEidolonWyrmTheme &&
                PlayCatastrophicFabrications &&
                PlayZenithFabrications &&
                PlayTheirFabricator &&
                OverrideCalTheme;
            }
            set
            {
                OverrideKingSlimeTheme = value;
                OverrideEyeOfCthulhuTheme = value;
                OverrideEaterOfWorldsTheme = value;
                OverrideBrainOfCthulhuTheme = value;
                OverrideQueenBeeTheme = value;
                OverrideSkeletronTheme = value;
                OverrideWallOfFleshTheme = value;
                OverrideMinibossTheme = value;
                OverrideDreadnautilusTheme = value;
                OverrideQueenSlimeTheme = value;
                OverrideTwinsTheme = value;
                OverrideDestroyerTheme = value;
                OverrideSkeletronPrimeTheme = value;
                OverridePlanteraTheme = value;
                OverrideGolemTheme = value;
                OverrideDukeFishronTheme = value;
                OverrideEmpressOfLightTheme = value;
                OverrideLunaticCultistTheme = value;
                OverrideMoonLordTheme = value;
                OverrideAdultEidolonWyrmTheme = value;
                PlayCatastrophicFabrications = value;
                PlayZenithFabrications = value;
                PlayTheirFabricator = value;
                OverrideCalTheme = value;
            }
        }

        public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref NetworkText message) => false;
    }
}
