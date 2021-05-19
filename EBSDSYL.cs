using System;
using System.Windows.Forms;

namespace Kolaj_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        OpenFileDialog op; String EBSYol;
        private void kolajYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            op = new OpenFileDialog();
            op.Multiselect = true;
            if (op.ShowDialog() == DialogResult.OK)
            {
                 EBSYol = op.FileNames[0].ToString().Replace(op.SafeFileNames[0],"");
            }
        }
    }
}
