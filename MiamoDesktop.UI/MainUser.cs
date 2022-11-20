using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiamoDesktop
{
    public partial class MainUser : Form
    {
        public MainUser()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainUser
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "MainUser";
            this.Load += new System.EventHandler(this.MainUser_Load);
            this.ResumeLayout(false);

        }

        private void MainUser_Load(object sender, EventArgs e)
        {

        }
    }
}
