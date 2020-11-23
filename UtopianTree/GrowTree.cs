namespace UtopianTree
{
    public static class GrowTree
    {
        public static int SimulateGrow(int numberOfCycles)
        {
            
            var treeHeight = 1;
            for (var seasonPeriod = 0; seasonPeriod < numberOfCycles; seasonPeriod++)
            {
                if (seasonPeriod%2==0)
                {
                    treeHeight*=2;
                }
                else
                {
                    treeHeight++;
                }
            }
            return treeHeight;
        }
    }
}