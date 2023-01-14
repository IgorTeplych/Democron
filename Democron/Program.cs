using Democron;

static class Proggram
{
    public static void Main()
    {
        int[][] vect = new int[6][];
        vect[0] = new int[] { };
        vect[1] = new int[] { };
        vect[2] = new int[] { 3 };
        vect[3] = new int[] { 1 };
        vect[4] = new int[] { 0, 1 };
        vect[5] = new int[] { 0, 2 };

        int[][] vect2 = new int[8][];
        vect2[0] = new int[] { 1 };
        vect2[1] = new int[] { 4 };
        vect2[2] = new int[] { 3 };
        vect2[3] = new int[] { 0, 1, 4, 5 };
        vect2[4] = new int[] { 6 };
        vect2[5] = new int[] { 4, 7 };
        vect2[6] = new int[] { 7 };
        vect2[7] = new int[] { };

        Graf graf = new Graf();
        graf.TopologicalSortByDemocron(vect2);
    }

}