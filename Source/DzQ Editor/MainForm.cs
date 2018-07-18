/*
 * Created by SharpDevelop.
 * User: ?????????????
 * Date: 04.12.2010
 * Time: 17:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace DzQ_Editor
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
			if(args.Length>0)fl = args[2];
		}
		
		static string fl;
		
		string lastName = "";
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			addsmth = new AddSmth();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			addsmth.ShowDialog();
			if (addsmth.Input!="")
				{
				storage.AddLoc(addsmth.Input);
				LocEd loced = new LocEd(storage.GetLoc(addsmth.Input),storage);
				loced.ShowDialog();
				}
			storage.RefreshLocs(listBox1);
			RefreshAll();
		}
		
		AddSmth addsmth;
		Storage storage;
		Saver saver;
		void MainFormLoad(object sender, EventArgs e)
		{
			storage = new Storage(this);
			saver = new Saver(storage);
			if(System.IO.File.Exists(fl))
			{
				saver.load(fl);
				RefreshAll();
			}
		}
		
		void ВыходToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void LoclistSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		
		void Button9Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex!=-1)
			{
				storage.KillLoc(listBox1.SelectedItem.ToString());
				storage.RefreshLocs(listBox1);
			}
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			addsmth.ShowDialog();
			if (addsmth.Input!="")
			{
				storage.AddVar(addsmth.Input);
				VarEd vared = new VarEd(storage.GetVar(addsmth.Input));
				vared.ShowDialog();
			}
			storage.RefreshVars(listBox2);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			addsmth.ShowDialog();
			if (addsmth.Input!="")
				{
				storage.AddItm(addsmth.Input);
				ItmEd itmed = new ItmEd(storage.GetItm(addsmth.Input),storage);
				itmed.ShowDialog();
				}
			storage.RefreshItms(listBox3);
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			addsmth.ShowDialog();
			if (addsmth.Input!="")
			{
				storage.AddGBlock(addsmth.Input);
				CmbEd cmbed = new CmbEd(storage.GetGBlock(addsmth.Input),this,storage);
				cmbed.ShowDialog();
			}
			storage.RefreshGBlocks(listBox4);
			RefreshAll();
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			if (listBox2.SelectedIndex!=-1)
			{
				storage.KillVar(listBox2.SelectedItem.ToString());
				storage.RefreshVars(listBox2);
			}
		}
		
		void Button11Click(object sender, EventArgs e)
		{
			if (listBox3.SelectedIndex!=-1)
			{
				storage.KillItm(listBox3.SelectedItem.ToString());
				storage.RefreshItms(listBox3);
			}
		}
		
		void Button12Click(object sender, EventArgs e)
		{
			if (listBox4.SelectedIndex!=-1)
			{
				storage.KillGBlock(listBox4.SelectedItem.ToString());
				storage.RefreshGBlocks(listBox4);
			}
		}
		
		void RefreshAll()
		{
			storage.RefreshLocs(listBox1);
			storage.RefreshVars(listBox2);
			storage.RefreshItms(listBox3);
			storage.RefreshGBlocks(listBox4);
		}
		
		void ОткрытьToolStripMenuItemClick(object sender, EventArgs e)
		{
			lastName = "";
			openFileDialog1.FileName="";
			openFileDialog1.ShowDialog();
			if(openFileDialog1.FileName!="")
			{
				lastName = openFileDialog1.FileName;
				saver.load(openFileDialog1.FileName);
			}
			RefreshAll();
		}
		
		void ВыходToolStripMenuItem1Click(object sender, EventArgs e)
		{
			Application.Exit();		
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			VarEd vared;
			if(listBox2.SelectedIndex!=-1)
			{
				vared = new VarEd(storage.GetVar(listBox2.SelectedItem.ToString()));
				vared.ShowDialog();
			}
			storage.RefreshVars(listBox2);
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			ItmEd itmed;
			if(listBox3.SelectedIndex!=-1)
			{
				itmed = new ItmEd(storage.GetItm(listBox3.SelectedItem.ToString()), storage);
				itmed.ShowDialog();
			}
			storage.RefreshItms(listBox3);
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			LocEd loced;
			if(listBox1.SelectedIndex!=-1)
			{
				loced = new LocEd(storage.GetLoc(listBox1.SelectedItem.ToString()), storage);
				loced.ShowDialog();
			}
			storage.RefreshLocs(listBox1);
			RefreshAll();
		}
		
		void СохранитьПроектToolStripMenuItemClick(object sender, EventArgs e)
		{
			saveFileDialog1.FileName="";
			saveFileDialog1.ShowDialog();
			if(saveFileDialog1.FileName!="")
			{
				saver.save(saveFileDialog1.FileName);
				lastName = saveFileDialog1.FileName;
			}
		}
		
		void Button8Click(object sender, EventArgs e)
		{
					CmbEd cmbed;
			if(listBox4.SelectedIndex!=-1)
			{
				cmbed = new CmbEd(storage.GetGBlock(listBox4.SelectedItem.ToString()), this, storage);
				cmbed.ShowDialog();
			}
			storage.RefreshGBlocks(listBox4);
			RefreshAll();
		}
		
		void ЭкспортКвестаToolStripMenuItemClick(object sender, EventArgs e)
		{
			exportd.FileName="";
			exportd.ShowDialog();
			if(exportd.FileName!="")
			storage.export(exportd.FileName);
		}
		
		void НовыйПроектToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Restart();
			//lastName = "";
			//storage = new Storage(this);
			//RefreshAll();
		}
		
		void ОПрограммеToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("" +
			                "Dzaft's Quest Platform EDITOR\n" +
			                "Autor: Petrov Pyotr aka DzafT\n" +
			                @"License GPL: source\license.txt"+"\n" +
			                "dzaft@mail.ru",
			                "About...");
		}
		
		void РуководствоПользователяToolStripMenuItemClick(object sender, EventArgs e)
		{
			Process p;
			if(System.IO.File.Exists(@"DzQGuide.pdf"))
				p = Process.Start(@"DzQGuide.pdf");
				else MessageBox.Show("Файл мануала 'DzQGuide.pdf' не найден!","Внимание!");
			
		}
		
		void ПомощьToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void СохранитьToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(lastName!="")
				saver.save(lastName);
			else СохранитьПроектToolStripMenuItemClick(null,null);
		}
		
		void ИмпортПроектаToolStripMenuItemClick(object sender, EventArgs e)
		{
			openFileDialog1.FileName = "";
			openFileDialog1.ShowDialog();
			if(openFileDialog1.FileName!="")
			{
				saver.import(openFileDialog1.FileName);
			}
			RefreshAll();
		}
	}
}
