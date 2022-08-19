namespace UÇUÞPANELÝ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text.ToUpper()+ " " + maskedTextBox2.Text + " " + maskedTextBox3.Text);
            listBox1.Items.Add("ROTA:" + comboBox1.Text + "-" + comboBox2.Text + "-"+ "TARÝH:" + dateTimePicker1.Text + "-"+ "SAAT:" + maskedTextBox1.Text);
            MessageBox.Show("YOLCU KAYDI YAPILDI");
         

        }

       
    }
}