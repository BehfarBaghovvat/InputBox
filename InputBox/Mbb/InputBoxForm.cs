

namespace Mbb
{
	public partial class InputBoxForm : System.Windows.Forms.Form
	{

		//------------------------------------------- Field, Properties, Layers

		public enum Input_Type
		{
			Text,
			Number,
		}

		public class GetInputType
		{
			public int Number_Value
			{
				get; set;
			}

			public string Text_Value
			{
				get; set;
			}
		}

		private System.Windows.Forms.Form myForm;
		public System.Windows.Forms.Form MyForm
		{
			get
			{
				if (myForm == null || myForm.IsDisposed == true)
				{
					myForm =
						new System.Windows.Forms.Form();
				}
				return myForm;
			}
			set
			{
				myForm = value;
			}
		}


		private System.Windows.Forms.Label myLabel;
		public System.Windows.Forms.Label MyLabel
		{
			get
			{
				return myLabel;
			}
			set
			{
				myLabel = value;
			}
		}


		private System.Windows.Forms.TextBox myTextBox;
		public System.Windows.Forms.TextBox MyTextBox
		{
			get
			{
				return myTextBox;
			}
			set
			{
				myTextBox = value;
			}
		}


		private System.Windows.Forms.ComboBox _comboBox;
		public System.Windows.Forms.ComboBox MyComboBox
		{
			get
			{
				return _comboBox;
			}
			set
			{
				_comboBox = value;
			}
		}


		private System.Windows.Forms.ListBox _myListBox;
		public System.Windows.Forms.ListBox MyListBox
		{
			get
			{
				return _myListBox;
			}
			set
			{
				_myListBox = value;
			}
		}


		private System.Windows.Forms.Control _myControls;
		public System.Windows.Forms.Control MyControls
		{
			get
			{
				return _myControls;
			}
			set
			{
				_myControls = value;
			}

		}


		public Input_Type InputType
		{
			get; set;
		}

		private GetInputType _getInputType;
		public GetInputType Get_Input_Type
		{
			get
			{
				if (_getInputType == null)
				{
					_getInputType =
						new GetInputType();
				}
				return _getInputType;
			}
			set
			{
				_getInputType = value;
			}
		}




		//------------------------------------------- Constructure
		public InputBoxForm()
		{
			InitializeComponent();
		}


		//------------------------------------------- Event Controls

		private void inputTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (InputType == Input_Type.Text)
			{
				TextTyping(e);
			}
			else
			{
				NumberTyping(e);
			}
		}

		private void inputTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(inputTextBox.Text))
			{
				return;
			}
			else
			{
				if (InputType == Input_Type.Text)
				{
					Get_Input_Type.Text_Value = inputTextBox.Text;
				}
				else
				{
					try
					{
						Get_Input_Type.Number_Value = int.Parse(inputTextBox.Text);
					}
					catch (System.Exception ex)
					{
						System.Windows.Forms.MessageBox.Show($"{ex.Message}");
					}
				}
			}
		}

		private void okButton_Click(object sender, System.EventArgs e)
		{
			if (MyControls.Equals(MyLabel))
			{
				MyLabel.Text = GetValue(Get_Input_Type);
			}
			else if (MyControls.Equals(MyTextBox))
			{
				MyTextBox.Text = GetValue(Get_Input_Type);
			}
			else if (MyControls.Equals(MyListBox))
			{
				MyListBox.Items.Add(GetValue(Get_Input_Type));
			}
			else if (MyControls.Equals(MyComboBox))
			{
				MyComboBox.Items.Add(GetValue(Get_Input_Type));
			}

			MyControls.Controls.Clear();
			this.Dispose();
		}

		private void cancelButton_Click(object sender, System.EventArgs e)
		{

		}



		//------------------------------------------- Methods

		private string GetValue(GetInputType get_Input_Type)
		{
			if (InputType == Input_Type.Text)
			{
				return get_Input_Type.Text_Value;
			}
			else
			{
				return get_Input_Type.Number_Value.ToString();
			}
		}

		private static void NumberTyping(System.Windows.Forms.KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}

		private static void PersianLanguage()
		{
			System.Threading.Thread.CurrentThread.CurrentCulture =
				new System.Globalization.CultureInfo("fa-ir");

			System.Threading.Thread.CurrentThread.CurrentUICulture =
				System.Threading.Thread.CurrentThread.CurrentCulture;

			System.Windows.Forms.InputLanguage.CurrentInputLanguage =
				System.Windows.Forms.InputLanguage.FromCulture(new System.Globalization.CultureInfo("fa-ir"));
		}

		public static void TextTyping(System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar > 'a' && e.KeyChar <= 'z') || (e.KeyChar > 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9'))
			{
				e.Handled = true;
			}
		}

		public void Initialize(Input_Type _inputType)
		{
			PersianLanguage();

			InputType = _inputType;

			if (_inputType == Input_Type.Text)
			{
				notificationTypeLabel.Text = "لطفا نام کالای/گروه خود را وارد نمایید.";
			}
			else
			{
				notificationTypeLabel.Text = "لطفا عدد خود را وارد نمایید.";
			}
		}

		public void SetControl(System.Windows.Forms.Form form, System.Windows.Forms.Label label, Input_Type _inputType)
		{
			MyForm = form;

			MyLabel = label;

			MyControls = label;

			Initialize(_inputType);
		}

		public void SetControl(System.Windows.Forms.Form form, System.Windows.Forms.TextBox textBox, Input_Type _inputType)
		{
			MyForm = form;

			MyTextBox = textBox;

			MyControls = textBox;

			Initialize(_inputType);
		}

		public void SetControl(System.Windows.Forms.Form form, System.Windows.Forms.ComboBox comboBox, Input_Type _inputType)
		{
			MyForm = form;

			MyComboBox = comboBox;

			MyControls = comboBox;

			Initialize(_inputType);
		}

		public void SetControl(System.Windows.Forms.Form form, System.Windows.Forms.ListBox listBox, Input_Type _inputType)
		{
			MyForm = form;

			MyListBox = listBox;

			MyControls = listBox;

			Initialize(_inputType);
		}

		public void SetControl(System.Windows.Forms.Form form, System.Windows.Forms.Control control, Input_Type _inputType)
		{
			MyForm = form;

			MyControls = control;

			Initialize(_inputType);
		}

		
	}
}
