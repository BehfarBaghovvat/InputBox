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
	public partial class Int2Form : Form
	{
		public Int2Form()
		{
			InitializeComponent();
		}

		private void stringListBox_DoubleClick(object sender, EventArgs e)
		{
			Mbb.Utility.InputBox(this, stringListBox, Mbb.InputBoxForm.Input_Type.Text);
		}

		private void intListBox_DoubleClick(object sender, EventArgs e)
		{
			Mbb.Utility.InputBox(this, intListBox, Mbb.InputBoxForm.Input_Type.Number);
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

		private void showInt1Button_Click(object sender, EventArgs e)
		{
			Mbb.Utility.ShowInt1();
			this.Close();
		}
	}
}
