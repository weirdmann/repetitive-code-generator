using System;
using System.Text;

namespace patternsolver
{
    public partial class Form1 : Form
    {
        private bool values_are_correct = false;
        private bool padding_enabled = false;
        private char escape_character = '&';
        public Form1()
        {
            InitializeComponent();
        }

        private void EnableButtons(bool enable)
        {
            copy_and_exit.Enabled = enable;
            copy_to_clip.Enabled = enable;
        }

        private void Process()
        {
            values_are_correct = false;

            if (start_value.Text.Length <= 0) return;
            if (end_value.Text.Length <= 0) return;
            if (pattern.Text.Length <= 0) return;

            int start_val, end_val, padding_length;

            try
            {
                start_val = int.Parse(start_value.Text);
                end_val = int.Parse(end_value.Text);
                padding_length = Math.Max(start_value.Text.Length, end_value.Text.Length);

                if (start_val > end_val) throw new ArgumentException("Start value can't be lower than end value");
                if (end_val - start_val > Int16.MaxValue) throw new ArgumentException($"Start and end value difference is too big (>{Int16.MaxValue})");
            }
            catch (Exception ex)
            {
                output.Text = ex.Message;
                EnableButtons(values_are_correct);
                return;
            }

            values_are_correct = true;
            EnableButtons(values_are_correct);

            StringBuilder sb = new();
            StringBuilder c = new();
            for (int i = start_val; i <= end_val; i++)
            {
                c.Clear();
                c.Append(pattern.Text);

                if (padding_enabled)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        c.Replace($"{escape_character}ip{j}", $"{i + j}".PadLeft(padding_length, '0'));
                        c.Replace($"{escape_character}im{j}", $"{i - j}".PadLeft(padding_length, '0'));
                    }
                    c.Replace($"{escape_character}i", i.ToString().PadLeft(padding_length, '0'));
                }
                else
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        c.Replace($"{escape_character}ip{j}", $"{i + j}");
                        c.Replace($"{escape_character}im{j}", $"{i - j}");
                    }
                    c.Replace($"{escape_character}i", i.ToString());
                }


                c.Append(Environment.NewLine);
                sb.Append(c.ToString());
            }

            output.Text = sb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            start_value.Focus();
            padding_enabled = checkBox_padding.Checked;
            escapeCharacter.Text = escape_character.ToString();

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
            Clipboard.SetText(output.Text);
        }

        private void copy_and_exit_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(output.Text);
            Environment.Exit(0);
        }

        private void Process(object sender, EventArgs e)
        {
            Process();
        }

        private void Pattern_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Form_KeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                if (e.KeyCode == Keys.Return)
                {
                    copy_and_exit.PerformClick();
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.C)
                {
                    copy_to_clip.PerformClick();
                    e.Handled = true;
                }
                return;
            }
            if (e.Modifiers == Keys.Alt)
            {
                if (e.KeyCode == Keys.I)
                {
                    pattern.Paste($"{escape_character}i");
                    e.Handled = true;
                    return;
                }
                else if (e.KeyCode == Keys.P)
                {
                    pattern.Paste($"{escape_character}ip");
                    e.Handled = true;
                    return;
                }
                else if (e.KeyCode == Keys.M)
                {
                    pattern.Paste($"{escape_character}im");
                    e.Handled = true;
                    return;
                }
                return;
            }

            if (e.KeyCode == Keys.Escape)
            {
                Environment.Exit(0);
                return;
            }
        }

        private void checkBox_padding_CheckedChanged(object sender, EventArgs e)
        {
            padding_enabled = checkBox_padding.Checked;
            Process();
        }

        private void escapeCharacter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(escapeCharacter.Text))
            {
                return;
            };
            escape_character = escapeCharacter.Text[0];
            Process();
        }
    }
}