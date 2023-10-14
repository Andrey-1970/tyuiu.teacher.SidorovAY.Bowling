namespace tyuiu.teacher.SidorovAY.Bowling.Tests
{
    [TestClass]
    public class BowlingTests
    {
        [TestMethod]
        public void CreateGameValid()
        {
            Game game = new Game();
            Assert.IsNotNull(game);

            game.AddThrow(10);
            Assert.AreEqual(10, game.Score);
            Assert.AreEqual(1, game.FrameCount); 

            game.AddThrow(5);
            Assert.AreEqual(20, game.Score);
            Assert.AreEqual(1, game.FrameCount);

            game.AddThrow(4);
            Assert.AreEqual(28, game.Score);
            Assert.AreEqual(2, game.FrameCount);
        }
    }
}