namespace Automatas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAutomata = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtLenguaje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConexiones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Prueba = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "De que tamaño es su automata??";
            // 
            // TxtAutomata
            // 
            this.TxtAutomata.Location = new System.Drawing.Point(15, 25);
            this.TxtAutomata.Name = "TxtAutomata";
            this.TxtAutomata.Size = new System.Drawing.Size(100, 20);
            this.TxtAutomata.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtLenguaje
            // 
            this.TxtLenguaje.Location = new System.Drawing.Point(12, 75);
            this.TxtLenguaje.Multiline = true;
            this.TxtLenguaje.Name = "TxtLenguaje";
            this.TxtLenguaje.Size = new System.Drawing.Size(161, 20);
            this.TxtLenguaje.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ingrese su lenguaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ej: a,b,c,d,e";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ingrese las conexiones";
            // 
            // txtConexiones
            // 
            this.txtConexiones.Location = new System.Drawing.Point(15, 153);
            this.txtConexiones.Name = "txtConexiones";
            this.txtConexiones.Size = new System.Drawing.Size(181, 20);
            this.txtConexiones.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ej: a,b>c;a,d>b";
            // 
            // Prueba
            // 
            this.Prueba.Location = new System.Drawing.Point(220, 90);
            this.Prueba.Name = "Prueba";
            this.Prueba.Size = new System.Drawing.Size(100, 20);
            this.Prueba.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 310);
            this.Controls.Add(this.Prueba);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtConexiones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtLenguaje);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtAutomata);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Automatas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAutomata;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtLenguaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConexiones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Prueba;


    }
}

