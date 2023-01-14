using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Democron
{
    internal class Graf
    {
        public int?[][] TopologicalSortByDemocron(int[][] g)
        {
            int?[] countNum = new int?[g.Length];
            int?[][] level = new int?[g.Length][];

            for (int i = 0; i < countNum.Length; i++)
                countNum[i] = 0;

            for (int v = 0; v < g.Length; v++)
                for (int u = 0; u < g[v].Length; u++)
                    countNum[g[v][u]]++;

            int lvl = 0;
            while (lvl < countNum.Length)
            {
                int idx = 0;
                for (idx = 0; idx < countNum.Length; idx++)
                    if (countNum[idx] != null && countNum[idx] == 0)
                        break;

                for (int i = 0; i < g[idx].Length; i++)
                    countNum[g[idx][i]]--;
                countNum[idx] = null;

                level[lvl] = new int?[countNum.Length];
                for (int i = 0; i < countNum.Length; i++)
                    level[lvl][i] = countNum[i];

                lvl++;
            }
            return level;
        }
    }
}
