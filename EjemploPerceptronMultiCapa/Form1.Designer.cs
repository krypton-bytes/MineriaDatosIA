namespace EjemploPerceptronMultiCapa
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
            this.btnEntrenar = new System.Windows.Forms.Button();
            this.btnReconocer = new System.Windows.Forms.Button();
            this.seguro = new System.Windows.Forms.PictureBox();
            this.noSeguro = new System.Windows.Forms.PictureBox();
            this.txtSanciones = new System.Windows.Forms.TextBox();
            this.txtInicidencias = new System.Windows.Forms.TextBox();
            this.txtDelitos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRequest = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seguro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noSeguro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrenar
            // 
            this.btnEntrenar.Location = new System.Drawing.Point(259, 28);
            this.btnEntrenar.Name = "btnEntrenar";
            this.btnEntrenar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrenar.TabIndex = 0;
            this.btnEntrenar.Text = "Entrenar";
            this.btnEntrenar.UseVisualStyleBackColor = true;
            this.btnEntrenar.Click += new System.EventHandler(this.BtnEntrenar_Click);
            // 
            // btnReconocer
            // 
            this.btnReconocer.Location = new System.Drawing.Point(51, 265);
            this.btnReconocer.Name = "btnReconocer";
            this.btnReconocer.Size = new System.Drawing.Size(75, 23);
            this.btnReconocer.TabIndex = 1;
            this.btnReconocer.Text = "Reconocer";
            this.btnReconocer.UseVisualStyleBackColor = true;
            this.btnReconocer.Click += new System.EventHandler(this.BtnReconocer_Click);
            // 
            // seguro
            // 
            this.seguro.Image = global::EjemploPerceptronMultiCapa.Properties.Resources.escudo;
            this.seguro.Location = new System.Drawing.Point(416, 33);
            this.seguro.Name = "seguro";
            this.seguro.Size = new System.Drawing.Size(258, 255);
            this.seguro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seguro.TabIndex = 2;
            this.seguro.TabStop = false;
            this.seguro.Visible = false;
            // 
            // noSeguro
            // 
            this.noSeguro.Image = global::EjemploPerceptronMultiCapa.Properties.Resources.no_seguro;
            this.noSeguro.Location = new System.Drawing.Point(416, 33);
            this.noSeguro.Name = "noSeguro";
            this.noSeguro.Size = new System.Drawing.Size(258, 255);
            this.noSeguro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.noSeguro.TabIndex = 3;
            this.noSeguro.TabStop = false;
            this.noSeguro.Visible = false;
            // 
            // txtSanciones
            // 
            this.txtSanciones.Location = new System.Drawing.Point(49, 148);
            this.txtSanciones.Name = "txtSanciones";
            this.txtSanciones.Size = new System.Drawing.Size(286, 20);
            this.txtSanciones.TabIndex = 4;
            // 
            // txtInicidencias
            // 
            this.txtInicidencias.Location = new System.Drawing.Point(49, 91);
            this.txtInicidencias.Name = "txtInicidencias";
            this.txtInicidencias.Size = new System.Drawing.Size(286, 20);
            this.txtInicidencias.TabIndex = 5;
            // 
            // txtDelitos
            // 
            this.txtDelitos.Location = new System.Drawing.Point(51, 204);
            this.txtDelitos.Name = "txtDelitos";
            this.txtDelitos.Size = new System.Drawing.Size(286, 20);
            this.txtDelitos.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero de sanciones:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numero de incidencias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Numero de delitos:";
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Location = new System.Drawing.Point(156, 270);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(40, 13);
            this.lblRequest.TabIndex = 10;
            this.lblRequest.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "OCUPAR SOLO PARA MODIFICAR PML";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 338);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRequest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDelitos);
            this.Controls.Add(this.txtInicidencias);
            this.Controls.Add(this.txtSanciones);
            this.Controls.Add(this.noSeguro);
            this.Controls.Add(this.seguro);
            this.Controls.Add(this.btnReconocer);
            this.Controls.Add(this.btnEntrenar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.seguro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noSeguro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrenar;
        private System.Windows.Forms.Button btnReconocer;
        private System.Windows.Forms.PictureBox seguro;
        private System.Windows.Forms.PictureBox noSeguro;
        private System.Windows.Forms.TextBox txtSanciones;
        private System.Windows.Forms.TextBox txtInicidencias;
        private System.Windows.Forms.TextBox txtDelitos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.Label label4;
    }
}

