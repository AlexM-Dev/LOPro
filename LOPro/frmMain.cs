using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOPro {
    public partial class frmMain : Form {
        InteractiveGrid grid;
        InteractiveGrid stepGrid;

        StepTracker tracker;

        Random rnd = new Random();

        public frmMain() {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e) {
            int w = (int)nudWidth.Value, h = (int)nudHeight.Value;

            grid = new InteractiveGrid(grpGrid, new Size(w, h));
            stepGrid = new InteractiveGrid(grpSteps, new Size(w, h), false);
            stepGrid.OnColor = Color.Red;

            grid.GenerateGrid();
            stepGrid.GenerateGrid();

            nudWidth.Enabled = false;
            nudHeight.Enabled = false;
            btnGenerate.Enabled = false;

            mnuInteraction.Enabled = true;
            mnuChase.Enabled = true;
            mnuSolve.Enabled = true;
        }

        private void mnuClickMode_Click(object sender, EventArgs e) {
            grid.ToggleOne = !grid.ToggleOne;

            mnuClickMode.Text = grid.ToggleOne ? "Click mode: one" :
                "Click mode: many/game";
        }

        private void mnuChaseAll_Click(object sender, EventArgs e) {
            BasicSolver.ChaseAll(grid.InternalGrid);

            grid.InternalToInteractiveSync();
        }

        private void mnuSolveSteps_Click(object sender, EventArgs e) {
            var lg = grid.InternalGrid;

            var copyArr = lg.InternalGrid.Clone() as bool[,];
            var ng = new Grid(copyArr);

            tracker = new StepTracker(ng);

            if (tracker.RequiresSecondChase()) {
                var sol = tracker.GetSolution();

                if (sol == null) {
                    grid.InternalToInteractiveSync();
                    txtOutput.AppendText("\r\nThis challenge is unsolvable.");
                    return;
                }
            }

            var c = tracker.ConvertToGrid();

            for (int x = 0; x < stepGrid.InternalGrid.Width; x++) {
                for (int y = 0; y < stepGrid.InternalGrid.Height; y++) {
                    stepGrid.InternalGrid.InternalGrid[x, y] = c[x, y];
                }
            }

            stepGrid.InternalToInteractiveSync();

            grpSteps.Show();
            grpSteps.BringToFront();
        }

        private void mnuSolveText_Click(object sender, EventArgs e) {
            var lg = grid.InternalGrid;

            var copyArr = lg.InternalGrid.Clone() as bool[,];
            var ng = new Grid(copyArr);

            if (BasicSolver.RequiresSecondChase(ng)) {
                var solution = BasicSolver.GetSolution(ng);

                if (solution != null) {
                    var friendly = solution.Select(n => { n = n + 1; return n; });

                    txtOutput.AppendText("\r\nChase all the lights, then " +
                        "press the lights at the top in the "
                        + "following order, then chase: " +
                        String.Join(", ", friendly));
                } else {
                    txtOutput.AppendText("\r\nThis challenge is unsolvable.");
                }
            } else {
                txtOutput.AppendText("\r\nAfter first chasing, no" +
                    " further chasing is required.");
            }
        }

        private void btnCloseSteps_Click(object sender, EventArgs e) {
            tracker.Reset();

            grpSteps.SendToBack();
            grpSteps.Hide();
        }

        private void mnuRandomGrid_Click(object sender, EventArgs e) {
            for (int x = 0; x < grid.InternalGrid.Width; x++) {
                for (int y = 0; y < grid.InternalGrid.Height; y++) {
                    grid.InternalGrid.InternalGrid[x, y] = rnd.Next(2) == 1;
                }
            }

            grid.InternalToInteractiveSync();
        }
    }
}
