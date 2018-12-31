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
        #endregion
    }
}
