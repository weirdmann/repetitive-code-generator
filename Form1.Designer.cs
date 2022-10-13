namespace patternsolver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.start_value = new System.Windows.Forms.TextBox();
            this.end_value = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.copy_to_clip = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pattern = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start value:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "End value:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // start_value
            // 
            this.start_value.Location = new System.Drawing.Point(5, 57);
            this.start_value.Name = "start_value";
            this.start_value.Size = new System.Drawing.Size(250, 22);
            this.start_value.TabIndex = 2;
            this.start_value.Text = "1";
            this.start_value.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // end_value
            // 
            this.end_value.Location = new System.Drawing.Point(5, 101);
            this.end_value.Name = "end_value";
            this.end_value.Size = new System.Drawing.Size(250, 22);
            this.end_value.TabIndex = 3;
            this.end_value.Text = "100";
            this.end_value.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.copy_to_clip);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.pattern);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.end_value);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.start_value);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.output);
            this.splitContainer1.Size = new System.Drawing.Size(1279, 594);
            this.splitContainer1.SplitterDistance = 565;
            this.splitContainer1.TabIndex = 4;
            // 
            // copy_to_clip
            // 
            this.copy_to_clip.Location = new System.Drawing.Point(5, 563);
            this.copy_to_clip.Name = "copy_to_clip";
            this.copy_to_clip.Size = new System.Drawing.Size(557, 28);
            this.copy_to_clip.TabIndex = 7;
            this.copy_to_clip.Text = "Copy result to clipboard";
            this.copy_to_clip.UseVisualStyleBackColor = true;
            this.copy_to_clip.Click += new System.EventHandler(this.copy_to_clip_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Result:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Input pattern:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pattern
            // 
            this.pattern.AcceptsReturn = true;
            this.pattern.AcceptsTab = true;
            this.pattern.Location = new System.Drawing.Point(5, 150);
            this.pattern.Multiline = true;
            this.pattern.Name = "pattern";
            this.pattern.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.pattern.Size = new System.Drawing.Size(557, 407);
            this.pattern.TabIndex = 4;
            this.pattern.Text = "test pattern \r\n&i + 1 = &ip1\r\n&i + 2 = &ip2\r\n&i + 4 = &ip4\r\n&i - 2 = &im2\r\n&i - 4" +
    " = &im4\r\n";
            this.pattern.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.output.Location = new System.Drawing.Point(3, 3);
            this.output.MaxLength = 99999;
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.output.Size = new System.Drawing.Size(704, 588);
            this.output.TabIndex = 6;
            this.output.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 618);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox start_value;
        private TextBox end_value;
        private SplitContainer splitContainer1;
        private Label label3;
        private TextBox pattern;
        private TextBox output;
        private Label label4;
        private Button copy_to_clip;
    }
}