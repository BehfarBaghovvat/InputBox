namespace InputBox
{
	partial class String2Form
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
			this.intComboBox = new System.Windows.Forms.ComboBox();
			this.stringComboBox = new System.Windows.Forms.ComboBox();
			this.leftSidePanel = new System.Windows.Forms.Panel();
			this.showInt2Button = new System.Windows.Forms.Button();
			this.showInt1Button = new System.Windows.Forms.Button();
			this.showString1Button = new System.Windows.Forms.Button();
			this.titlePanel = new System.Windows.Forms.Panel();
			this.titleLabel = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			this.leftSidePanel.SuspendLayout();
			this.titlePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.intComboBox);
			this.mainPanel.Controls.Add(this.stringComboBox);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(161, 78);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(639, 372);
			this.mainPanel.TabIndex = 6;
			// 
			// intComboBox
			// 
			this.intComboBox.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.intComboBox.FormattingEnabled = true;
			this.intComboBox.Location = new System.Drawing.Point(201, 154);
			this.intComboBox.Name = "intComboBox";
			this.intComboBox.Size = new System.Drawing.Size(237, 32);
			this.intComboBox.TabIndex = 2;
			this.intComboBox.Click += new System.EventHandler(this.intComboBox_Click);
			this.intComboBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.intComboBox_MouseDoubleClick);
			// 
			// stringComboBox
			// 
			this.stringComboBox.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.stringComboBox.FormattingEnabled = true;
			this.stringComboBox.Location = new System.Drawing.Point(201, 77);
			this.stringComboBox.Name = "stringComboBox";
			this.stringComboBox.Size = new System.Drawing.Size(237, 32);
			this.stringComboBox.TabIndex = 3;
			this.stringComboBox.Click += new System.EventHandler(this.stringComboBox_Click);
			this.stringComboBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.stringComboBox_MouseDoubleClick);
			// 
			// leftSidePanel
			// 
			this.leftSidePanel.BackColor = System.Drawing.Color.Aqua;
			this.leftSidePanel.Controls.Add(this.showInt2Button);
			this.leftSidePanel.Controls.Add(this.showInt1Button);
			this.leftSidePanel.Controls.Add(this.showString1Button);
			this.leftSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftSidePanel.Location = new System.Drawing.Point(0, 0);
			this.leftSidePanel.Name = "leftSidePanel";
			this.leftSidePanel.Size = new System.Drawing.Size(161, 450);
			this.leftSidePanel.TabIndex = 4;
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
			this.titleLabel.Text = "فرم متن شماره دو";
			this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// String2Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.titlePanel);
			this.Controls.Add(this.leftSidePanel);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "String2Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "String2Form";
			this.mainPanel.ResumeLayout(false);
			this.leftSidePanel.ResumeLayout(false);
			this.titlePanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel leftSidePanel;
        private System.Windows.Forms.Button showInt2Button;
        private System.Windows.Forms.Button showInt1Button;
        private System.Windows.Forms.Button showString1Button;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox intComboBox;
        private System.Windows.Forms.ComboBox stringComboBox;
    }
}