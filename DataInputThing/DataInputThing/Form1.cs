namespace DataInputThing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            tbOutput.Text = tbInput.Text.Replace("\r\n", ";");
        }
    }
}