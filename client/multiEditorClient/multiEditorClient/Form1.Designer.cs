﻿namespace WindowsFormsApplication1
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
				  this.label1 = new System.Windows.Forms.Label();
				  this.label2 = new System.Windows.Forms.Label();
				  this.textBox1 = new System.Windows.Forms.TextBox();
				  this.textBox2 = new System.Windows.Forms.TextBox();
				  this.button1 = new System.Windows.Forms.Button();
				  this.label3 = new System.Windows.Forms.Label();
				  this.button2 = new System.Windows.Forms.Button();
				  this.SuspendLayout();
				  // 
				  // label1
				  // 
				  this.label1.AutoSize = true;
				  this.label1.Location = new System.Drawing.Point(34, 32);
				  this.label1.Name = "label1";
				  this.label1.Size = new System.Drawing.Size(55, 13);
				  this.label1.TabIndex = 0;
				  this.label1.Text = "Username";
				  // 
				  // label2
				  // 
				  this.label2.AutoSize = true;
				  this.label2.Location = new System.Drawing.Point(34, 79);
				  this.label2.Name = "label2";
				  this.label2.Size = new System.Drawing.Size(53, 13);
				  this.label2.TabIndex = 1;
				  this.label2.Text = "Password";
				  // 
				  // textBox1
				  // 
				  this.textBox1.Location = new System.Drawing.Point(95, 29);
				  this.textBox1.Name = "textBox1";
				  this.textBox1.Size = new System.Drawing.Size(125, 20);
				  this.textBox1.TabIndex = 2;
				  this.textBox1.Tag = "";
				  // 
				  // textBox2
				  // 
				  this.textBox2.Location = new System.Drawing.Point(93, 76);
				  this.textBox2.Name = "textBox2";
				  this.textBox2.PasswordChar = '・';
				  this.textBox2.Size = new System.Drawing.Size(125, 20);
				  this.textBox2.TabIndex = 3;
				  // 
				  // button1
				  // 
				  this.button1.Location = new System.Drawing.Point(67, 190);
				  this.button1.Name = "button1";
				  this.button1.Size = new System.Drawing.Size(125, 23);
				  this.button1.TabIndex = 4;
				  this.button1.Text = "Start";
				  this.button1.UseVisualStyleBackColor = true;
				  this.button1.Click += new System.EventHandler(this.button1_Click);
				  // 
				  // label3
				  // 
				  this.label3.AutoSize = true;
				  this.label3.Enabled = false;
				  this.label3.Location = new System.Drawing.Point(53, 137);
				  this.label3.Name = "label3";
				  this.label3.Size = new System.Drawing.Size(154, 13);
				  this.label3.TabIndex = 5;
				  this.label3.Text = "Login successful, starting client";
				  this.label3.Visible = false;
				  this.label3.Click += new System.EventHandler(this.label3_Click);
				  // 
				  // button2
				  // 
				  this.button2.Location = new System.Drawing.Point(67, 190);
				  this.button2.Name = "button2";
				  this.button2.Size = new System.Drawing.Size(125, 23);
				  this.button2.TabIndex = 6;
				  this.button2.Text = "Re-enable buttons";
				  this.button2.UseVisualStyleBackColor = true;
				  this.button2.Visible = false;
				  this.button2.Click += new System.EventHandler(this.button2_Click);
				  // 
				  // Form1
				  // 
				  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
				  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				  this.ClientSize = new System.Drawing.Size(258, 262);
				  this.Controls.Add(this.button2);
				  this.Controls.Add(this.label3);
				  this.Controls.Add(this.button1);
				  this.Controls.Add(this.textBox2);
				  this.Controls.Add(this.textBox1);
				  this.Controls.Add(this.label2);
				  this.Controls.Add(this.label1);
				  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
				  this.Name = "Form1";
				  this.Text = "MultiEditor v.0.0";
				  this.Load += new System.EventHandler(this.Form1_Load);
				  this.ResumeLayout(false);
				  this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

