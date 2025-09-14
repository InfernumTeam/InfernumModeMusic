using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace InfernumModeMusic.MusicOverrides
{
    public class BrainMusicHandler : ModSceneEffect
    {
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Sounds/Music/BrainOfCthulhu");

        public override bool IsSceneEffectActive(Player player) => InfernumModeMusic.CanPlayMusic(NPCID.BrainofCthulhu) && InfernumMusicConfig.Instance.OverrideBrainOfCthulhuTheme;

        public override SceneEffectPriority Priority => (SceneEffectPriority)9;
    }
}
