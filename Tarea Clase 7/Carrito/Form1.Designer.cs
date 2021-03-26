
namespace Carrito
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
            this.buttonInicio = new System.Windows.Forms.Button();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.buttonFrenar = new System.Windows.Forms.Button();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.labeldatos = new System.Windows.Forms.Label();
            this.labelVelocidad = new System.Windows.Forms.Label();
            this.buttonRadio = new System.Windows.Forms.Button();
            this.labelRadio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonInicio
            // 
            this.buttonInicio.Location = new System.Drawing.Point(70, 42);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(97, 24);
            this.buttonInicio.TabIndex = 0;
            this.buttonInicio.Text = "Crear carro";
            this.buttonInicio.UseVisualStyleBackColor = true;
            this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
            // 
            // buttonEncender
            // 
            this.buttonEncender.Location = new System.Drawing.Point(70, 91);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(97, 24);
            this.buttonEncender.TabIndex = 1;
            this.buttonEncender.Text = "Encender carro";
            this.buttonEncender.UseVisualStyleBackColor = true;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // buttonFrenar
            // 
            this.buttonFrenar.Location = new System.Drawing.Point(70, 185);
            this.buttonFrenar.Name = "buttonFrenar";
            this.buttonFrenar.Size = new System.Drawing.Size(97, 24);
            this.buttonFrenar.TabIndex = 2;
            this.buttonFrenar.Text = "Frenar";
            this.buttonFrenar.UseVisualStyleBackColor = true;
            this.buttonFrenar.Click += new System.EventHandler(this.buttonFrenar_Click);
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.Location = new System.Drawing.Point(70, 141);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(97, 24);
            this.buttonAcelerar.TabIndex = 3;
            this.buttonAcelerar.Text = "Acelerar";
            this.buttonAcelerar.UseVisualStyleBackColor = true;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(70, 234);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(97, 24);
            this.buttonApagar.TabIndex = 4;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // labeldatos
            // 
            this.labeldatos.AutoSize = true;
            this.labeldatos.Location = new System.Drawing.Point(467, 48);
            this.labeldatos.Name = "labeldatos";
            this.labeldatos.Size = new System.Drawing.Size(35, 13);
            this.labeldatos.TabIndex = 5;
            this.labeldatos.Text = "Datos";
            // 
            // labelVelocidad
            // 
            this.labelVelocidad.AutoSize = true;
            this.labelVelocidad.Location = new System.Drawing.Point(467, 147);
            this.labelVelocidad.Name = "labelVelocidad";
            this.labelVelocidad.Size = new System.Drawing.Size(54, 13);
            this.labelVelocidad.TabIndex = 6;
            this.labelVelocidad.Text = "Velocidad";
            // 
            // buttonRadio
            // 
            this.buttonRadio.Location = new System.Drawing.Point(70, 283);
            this.buttonRadio.Name = "buttonRadio";
            this.buttonRadio.Size = new System.Drawing.Size(97, 24);
            this.buttonRadio.TabIndex = 7;
            this.buttonRadio.Text = "Radio";
            this.buttonRadio.UseVisualStyleBackColor = true;
            this.buttonRadio.Click += new System.EventHandler(this.buttonRadio_Click);
            // 
            // labelRadio
            // 
            this.labelRadio.AutoSize = true;
            this.labelRadio.Location = new System.Drawing.Point(467, 283);
            this.labelRadio.Name = "labelRadio";
            this.labelRadio.Size = new System.Drawing.Size(35, 13);
            this.labelRadio.TabIndex = 8;
            this.labelRadio.Text = "Radio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRadio);
            this.Controls.Add(this.buttonRadio);
            this.Controls.Add(this.labelVelocidad);
            this.Controls.Add(this.labeldatos);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonAcelerar);
            this.Controls.Add(this.buttonFrenar);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.buttonInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Button buttonEncender;
        private System.Windows.Forms.Button buttonFrenar;
        private System.Windows.Forms.Button buttonAcelerar;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Label labeldatos;
        private System.Windows.Forms.Label labelVelocidad;
        private System.Windows.Forms.Button buttonRadio;
        private System.Windows.Forms.Label labelRadio;
    }
}

