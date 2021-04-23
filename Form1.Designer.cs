
namespace Navegador
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
            this.bBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBuscar = new System.Windows.Forms.TextBox();
            this.bRojo = new System.Windows.Forms.Button();
            this.bVerde = new System.Windows.Forms.Button();
            this.bAzul = new System.Windows.Forms.Button();
            this.bVer = new System.Windows.Forms.Button();
            this.bIr = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // bBuscar
            // 
            this.bBuscar.BackColor = System.Drawing.Color.Blue;
            this.bBuscar.ForeColor = System.Drawing.Color.White;
            this.bBuscar.Location = new System.Drawing.Point(110, 50);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(131, 20);
            this.bBuscar.TabIndex = 1;
            this.bBuscar.Text = "Buscar en Google";
            this.bBuscar.UseVisualStyleBackColor = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escriba";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tBuscar
            // 
            this.tBuscar.Location = new System.Drawing.Point(110, 22);
            this.tBuscar.Name = "tBuscar";
            this.tBuscar.Size = new System.Drawing.Size(421, 20);
            this.tBuscar.TabIndex = 3;
            // 
            // bRojo
            // 
            this.bRojo.BackColor = System.Drawing.Color.Red;
            this.bRojo.Location = new System.Drawing.Point(610, 18);
            this.bRojo.Name = "bRojo";
            this.bRojo.Size = new System.Drawing.Size(75, 23);
            this.bRojo.TabIndex = 4;
            this.bRojo.Text = "Rojo";
            this.bRojo.UseVisualStyleBackColor = false;
            // 
            // bVerde
            // 
            this.bVerde.BackColor = System.Drawing.Color.Lime;
            this.bVerde.Location = new System.Drawing.Point(610, 47);
            this.bVerde.Name = "bVerde";
            this.bVerde.Size = new System.Drawing.Size(75, 23);
            this.bVerde.TabIndex = 5;
            this.bVerde.Text = "Verde";
            this.bVerde.UseVisualStyleBackColor = false;
            // 
            // bAzul
            // 
            this.bAzul.BackColor = System.Drawing.Color.Blue;
            this.bAzul.ForeColor = System.Drawing.Color.White;
            this.bAzul.Location = new System.Drawing.Point(610, 76);
            this.bAzul.Name = "bAzul";
            this.bAzul.Size = new System.Drawing.Size(75, 23);
            this.bAzul.TabIndex = 6;
            this.bAzul.Text = "Azul";
            this.bAzul.UseVisualStyleBackColor = false;
            this.bAzul.Click += new System.EventHandler(this.bAzul_Click);
            // 
            // bVer
            // 
            this.bVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bVer.Location = new System.Drawing.Point(702, 18);
            this.bVer.Name = "bVer";
            this.bVer.Size = new System.Drawing.Size(75, 23);
            this.bVer.TabIndex = 7;
            this.bVer.Text = "Ver";
            this.bVer.UseVisualStyleBackColor = false;
            this.bVer.Click += new System.EventHandler(this.bVer_Click);
            // 
            // bIr
            // 
            this.bIr.BackColor = System.Drawing.Color.Blue;
            this.bIr.ForeColor = System.Drawing.Color.White;
            this.bIr.Location = new System.Drawing.Point(391, 50);
            this.bIr.Name = "bIr";
            this.bIr.Size = new System.Drawing.Size(140, 20);
            this.bIr.TabIndex = 8;
            this.bIr.Text = "IR a la url";
            this.bIr.UseVisualStyleBackColor = false;
            this.bIr.Click += new System.EventHandler(this.bIr_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(110, 119);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(575, 304);
            this.webBrowser1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.bIr);
            this.Controls.Add(this.bVer);
            this.Controls.Add(this.bAzul);
            this.Controls.Add(this.bVerde);
            this.Controls.Add(this.bRojo);
            this.Controls.Add(this.tBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bBuscar);
            this.Name = "Form1";
            this.Text = "Buscador Google";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBuscar;
        private System.Windows.Forms.Button bRojo;
        private System.Windows.Forms.Button bVerde;
        private System.Windows.Forms.Button bAzul;
        private System.Windows.Forms.Button bVer;
        private System.Windows.Forms.Button bIr;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

