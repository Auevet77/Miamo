using DGVPrinterHelper;
using Miamo.BLL;
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
        private Label lblTitulo;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private Button btnPDF;
        private Button btnExibirCategoria;
        private Button btnExibirProduto;
        private Button btnSair;

        public Listar()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listar));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnExibirCategoria = new System.Windows.Forms.Button();
            this.btnExibirProduto = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Blue;
            this.lblTitulo.Location = new System.Drawing.Point(87, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(849, 73);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "CONSULTA E RELATÓRIO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Cyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(999, 388);
            this.dataGridView1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 100);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.btnPDF);
            this.panel2.Controls.Add(this.btnExibirCategoria);
            this.panel2.Controls.Add(this.btnExibirProduto);
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 488);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(999, 86);
            this.panel2.TabIndex = 7;
            // 
            // btnPDF
            // 
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.Location = new System.Drawing.Point(45, 23);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(107, 41);
            this.btnPDF.TabIndex = 4;
            this.btnPDF.Text = "Gerar PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnExibirCategoria
            // 
            this.btnExibirCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirCategoria.ForeColor = System.Drawing.Color.Blue;
            this.btnExibirCategoria.Location = new System.Drawing.Point(595, 23);
            this.btnExibirCategoria.Name = "btnExibirCategoria";
            this.btnExibirCategoria.Size = new System.Drawing.Size(108, 41);
            this.btnExibirCategoria.TabIndex = 3;
            this.btnExibirCategoria.Text = "Categoria";
            this.btnExibirCategoria.UseVisualStyleBackColor = true;
            this.btnExibirCategoria.Click += new System.EventHandler(this.btnExibirCategoria_Click);
            // 
            // btnExibirProduto
            // 
            this.btnExibirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirProduto.ForeColor = System.Drawing.Color.Blue;
            this.btnExibirProduto.Location = new System.Drawing.Point(426, 23);
            this.btnExibirProduto.Name = "btnExibirProduto";
            this.btnExibirProduto.Size = new System.Drawing.Size(105, 41);
            this.btnExibirProduto.TabIndex = 3;
            this.btnExibirProduto.Text = "Produto";
            this.btnExibirProduto.UseVisualStyleBackColor = true;
            this.btnExibirProduto.Click += new System.EventHandler(this.btnExibirProduto_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(869, 23);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(107, 41);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Listar
            // 
            this.ClientSize = new System.Drawing.Size(999, 574);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Listar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Listar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void Listar_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = Color.GhostWhite;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExibirProduto_Click(object sender, EventArgs e)
        {
            ProdutoBLL objProduto = new ProdutoBLL();
            dataGridView1.DataSource = objProduto.ListarProduto();
        }

        private void btnExibirCategoria_Click(object sender, EventArgs e)
        {
            CategoriaBLL objCAT = new CategoriaBLL();
            dataGridView1.DataSource = objCAT.ListarCategoria();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = lblTitulo.Text;
            printer.PageNumbers = true;
            printer.PorpotionalColuns = true;
            printer.Footer = DateTime.Now.ToString();
            printer.PrintDataGridView(dataGridView1);
        }
    }
}
