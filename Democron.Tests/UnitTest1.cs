namespace Democron.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGrafFromWebinar()
        {
            int[][] vect = new int[8][];
            vect[0] = new int[] { 1 };
            vect[1] = new int[] { 4 };
            vect[2] = new int[] { 3 };
            vect[3] = new int[] { 0, 1, 4, 5 };
            vect[4] = new int[] { 6 };
            vect[5] = new int[] { 4, 7 };
            vect[6] = new int[] { 7 };
            vect[7] = new int[] { };

            Graf graf = new Graf();
            int?[][] level = graf.TopologicalSortByDemocron(vect);

            int?[][] correct = new int?[vect.Length][];
            correct[0] = new int?[] { 1, 2, null, 0, 3, 1, 1, 2};
            correct[1] = new int?[] { 0, 1, null, null, 2, 0, 1, 2 };
            correct[2] = new int?[] { null, 0, null, null, 2, 0, 1, 2 };
            correct[3] = new int?[] { null, null, null, null, 1, 0, 1, 2 };
            correct[4] = new int?[] { null, null, null, null, 0, null, 1, 1 };
            correct[5] = new int?[] { null, null, null, null, null, null, 0, 1 };
            correct[6] = new int?[] { null, null, null, null, null, null, null, 0 };
            correct[7] = new int?[] { null, null, null, null, null, null, null, null };

            Assert.AreEqual(level.Length, correct.Length);

            for(int v = 0; v < correct.Length; v++)
            {
                for(int u = 0; u < correct.Length; u++)
                {
                    Assert.AreEqual(level[v][u], correct[v][u]);
                }
            }
        }
    }
}