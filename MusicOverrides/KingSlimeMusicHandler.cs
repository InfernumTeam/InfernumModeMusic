using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace InfernumModeMusic.MusicOverrides
{
    public class KingSlimeMusicHandler : ModSceneEffect
    {
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Sounds/Music/KingSlime");

        public override bool IsSceneEffectActive(Player player) => InfernumModeMusic.CanPlayMusic(NPCID.KingSlime) && InfernumMusicConfig.Instance.OverrideKingSlimeTheme;

        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
    }
}
