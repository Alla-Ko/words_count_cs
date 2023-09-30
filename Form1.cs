using System.Text.RegularExpressions;

namespace WinFormsApp1_ui
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

        private void button1_Click(object sender, EventArgs e)
        {
            String slova = "àáâã´äåºæç³è¿éêëìíîïğñòîóôõö÷øùüşÿabcdefghijklmnopqrstuvwxyz ";
            String text=this.textBox1.Text;
            text = text.ToLower();
            String text1="";
            for(int i = 0; i < text.Length;i++)
            {
                if (slova.IndexOf(text[i])!=-1){
                    text1 = text1 + text[i];
                }
                if (text[i]== '\n') text1 = text1 + " ";

            }
            text = text1;
            if (text.Length == 0)
            {
                this.label_kk.Text = "0";
                return;
            }
            else
            {
                while (text[0] == ' ')
                {
                    text = text.Remove(0, 1);

                    if (text.Length == 0)
                    {
                        this.label_kk.Text = "0";
                        return;
                    }
                    
                }
                if (text.Length > 1)
                {
                    while (text[text.Length - 1] == ' ')
                    {
                        text = text.Remove(text.Length - 1, 1);
                        if (text.Length <= 1) break;
                    }

                }
                while (text.IndexOf("  ") != -1)
                {
                    text = text.Remove(text.IndexOf("  "), 1);
                }
                int amount = new Regex(" ").Matches(text).Count + 1;


                this.label_kk.Text = amount.ToString();
            }
           
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.label_kk.Text = "";
        }
    }
}