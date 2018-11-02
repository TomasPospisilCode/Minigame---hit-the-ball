namespace minihra
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.poleKulicek = new System.Windows.Forms.TextBox();
            this.poleZasahu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.casovac = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 320);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // poleKulicek
            // 
            this.poleKulicek.Location = new System.Drawing.Point(81, 339);
            this.poleKulicek.Name = "poleKulicek";
            this.poleKulicek.ReadOnly = true;
            this.poleKulicek.Size = new System.Drawing.Size(100, 20);
            this.poleKulicek.TabIndex = 1;
            this.poleKulicek.Text = "0";
            // 
            // poleZasahu
            // 
            this.poleZasahu.Location = new System.Drawing.Point(266, 339);
            this.poleZasahu.Name = "poleZasahu";
            this.poleZasahu.ReadOnly = true;
            this.poleZasahu.Size = new System.Drawing.Size(100, 20);
            this.poleZasahu.TabIndex = 2;
            this.poleZasahu.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kuliček:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zásahů:";
            // 
            // casovac
            // 
            this.casovac.Enabled = true;
            this.casovac.Interval = 1000;
            this.casovac.Tick += new System.EventHandler(this.casovac_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 371);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.poleZasahu);
            this.Controls.Add(this.poleKulicek);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox poleKulicek;
        private System.Windows.Forms.TextBox poleZasahu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer casovac;
    }
}

