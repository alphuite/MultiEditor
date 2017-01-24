﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
		string opendPath;
		string fileContent;
		bool fileSelected = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

			private void button1_Click(object sender, EventArgs e) {
				  openFileDialog1.ShowDialog();
			}

			private void openFileDialog1_FileOk(object sender, CancelEventArgs e) {
				  fileSelected = true;
			}
	  }
}
