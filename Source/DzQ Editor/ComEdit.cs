/*
 * Created by SharpDevelop.
 * User: Boss
 * Date: 14.05.2011
 * Time: 20:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace DzQ_Editor
{
	/// <summary>
	/// Description of ComEdit.
	/// </summary>
	public partial class ComEdit : Form
	{
		string cmd;
		public ComEdit(string cmd)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.cmd = cmd;
			textBox1.Text = cmd;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public string GetCommand()
		{
			return cmd;
		}
		
		void ComEditLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			cmd = textBox1.Text;
			this.Close();
		}
	}
}
