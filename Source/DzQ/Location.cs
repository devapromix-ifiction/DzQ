/*
 * Created by SharpDevelop.
 * User: ????????
 * Date: 17.11.2010
 * Time: 20:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections;
using System.Windows.Forms;

namespace DzQ
{
	/// <summary>
	/// Description of Location.
	/// </summary>
	[Serializable]
	public class Location : QuestObject
	{
		
		ArrayList actions = new ArrayList();
		public long Visit {
			get { return visit; }
			set { visit = value; }
		}
		long visit;
		public Location(MainForm p)
		{
			acts = p.Actlist;
			outp = p.RichTextBox1;
		}
		string text;
		public string discr
		{
			set{text = value;}
			get{return text;}
		}

		
		
		
		public string Auto {
			get { return auto; }
			set { auto = value; }
		}
		string auto;
		public void AddCmBlock(CmBlock act)
		{
			actions.Add(act);
		}
		public CmBlock GetCmBlock(string nm)
		{
			foreach(CmBlock obj in actions)
				if(obj.name==nm)return obj;
			return null;
		}
		public void ShowAllActions()
		{
			ChangeVisibleAllActions(true);
		}
		
		void ChangeVisibleAllActions(bool newStatus)
		{
			foreach(CmBlock obj in actions) 
				if(obj is IAction)
				(obj as IAction).visible = newStatus;
			RefreshActlist();
		}
		
		public void HideAllActions()
		{
			ChangeVisibleAllActions(false);
		}
		
		public override void ReanimateLinks(MainForm p)
		{
			base.ReanimateLinks(p);
			acts = p.Actlist;
			outp = p.RichTextBox1;
		}
		
		public void Show()
		{
			//ShowAllActions();
			if (text!=null)
			outp.AppendText(text);
			RefreshActlist();
		}
		
		void RefreshActlist()
		{
			acts.Items.Clear();
			foreach(CmBlock obj in actions) 
			if((obj is IAction)&&((obj as IAction).visible))acts.Items.Add(obj.name);
		}
		
		public void ShowAction(string nm)
		{
			CmBlock obj = GetCmBlock(nm);
			if ((obj!=null)&&(obj is IAction))
				{
				(obj as IAction).visible = true;
				RefreshActlist();
				}
		}
		public void HideAction(string nm)
		{
			
			CmBlock obj = GetCmBlock(nm);
			if ((obj!=null)&&(obj is IAction))
				{
				(obj as IAction).visible = false;
				RefreshActlist();
				}
		}
		[NonSerialized]
		RichTextBox outp;
		[NonSerialized]
		ListBox acts;
		
		
		
		
}
}
