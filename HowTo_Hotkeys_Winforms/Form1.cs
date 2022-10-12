using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowTo_Hotkeys_Winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape: ExitApp(); return true;
                case Keys.Right: Next(); return true;
                case Keys.Left: Previous(); return true;
                case Keys.NumPad0: button1.PerformClick(); return true;
                default: return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void Previous() { MessageBox.Show("Previous"); }

        private void Next() { MessageBox.Show("Next"); }

        private void ExitApp() { MessageBox.Show("Exit"); }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button click");
        }
    }
}
