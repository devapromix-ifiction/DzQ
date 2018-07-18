/*
 * Created by SharpDevelop.
 * User: ?????????????
 * Date: 05.12.2010
 * Time: 12:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace DzQ_Editor
{
	/// <summary>
	/// Description of VarEd.
	/// </summary>
	public partial class VarEd : Form
	{
		Variab vr;
		public VarEd(Variab vr)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.vr = vr;
			textBox1.Text = vr.name;
			if (vr.getVal()!=null)
			textBox2.Text = vr.getVal().ToString();
			if(vr.getTp()=="text")radioButton2.Checked = true;
			else radioButton1.Checked = true;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			vr.name = textBox1.Text;
			if (radioButton1.Checked)vr.SetType("number");
			else vr.SetType("text");
			vr.setVal(textBox2.Text);
			this.Hide();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
