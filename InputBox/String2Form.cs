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
	public partial class String2Form : Form
	{
		public String2Form()
		{
			InitializeComponent();
		}

		private void stringComboBox_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			
		}

		private void intComboBox_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			
		}

		private void showString1Button_Click(object sender, EventArgs e)
		{
			Mbb.Utility.ShowString1();
			this.Close();
		}

		private void showInt1Button_Click(object sender, EventArgs e)
		{
			Mbb.Utility.ShowInt1();
			this.Close();
		}

		private void showInt2Button_Click(object sender, EventArgs e)
		{
			Mbb.Utility.ShowInt2();
			this.Close();
		}

		private void stringComboBox_Click(object sender, EventArgs e)
		{
			Mbb.Utility.InputBox(this, stringComboBox, Mbb.InputBoxForm.Input_Type.Text);
		}

		private void intComboBox_Click(object sender, EventArgs e)
		{
			Mbb.Utility.InputBox(this, intComboBox, Mbb.InputBoxForm.Input_Type.Number);
		}
	}
}
