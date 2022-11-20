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
    public partial class Listar : Form
    {
        public Listar()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Listar
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Listar";
            this.Load += new System.EventHandler(this.Listar_Load);
            this.ResumeLayout(false);

        }

        private void Listar_Load(object sender, EventArgs e)
        {

        }
    }
}
