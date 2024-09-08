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
            Assert.AreEqual<int>(3, wordFinder.Find(new List<string> { "chill", "cold", "wind", "snow" }).Count());
        }

        [TestMethod]
        public void NotExistingWords()
        {
            List<string> matrix = new List<string>{ 
                "abcdcchildrtrttchildvcte",
                "awinchirtrtchlcvctestwin",
                "abcdctestrtrttestcvctest",
                "abcdctestrtrttestcvctest",
                "abcdctestrtrttestcvctest",
                "abcdctestrtrttestcvctest",
                "abcdctestrtrttestcvctest",
                "abcdctestrtrttestcvctest",
                "abcdctestrtrttestcvctest",
                "abcdctestrtrttestcvctest",
                "abcdctestrtrttestcvctest",
                "abcdctestrtrttestcvctest",
                "abcdctestrtrttestcvctest",
                "abcdctestrtrttestcvctest",
                "abcdctestrtrttestcvctest",
                "abcdctestrtrttestcvctest",
                "abcdctestrtrttestcvctest",
                "abcdctestrtrttestcvctest",
                "abcdctestrtrttestcvctest",
                "abcdctestrtrttestcvctest",
                "abcdctestrtrttestcvctest",
                "abcdctestrtrttestcvctest",
                "abcdctestrtrttestcvctest",
                "abcdctestrtrttestcvctest",
            };
            var wordFinder = new WordFinder.WordFinder(matrix);
            Assert.AreEqual<int>(0, wordFinder.Find(new List<string> { "winner", "childrend", "lazy", "counter"}).Count());  
        }

        [TestMethod]
        public void OnlyReturn10MostRepeatedWord()
        {
            List<string> matrix = new List<string>{
                "abcdcchildrtrttchildvcte",
                "awinchirtrtchlcvctestwin",
                "abcdcothertrttestcvctest",
                "abcdcothertrttestcvctest",
                "abcdcwordetrttestcvctest",
                "abcdchardrtrttestcvctest",
                "abcdcthreetrttestcvctest",
                "abcdcthreertrttestcvctes",
                "abcdctfivedtrttestcvctes",
                "abcdctfivessrttestcvctes",
                "abcdctsevenffttestcvctes",
                "abcdctseventrrtestcvctes",
                "abcdcteigthtrttestcvctes",
                "abcdcteightrttrestcvctes",
                "abcdctninedrtterstcvctes",
                "abcdctninetrtetestcvctes",
                "abcdceleventettestcvctes",
                "abcdcteleventtestcvctest",
                "abcdctwelverttestcvctest",
                "abcdctwelvedttestcvctest",
                "abcdcthirteentestcvctest",
                "abcdcthirteentestcvctest",
                "abcdcfourteentestcvctest",
                "abcdcfourteentestcvctest",
            };
            var wordFinder = new WordFinder.WordFinder(matrix);
            var findingWords = wordFinder.Find(new List<string> { "child", "win", "other", "word", "three", "five", "seven", "eigth", "nine", "eleven", "twelve", "thirteen", "fourteen", "hard" });
            Assert.AreEqual<int>(10, findingWords.Count());
            Assert.IsFalse(findingWords.Contains("word"));
            Assert.IsFalse(findingWords.Contains("win"));
            Assert.IsFalse(findingWords.Contains("hard"));
            

        }

    }
}