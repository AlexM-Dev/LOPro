using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOPro {
    class StepTracker {
        public readonly Grid InternalGrid;
        public readonly int[,] StepGrid;

        public StepTracker(Grid grid) {
            this.InternalGrid = grid;

            this.StepGrid = new int[grid.Width, grid.Height];
            // We need 2 actions.
            // The chase action to record clicks.
            // The gen action to record clicks on a temp one, 
            // then return the one which succeeds.
        }


        private void recordChase(int x, int y) {
            StepGrid[x, y]++;
        }

        private IEnumerable<int> currentPerm;

        private void recordPerm(IEnumerable<int> perm, int x, int y) {
            if (currentPerm == null || !currentPerm.SequenceEqual(perm)) {
                currentPerm = perm;

                // Clear the step grid because we had it recorded.
                for (int x2 = 0; x2 < InternalGrid.Width; x2++) {
                    StepGrid[x2, InternalGrid.Height - 1] = 0;
                }
            }

            StepGrid[x, y]++;
        }

        public List<int> GetSolution() {
            var sol = BasicSolver.GetSolution(InternalGrid, 
                recordChase, recordPerm);

            return sol;
        }

        public bool RequiresSecondChase() {
            BasicSolver.ChaseAll(InternalGrid, recordChase);

            return !InternalGrid.CheckEmpty();
        }

        public bool[,] ConvertToGrid() {
            bool[,] newGrid = new bool[InternalGrid.Width, InternalGrid.Height];

            for (int x = 0; x < InternalGrid.Width; x++) {
                for (int y = 0; y < InternalGrid.Height; y++) {
                    newGrid[x, y] = (StepGrid[x, y] % 2) == 1;
                }
            }

            return newGrid;
        }

        public void Reset() {
            currentPerm = null;

            for (int x = 0; x < InternalGrid.Width; x++) {
                for (int y = 0; y < InternalGrid.Height; y++) {
                    StepGrid[x, y] = 0;
                }
            }
        }
    }
}
