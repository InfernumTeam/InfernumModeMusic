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

        [DefaultValue(true)]
        public bool OverrideKingSlimeTheme
        {
            get; set;
        }

        [DefaultValue(true)]
        public bool OverrideEyeOfCthulhuTheme
        {
            get; set;
        }

        [DefaultValue(true)]
        public bool OverrideEaterOfWorldsTheme
        {
            get; set;
        }

        [DefaultValue(true)]
        public bool OverrideBrainOfCthulhuTheme
        {
            get; set;
        }

        [DefaultValue(true)]
        public bool OverrideQueenBeeTheme
        {
            get; set;
        }

        [DefaultValue(true)]
        public bool OverrideSkeletronTheme
        {
            get; set;
        }

        [DefaultValue(true)]
        public bool OverrideWallOfFleshTheme
        {
            get; set;
        }

        [DefaultValue(true)]
        public bool OverrideMinibossTheme
        {
            get; set;
        }

        [DefaultValue(true)]
        public bool OverrideDreadnautilusTheme
        {
            get; set;
        }

        [DefaultValue(true)]
        public bool OverrideQueenSlimeTheme
        {
            get; set;
        }

        [DefaultValue(true)]
        public bool OverrideTwinsTheme
        {
            get; set;
        }

        [DefaultValue(true)]
        public bool OverrideDestroyerTheme
        {
            get; set;
        }

        [DefaultValue(true)]
        public bool OverrideSkeletronPrimeTheme
        {
            get; set;
        }

        [DefaultValue(true)]
        public bool OverridePlanteraTheme
        {
            get; set;
        }

        [DefaultValue(true)]
        public bool OverrideGolemTheme
        {
            get; set;
        }

        [DefaultValue(true)]
        public bool OverrideDukeFishronTheme
        {
            get; set;
        }

        [DefaultValue(true)]
        public bool OverrideEmpressOfLightTheme
        {
            get; set;
        }

        [DefaultValue(true)]
        public bool OverrideLunaticCultistTheme
        {
            get; set;
        }

        [DefaultValue(true)]
        public bool OverrideMoonLordTheme
        {
            get; set;
        }

        [DefaultValue(true)]
        public bool OverrideAdultEidolonWyrmTheme
        {
            get; set;
        }

        [BackgroundColor(224, 127, 180, 192)]
        [DefaultValue(true)]
        public bool OverrideCalTheme
        {
            get; set;
        }

        [Header("$Mods.InfernumModeMusic.Configs.InfernumMusicConfig.Headers.ExoMechs")]
        
        [DefaultValue(true)]
        public bool PlayCatastrophicFabrications
        {
            get; set;
        }

        [DefaultValue(true)]
        public bool PlayZenithFabrications
        {
            get; set;
        }

        [DefaultValue(true)]
        public bool PlayTheirFabricator
        {
            get; set;
        }

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
