namespace WindowsFormsApp1
{
    partial class Form1
    {
      




        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lost = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.empfänger = new System.Windows.Forms.TextBox();
            this.betreff = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Empfänger";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Betreff";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Passwort";
            // 
            // lost
            // 
            this.lost.Location = new System.Drawing.Point(113, 9);
            this.lost.Name = "lost";
            this.lost.Size = new System.Drawing.Size(100, 20);
            this.lost.TabIndex = 1;

            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(113, 39);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(100, 20);
            this.pass.TabIndex = 1;
            // 
            // empfänger
            // 
            this.empfänger.Location = new System.Drawing.Point(113, 65);
            this.empfänger.Name = "empfänger";
            this.empfänger.Size = new System.Drawing.Size(100, 20);
            this.empfänger.TabIndex = 1;
            // 
            // betreff
            // 
            this.betreff.Location = new System.Drawing.Point(113, 91);
            this.betreff.Name = "betreff";
            this.betreff.Size = new System.Drawing.Size(100, 20);
            this.betreff.TabIndex = 1;
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(46, 125);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(167, 96);
            this.text.TabIndex = 2;
            this.text.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Senden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text);
            this.Controls.Add(this.betreff);
            this.Controls.Add(this.empfänger);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.lost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "E-Mail";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lost;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox empfänger;
        private System.Windows.Forms.TextBox betreff;
        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.Button button1;
    }
}