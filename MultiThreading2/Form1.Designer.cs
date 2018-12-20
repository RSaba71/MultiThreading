namespace MultiThreading2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TimeConsumingJob = new System.Windows.Forms.Button();
            this.PrintNumbers = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TimeConsumingJob
            // 
            this.TimeConsumingJob.Location = new System.Drawing.Point(82, 13);
            this.TimeConsumingJob.Name = "TimeConsumingJob";
            this.TimeConsumingJob.Size = new System.Drawing.Size(139, 23);
            this.TimeConsumingJob.TabIndex = 0;
            this.TimeConsumingJob.Text = "TimeConsumingJob";
            this.TimeConsumingJob.UseVisualStyleBackColor = true;
            this.TimeConsumingJob.Click += new System.EventHandler(this.TimeConsumingJob_Click);
            // 
            // PrintNumbers
            // 
            this.PrintNumbers.Location = new System.Drawing.Point(109, 56);
            this.PrintNumbers.Name = "PrintNumbers";
            this.PrintNumbers.Size = new System.Drawing.Size(75, 23);
            this.PrintNumbers.TabIndex = 1;
            this.PrintNumbers.Text = "Print Numbers";
            this.PrintNumbers.UseVisualStyleBackColor = true;
            this.PrintNumbers.Click += new System.EventHandler(this.PrintNumbers_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(82, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(167, 147);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.PrintNumbers);
            this.Controls.Add(this.TimeConsumingJob);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TimeConsumingJob;
        private System.Windows.Forms.Button PrintNumbers;
        private System.Windows.Forms.ListBox listBox1;
    }
}

