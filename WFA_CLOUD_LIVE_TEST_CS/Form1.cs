using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_CLOUD_LIVE_TEST_CS
{
    public partial class frmSoftware : Form
    {
        public frmSoftware()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            double v = validate();
            if (v == 0)
            {
                MessageBox.Show("เลือกรายการไอเหี้ย!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(v.ToString(), "ยอดชำระ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private double validate()
        {
            int cost=0;
            if (chk1.Checked) { cost += 35; }
            if (chk2.Checked) { cost += 25; }
            if (chk3.Checked) { cost += 15; }
            if (chk4.Checked) { cost += 45; }
            if (chk5.Checked) { cost += 55; }
            if (chk6.Checked) { cost += 65; }
            return cost;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
