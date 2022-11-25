using Miamo.BLL;
using Miamo.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiamoDesktop
{
    public partial class Editar : Form
    {
        private const int V = 1;
        private GroupBox gBox2;
        private RadioButton rb1;
        private RadioButton rb2;
        private Button btnSair;
        private Button btnCancelar;
        private Button btnExcluir;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private TextBox txtNome;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox txtId;
        private Button btnPesquisar;
        private Button btnConfirmar;
        private Label label6;
        private TextBox txtTpUsuario;
        private GroupBox gBox3;
        private GroupBox gBox1;
        private Label label1;
        private object txtFTpUsuario;

        public Editar()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.gBox2 = new System.Windows.Forms.GroupBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTpUsuario = new System.Windows.Forms.TextBox();
            this.gBox3 = new System.Windows.Forms.GroupBox();
            this.gBox1 = new System.Windows.Forms.GroupBox();
            this.gBox2.SuspendLayout();
            this.gBox3.SuspendLayout();
            this.gBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "EDITAR USUÁRIO";
            // 
            // gBox2
            // 
            this.gBox2.Controls.Add(this.rb1);
            this.gBox2.Controls.Add(this.rb2);
            this.gBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox2.Location = new System.Drawing.Point(486, 89);
            this.gBox2.Name = "gBox2";
            this.gBox2.Size = new System.Drawing.Size(243, 155);
            this.gBox2.TabIndex = 19;
            this.gBox2.TabStop = false;
            this.gBox2.Text = "Selecione o tipo de usuário";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(51, 38);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(128, 25);
            this.rb1.TabIndex = 8;
            this.rb1.TabStop = true;
            this.rb1.Text = "Administrador";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(51, 89);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(76, 25);
            this.rb2.TabIndex = 9;
            this.rb2.TabStop = true;
            this.rb2.Text = "Outros";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(599, 107);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(87, 41);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Blue;
            this.btnCancelar.Location = new System.Drawing.Point(371, 32);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 41);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Blue;
            this.btnExcluir.Location = new System.Drawing.Point(25, 32);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(107, 41);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(24, 197);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(381, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(24, 128);
            this.txtSenha.MaxLength = 6;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(381, 20);
            this.txtSenha.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(24, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(381, 20);
            this.txtNome.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(146, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Digite o Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(151, 128);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(153, 20);
            this.txtId.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.Blue;
            this.btnPesquisar.Location = new System.Drawing.Point(413, 107);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(107, 41);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.Blue;
            this.btnConfirmar.Location = new System.Drawing.Point(193, 32);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(107, 41);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo do Usuário";
            // 
            // txtTpUsuario
            // 
            this.txtTpUsuario.Location = new System.Drawing.Point(24, 265);
            this.txtTpUsuario.Name = "txtTpUsuario";
            this.txtTpUsuario.Size = new System.Drawing.Size(381, 20);
            this.txtTpUsuario.TabIndex = 7;
            // 
            // gBox3
            // 
            this.gBox3.Controls.Add(this.btnExcluir);
            this.gBox3.Controls.Add(this.btnConfirmar);
            this.gBox3.Controls.Add(this.btnCancelar);
            this.gBox3.Location = new System.Drawing.Point(233, 485);
            this.gBox3.Name = "gBox3";
            this.gBox3.Size = new System.Drawing.Size(513, 100);
            this.gBox3.TabIndex = 22;
            this.gBox3.TabStop = false;
            // 
            // gBox1
            // 
            this.gBox1.Controls.Add(this.label2);
            this.gBox1.Controls.Add(this.label3);
            this.gBox1.Controls.Add(this.label4);
            this.gBox1.Controls.Add(this.gBox2);
            this.gBox1.Controls.Add(this.txtNome);
            this.gBox1.Controls.Add(this.label6);
            this.gBox1.Controls.Add(this.txtTpUsuario);
            this.gBox1.Controls.Add(this.txtSenha);
            this.gBox1.Controls.Add(this.txtEmail);
            this.gBox1.Location = new System.Drawing.Point(133, 181);
            this.gBox1.Name = "gBox1";
            this.gBox1.Size = new System.Drawing.Size(803, 298);
            this.gBox1.TabIndex = 23;
            this.gBox1.TabStop = false;
            // 
            // Editar
            // 
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.gBox1);
            this.Controls.Add(this.gBox3);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Editar_Load);
            this.gBox2.ResumeLayout(false);
            this.gBox2.PerformLayout();
            this.gBox3.ResumeLayout(false);
            this.gBox1.ResumeLayout(false);
            this.gBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void Limpar()
        {
            //caixas de texto
            txtId.Text = txtNome.Text = txtSenha.Text = txtEmail.Text = string.Empty;

            txtId.Enabled = btnPesquisar.Enabled = true;

            //radio buttons
            rb1.Checked = rb2.Checked = false;

            //groupBox

            gBox1.Visible = gBox3.Enabled = false;
            txtId.Focus();
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            gBox1.Visible = gBox3.Enabled = false;
            txtId.Focus();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            gBox1.Visible = true;
            gBox3.Enabled = true;

            //checando preenchimento do campo Id
            int codigo;
            if (!int.TryParse(txtId.Text, out codigo))
            {
                Limpar();
                MessageBox.Show("Digite o Id do usuario!!");
                txtId.Focus();
                btnPesquisar.Enabled = true;
                return;
            }

            //chamando metodos
            codigo = Convert.ToInt32(txtId.Text);
            UsuarioListDTO objPesquisa = new UsuarioListDTO();//modelo
            UsuarioBLL objPesqBLL = new UsuarioBLL();//metodo
            objPesquisa = objPesqBLL.SelecionarUsuario(codigo);

            if (objPesquisa.NomeUsuario != null)
            {

                //habilitando componentes
                txtNome.Text = objPesquisa.NomeUsuario;
                txtSenha.Text = objPesquisa.SenhaUsuario;
                txtEmail.Text = objPesquisa.EmailUsuario;
                txtTpUsuario.Text = objPesquisa.DescricaoTpUsuario;

            }
            else
            {
                Limpar();
                MessageBox.Show("Não rolou a busca !!!");
                return;
            }

        }

        //CONFIRMAR
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            UsuarioDTO objPesquisa = new UsuarioDTO();//Modelo
            UsuarioBLL objPesqBLL =new UsuarioBLL();//Modelo
            objPesquisa.IdUsuario = Convert.ToInt32(txtId.Text);
            objPesquisa.NomeUsuario = txtNome.Text;
            objPesquisa.SenhaUsuario = txtSenha.Text;
            objPesquisa.EmailUsuario = txtEmail.Text;

            //alertando radio buttons não selecionados
            if ((!rb1.Checked) && !rb2.Checked)
            {
                MessageBox.Show("Escolha uma opção!!");
                return;
            }

            //atribuindo valor radio buttons
            if (rb1.Checked)
            {
                objPesquisa.TpUsuario = "1";
            }
            else if (rb2.Checked)
            {
                objPesquisa.TpUsuario = "2";
            }

            objPesqBLL.EditarUsuario(objPesquisa);
            Limpar();
            MessageBox.Show("Usuário editado com sucesso!!");

           

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Deseja mesmo eliminar o registro?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //manipulando o valor escolhido mo messagebox
            if (msg == DialogResult.Yes)
            {
                UsuarioBLL objExcluiBLL = new UsuarioBLL();//metodo
                int codigo = Convert.ToInt32(txtId.Text);
                objExcluiBLL.ExcluirUsuario(codigo);
                Limpar();
            }
            else if (msg == DialogResult.No)
            {
                Limpar();
            }
        }
    }
}
