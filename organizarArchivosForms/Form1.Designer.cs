namespace organizarArchivosForms
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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.tvArchivos = new System.Windows.Forms.TreeView();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrganizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(12, 12);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // tvArchivos
            // 
            this.tvArchivos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tvArchivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvArchivos.Location = new System.Drawing.Point(12, 41);
            this.tvArchivos.Name = "tvArchivos";
            this.tvArchivos.Size = new System.Drawing.Size(452, 386);
            this.tvArchivos.TabIndex = 1;
            this.tvArchivos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvArchivos_AfterSelect);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(94, 14);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(694, 20);
            this.txtRuta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = " ";
            // 
            // btnOrganizar
            // 
            this.btnOrganizar.Location = new System.Drawing.Point(504, 52);
            this.btnOrganizar.Name = "btnOrganizar";
            this.btnOrganizar.Size = new System.Drawing.Size(214, 60);
            this.btnOrganizar.TabIndex = 4;
            this.btnOrganizar.Text = "Organizar";
            this.btnOrganizar.UseVisualStyleBackColor = true;
            this.btnOrganizar.Click += new System.EventHandler(this.btnOrganizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOrganizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.tvArchivos);
            this.Controls.Add(this.btnAbrir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.TreeView tvArchivos;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrganizar;
    }
}

