
namespace CapaVista
{
    partial class Consulta
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
            this.tablaregistros = new System.Windows.Forms.DataGridView();
            this.btn_consulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaregistros)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaregistros
            // 
            this.tablaregistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaregistros.Location = new System.Drawing.Point(29, 221);
            this.tablaregistros.Name = "tablaregistros";
            this.tablaregistros.Size = new System.Drawing.Size(739, 217);
            this.tablaregistros.TabIndex = 0;
            // 
            // btn_consulta
            // 
            this.btn_consulta.Location = new System.Drawing.Point(590, 76);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(155, 68);
            this.btn_consulta.TabIndex = 1;
            this.btn_consulta.Text = "Consulta";
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.button1_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.tablaregistros);
            this.Name = "Consulta";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.tablaregistros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaregistros;
        private System.Windows.Forms.Button btn_consulta;
    }
}