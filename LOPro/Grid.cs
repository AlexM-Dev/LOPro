using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOPro {
    class Grid {
        #region Fields

        public readonly bool[,] InternalGrid;

        public readonly int Width;
        public readonly int Height;

        #endregion

        #region Basic Operations

        public Grid(bool[,] grid) {
            this.InternalGrid = grid;

            Width = grid.GetLength(0);
            Height = grid.GetLength(1);
        }

        public void ToggleAll(int x, int y) {
            if (x > 0) Toggle(x - 1, y);
            if (x < Width - 1) Toggle(x + 1, y);

            if (y > 0) Toggle(x, y - 1);
            if (y < Height - 1) Toggle(x, y + 1);

            Toggle(x, y);
        }

        /// <summary>
        /// Toggle a value at the specified position.
        /// </summary>
        /// <param name="x">The column position.</param>
        /// <param name="y">The row position.</param>
        public void Toggle(int x, int y) {
            InternalGrid[x, y] = !InternalGrid[x, y];
        }

        #endregion

        #region Solution Operations

        /// <summary>
        /// Chases a row.
        /// </summary>
        /// <param name="row">The row below to chase (0 based index, uses the row below desired one).</param>
        public void ChaseRow(int row) {
            if (row <= 0 || row >= Width) return;

            for (int x = 0; x < Width; x++)
                if (InternalGrid[x, row - 1]) ToggleAll(x, row);
        }

        /// <summary>
        /// Chases the entire grid.
        /// </summary>
        public void ChaseAll() {
            for (int row = 0; row < Height; row++) {
                ChaseRow(row);
            }
        }

        /// <summary>
        /// Checks that no lights are on.
        /// </summary>
        /// <returns>Grid is empty or not.</returns>
        public bool CheckEmpty() {
            for (int x = 0; x < Width; x++) {
                for (int y = 0; y < Height; y++) {
                    if (InternalGrid[x, y])
                        return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Generates a new grid from top permutations and bottom values.
        /// </summary>
        /// <param name="topPerm">The top permutation to check.</param>
        /// <returns>New grid.</returns>
        public Grid GenerateNewGrid(IEnumerable<int> topPerm) {
            var newGrid = new Grid(new bool[Width, Height]);

            for (int x = 0; x < Width; x++) {
                newGrid.InternalGrid[x, Height - 1] = 
                    InternalGrid[x, Height - 1];
            }

            foreach (var index in topPerm)
                newGrid.ToggleAll(index, 0);

            return newGrid;
        }

        /// <summary>
        /// Checks if the challenge requires a second chase.
        /// </summary>
        /// <returns>Requires second chase.</returns>
        public bool RequiresSecondChase() {
            ChaseAll();

            return !CheckEmpty();
        }

        /// <summary>
        /// Gets the best solution to the challenge.
        /// </summary>
        /// <returns>List of positions to click to win.</returns>
        public List<int> GetSolution() {
            var combos = GetAllTopPermutations();
            
            // Clear the list.
            foreach (var combo in combos) {
                Grid comboGrid = GenerateNewGrid(combo);

                comboGrid.ChaseAll();

                if (comboGrid.CheckEmpty()) 
                    return combo.ToList();
            }

            return null;
        }

        #endregion

        #region Permutations / Generation
        public IEnumerable<IEnumerable<int>> GetAllTopPermutations() {
            List<int> cols = new List<int>();
            for (int i = 0; i < Width; i++)
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
