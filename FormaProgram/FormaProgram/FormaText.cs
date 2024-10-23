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
    public partial class FormaText : Form
    {
        public string ProgramName { get; private set; }
        public string ProgramDescription { get; private set; }
        public FormaText()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            // Zatvorite formu i vratite DialogResult.OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
