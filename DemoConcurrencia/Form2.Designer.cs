namespace DemoConcurrencia
{
    partial class FrmBloqueos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblContador = new Label();
            splitContainer1 = new SplitContainer();
            TxtResultado = new TextBox();
            BtnDisminuir = new Button();
            btnIncrementar = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(57, 145);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(17, 20);
            lblContador.TabIndex = 1;
            lblContador.Text = "0";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lblContador);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.SpringGreen;
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(575, 293);
            splitContainer1.SplitterDistance = 191;
            splitContainer1.TabIndex = 3;
            // 
            // TxtResultado
            // 
            TxtResultado.BackColor = Color.LightGreen;
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(380, 293);
            TxtResultado.TabIndex = 1;
            // 
            // BtnDisminuir
            // 
            BtnDisminuir.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnDisminuir.Location = new Point(12, 81);
            BtnDisminuir.Name = "BtnDisminuir";
            BtnDisminuir.Size = new Size(113, 39);
            BtnDisminuir.TabIndex = 2;
            BtnDisminuir.Text = "Disminuir";
            BtnDisminuir.UseVisualStyleBackColor = true;
            BtnDisminuir.Click += BtnDisminuir_Click_1;
            // 
            // btnIncrementar
            // 
            btnIncrementar.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnIncrementar.Location = new Point(12, 12);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(113, 41);
            btnIncrementar.TabIndex = 0;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // FrmBloqueos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(575, 293);
            Controls.Add(btnIncrementar);
            Controls.Add(BtnDisminuir);
            Controls.Add(splitContainer1);
            Name = "FrmBloqueos";
            Text = "Gestión de Bloqueos";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblContador;
        private SplitContainer splitContainer1;
        private Button BtnDisminuir;
        private Button btnIncrementar;
        private TextBox TxtResultado;
    }
}