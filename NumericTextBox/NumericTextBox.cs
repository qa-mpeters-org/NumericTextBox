namespace NumericTextBox
{
    public partial class NumericTextBox : TextBox
    {
        public NumericTextBox()
        {
            BackColor = Color.Pink;
            ForeColor = Color.Black;

        }

        public bool HasDecimal { get; set; }

    }
}
