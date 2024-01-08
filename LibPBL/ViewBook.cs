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
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void cbxBookTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbxBookTypes.SelectedIndex;

            switch (selectedIndex)
            {
                case 0:
                    // Code to run for the first item (Fiction Book)
                    
                    // Add your specific code for fiction books here
                    break;

                case 1:
                    // Code to run for the second item (Non-Fiction Book)
                   
                    // Add your specific code for non-fiction books here
                    break;

                case 2:
                    // Code to run for the third item (Academic Book)
                    
                    // Add your specific code for academic books here
                    break;

                default:
                    // Handle any other cases if needed
                    break;
            }

        }
    }
}
