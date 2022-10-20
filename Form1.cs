namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string firstname = TbName.Text;
            string lastname = TblastName.Text;
            lbwelcome.Text="Hello "+firstname+" "+lastname+" Nice to meet you!!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TbName.Text="";
            TblastName.Text="";
            lbwelcome.Text="";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbwelcome.Text=""; 
        }

        private void lbwelcome_Click(object sender, EventArgs e)
        {

        }

        private void TblastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string click = clickme.Text;
            huh.Text="Hello!";
           
            
        }
    }
}