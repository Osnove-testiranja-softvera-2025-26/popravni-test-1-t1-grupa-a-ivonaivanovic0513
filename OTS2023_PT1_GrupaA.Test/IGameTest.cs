using OTS2026_PT1_GrupaA.Models;

namespace OTS2026_PT1_GrupaA.Test
{
    public interface IGameTest
    {
        Position Position { get; }

        void CalculateScore_MoreThan12Fish_ShouldBeGood();
        void InitGame_PlayerAndBoatInLand_ShouldInitialize();
        void InitGame_PlayerInPond_ShouldThrowException();
        void ResolvePlayerPosition_OnBaitTile_ShouldCollectBait();
    }
}