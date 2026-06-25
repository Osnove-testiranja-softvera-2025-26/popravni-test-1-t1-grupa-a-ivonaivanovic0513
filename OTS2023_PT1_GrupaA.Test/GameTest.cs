

using NUnit.Framework;
using OTS2026_PT1_GrupaA.Exceptions;
using OTS2026_PT1_GrupaA.Models;
using static OTS2026_PT1_GrupaA.Game;

namespace OTS2026_PT1_GrupaA.Test
{
    public class GameTest : GameTestBase, IGameTest
    {
        public Position Position { get; private set; }
        public object TileType { get; private set; }

        [Test]
        public void InitGame_PlayerAndBoatInLand_ShouldInitialize(object game)
        {
            var game = new Game(new Position(12, 10), new Position(5, 5));
            Assert.NotNull(anObject: game);
        }
        [Test]
        public void InitGame_PlayerInPond_ShouldThrowException()
        {
            Assert.Throws<InvalidPlayerPositionException>((TestDelegate) =>
                new Game(new Position(20, 0), new Position(5, 5)));
        }
        [Test]
        public void CalculateScore_MoreThan12Fish_ShouldBeGood()
        {
            var game = new Game(new Position(12, 10), new Position(5, 5));
            game.Player.FishCount = 13;
            Assert.AreEqual(expected: Score.Good, actual: game.CalculateScore());
        }
        [Test]
        public void ResolvePlayerPosition_OnBaitTile_ShouldCollectBait()
        {
            var game = new Game(new Position(12, 10), new Position(5, 5));
            var tile = new Tile(TileType.Land, TileContent.Bait);
            game.ResolvePlayerPosition(tile);
            Assert.AreEqual(expected: 1, actual: game.Player.BaitCount);
        }
        [Test]
        public void CalculateScore_LessThen5Fish_ShouldBeBad()


        {
            var game = new Game(new Position(12, 10), new Position(5, 5));
            game.Player.FishCount = 4;
            Assert.AreEqual(Score.Bad, game.CalculateScore());
            return  ;
        }
    }
}
