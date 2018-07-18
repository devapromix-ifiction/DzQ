/*
 * Created by SharpDevelop.
 * User: ?????????????
 * Date: 04.12.2010
 * Time: 17:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace DzQ_Editor
{
	/// <summary>
	/// Description of AddSmth.
	/// </summary>
	public partial class AddSmth : Form
	{
		public AddSmth()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public string Input {
			get { return input; }
		}
		string input;
		void Button1Click(object sender, EventArgs e)
		{
			input = textBox1.Text;
			this.Hide();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			input = "";
			this.Hide();
		}
		
		void AddSmthLoad(object sender, EventArgs e)
		{
			textBox1.Text = "";
			this.ActiveControl = textBox1;
		}
	}
}
