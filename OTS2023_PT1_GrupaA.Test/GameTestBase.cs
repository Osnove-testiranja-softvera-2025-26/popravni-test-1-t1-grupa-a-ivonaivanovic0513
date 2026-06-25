using NUnit.Framework;
using OTS2026_PT1_GrupaA.Models;

namespace OTS2026_PT1_GrupaA.Test
{
    public class GameTestBase
    {
        [Test]
        public void ValidatePosition_PlayerInPondWithoutBoat_ShouldBeInvalid()
        {
            var game = new Game(new Position(12, 10), new Position(5, 5));
            game.Player.HasBoat = false;
            Assert.False(game.ValidatePosition(new Position(20, 1)));
        }
    }
}