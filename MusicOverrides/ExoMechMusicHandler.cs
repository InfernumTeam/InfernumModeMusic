using Terraria;
using Terraria.ModLoader;

namespace InfernumModeMusic.MusicOverrides
{
    public class ExoMechMusicHandler : ModSceneEffect
    {
        public override int Music
        {
            get
            {
                if (InfernumModeMusic.Infernum != null && DraedonThemeTimer > 0)
                {
                    DraedonThemeTimer++;
                    if (DraedonThemeTimer >= 5122f)
                        DraedonThemeTimer = 0f;
                    else
                        return InfernumMusicConfig.Instance.PlayTheirFabricator ? MusicLoader.GetMusicSlot(Mod, "Sounds/Music/Draedon") :
                            MusicLoader.GetMusicSlot(InfernumModeMusic.Calamity, "Sounds/Music/DraedonExoSelect");
                }

                if (!SkyActive)
                    return MusicLoader.GetMusicSlot(InfernumModeMusic.Calamity, "Sounds/Music/DraedonExoSelect");

                return SecondThemeShouldPlay ? MusicLoader.GetMusicSlot(Mod, "Sounds/Music/ZenithFabrications") :
                    (InfernumMusicConfig.Instance.PlayCatastrophicFabrications ? MusicLoader.GetMusicSlot(Mod, "Sounds/Music/ExoMechBosses") :
                    MusicLoader.GetMusicSlot(InfernumModeMusic.CalamityMusic, "Sounds/Music/ExoMechs"));
            }
        }

        public static float DraedonThemeTimer
        {
            get => (float)InfernumModeMusic.Infernum.Code.GetType("InfernumMode.InfernumMode").GetProperty("DraedonThemeTimer").GetValue(null);
            set => InfernumModeMusic.Infernum.Code.GetType("InfernumMode.InfernumMode").GetProperty("DraedonThemeTimer").SetValue(null, value);
        }

        public static bool SecondThemeShouldPlay
        {
            get
            {
                if (!InfernumMusicConfig.Instance.PlayZenithFabrications)
                    return false;
                if (InfernumModeMusic.Infernum == null || !InfernumModeMusic.InfernumActive)
                    return false;

                var property = InfernumModeMusic.Infernum.Code.GetType("InfernumMode.Content.BehaviorOverrides.BossAIs.Draedon.ExoMechManagement").GetProperty("SecondThemeShouldPlay");
                if (property != null)
                    return (bool)property.GetValue(null);
                else
                    return false;
            }
        }

        public static bool SkyActive => (bool)InfernumModeMusic.Calamity.Code.GetType("CalamityMod.Skies.ExoMechsSky").GetProperty("CanSkyBeActive").GetValue(null);

        public override bool IsSceneEffectActive(Player player) => InfernumModeMusic.Calamity != null &&
            (InfernumModeMusic.CanPlayMusic(InfernumModeMusic.Calamity.Find<ModNPC>("Draedon").Type) || SkyActive) &&
            !(bool)InfernumModeMusic.Calamity.Code.GetType("CalamityMod.Events.BossRushEvent").GetField("BossRushActive").GetValue(null) &&
            (InfernumMusicConfig.Instance.PlayCatastrophicFabrications || InfernumMusicConfig.Instance.PlayZenithFabrications || InfernumMusicConfig.Instance.PlayTheirFabricator);

        public override SceneEffectPriority Priority => (SceneEffectPriority)10;
        public override float GetWeight(Player player) => 0.6f;
    }
}
