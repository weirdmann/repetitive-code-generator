using System;
using System.Text;

namespace patternsolver
{
    public partial class Form1 : Form
    {
        private bool values_are_correct = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Process()
        {
            values_are_correct = false;

            if (start_value.Text.Length <= 0) return;
            if (end_value.Text.Length <= 0) return;
            if (pattern.Text.Length <= 0) return;

            int start_val, end_val;

            try
            {
                start_val = int.Parse(start_value.Text);
                end_val = int.Parse(end_value.Text);
            }
            catch (Exception ex)
            {
                output.Text = ex.Message;
                copy_to_clip.Enabled = values_are_correct;
                return;
            }

            values_are_correct = true;
            copy_to_clip.Enabled = values_are_correct;

            StringBuilder sb = new();
            StringBuilder c = new();
            for (int i = start_val; i <= end_val; i++)
            {
                c.Clear();
                c.Append(pattern.Text);

                for (int j = 1; j <= 10; j++)
                {
                    c.Replace($"&ip{j}", $"{i + j}");
                    c.Replace($"&im{j}", $"{i - j}");
                }

                c.Replace("&i", i.ToString());
                c.Append(Environment.NewLine);
                sb.Append(c.ToString());
            }

            output.Text = sb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Process();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Process();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Process();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void copy_to_clip_Click(object sender, EventArgs e)
        {
            if (values_are_correct)
            {
                Clipboard.SetText(output.Text);
            }
        }
    }
}