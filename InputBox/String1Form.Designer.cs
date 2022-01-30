namespace InputBox
{
	partial class String1Form
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
			this.stringLabel = new System.Windows.Forms.Label();
			this.intLabel = new System.Windows.Forms.Label();
			this.leftSidePanel = new System.Windows.Forms.Panel();
			this.showString2Button = new System.Windows.Forms.Button();
			this.showInt1Button = new System.Windows.Forms.Button();
			this.showInt2Button = new System.Windows.Forms.Button();
			this.titlePanel = new System.Windows.Forms.Panel();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.titleLabel = new System.Windows.Forms.Label();
			this.leftSidePanel.SuspendLayout();
			this.titlePanel.SuspendLayout();
			this.mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// stringLabel
			// 
			this.stringLabel.AutoSize = true;
			this.stringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.stringLabel.Location = new System.Drawing.Point(126, 93);
			this.stringLabel.Name = "stringLabel";
			this.stringLabel.Size = new System.Drawing.Size(386, 76);
			this.stringLabel.TabIndex = 0;
			this.stringLabel.Text = "String Label";
			this.stringLabel.DoubleClick += new System.EventHandler(this.stringLabel_DoubleClick);
			// 
			// intLabel
			// 
			this.intLabel.AutoSize = true;
			this.intLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.intLabel.Location = new System.Drawing.Point(174, 204);
			this.intLabel.Name = "intLabel";
			this.intLabel.Size = new System.Drawing.Size(287, 76);
			this.intLabel.TabIndex = 0;
			this.intLabel.Text = "Int Label";
			this.intLabel.DoubleClick += new System.EventHandler(this.intLabel_DoubleClick);
			// 
			// leftSidePanel
			// 
			this.leftSidePanel.BackColor = System.Drawing.Color.Aqua;
			this.leftSidePanel.Controls.Add(this.showInt2Button);
			this.leftSidePanel.Controls.Add(this.showInt1Button);
			this.leftSidePanel.Controls.Add(this.showString2Button);
			this.leftSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftSidePanel.Location = new System.Drawing.Point(0, 0);
			this.leftSidePanel.Name = "leftSidePanel";
			this.leftSidePanel.Size = new System.Drawing.Size(161, 450);
			this.leftSidePanel.TabIndex = 1;
			// 
			// showString2Button
			// 
			this.showString2Button.Location = new System.Drawing.Point(18, 32);
			this.showString2Button.Name = "showString2Button";
			this.showString2Button.Size = new System.Drawing.Size(125, 30);
			this.showString2Button.TabIndex = 0;
			this.showString2Button.Text = "فرم متن شماره دو";
			this.showString2Button.UseVisualStyleBackColor = true;
			this.showString2Button.Click += new System.EventHandler(this.showString2Button_Click);
			// 
			// showInt1Button
			// 
			this.showInt1Button.Location = new System.Drawing.Point(18, 68);
			this.showInt1Button.Name = "showInt1Button";
			this.showInt1Button.Size = new System.Drawing.Size(125, 30);
			this.showInt1Button.TabIndex = 0;
			this.showInt1Button.Text = "فرم عدد شماره یک";
			this.showInt1Button.UseVisualStyleBackColor = true;
			this.showInt1Button.Click += new System.EventHandler(this.showInt1Button_Click);
			// 
			// showInt2Button
			// 
			this.showInt2Button.Location = new System.Drawing.Point(18, 104);
			this.showInt2Button.Name = "showInt2Button";
			this.showInt2Button.Size = new System.Drawing.Size(125, 30);
			this.showInt2Button.TabIndex = 0;
			this.showInt2Button.Text = "فرم عدد شماره دو";
			this.showInt2Button.UseVisualStyleBackColor = true;
			this.showInt2Button.Click += new System.EventHandler(this.showInt2Button_Click);
			// 
			// titlePanel
			// 
			this.titlePanel.BackColor = System.Drawing.Color.White;
			this.titlePanel.Controls.Add(this.titleLabel);
			this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titlePanel.Location = new System.Drawing.Point(161, 0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(639, 78);
			this.titlePanel.TabIndex = 2;
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.stringLabel);
			this.mainPanel.Controls.Add(this.intLabel);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(161, 78);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(639, 372);
			this.mainPanel.TabIndex = 3;
			// 
			// titleLabel
			// 
			this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.titleLabel.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.titleLabel.Location = new System.Drawing.Point(0, 0);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(639, 78);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "فرم شماره یک";
			this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// String1Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.titlePanel);
			this.Controls.Add(this.leftSidePanel);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "String1Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "String1Form";
			this.leftSidePanel.ResumeLayout(false);
			this.titlePanel.ResumeLayout(false);
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Label stringLabel;
		public System.Windows.Forms.Label intLabel;
        private System.Windows.Forms.Panel leftSidePanel;
        private System.Windows.Forms.Button showInt2Button;
        private System.Windows.Forms.Button showInt1Button;
        private System.Windows.Forms.Button showString2Button;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel mainPanel;
    }
}