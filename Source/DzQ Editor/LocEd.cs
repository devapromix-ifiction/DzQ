/*
 * Created by SharpDevelop.
 * User: ?????????????
 * Date: 05.12.2010
 * Time: 14:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace DzQ_Editor
{
	/// <summary>
	/// Description of LocEd.
	/// </summary>
	public partial class LocEd : Form
	{
		Location loca;
		Storage store;
		public LocEd(DzQ_Editor.Location loca, Storage store)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.loca = loca;
			DzQ_Editor.Location.LastLocation = loca;
			textBox1.Text = loca.name;
			richTextBox1.Text = loca.discr;
			comboBox1.Text = loca.Auto;
			this.store = store;
			store.RefreshGBlocks(comboBox1);
			comboBox1.Items.Add("New block...");
			loca.RefreshActions(comboBox2);
			label6.Text = store.dt.StartLoc;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			loca.name = textBox1.Text;
			loca.Auto = comboBox1.Text;
			loca.discr = richTextBox1.Text;
			this.Hide();
		}
		
		void LocEdLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{

			CmBlock tmp = new CmBlock();
			AddSmth addsmth = new AddSmth();
			addsmth.ShowDialog();
			tmp.name = addsmth.Input;
			if(addsmth.Input!="")
			{
			loca.AddCmBlock(tmp);
			CmbEd cmbed = new CmbEd(loca.GetCmBlock(addsmth.Input), null, store);
			cmbed.Show();
			loca.RefreshActions(comboBox2);
			comboBox2.Text = "";
			}
			   
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			loca.DelCmBlock(comboBox2.Text);
			loca.RefreshActions(comboBox2);
			comboBox2.Text = "";
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			if(loca.GetCmBlock(comboBox2.Text)!=null)
			{
			CmbEd cmbed = new CmbEd(loca.GetCmBlock(comboBox2.Text), null, store);
			cmbed.ShowDialog();
			loca.RefreshActions(comboBox2);
			if(cmbed.GetLastName()!="") comboBox2.Text = cmbed.GetLastName();
			}
			
		}
		
		void ComboBox2SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			store.dt.StartLoc = loca.name;
			label6.Text = store.dt.StartLoc;
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			if(comboBox1.Text == "New block..."){
				AddSmth addsmth = new AddSmth();
				addsmth.ShowDialog();
				if(addsmth.Input!="")
				{
					store.AddGBlock(addsmth.Input);
					CmBlock cmb = store.GetGBlock(addsmth.Input);
					CmbEd cmbed = new CmbEd(cmb,null,store);
					cmbed.ShowDialog();
					comboBox1.Items.Add(addsmth.Input);
					comboBox1.Text = cmb.name;
				}
			}
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void LocEdMouseMove(object sender, MouseEventArgs e)
		{
			
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			CmBlock cb; 
			cb = store.GetGBlock(comboBox1.Text);
			if(cb==null)return;
			CmbEd cmbed = new CmbEd(cb, null, store);
			cmbed.ShowDialog();
			store.RefreshGBlocks(comboBox1);
		}
	}
}
