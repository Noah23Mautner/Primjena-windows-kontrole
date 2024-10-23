using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormaProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Da li želite nastaviti?",
        "Potvrda",
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Information);

            // Obrada rezultata
            switch (result)
            {
                case DialogResult.Yes:
                    // Akcija za 'Yes'
                    MessageBox.Show("Odabrali ste Da.");
                    break;
                case DialogResult.No:
                    // Akcija za 'No'
                    MessageBox.Show("Odabrali ste Ne.");
                    break;
                case DialogResult.Cancel:
                    // Akcija za 'Cancel'
                    MessageBox.Show("Akcija je otkazana.");
                    break;
            }

        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (FormaText formaText = new FormaText())
            {
                // Otvorite FormaText kao dijalog
                formaText.ShowDialog(); // Samo otvorite formu
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Nametxt.Clear();
            Dectxt.Clear();
        }
    }
}
