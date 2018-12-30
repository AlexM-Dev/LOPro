using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOPro {
    class InteractiveGrid {
        public readonly Grid InternalGrid;
        private readonly PictureBox[,] interactiveGrid;

        private readonly int width;
        private readonly int height;

        private Control parent;
        private Action<int, int> clicked;

        public bool ToggleOne { get; set; } = true;

        public InteractiveGrid(Control parent, Size size) {
            InternalGrid = new Grid(new bool[size.Width, size.Height]);
            interactiveGrid = new PictureBox[size.Width, size.Height];

            width = size.Width;
            height = size.Height;

            this.parent = parent;
            this.clicked = (x, y) => {
                if (ToggleOne) InternalGrid.Toggle(x, y);
                else InternalGrid.ToggleAll(x, y);

                InternalToInteractiveSync();
            };
        }

        public void GenerateGrid() {
            for (int x = 0; x < width; x++) {
                for (int y = 0; y < height; y++) {
                    var pb = new PictureBox {
                        Name = (y * parent.Height + x).ToString(),
                        Size = new Size(32, 32),
                        Location = new Point(10 + x * 35, 20 + y * 35),
                        BackColor = InternalGrid.InternalGrid[x, y] ?
                            Color.Yellow : Color.Black
                    };

                    int x2 = x, y2 = y;

                    pb.Click += (sender, e) => clicked(x2, y2);
                    parent.Controls.Add(pb);
                    interactiveGrid[x, y] = pb;
                }
            }
        }

        public void InternalToInteractiveSync() {
            for (int x = 0; x < width; x++) {
                for (int y = 0; y < height; y++) {
                    bool on = InternalGrid.InternalGrid[x, y];

                    interactiveGrid[x, y].BackColor = 
                        on ? Color.Yellow : Color.Black;
                }
            }
        }
    }
}
