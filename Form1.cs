namespace Hello_C__Love
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am Button 3", "hello!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am Button 2!!!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello This Is My First C# Code and I am Really Happy!!!!!");
            // there is no limitation in Multiple msgges or msg Box

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Yellow;
            button2.BackColor = Color.Green;
            // if we want to access the property of the form we have to write this keyword first
            // in case of if we want to access or changing the color  but we can directly access
            // from "form1." some property
            this.BackColor = Color.Red;
            button4.ForeColor = Color.Red;
            // for button4.Color-> this type of property we dont have.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "hello I'am Aniket";
            this.button3.Text = "Hi Babes!";
            this.Text = "hello coding control Form Welcome!!!";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = false;
            // this.Enabled = false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //this will shows in text box continue current time
            this.textBox2.Text = DateTime.Now.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //this.textBox2.Text = DateTime.Now.ToString();
            //here we can use multiple "Now" property
            //this.textBox2.Text=DateTime.Now.DayOfWeek.ToString();
            //this.textBox2.Text = DateTime.Now.DayOfYear.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.textBox3.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + ":" + DateTime.Now.Millisecond.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.timer2.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.timer2.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Do you want to Continue?","Finish",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1,MessageBoxOptions.DefaultDesktopOnly);
            MessageBox.Show("Done!");
        }

        private void button12_Click(object sender, EventArgs e)
        {
           // this.pictureBox1.Image = Image.FromFile("C:\\Users\\anike\\OneDrive\\Pictures\\Screenshots\\originalanime.png");
         this.pictureBox1.BackgroundImage = Image.FromFile("C:\\Users\\anike\\OneDrive\\Pictures\\Screenshots\\originalanime.png");
         this.BackgroundImage= Image.FromFile("C:\\Users\\anike\\OneDrive\\Pictures\\Screenshots\\originalanime.png");
        }
    }
}
