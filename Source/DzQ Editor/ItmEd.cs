/*
 * Created by SharpDevelop.
 * User: ?????????????
 * Date: 05.12.2010
 * Time: 12:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace DzQ_Editor
{
	/// <summary>
	/// Description of ItmEd.
	/// </summary>
	public partial class ItmEd : Form
	{
		myItem itm;
		Storage store;
		public ItmEd(myItem itm, Storage store)
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.itm = itm;
			this.store = store;
			textBox1.Text = itm.name;
			textBox2.Text = itm.Onclick;
			//comboBox1.Text = itm.Onclick;
			//store.RefreshGBlocks(comboBox1);
			//for(int i=0;i<comboBox1.Items.Count;i++)
			//	comboBox1.Items[i] = "run "+comboBox1.Items[i];
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			itm.name = textBox1.Text;
			itm.Onclick = textBox2.Text;
			//itm.Onclick = comboBox1.Text;
			this.Hide();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		
		void ItmEdLoad(object sender, EventArgs e)
		{
			
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			CmbEd cmbed = new CmbEd(null,null,store);
			NewCom newcom = new NewCom(store,cmbed);
			newcom.ShowDialog();
			textBox2.Text = cmbed.Lstcom;
			
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
