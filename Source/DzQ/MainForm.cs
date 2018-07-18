// LOCATION OF FULL VERSION OF THE LICENSE: source\license.txt;
// DzQ Platform
// Copyright (C) 2010 - 2011 Petrov "DzafT" Pyotr
// 
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
/*
 * Created by SharpDevelop.
 * User: ????????
 * Date: 17.11.2010
 * Time: 20:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DzQ
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
		
	public partial class MainForm : Form
	{
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}

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
		public Core theCore {
			get { return core; }
			set { core = value; }
		}
		private Core core;
		private Decoder decoder;
		Options opt;
		Saver saver;
		void MainFormLoad(object sender, EventArgs e)
		{
			core = new Core(this);
			decoder = new Decoder(this);
			saver = new Saver(core);
			opt = new Options(this);
			opt.ThrowOptions += AcceptOptions;
			opt.InstallOptions();
		}
		
		void ActlistSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		public System.Windows.Forms.ListBox Itemlist {
			get { return itemlist; }
			set { itemlist = value; }
		}
		
		public System.Windows.Forms.ListBox Actlist {
			get { return actlist; }
			set { actlist = value; }
		}
		
		public System.Windows.Forms.RichTextBox RichTextBox1 {
			get { return richTextBox1; }
			set { richTextBox1 = value; }
		}

		public void AllClear()
		{
			actlist.Items.Clear();
			richTextBox1.Clear();
		}
		
		void ActlistDoubleClick(object sender, EventArgs e)
		{
			if(allow2click) userClick();
		}
		
		void userClick()
		{
			if (actlist.SelectedIndex!=-1)
			core.userClickAction(actlist.SelectedItem.ToString());
		}
		
		void ВыходToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void ItemlistDoubleClick(object sender, EventArgs e)
		{
			if (itemlist.SelectedIndex!=-1)
				core.userItemClick(itemlist.SelectedItem.ToString());
		}
		
		
		public string FirstRoom {
			get { return firstRoom; }
			set { firstRoom = value; }
		}
		string firstRoom;
		
		
		
		string timerblock="";
		public void SetTimer(string parB, string parI)
		{
			
			timer1.Interval = Convert.ToInt16(parI);
			timerblock = parB;
		}
		
		void ItemlistSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			//if(timerblock!="")
			core.ExecCommand("run "+timerblock);
		}
		
		public void StartQuest(string qname)
		{
			timerblock = "";
			itemlist.Items.Clear();
			if(qname=="")
			{
			openFileDialog1.FileName = "";
			openFileDialog1.Filter = "DzQ files (*.dzq)|*.dzq";
			openFileDialog1.ShowDialog();
			} else openFileDialog1.FileName = qname;
			if (openFileDialog1.FileName != "")
			{
				AllClear();
				core.Reset();
				
				try
				{
				decoder.openfile(openFileDialog1.FileName);
				core.ExecCommand("go "+FirstRoom);
				}
				catch
				{
					MessageBox.Show("Произошла ошибка во время построения каркаса структуры квеста. Это может быть связано с :\n1) Повреждением файла *.dzq при получении из Сети.\n2) Отсутствием закрывающего тега, например '/b'.\n3) Попыткой открыть не *.dzq файл.\nПродолжить работу с квестом не возможно.","Ошибка при открытии квеста!");
					return;
				}
				
				
			}
		}
		
		void ЗапускКвестаToolStripMenuItemClick(object sender, EventArgs e)
		{
			StartQuest("");
		}
		
		void ОПрограммеToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Dzaft's Quest Platform\nAutor: Petrov Pyotr aka DzafT\nLicense: GPL "+@"(source\license.txt)"+"\n2010 - 2011\ndzaft@mail.ru","About...");
		
		}


		
		
		void ЗагрузитьИгруToolStripMenuItemClick(object sender, EventArgs e)
		{
			openFileDialog1.FileName = "";
			openFileDialog1.Filter = "DzQ save files (*.sav)|*.sav";
			openFileDialog1.ShowDialog();
			if (openFileDialog1.FileName!="")
			{
				AllClear();
				core.Reset();
				saver.load(openFileDialog1.FileName);		
				decoder.openfile(core.Questname);
				saver.returndata();
				core.ExecCommand("go "+"curloc");
			}
		}
		
		void RichTextBox1LinkClicked(object sender, LinkClickedEventArgs e)
		{
		}
		bool allow2click;
		void AcceptOptions(object opts)
		{
			Options.Values op = (opts as Options.Values);
			richTextBox1.Font = op.FontType;
			actlist.Font = op.FontType;
			itemlist.Font = op.FontType;
			richTextBox1.ForeColor = op.FontColor;
			actlist.ForeColor = op.FontColor;
			itemlist.ForeColor = op.FontColor;
			richTextBox1.BackColor = op.BackColor;
			actlist.BackColor = op.BackColor;
			itemlist.BackColor = op.BackColor;
			allow2click = op.Allow2click;
			
			try
			{
				splitContainer1.SplitterDistance = op.Sdist[0];
				splitContainer2.SplitterDistance = op.Sdist[1];	
				
			}
			catch
			{	
			}
		}
		
		void НастройкиToolStripMenuItemClick(object sender, EventArgs e)
		{
			opt.ShowDialog();
			
		}
		
		void ItemlistClick(object sender, EventArgs e)
		{
			
		}
		
		void RichTextBox1Click(object sender, EventArgs e)
		{
			
		}
		
		void ActlistClick(object sender, EventArgs e)
		{
			if(!allow2click) userClick();
		}
		
		void ПерезапуститьКвестToolStripMenuItemClick(object sender, EventArgs e)
		{
			StartQuest(core.Questname);
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		public int[] GetSplitContainersDistance()
		{
			int[] dst = new int[2];
			dst[0] = splitContainer1.SplitterDistance;
			dst[1] = splitContainer2.SplitterDistance;
			return dst;
		}
		
	}
}
