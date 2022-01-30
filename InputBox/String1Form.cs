using Mbb;
using System;
using System.Windows.Forms;

namespace InputBox
{
	public partial class String1Form : System.Windows.Forms.Form
	{
		public enum Input_Type
		{
			OnlyText,
			Only_Number,
		}

		public Input_Type InputType
		{
			get; set;
		}

		public String1Form()
		{
			InitializeComponent();
		}

		private void stringLabel_DoubleClick(object sender, System.EventArgs e)
		{
			Mbb.Utility.InputBox(this, stringLabel, InputBoxForm.Input_Type.Text);
		}

		private void intLabel_DoubleClick(object sender, System.EventArgs e)
		{
			Mbb.Utility.InputBox(this, intLabel, InputBoxForm.Input_Type.Number);
		}	

		private void showString2Button_Click(object sender, EventArgs e)
		{
			Mbb.Utility.ShowString2();
			this.Hide();
		}

		private void showInt1Button_Click(object sender, EventArgs e)
		{
			Mbb.Utility.ShowInt1();
			this.Hide();
		}

		private void showInt2Button_Click(object sender, EventArgs e)
		{
			Mbb.Utility.ShowInt2();
			this.Hide();
		}
	}
}
