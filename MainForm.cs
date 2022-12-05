using System.Text;

namespace DevonsProgrammerCalc
{
    public partial class MainForm : Form
    {
        private long Results;
        private string Error = "";
        private long ResultsNumBase = 10;
        private int ResultsSize = 64;
        private bool ResultsUnsigned;

        public MainForm()
        {
            InitializeComponent();
		}

		private void DisplayResults()
		{
			if (Error.Length > 0)
			{
				// Error
				txtResults.Text = Error;
				return;
			}

			// Get base number to display
			long msb = 1L << (ResultsSize - 1);
			long mask = (ResultsUnsigned ? msb : 0) + (msb - 1);
			long baseNum = Results & mask;
			bool negative = false;
			if (!ResultsUnsigned && (Results & msb) != 0)
			{
				negative = true;
				baseNum = -baseNum & mask;
				if (baseNum == 0)
					baseNum = msb;
			}

			// Convert number to string
			StringBuilder stringBuilder = new StringBuilder();
			while (baseNum != 0)
			{
				stringBuilder.Insert(0, (baseNum % ResultsNumBase).ToString("X1"));
				baseNum /= ResultsNumBase;
			}
			if (stringBuilder.Length == 0)
				stringBuilder.Append("0");

			// Add prefix
			switch (ResultsNumBase)
            {
				case 2:
					// Binary
					stringBuilder.Insert(0, "0b");
					break;

				case 8:
					// Octal
					stringBuilder.Insert(0, "0o");
					break;

				case 16:
					// Hexadecimal
					stringBuilder.Insert(0, "0x");
					break;
            }
			if (negative)
			{
				// Negative sign
				stringBuilder.Insert(0, "-");
			}

			txtResults.Text = stringBuilder.ToString();
		}

		private void InsertButtonText(Button button, string additional)
		{
			if (button != null)
			{
				string text = (button.Text + additional).Replace("&&", "&");
				int selection = txtExpression.SelectionStart;

				StringBuilder stringBuilder = new StringBuilder(txtExpression.Text);
				if (txtExpression.SelectionLength > 0)
					stringBuilder.Remove(selection, txtExpression.SelectionLength);
				stringBuilder.Insert(selection, text);

				txtExpression.Text = stringBuilder.ToString();
				txtExpression.SelectionStart = selection + text.Length;
			}
		}

		private void Button_Insert(object sender, EventArgs e)
		{
			InsertButtonText((Button)sender, "");
		}

		private void Button_InsertFunc(object sender, EventArgs e)
		{
			InsertButtonText((Button)sender, "(");
		}

		private void Button_Equals(object sender, EventArgs e)
		{
			long results;
			Calculator.Calculate(txtExpression.Text, out results, out Error);
			Results = results;
			DisplayResults();
		}

		private void Button_Clear(object sender, EventArgs e)
		{
			txtExpression.Text = "";
			txtResults.Text = "";
		}

		private void Button_Backspace(object sender, EventArgs e)
		{
			int selection = txtExpression.SelectionStart;

			StringBuilder stringBuilder = new StringBuilder(txtExpression.Text);
			if (txtExpression.SelectionLength > 0)
				stringBuilder.Remove(selection, txtExpression.SelectionLength);
			else if (selection > 0)
				stringBuilder.Remove(--selection, 1);

			txtExpression.Text = stringBuilder.ToString();
			txtExpression.SelectionStart = selection;
		}

		private void radioBase16_CheckedChanged(object sender, EventArgs e)
		{
			ResultsNumBase = 16;
			DisplayResults();
		}

		private void radioBase10_CheckedChanged(object sender, EventArgs e)
		{
			ResultsNumBase = 10;
			DisplayResults();
		}

		private void radioBase8_CheckedChanged(object sender, EventArgs e)
		{
			ResultsNumBase = 8;
			DisplayResults();
		}

		private void radioBase2_CheckedChanged(object sender, EventArgs e)
		{
			ResultsNumBase = 2;
			DisplayResults();
		}

		private void radioQword_CheckedChanged(object sender, EventArgs e)
		{
			ResultsSize = 64;
			DisplayResults();
		}

		private void radioDword_CheckedChanged(object sender, EventArgs e)
		{
			ResultsSize = 32;
			DisplayResults();
		}

		private void radioWord_CheckedChanged(object sender, EventArgs e)
		{
			ResultsSize = 16;
			DisplayResults();
		}

		private void radioByte_CheckedChanged(object sender, EventArgs e)
		{
			ResultsSize = 8;
			DisplayResults();
		}

		private void radioSigned_CheckedChanged(object sender, EventArgs e)
		{
			ResultsUnsigned = false;
			DisplayResults();
		}

		private void radioUnsigned_CheckedChanged(object sender, EventArgs e)
		{
			ResultsUnsigned = true;
			DisplayResults();
		}
	}
}