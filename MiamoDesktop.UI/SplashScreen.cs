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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SplashScreen
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
