using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_for_null_in_finally_block
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextReader TR = null;

            try
            {
                TR = new StreamReader("File.txt");
            }
            catch
            {
                MessageBox.Show("Error occured");
            }
            finally
            {
                if(TR != null) TR.Close();
            }
        }
    }
}
