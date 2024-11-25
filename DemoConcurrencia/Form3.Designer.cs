namespace DemoConcurrencia
{
    partial class FrmImpresora
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
            splitContainer1 = new SplitContainer();
            lblEstado = new Label();
            btnDetener = new Button();
            BtnImpresion2 = new Button();
            btnImpresion1 = new Button();
            TxtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Thistle;
            splitContainer1.Panel1.Controls.Add(lblEstado);
            splitContainer1.Panel1.Controls.Add(btnDetener);
            splitContainer1.Panel1.Controls.Add(BtnImpresion2);
            splitContainer1.Panel1.Controls.Add(btnImpresion1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(16, 170);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(161, 20);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Estado de la Impresión";
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(16, 233);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(116, 39);
            btnDetener.TabIndex = 2;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // BtnImpresion2
            // 
            BtnImpresion2.Location = new Point(16, 82);
            BtnImpresion2.Name = "BtnImpresion2";
            BtnImpresion2.Size = new Size(116, 48);
            BtnImpresion2.TabIndex = 1;
            BtnImpresion2.Text = "Impresión 2";
            BtnImpresion2.UseVisualStyleBackColor = true;
            BtnImpresion2.Click += BtnImpresion2_Click;
            // 
            // btnImpresion1
            // 
            btnImpresion1.Location = new Point(12, 12);
            btnImpresion1.Name = "btnImpresion1";
            btnImpresion1.Size = new Size(120, 46);
            btnImpresion1.TabIndex = 0;
            btnImpresion1.Text = "Impresión1";
            btnImpresion1.UseVisualStyleBackColor = true;
            btnImpresion1.Click += btnImpresion1_Click_1;
            // 
            // TxtResultado
            // 
            TxtResultado.BackColor = Color.LightGreen;
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(530, 450);
            TxtResultado.TabIndex = 2;
            // 
            // FrmImpresora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FrmImpresora";
            Text = "Cola Impreción";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button BtnImpresion2;
        private Button btnImpresion1;
        private TextBox TxtResultado;
        private Label lblEstado;
        private Button btnDetener;
    }
}