using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOPro {
    class BasicSolver {
        /// <summary>
        /// Gets the best solution to the challenge.
        /// </summary>
        /// <returns>List of positions to click to win.</returns>
        public static List<int> GetSolution(Grid grid,
            Action<int, int> chaseAction = null, 
            Action<IEnumerable<int>, int, int> genAction = null) {
            var combos = GetAllTopPermutations(grid);

            // Clear the list.
            foreach (var combo in combos) {
                Grid comboGrid = generateNewGrid(grid, combo, genAction);

                ChaseAll(comboGrid, chaseAction);

                if (comboGrid.CheckEmpty()) {
                    return combo.ToList();
                }
            }

            return null;
        }

        #region Solution Operations
        /// <summary>
        /// Chases a row.
        /// </summary>
        /// <param name="row">The row below to chase (0 based index, uses the row below desired one).</param>
        public static void ChaseRow(Grid grid, int row,
            Action<int, int> lightAction = null) {
            if (row <= 0 || row >= grid.Width) return;

            for (int x = 0; x < grid.Width; x++)
                if (grid.InternalGrid[x, row - 1]) {
                    // Record click here at [x, row]
                    if (lightAction != null)
                        lightAction.Invoke(x, row);

                    grid.ToggleAll(x, row);
                }
        }

        /// <summary>
        /// Chases the entire grid.
        /// </summary>
        public static void ChaseAll(Grid grid,
            Action<int, int> lightAction = null) {
            for (int row = 0; row < grid.Height; row++) {
                ChaseRow(grid, row, lightAction);
            }
        }

        /// <summary>
        /// Generates a new grid from top permutations and bottom values.
        /// </summary>
        /// <param name="topPerm">The top permutation to check.</param>
        /// <returns>New grid.</returns>
        private static Grid generateNewGrid(Grid grid,
            IEnumerable<int> topPerm, 
            Action<IEnumerable<int>, int, int> lightAction = null) {
            var newGrid = new Grid(new bool[grid.Width, grid.Height]);

            for (int x = 0; x < grid.Width; x++) {
                newGrid.InternalGrid[x, grid.Height - 1] =
                    grid.InternalGrid[x, grid.Height - 1];
            }

            foreach (var index in topPerm) {
                // After making a temporary grid, record a click here.
                if (lightAction != null)
                    lightAction.Invoke(topPerm, index, 0);
                newGrid.ToggleAll(index, 0);
            }

            return newGrid;
        }

        /// <summary>
        /// Checks if the challenge requires a second chase.
        /// </summary>
        /// <returns>Requires second chase.</returns>
        public static bool RequiresSecondChase(Grid grid) {
            ChaseAll(grid);

            return !grid.CheckEmpty();
        }
        #endregion

        #region Permutations / Generation
        public static IEnumerable<IEnumerable<int>> GetAllTopPermutations(Grid grid) {
            List<int> cols = new List<int>();
            for (int i = 0; i < grid.Width; i++)
                cols.Add(i);

            var combos = getPermutations(cols, 1);

            for (int i = 2; i <= cols.Count; i++) {
                combos = combos.Concat(getPermutations(cols, i));
            }

            return combos;
        }

        private static IEnumerable<IEnumerable<T>> getPermutations<T>(IEnumerable<T> list, int length) {
            if (length == 1) return list.Select(t => new T[] { t });
            return getPermutations(list, length - 1)
                .SelectMany(t => list.Where(o => !t.Contains(o)),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }
        #endregion
    }
}
