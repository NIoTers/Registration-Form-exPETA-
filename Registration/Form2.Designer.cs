namespace Registration
{
    partial class Form2
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
            this.comboMenu = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.imageShow = new System.Windows.Forms.PictureBox();
            this.titleName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageShow)).BeginInit();
            this.SuspendLayout();
            // 
            // comboMenu
            // 
            this.comboMenu.FormattingEnabled = true;
            this.comboMenu.Location = new System.Drawing.Point(187, 299);
            this.comboMenu.Name = "comboMenu";
            this.comboMenu.Size = new System.Drawing.Size(121, 21);
            this.comboMenu.TabIndex = 0;
            this.comboMenu.SelectedIndexChanged += new System.EventHandler(this.comboMenu_SelectedIndexChanged);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(64, 297);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 1;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(353, 299);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 24);
            this.next.TabIndex = 2;
            this.next.Text = "next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // imageShow
            // 
            this.imageShow.Location = new System.Drawing.Point(64, 60);
            this.imageShow.Name = "imageShow";
            this.imageShow.Size = new System.Drawing.Size(364, 224);
            this.imageShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageShow.TabIndex = 3;
            this.imageShow.TabStop = false;
            // 
            // titleName
            // 
            this.titleName.AutoSize = true;
            this.titleName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleName.Location = new System.Drawing.Point(159, 10);
            this.titleName.Name = "titleName";
            this.titleName.Size = new System.Drawing.Size(0, 32);
            this.titleName.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 366);
            this.Controls.Add(this.titleName);
            this.Controls.Add(this.imageShow);
            this.Controls.Add(this.next);
            this.Controls.Add(this.back);
            this.Controls.Add(this.comboMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Gallery";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboMenu;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.PictureBox imageShow;
        private System.Windows.Forms.Label titleName;
    }
}