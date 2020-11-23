using System;

namespace UtopianTree
{
    class ProgramUtopianTree
    {
        static void Main()
        {
            var numberOfCases = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < numberOfCases; i++)
            {
                var numberOfCycles = Convert.ToInt32(Console.ReadLine());
                var treeHeight = GrowTree.SimulateGrow(numberOfCycles);
                Console.WriteLine(treeHeight);
            }
        }
    }
}