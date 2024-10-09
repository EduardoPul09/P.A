namespace _3OLIDTS_EduardoPulido_04
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Apellidos = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.Edad = new System.Windows.Forms.TextBox();
            this.Estatura = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Genero = new System.Windows.Forms.GroupBox();
            this.Hombre = new System.Windows.Forms.RadioButton();
            this.Mujer = new System.Windows.Forms.RadioButton();
            this.Guardar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Genero.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "APELLIDOS:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "TELEFONO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "EDAD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "ESTATURA:";
            // 
            // Apellidos
            // 
            this.Apellidos.Location = new System.Drawing.Point(119, 93);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(208, 22);
            this.Apellidos.TabIndex = 5;
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(119, 131);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(208, 22);
            this.Telefono.TabIndex = 6;
            // 
            // Edad
            // 
            this.Edad.Location = new System.Drawing.Point(119, 168);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(208, 22);
            this.Edad.TabIndex = 7;
            // 
            // Estatura
            // 
            this.Estatura.Location = new System.Drawing.Point(119, 207);
            this.Estatura.Name = "Estatura";
            this.Estatura.Size = new System.Drawing.Size(208, 22);
            this.Estatura.TabIndex = 8;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(119, 37);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(208, 22);
            this.Nombre.TabIndex = 9;
            // 
            // Genero
            // 
            this.Genero.Controls.Add(this.Hombre);
            this.Genero.Controls.Add(this.Mujer);
            this.Genero.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genero.Location = new System.Drawing.Point(53, 315);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(282, 123);
            this.Genero.TabIndex = 10;
            this.Genero.TabStop = false;
            this.Genero.Text = "GENERO";
            this.Genero.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Hombre
            // 
            this.Hombre.AutoSize = true;
            this.Hombre.Location = new System.Drawing.Point(6, 61);
            this.Hombre.Name = "Hombre";
            this.Hombre.Size = new System.Drawing.Size(87, 23);
            this.Hombre.TabIndex = 11;
            this.Hombre.TabStop = true;
            this.Hombre.Text = "HOMBRE";
            this.Hombre.UseVisualStyleBackColor = true;
            // 
            // Mujer
            // 
            this.Mujer.AutoSize = true;
            this.Mujer.Location = new System.Drawing.Point(171, 61);
            this.Mujer.Name = "Mujer";
            this.Mujer.Size = new System.Drawing.Size(73, 23);
            this.Mujer.TabIndex = 12;
            this.Mujer.TabStop = true;
            this.Mujer.Text = "MUJER";
            this.Mujer.UseVisualStyleBackColor = true;
            // 
            // Guardar
            // 
            this.Guardar.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Location = new System.Drawing.Point(87, 466);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(83, 23);
            this.Guardar.TabIndex = 11;
            this.Guardar.Text = "GUARDAR";
            this.Guardar.UseVisualStyleBackColor = true;
            // 
            // Cancelar
            // 
            this.Cancelar.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(206, 466);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(91, 23);
            this.Cancelar.TabIndex = 12;
            this.Cancelar.Text = "CANCELAR";
            this.Cancelar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "NOMBRE:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 590);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Estatura);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Genero.ResumeLayout(false);
            this.Genero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Apellidos;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.TextBox Edad;
        private System.Windows.Forms.TextBox Estatura;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.GroupBox Genero;
        private System.Windows.Forms.RadioButton Hombre;
        private System.Windows.Forms.RadioButton Mujer;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label label6;
    }
}

