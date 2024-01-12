using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace LibPBL
{
    public partial class ViewReturnBooks : Form
    {
        public string UserID;
        public ViewReturnBooks()
        {
            InitializeComponent();
            UserID = MainLibrary.instance.LogInID;
        }




        private void ViewReturnBooks_Load(object sender, EventArgs e)
        {
            string UserID = MainLibrary.instance.LogInID;
            BookDatabase.LoadBooksToFlowLayoutPanelOnlyBorrower(flowLayoutPanel1, UserID);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
