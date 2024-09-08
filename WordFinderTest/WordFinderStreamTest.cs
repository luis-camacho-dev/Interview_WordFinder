namespace WordFinderTest
{
    [TestClass]
    public class WordFinderStreamTest
    {
        [TestMethod]
        public void BasicScenarioTest()
        {
            List<string> matrix = new List<string>();
            matrix.Add("abcdc");
            matrix.Add("fgwio");
            matrix.Add("chill");
            matrix.Add("pqnsd");
            matrix.Add("uvdxy");
            var wordFinder = new WordFinder.WordFinder(matrix);
            Assert.AreEqual<int>(3, wordFinder.Find(new List<string> { "chill", "cold", "wind" }).Count());
        }
    }
}