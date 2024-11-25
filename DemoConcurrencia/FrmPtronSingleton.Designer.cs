namespace DemoConcurrencia
{
    partial class FrmPatronSingleton
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
            btnAsignar = new Button();
            btnRecuperarCadenaConecion = new Button();
            lblCadenaConexion = new Label();
            txtCadenaConexion = new TextBox();
            lblCadenaconexionrecuperada = new Label();
            SuspendLayout();
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(44, 142);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(161, 55);
            btnAsignar.TabIndex = 0;
            btnAsignar.Text = "Asignar cadena de conexión";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // btnRecuperarCadenaConecion
            // 
            btnRecuperarCadenaConecion.Location = new Point(44, 247);
            btnRecuperarCadenaConecion.Name = "btnRecuperarCadenaConecion";
            btnRecuperarCadenaConecion.Size = new Size(161, 52);
            btnRecuperarCadenaConecion.TabIndex = 1;
            btnRecuperarCadenaConecion.Text = "Recuperar la cadena conexión";
            btnRecuperarCadenaConecion.UseVisualStyleBackColor = true;
            btnRecuperarCadenaConecion.Click += btnRecuperarCadenaConecion_Click;
            // 
            // lblCadenaConexion
            // 
            lblCadenaConexion.AutoSize = true;
            lblCadenaConexion.Location = new Point(44, 27);
            lblCadenaConexion.Name = "lblCadenaConexion";
            lblCadenaConexion.Size = new Size(125, 20);
            lblCadenaConexion.TabIndex = 2;
            lblCadenaConexion.Text = "Cadena Conexión";
            // 
            // txtCadenaConexion
            // 
            txtCadenaConexion.Location = new Point(44, 73);
            txtCadenaConexion.Name = "txtCadenaConexion";
            txtCadenaConexion.Size = new Size(702, 27);
            txtCadenaConexion.TabIndex = 3;
            // 
            // lblCadenaconexionrecuperada
            // 
            lblCadenaconexionrecuperada.AutoSize = true;
            lblCadenaconexionrecuperada.Location = new Point(357, 305);
            lblCadenaconexionrecuperada.Name = "lblCadenaconexionrecuperada";
            lblCadenaconexionrecuperada.Size = new Size(0, 20);
            lblCadenaconexionrecuperada.TabIndex = 4;
            // 
            // FrmPatronSingleton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCadenaconexionrecuperada);
            Controls.Add(txtCadenaConexion);
            Controls.Add(lblCadenaConexion);
            Controls.Add(btnRecuperarCadenaConecion);
            Controls.Add(btnAsignar);
            Name = "FrmPatronSingleton";
            Text = "Demostracion Patron Singleton";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAsignar;
        private Button btnRecuperarCadenaConecion;
        private Label lblCadenaConexion;
        private TextBox txtCadenaConexion;
        private Label lblCadenaconexionrecuperada;
    }
}