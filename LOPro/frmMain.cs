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

        public frmMain() {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) {
        }

        private void btnToggleX_Click(object sender, EventArgs e) {
            grid.ToggleOne = !grid.ToggleOne;

            btnToggleX.Text = grid.ToggleOne ? "Toggle one" : "Toggle many";
        }

        private void btnChaseRows_Click(object sender, EventArgs e) {
            grid.InternalGrid.ChaseAll();

            grid.InternalToInteractiveSync();
        }

        private void btnSolutions_Click(object sender, EventArgs e) {
            var lg = grid.InternalGrid;

            if (!lg.RequiresSecondChase()) {
                txtOutput.AppendText("\r\nAfter first chasing, no" +
                    " further chasing is required.");
                grid.InternalToInteractiveSync();
                return;
            }
            grid.InternalToInteractiveSync();

            var solution = lg.GetSolution();
            if (solution != null) {
                var friendly = solution.Select(n => { n = n + 1; return n; });

                txtOutput.AppendText("\r\nPress the lights at the top in the "
                    + "following order, then chase: " +
                    String.Join(", ", friendly));
            } else {
                txtOutput.AppendText("\r\nThis challenge is unsolvable.");
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e) {
            if (!Int32.TryParse(txtWidth.Text, out int w) ||
                !Int32.TryParse(txtHeight.Text, out int h))
                return;

            grid = new InteractiveGrid(grpGrid, new Size(w, h));

            grid.GenerateGrid();

            txtWidth.Enabled = false;
            txtHeight.Enabled = false;
            btnGenerate.Enabled = false;

            btnToggleX.Enabled = true;
            btnChaseRows.Enabled = true;
            btnSolutions.Enabled = true;

            btnSolutions.Focus();
        }
    }
}
