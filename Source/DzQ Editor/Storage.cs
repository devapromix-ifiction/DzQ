/*
 * Created by SharpDevelop.
 * User: ?????????????
 * Date: 05.12.2010
 * Time: 9:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace DzQ_Editor
{
	/// <summary>
	/// Description of Storage.
	/// </summary>
	
	public class Storage
	{
		[Serializable]
		public class Dt
		{
		public List<Location> locs = new List<Location>();
		public List<CmBlock> gblocks = new List<CmBlock>();
		public List<myItem> itms = new List<myItem>();
		public List<Variab> vars = new List<Variab>();
		public string StartLoc {
			get { return startLoc; }
			set { startLoc = value; }
		}
		string startLoc;
		public Dt() {}
		public void Append(Dt inDt)
		{
			locs.AddRange(inDt.locs);
			gblocks.AddRange(inDt.gblocks);
			itms.AddRange(inDt.itms);
			vars.AddRange(inDt.vars);
		}
		
		}
		
		
		public Dt dt;
		public void AddGBlock(string nm)
		{
			CmBlock temp = new CmBlock(this);
			temp.name = nm;
			dt.gblocks.Add(temp);
		}
		public void AddItm(string nm)
		{
			myItem temp = new myItem();
			temp.name = nm;
			dt.itms.Add(temp);
		}
		public void AddLoc(string nm)
		{
			Location temp = new Location(this);
			temp.name = nm;
			dt.locs.Add(temp);
		}
		public void AddVar(string nm)
		{
			Variab temp = new Variab();
			temp.name = nm;
			dt.vars.Add(temp);
		}
		public CmBlock GetGBlock(string nm)
		{
			foreach(CmBlock obj in dt.gblocks)
				if(obj.name == nm)return obj;
			return null;
		}
		public myItem GetItm(string nm)
		{
			foreach(myItem obj in dt.itms)
				if(obj.name == nm)return obj;
			return null;
		}
		public Variab GetVar(string nm)
		{
			foreach(Variab obj in dt.vars)
				if(obj.name == nm)return obj;
			return null;
		}
		public Location GetLoc(string nm)
		{
			foreach(Location obj in dt.locs)
				if(obj.name == nm)return obj;
			return null;
		}
		public void KillLoc(string nm)
		{
				dt.locs.Remove(GetLoc(nm));
		}
		public void KillItm(string nm)
		{
				dt.itms.Remove(GetItm(nm));
		}
		public void KillGBlock(string nm)
		{
				dt.gblocks.Remove(GetGBlock(nm));
		}
		public void KillVar(string nm)
		{
			dt.vars.Remove(GetVar(nm));
		}
		
		public void RefreshLocs(System.Windows.Forms.ListBox lb)
		{
			lb.Items.Clear();
			foreach(Location obj in dt.locs)
			lb.Items.Add(obj.name);
				
		}
		
		public void RefreshLocs(System.Windows.Forms.ComboBox lb)
		{
			lb.Items.Clear();
			foreach(Location obj in dt.locs)
			lb.Items.Add(obj.name);
				
		}
		
		public void RefreshVars(System.Windows.Forms.ListBox lb)
		{
			lb.Items.Clear();
			foreach(Variab obj in dt.vars)
			lb.Items.Add(obj.name);
				
		}
		public void RefreshVars(System.Windows.Forms.ComboBox lb)
		{
			lb.Items.Clear();
			foreach(Variab obj in dt.vars)
			lb.Items.Add(obj.name);
				
		}
		
		public void RefreshNumVars(System.Windows.Forms.ComboBox lb)
		{
			lb.Items.Clear();
			foreach(Variab obj in dt.vars)
			if(obj.getTp()!="text")lb.Items.Add(obj.name);
				
		}
		
		public void RefreshTxtVars(System.Windows.Forms.ComboBox lb)
		{
			lb.Items.Clear();
			foreach(Variab obj in dt.vars)
				if(obj.getTp()=="text")lb.Items.Add("textvar "+obj.name);
				
		}
		
		public void RefreshTxsVars(System.Windows.Forms.ComboBox lb)
		{
			lb.Items.Clear();
			foreach(Variab obj in dt.vars)
				if(obj.getTp()=="text")lb.Items.Add(obj.name);
				
		}
		
		public void RefreshItms(System.Windows.Forms.ListBox lb)
		{
			lb.Items.Clear();
			foreach(myItem obj in dt.itms)
			lb.Items.Add(obj.name);
				
		}
			public void RefreshItms(System.Windows.Forms.ComboBox lb)
		{
			lb.Items.Clear();
			foreach(myItem obj in dt.itms)
			lb.Items.Add(obj.name);
				
		}
		
		public void RefreshGBlocks(System.Windows.Forms.ListBox lb)
		{
			lb.Items.Clear();
			foreach(CmBlock obj in dt.gblocks)
			lb.Items.Add(obj.name);
		}
		
		public void RefreshGBlocks(System.Windows.Forms.ComboBox cb)
		{
			cb.Items.Clear();
			foreach(CmBlock obj in dt.gblocks)
			cb.Items.Add(obj.name);
		}
		
		[NonSerialized]
		MainForm mf;
		public Storage(MainForm mf)
		{
			this.mf = mf;
			dt = new Dt();
		}
		
		
		string[] txfile;
		
		public void export(string fn)
		{
			string s;
			ArrayList d = new ArrayList();
			d.Add("*loc #START");
			d.Add("/descr");
			d.Add("*auto at");
			d.Add("*b at");
			foreach(Variab obj in dt.vars)
			{
				s = "var "+obj.getTp()+" "+obj.name+" "+obj.getVal().ToString();
				d.Add(s);
			}
			if(dt.StartLoc!="")
				d.Add("go "+dt.StartLoc);
			d.Add("/b");
			d.Add("/loc");
			foreach(Location obj in dt.locs)
			{
				d.Add("*loc "+obj.name);
				d.Add(obj.discr);
				d.Add("/descr");
				if(obj.Auto!="")d.Add("*auto "+obj.Auto);
				foreach(CmBlock act in obj.actions)
				{
					d.Add("*act "+act.name);
					foreach(string st in act.commands)
						d.Add(st);
					d.Add("/act");
				}
				d.Add("/loc");
			}
			
			foreach(CmBlock cmb in dt.gblocks)
			{
				d.Add("*b "+cmb.name);
				foreach(string st in cmb.commands)
					d.Add(st);
				d.Add("/b");
			}
			
			foreach(myItem itm in dt.itms)
			{
				d.Add("*item "+itm.name);
				d.Add("*onclick "+itm.Onclick);
				d.Add("/item");
			}
			
			string[] smas = new string[d.Count];
			int i =0;
			foreach(string st in d)
				{
				smas[i] = st;
				i++;
				}
			File.WriteAllLines(fn, smas );
		}
	
			
	
	}
}
