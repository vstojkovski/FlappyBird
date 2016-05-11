using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class DisplayScore : Form
    {

        public DisplayScore(int currentPoints, int bestPoints)
        {
            InitializeComponent();
            lbScore.Text = string.Format("{0}", currentPoints);
            lbBest.Text = string.Format("{0}", bestPoints);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
