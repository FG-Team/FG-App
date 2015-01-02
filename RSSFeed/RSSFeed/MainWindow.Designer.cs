namespace RSSFeed_Test
{
    partial class MainWindow
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
            this.GetButton = new System.Windows.Forms.Button();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.DownloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.AuthorTextLabel = new System.Windows.Forms.Label();
            this.URLLabel = new System.Windows.Forms.Label();
            this.URLTextLabel = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.CountTextLabel = new System.Windows.Forms.Label();
            this.PublishedLabel = new System.Windows.Forms.Label();
            this.PublishedTextLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextLabel = new System.Windows.Forms.Label();
            this.NewestLabel = new System.Windows.Forms.Label();
            this.NewestTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetButton
            // 
            this.GetButton.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetButton.Location = new System.Drawing.Point(831, 23);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(75, 34);
            this.GetButton.TabIndex = 0;
            this.GetButton.Text = "Get";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTextBox.Location = new System.Drawing.Point(44, 27);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(781, 26);
            this.InputTextBox.TabIndex = 1;
            // 
            // DownloadProgressBar
            // 
            this.DownloadProgressBar.Location = new System.Drawing.Point(44, 63);
            this.DownloadProgressBar.Name = "DownloadProgressBar";
            this.DownloadProgressBar.Size = new System.Drawing.Size(781, 23);
            this.DownloadProgressBar.TabIndex = 3;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.Location = new System.Drawing.Point(40, 94);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(62, 21);
            this.AuthorLabel.TabIndex = 4;
            this.AuthorLabel.Text = "Author";
            // 
            // AuthorTextLabel
            // 
            this.AuthorTextLabel.AutoSize = true;
            this.AuthorTextLabel.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorTextLabel.Location = new System.Drawing.Point(148, 95);
            this.AuthorTextLabel.Name = "AuthorTextLabel";
            this.AuthorTextLabel.Size = new System.Drawing.Size(78, 20);
            this.AuthorTextLabel.TabIndex = 5;
            this.AuthorTextLabel.Text = "<Author>";
            // 
            // URLLabel
            // 
            this.URLLabel.AutoSize = true;
            this.URLLabel.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLLabel.Location = new System.Drawing.Point(40, 115);
            this.URLLabel.Name = "URLLabel";
            this.URLLabel.Size = new System.Drawing.Size(40, 21);
            this.URLLabel.TabIndex = 6;
            this.URLLabel.Text = "URL";
            // 
            // URLTextLabel
            // 
            this.URLTextLabel.AutoSize = true;
            this.URLTextLabel.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLTextLabel.Location = new System.Drawing.Point(148, 115);
            this.URLTextLabel.Name = "URLTextLabel";
            this.URLTextLabel.Size = new System.Drawing.Size(56, 20);
            this.URLTextLabel.TabIndex = 7;
            this.URLTextLabel.Text = "<URL>";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLabel.Location = new System.Drawing.Point(40, 136);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(56, 21);
            this.CountLabel.TabIndex = 8;
            this.CountLabel.Text = "Count";
            // 
            // CountTextLabel
            // 
            this.CountTextLabel.AutoSize = true;
            this.CountTextLabel.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountTextLabel.Location = new System.Drawing.Point(148, 135);
            this.CountTextLabel.Name = "CountTextLabel";
            this.CountTextLabel.Size = new System.Drawing.Size(72, 20);
            this.CountTextLabel.TabIndex = 9;
            this.CountTextLabel.Text = "<Count>";
            // 
            // PublishedLabel
            // 
            this.PublishedLabel.AutoSize = true;
            this.PublishedLabel.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublishedLabel.Location = new System.Drawing.Point(40, 157);
            this.PublishedLabel.Name = "PublishedLabel";
            this.PublishedLabel.Size = new System.Drawing.Size(81, 21);
            this.PublishedLabel.TabIndex = 10;
            this.PublishedLabel.Text = "Published";
            // 
            // PublishedTextLabel
            // 
            this.PublishedTextLabel.AutoSize = true;
            this.PublishedTextLabel.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublishedTextLabel.Location = new System.Drawing.Point(148, 155);
            this.PublishedTextLabel.Name = "PublishedTextLabel";
            this.PublishedTextLabel.Size = new System.Drawing.Size(96, 20);
            this.PublishedTextLabel.TabIndex = 11;
            this.PublishedTextLabel.Text = "<Published>";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(40, 176);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(96, 21);
            this.DescriptionLabel.TabIndex = 12;
            this.DescriptionLabel.Text = "Description";
            // 
            // DescriptionTextLabel
            // 
            this.DescriptionTextLabel.AutoSize = true;
            this.DescriptionTextLabel.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTextLabel.Location = new System.Drawing.Point(148, 176);
            this.DescriptionTextLabel.Name = "DescriptionTextLabel";
            this.DescriptionTextLabel.Size = new System.Drawing.Size(108, 20);
            this.DescriptionTextLabel.TabIndex = 13;
            this.DescriptionTextLabel.Text = "<Description>";
            // 
            // NewestLabel
            // 
            this.NewestLabel.AutoSize = true;
            this.NewestLabel.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewestLabel.Location = new System.Drawing.Point(40, 197);
            this.NewestLabel.Name = "NewestLabel";
            this.NewestLabel.Size = new System.Drawing.Size(66, 21);
            this.NewestLabel.TabIndex = 14;
            this.NewestLabel.Text = "Newest";
            // 
            // NewestTextLabel
            // 
            this.NewestTextLabel.AutoSize = true;
            this.NewestTextLabel.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewestTextLabel.Location = new System.Drawing.Point(148, 198);
            this.NewestTextLabel.Name = "NewestTextLabel";
            this.NewestTextLabel.Size = new System.Drawing.Size(82, 20);
            this.NewestTextLabel.TabIndex = 15;
            this.NewestTextLabel.Text = "<Newest>";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 262);
            this.Controls.Add(this.NewestTextLabel);
            this.Controls.Add(this.NewestLabel);
            this.Controls.Add(this.DescriptionTextLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.PublishedTextLabel);
            this.Controls.Add(this.PublishedLabel);
            this.Controls.Add(this.CountTextLabel);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.URLTextLabel);
            this.Controls.Add(this.URLLabel);
            this.Controls.Add(this.AuthorTextLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.DownloadProgressBar);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.GetButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "RSS Feed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.ProgressBar DownloadProgressBar;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label AuthorTextLabel;
        private System.Windows.Forms.Label URLLabel;
        private System.Windows.Forms.Label URLTextLabel;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label CountTextLabel;
        private System.Windows.Forms.Label PublishedLabel;
        private System.Windows.Forms.Label PublishedTextLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label DescriptionTextLabel;
        private System.Windows.Forms.Label NewestLabel;
        private System.Windows.Forms.Label NewestTextLabel;
    }
}

