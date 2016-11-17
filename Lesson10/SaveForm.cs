using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lesson10
{
    public partial class SaveForm : Form
    {
        public SaveForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("Names.txt", true);
            writer.WriteLine(FirstNameTextBox.Text);
            writer.WriteLine(LastNameTextBox.Text);

            writer.Close();
        }
    }
}
