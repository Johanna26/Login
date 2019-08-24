namespace Login
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.abrir = new System.Windows.Forms.Button();
            this.usuario = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.Salir = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 61);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // abrir
            // 
            this.abrir.BackColor = System.Drawing.Color.Lime;
            this.abrir.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrir.Location = new System.Drawing.Point(137, 348);
            this.abrir.Name = "abrir";
            this.abrir.Size = new System.Drawing.Size(149, 65);
            this.abrir.TabIndex = 2;
            this.abrir.Text = "Abrir";
            this.abrir.UseVisualStyleBackColor = false;
            this.abrir.Click += new System.EventHandler(this.abrir_Click);
            // 
            // usuario
            // 
            this.usuario.BackColor = System.Drawing.Color.Thistle;
            this.usuario.Location = new System.Drawing.Point(353, 112);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(344, 22);
            this.usuario.TabIndex = 3;
            this.usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contraseña
            // 
            this.contraseña.BackColor = System.Drawing.Color.Thistle;
            this.contraseña.Location = new System.Drawing.Point(353, 223);
            this.contraseña.Name = "contraseña";
            this.contraseña.PasswordChar = '*';
            this.contraseña.Size = new System.Drawing.Size(344, 22);
            this.contraseña.TabIndex = 4;
            // 
            // Salir
            // 
            this.Salir.AutoSize = true;
            this.Salir.BackColor = System.Drawing.Color.Red;
            this.Salir.Font = new System.Drawing.Font("Comic Sans MS", 24.2F);
            this.Salir.Location = new System.Drawing.Point(481, 348);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(116, 57);
            this.Salir.TabIndex = 5;
            this.Salir.Text = "Salir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(502, 60);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sistema Super secreto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.abrir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button abrir;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Label Salir;
        private System.Windows.Forms.Label label3;
    }
}

