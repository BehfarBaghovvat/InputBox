using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputBox
{
	public partial class Int1Form : Form
	{
		public Int1Form()
		{
			InitializeComponent();
		}

		private void stringTextBox_DoubleClick(object sender, EventArgs e)
		{
			Mbb.Utility.InputBox(this, stringTextBox, Mbb.InputBoxForm.Input_Type.Text);
		}

		private void intTextBox_DoubleClick(object sender, EventArgs e)
		{
			Mbb.Utility.InputBox(this, intTextBox, Mbb.InputBoxForm.Input_Type.Number);
		}

		private void showString1Button_Click(object sender, EventArgs e)
		{
			Mbb.Utility.ShowString1();
			this.Close();
		}

		private void showString2Button_Click(object sender, EventArgs e)
		{
			Mbb.Utility.ShowString2();
			this.Close();
		}

		private void showInt2Button_Click(object sender, EventArgs e)
		{
			Mbb.Utility.ShowInt2();
			this.Close();
		}
	}
}
