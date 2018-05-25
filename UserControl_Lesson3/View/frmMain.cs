using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControl_Lesson3.View;

namespace UserControl_Lesson3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            UserControlTimer user = new UserControlTimer();
            this.Controls.Add(user);

        }

    }
}
