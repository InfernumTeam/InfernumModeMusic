using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace InfernumModeMusic.MusicOverrides
{
    public class MechBossMusicHandler : ModSceneEffect
    {
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Sounds/Music/MechBosses");

        public override bool IsSceneEffectActive(Player player) =>
            ((InfernumModeMusic.CanPlayMusic(NPCID.Spazmatism) || InfernumModeMusic.CanPlayMusic(NPCID.Retinazer)) && InfernumMusicConfig.Instance.OverrideTwinsTheme) ||
            (InfernumModeMusic.CanPlayMusic(NPCID.SkeletronPrime) && InfernumMusicConfig.Instance.OverrideSkeletronPrimeTheme) ||
            (InfernumModeMusic.CanPlayMusic(NPCID.TheDestroyer) && InfernumMusicConfig.Instance.OverrideDestroyerTheme);

        public override SceneEffectPriority Priority => (SceneEffectPriority)10;
    }
}
