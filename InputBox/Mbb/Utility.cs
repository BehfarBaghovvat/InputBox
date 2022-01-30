namespace Mbb
{
	internal class Utility
	{
		private static InputBox.Int1Form _int1Form;
		private static InputBox.Int1Form Int1Form
		{
			get
			{
				if (_int1Form == null || _int1Form.IsDisposed == true)
				{
					_int1Form =
						new InputBox.Int1Form();
				}

				return _int1Form;
			}
			set
			{
				_int1Form = value;
			}
		}


		private static InputBox.Int2Form _int2Form;
		private static InputBox.Int2Form Int2Form
		{
			get
			{
				if (_int2Form == null || _int2Form.IsDisposed == true)
				{
					_int2Form =
						new InputBox.Int2Form();
				}

				return _int2Form;
			}
			set
			{
				_int2Form = value;
			}
		}


		private static InputBox.String1Form _stirng1Form;
		private static InputBox.String1Form String1Form
		{
			get
			{
				if (_stirng1Form == null || _stirng1Form.IsDisposed == true)
				{
					_stirng1Form =
						new InputBox.String1Form();
				}

				return _stirng1Form;
			}
			set
			{
				_stirng1Form = value;
			}
		}


		private static InputBox.String2Form _stirng2Form;
		private static InputBox.String2Form String2Form
		{
			get
			{
				if (_stirng2Form == null || _stirng2Form.IsDisposed == true)
				{
					_stirng2Form =
						new InputBox.String2Form();
				}

				return _stirng2Form;
			}
			set
			{
				_stirng2Form = value;
			}
		}


		public Utility() : base()
		{

		}

		public static void ShowInt1()
		{
			Int1Form.Show();
		}

		public static void ShowInt2()
		{
			Int2Form.Show();
		}

		public static void ShowString1()
		{
			String1Form.Show();
		}

		public static void ShowString2()
		{
			String2Form.Show();
		}


		public static void InputBox(System.Windows.Forms.Form form, System.Windows.Forms.Label label, InputBoxForm.Input_Type inputType)
		{
			Mbb.InputBoxForm inputBoxForm = new Mbb.InputBoxForm();

			inputBoxForm.SetControl(form, label, inputType);

			inputBoxForm.ShowDialog();
		}

		public static void InputBox(System.Windows.Forms.Form form, System.Windows.Forms.TextBox textBox, InputBoxForm.Input_Type inputType)
		{
			Mbb.InputBoxForm inputBoxForm = new Mbb.InputBoxForm();

			inputBoxForm.SetControl(form, textBox, inputType);

			inputBoxForm.ShowDialog();
		}

		public static void InputBox(System.Windows.Forms.Form form, System.Windows.Forms.ComboBox comboBox, InputBoxForm.Input_Type inputType)
		{
			Mbb.InputBoxForm inputBoxForm = new Mbb.InputBoxForm();

			inputBoxForm.SetControl(form, comboBox, inputType);

			inputBoxForm.ShowDialog();
		}

		public static void InputBox(System.Windows.Forms.Form form, System.Windows.Forms.ListBox listBox, InputBoxForm.Input_Type inputType)
		{
			Mbb.InputBoxForm inputBoxForm = new Mbb.InputBoxForm();

			inputBoxForm.SetControl(form, listBox, inputType);

			inputBoxForm.ShowDialog();
		}
	}
}
