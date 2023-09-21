
namespace ManejoExcepciones
{
    partial class frmprincipal
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
            this.txtUno = new System.Windows.Forms.TextBox();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.txtDos = new System.Windows.Forms.TextBox();
            this.btnUno = new System.Windows.Forms.Button();
            this.lblDiResultado = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUno
            // 
            this.txtUno.Location = new System.Drawing.Point(77, 84);
            this.txtUno.Name = "txtUno";
            this.txtUno.Size = new System.Drawing.Size(138, 20);
            this.txtUno.TabIndex = 0;
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPresentacion.Location = new System.Drawing.Point(66, 37);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(167, 16);
            this.lblPresentacion.TabIndex = 1;
            this.lblPresentacion.Text = "Calculadora de prueba";
            // 
            // txtDos
            // 
            this.txtDos.Location = new System.Drawing.Point(77, 136);
            this.txtDos.Name = "txtDos";
            this.txtDos.Size = new System.Drawing.Size(138, 20);
            this.txtDos.TabIndex = 2;
            // 
            // btnUno
            // 
            this.btnUno.Location = new System.Drawing.Point(97, 185);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(96, 40);
            this.btnUno.TabIndex = 3;
            this.btnUno.Text = "button1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // lblDiResultado
            // 
            this.lblDiResultado.AutoSize = true;
            this.lblDiResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiResultado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDiResultado.Location = new System.Drawing.Point(58, 249);
            this.lblDiResultado.Name = "lblDiResultado";
            this.lblDiResultado.Size = new System.Drawing.Size(182, 15);
            this.lblDiResultado.TabIndex = 4;
            this.lblDiResultado.Text = "El resultado de su operación es:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResult.Location = new System.Drawing.Point(134, 290);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(13, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "=";
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(297, 346);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDiResultado);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.txtDos);
            this.Controls.Add(this.lblPresentacion);
            this.Controls.Add(this.txtUno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora mini";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUno;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.TextBox txtDos;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Label lblDiResultado;
        private System.Windows.Forms.Label lblResult;
    }
}

