namespace MyFirst_WindowsFormApp
{
    partial class MessageBoxForm3
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnshowMessagetitle = new System.Windows.Forms.Button();
            this.btnMTB = new System.Windows.Forms.Button();
            this.MTBI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "showMessage";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnshowMessagetitle
            // 
            this.btnshowMessagetitle.Location = new System.Drawing.Point(48, 136);
            this.btnshowMessagetitle.Name = "btnshowMessagetitle";
            this.btnshowMessagetitle.Size = new System.Drawing.Size(229, 70);
            this.btnshowMessagetitle.TabIndex = 1;
            this.btnshowMessagetitle.Text = "showMessage+title";
            this.btnshowMessagetitle.UseVisualStyleBackColor = true;
            this.btnshowMessagetitle.Click += new System.EventHandler(this.btnshowMessagetitle_Click);
            // 
            // btnMTB
            // 
            this.btnMTB.Location = new System.Drawing.Point(48, 243);
            this.btnMTB.Name = "btnMTB";
            this.btnMTB.Size = new System.Drawing.Size(229, 70);
            this.btnMTB.TabIndex = 2;
            this.btnMTB.Text = "Message+title+btn";
            this.btnMTB.UseVisualStyleBackColor = true;
            this.btnMTB.Click += new System.EventHandler(this.btnMTB_Click);
            // 
            // MTBI
            // 
            this.MTBI.Location = new System.Drawing.Point(48, 350);
            this.MTBI.Name = "MTBI";
            this.MTBI.Size = new System.Drawing.Size(229, 70);
            this.MTBI.TabIndex = 3;
            this.MTBI.Text = "Message+title+btn+icon";
            this.MTBI.UseVisualStyleBackColor = true;
            this.MTBI.Click += new System.EventHandler(this.MTBI_Click);
            // 
            // MessageBoxForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MTBI);
            this.Controls.Add(this.btnMTB);
            this.Controls.Add(this.btnshowMessagetitle);
            this.Controls.Add(this.button1);
            this.Name = "MessageBoxForm3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnshowMessagetitle;
        private System.Windows.Forms.Button btnMTB;
        private System.Windows.Forms.Button MTBI;
    }
}