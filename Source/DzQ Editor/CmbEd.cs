/*
 * Created by SharpDevelop.
 * User: ?????????????
 * Date: 05.12.2010
 * Time: 16:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace DzQ_Editor
{
	/// <summary>
	/// Description of CmbEd.
	/// </summary>
	public partial class CmbEd : Form
	{
		MainForm mf;
		Storage st;
		CmBlock cmb;
		public CmbEd(CmBlock cmb,MainForm mf, Storage st)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.mf = mf;
			this.st = st;
			this.cmb = cmb;
			
			try
			{
			textBox1.Text = cmb.name;
			}
			catch
			{	
			}
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			object buffer;
			if(listBox1.SelectedIndex>0)
			{
				buffer = listBox1.Items[listBox1.SelectedIndex-1];
				listBox1.Items[listBox1.SelectedIndex-1] = listBox1.Items[listBox1.SelectedIndex];
				listBox1.Items[listBox1.SelectedIndex] = buffer;
				listBox1.SelectedIndex--;
			}
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			object buffer;
			if((listBox1.SelectedIndex!=-1)&&(listBox1.SelectedIndex<listBox1.Items.Count-1))
			{
				buffer = listBox1.Items[listBox1.SelectedIndex+1];
				listBox1.Items[listBox1.SelectedIndex+1] = listBox1.Items[listBox1.SelectedIndex];
				listBox1.Items[listBox1.SelectedIndex] = buffer;
				listBox1.SelectedIndex++;
			}
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			lastName = "";
			this.Hide();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			if(listBox1.SelectedIndex!=-1)
			listBox1.Items.RemoveAt(listBox1.SelectedIndex);
		}
		
		void CmbEdLoad(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			cmb.InsCommands(listBox1);
			Lstcom = "";
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			cmb.Clear();
			cmb.name = textBox1.Text;
			foreach(string s in listBox1.Items)
				cmb.AddCommand(s);
			lastName = cmb.name;
			this.Close();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Lstcom = "";
			NewCom newcom = new NewCom(st,this);
			newcom.ShowDialog();
			if(Lstcom!=null)listBox1.Items.Add(Lstcom);
		}
	
	public string Lstcom {
			get { return lstcom; }
			set { lstcom = value; }
		}
		static string lstcom;
		
		void Button8Click(object sender, EventArgs e)
		{
			if(listBox1.SelectedIndex!=-1)
			{
				ComEdit cmde = new ComEdit(listBox1.SelectedItem.ToString());
				cmde.ShowDialog();
				listBox1.Items[listBox1.SelectedIndex]  = cmde.GetCommand();
			}
				
		}
		
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void ListBox1MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Button8Click(null,null);
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		string lastName;
		public string GetLastName()
		{
			return lastName;
		}
		
	}
}
