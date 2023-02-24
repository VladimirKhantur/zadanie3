using System.Diagnostics;
using System.Text;

namespace zadanie3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string v1 = textBox1.Text;
            string v2 = textBox2.Text;
            string ans2 = "";
            int n = int.Parse(textBox3.Text);
            int k = v1.Length + v2.Length;
            int st =(int)( k / Math.Pow(2, n));
            string ans1 = new string('0', degree2(k));

            for(int i = 0; i < v1.Length; i += st)
            {
                ans2 += v1.Substring(i, st);
                ans2 += v2.Substring(i, st);
            }

            for(int i = 0; i < k; i++)
            {
                dataGridView1.Rows.Add(ans1, ans2[i]);
                ans1 = step(ans1);
            }


            
        }

        private int degree2(int k)
        {

            int c = 0;

            while (k / 2 != 0) {
                c++;
                k = k / 2;
                    }

            return c; 
        }
        string step(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            int k = s.LastIndexOf('0');
            if (k != -1)
            {
                int sub = s.Length - (k + 1);
                sb[k] = '1';
                s = sb.ToString();
                s = s.Remove(k + 1);
                s += new string('0', sub);
            }
            return s;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}