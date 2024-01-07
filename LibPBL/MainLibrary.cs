using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibPBL
{
    public partial class MainLibrary : Form
    {
        private string LogInID;
        private string variable2;
        public MainLibrary(string var1, string var2)
        {
            InitializeComponent();
            LogInID = var1;
            variable2 = var2;
        }

        private void MainLibrary_Load(object sender, EventArgs e)
        {
            
        }
    }
}
