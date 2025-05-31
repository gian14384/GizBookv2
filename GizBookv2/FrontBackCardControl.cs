using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GizBookv2
{
    public partial class FrontBackCardControl : UserControl
    {
        public FrontBackCardControl()
        {
            InitializeComponent();
        }

        private void FrontBackCardControl_Load(object sender, EventArgs e)
        {

        }

        public void SetFrontBack(string front, string back)
        {
            lblFront.Text = front;
            lblBack.Text = back;
        }
    }
}
