/*
 * Created by SharpDevelop.
 * User: ????????
 * Date: 20.11.2010
 * Time: 13:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;


namespace DzQ
{
	/// <summary>
	/// Description of InputBox.
	/// </summary>
	public partial class InputBox : Form
	{
		Core coreptr;
		public InputBox(Core ptr, string lbtext)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			coreptr = ptr;
			label1.Text = lbtext;
			this.ActiveControl = textBox1;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void InputBoxLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			coreptr.InputText = textBox1.Text;
			this.Hide();
		}
	}
}
