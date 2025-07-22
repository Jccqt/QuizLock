using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizLock
{
    public partial class QuizLock : Form
    {
        public QuizLock()
        {
            InitializeComponent();
            this.MinimizeBox = false; // will prevent windows from minizing the size
            this.MaximizeBox = false; // will prevent windows from maximizing the size
        }

        private void QuizLock_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // will prevent windows from closing
        }

        private void QuizLock_Load(object sender, EventArgs e)
        {
            this.TopMost = true; // will prevent windows from switching to another windows
        }
    }
}
