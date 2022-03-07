/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 07/03/2022
 * Time: 21:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tugaspv
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
	MessageBox.Show ( "Nama :"+this.textBox1.Text +"\r\r"+"NIM :"
			                 + this.textBox2.Text +"\r\r"+"Kom :" + this.textBox3.Text);
		}
	}
}
