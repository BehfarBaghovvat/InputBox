namespace InputBox
{
	partial class Int2Form
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
			this.mainPanel = new System.Windows.Forms.Panel();
			this.leftSidePanel = new System.Windows.Forms.Panel();
			this.showInt1Button = new System.Windows.Forms.Button();
			this.showString2Button = new System.Windows.Forms.Button();
			this.showString1Button = new System.Windows.Forms.Button();
			this.titlePanel = new System.Windows.Forms.Panel();
			this.titleLabel = new System.Windows.Forms.Label();
			this.stringListBox = new System.Windows.Forms.ListBox();
			this.intListBox = new System.Windows.Forms.ListBox();
			this.mainPanel.SuspendLayout();
			this.leftSidePanel.SuspendLayout();
			this.titlePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.intListBox);
			this.mainPanel.Controls.Add(this.stringListBox);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(161, 78);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(639, 372);
			this.mainPanel.TabIndex = 6;
			// 
			// leftSidePanel
			// 
			this.leftSidePanel.BackColor = System.Drawing.Color.Aqua;
			this.leftSidePanel.Controls.Add(this.showInt1Button);
			this.leftSidePanel.Controls.Add(this.showString2Button);
			this.leftSidePanel.Controls.Add(this.showString1Button);
			this.leftSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftSidePanel.Location = new System.Drawing.Point(0, 0);
			this.leftSidePanel.Name = "leftSidePanel";
			this.leftSidePanel.Size = new System.Drawing.Size(161, 450);
			this.leftSidePanel.TabIndex = 4;
			// 
			// showInt1Button
			// 
			this.showInt1Button.Location = new System.Drawing.Point(18, 104);
			this.showInt1Button.Name = "showInt1Button";
			this.showInt1Button.Size = new System.Drawing.Size(125, 30);
			this.showInt1Button.TabIndex = 0;
			this.showInt1Button.Text = "فرم عدد شماره یک";
			this.showInt1Button.UseVisualStyleBackColor = true;
			this.showInt1Button.Click += new System.EventHandler(this.showInt1Button_Click);
			// 
			// showString2Button
			// 
			this.showString2Button.Location = new System.Drawing.Point(18, 68);
			this.showString2Button.Name = "showString2Button";
			this.showString2Button.Size = new System.Drawing.Size(125, 30);
			this.showString2Button.TabIndex = 0;
			this.showString2Button.Text = "فرم متن شماره دو";
			this.showString2Button.UseVisualStyleBackColor = true;
			this.showString2Button.Click += new System.EventHandler(this.showString2Button_Click);
			// 
			// showString1Button
			// 
			this.showString1Button.Location = new System.Drawing.Point(18, 32);
			this.showString1Button.Name = "showString1Button";
			this.showString1Button.Size = new System.Drawing.Size(125, 30);
			this.showString1Button.TabIndex = 0;
			this.showString1Button.Text = "فرم متن شماره یک";
			this.showString1Button.UseVisualStyleBackColor = true;
			this.showString1Button.Click += new System.EventHandler(this.showString1Button_Click);
			// 
			// titlePanel
			// 
			this.titlePanel.BackColor = System.Drawing.Color.White;
			this.titlePanel.Controls.Add(this.titleLabel);
			this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titlePanel.Location = new System.Drawing.Point(161, 0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(639, 78);
			this.titlePanel.TabIndex = 5;
			// 
			// titleLabel
			// 
			this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.titleLabel.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.titleLabel.Location = new System.Drawing.Point(0, 0);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(639, 78);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "فرم عددی شماره دو";
			this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// stringListBox
			// 
			this.stringListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.stringListBox.FormattingEnabled = true;
			this.stringListBox.Location = new System.Drawing.Point(60, 63);
			this.stringListBox.Name = "stringListBox";
			this.stringListBox.Size = new System.Drawing.Size(238, 247);
			this.stringListBox.TabIndex = 0;
			this.stringListBox.DoubleClick += new System.EventHandler(this.stringListBox_DoubleClick);
			// 
			// intListBox
			// 
			this.intListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.intListBox.FormattingEnabled = true;
			this.intListBox.Location = new System.Drawing.Point(340, 63);
			this.intListBox.Name = "intListBox";
			this.intListBox.Size = new System.Drawing.Size(238, 247);
			this.intListBox.TabIndex = 1;
			this.intListBox.DoubleClick += new System.EventHandler(this.intListBox_DoubleClick);
			// 
			// Int2Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.titlePanel);
			this.Controls.Add(this.leftSidePanel);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Int2Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Int2Form";
			this.mainPanel.ResumeLayout(false);
			this.leftSidePanel.ResumeLayout(false);
			this.titlePanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel leftSidePanel;
        private System.Windows.Forms.Button showInt1Button;
        private System.Windows.Forms.Button showString2Button;
        private System.Windows.Forms.Button showString1Button;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ListBox intListBox;
        private System.Windows.Forms.ListBox stringListBox;
    }
}