namespace windowsFormApp_C_Ass1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ComoBox.Items.Add(TextBox.Text);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox.Items.Add(ComoBox.SelectedItem);
        }
    }
}
