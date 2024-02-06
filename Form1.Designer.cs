namespace GeradorDeSenhas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableExibirSenhas = new System.Windows.Forms.ListBox();
            this.numeroCaracteres = new System.Windows.Forms.NumericUpDown();
            this.lblCarac = new System.Windows.Forms.Label();
            this.cMaiusculos = new System.Windows.Forms.CheckBox();
            this.cEspeciais = new System.Windows.Forms.CheckBox();
            this.cAlgarismos = new System.Windows.Forms.CheckBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeroCaracteres)).BeginInit();
            this.SuspendLayout();
            // 
            // tableExibirSenhas
            // 
            this.tableExibirSenhas.FormattingEnabled = true;
            resources.ApplyResources(this.tableExibirSenhas, "tableExibirSenhas");
            this.tableExibirSenhas.Name = "tableExibirSenhas";
            // 
            // numeroCaracteres
            // 
            resources.ApplyResources(this.numeroCaracteres, "numeroCaracteres");
            this.numeroCaracteres.Name = "numeroCaracteres";
            // 
            // lblCarac
            // 
            resources.ApplyResources(this.lblCarac, "lblCarac");
            this.lblCarac.Name = "lblCarac";
            // 
            // cMaiusculos
            // 
            resources.ApplyResources(this.cMaiusculos, "cMaiusculos");
            this.cMaiusculos.Name = "cMaiusculos";
            this.cMaiusculos.UseVisualStyleBackColor = true;
            // 
            // cEspeciais
            // 
            resources.ApplyResources(this.cEspeciais, "cEspeciais");
            this.cEspeciais.Name = "cEspeciais";
            this.cEspeciais.UseVisualStyleBackColor = true;
            // 
            // cAlgarismos
            // 
            resources.ApplyResources(this.cAlgarismos, "cAlgarismos");
            this.cAlgarismos.Name = "cAlgarismos";
            this.cAlgarismos.UseVisualStyleBackColor = true;
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.btnGerar, "btnGerar");
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.RosyBrown;
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.Name = "btnSair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.cAlgarismos);
            this.Controls.Add(this.cEspeciais);
            this.Controls.Add(this.cMaiusculos);
            this.Controls.Add(this.lblCarac);
            this.Controls.Add(this.numeroCaracteres);
            this.Controls.Add(this.tableExibirSenhas);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numeroCaracteres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox tableExibirSenhas;
        private System.Windows.Forms.NumericUpDown numeroCaracteres;
        private System.Windows.Forms.Label lblCarac;
        private System.Windows.Forms.CheckBox cMaiusculos;
        private System.Windows.Forms.CheckBox cEspeciais;
        private System.Windows.Forms.CheckBox cAlgarismos;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnSair;
    }
}

