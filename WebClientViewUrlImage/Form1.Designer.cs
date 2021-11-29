
namespace WebClientViewUrlImage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PictureBoxView = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TextBoxUrl = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxLoading
            // 
            this.PictureBoxLoading.BackColor = System.Drawing.Color.LightGray;
            this.PictureBoxLoading.Image = global::WebClientViewUrlImage.Properties.Resources.loading;
            this.PictureBoxLoading.Location = new System.Drawing.Point(218, 254);
            this.PictureBoxLoading.Name = "PictureBoxLoading";
            this.PictureBoxLoading.Size = new System.Drawing.Size(32, 32);
            this.PictureBoxLoading.TabIndex = 148;
            this.PictureBoxLoading.TabStop = false;
            this.PictureBoxLoading.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 147;
            this.label1.Tag = "";
            this.label1.Text = "Url Image";
            // 
            // PictureBoxView
            // 
            this.PictureBoxView.BackColor = System.Drawing.Color.LightGray;
            this.PictureBoxView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxView.Location = new System.Drawing.Point(12, 126);
            this.PictureBoxView.Name = "PictureBoxView";
            this.PictureBoxView.Size = new System.Drawing.Size(445, 288);
            this.PictureBoxView.TabIndex = 146;
            this.PictureBoxView.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Silver;
            this.pictureBox2.Location = new System.Drawing.Point(12, 88);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(445, 3);
            this.pictureBox2.TabIndex = 150;
            this.pictureBox2.TabStop = false;
            // 
            // TextBoxUrl
            // 
            this.TextBoxUrl.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxUrl.Location = new System.Drawing.Point(12, 12);
            this.TextBoxUrl.Name = "TextBoxUrl";
            this.TextBoxUrl.Size = new System.Drawing.Size(445, 33);
            this.TextBoxUrl.TabIndex = 151;
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.Transparent;
            this.buttonLoad.FlatAppearance.BorderSize = 2;
            this.buttonLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(179)))), ((int)(((byte)(226)))));
            this.buttonLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(179)))), ((int)(((byte)(226)))));
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLoad.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.buttonLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoad.Location = new System.Drawing.Point(380, 51);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(77, 34);
            this.buttonLoad.TabIndex = 152;
            this.buttonLoad.Text = "load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(469, 426);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.TextBoxUrl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PictureBoxLoading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBoxView);
            this.Name = "Form1";
            this.Text = "Sample WebClient View Url Image";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxLoading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PictureBoxView;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TextBoxUrl;
        private System.Windows.Forms.Button buttonLoad;
    }
}

