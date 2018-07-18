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

namespace DzQ_Editor
{
	/// <summary>
	/// Description of Location.
	/// </summary>
	[Serializable]
	public class Location : QuestObject
	{

		//ListBox acts;

		//RichTextBox outp;
		
		public Location(Storage st)
		{
			this.st = st;
			//acts = p.actlist;
			//outp = p.richTextBox1;
		}
		string text;
		public string discr
		{
			set{text = value;}
			get{return text;}
		}

		public ArrayList actions = new ArrayList();
		
		public string Auto {
			get { return auto; }
			set { auto = value; }
		}
		string auto;
		public void AddCmBlock(CmBlock act)
		{
			actions.Add(act);
		}
		
		public void DelCmBlock(string nm)
		{
			actions.Remove(GetCmBlock(nm));
		}
		
		public CmBlock GetCmBlock(string nm)
		{
			foreach(CmBlock obj in actions)
				if(obj.name==nm)return obj;
			return null;
		}
	
		public void RefreshActions(System.Windows.Forms.ComboBox cb)
		{
			cb.Items.Clear();
			foreach(CmBlock obj in actions)
			cb.Items.Add(obj.name);
		}
		
			
		
		public static DzQ_Editor.Location LastLocation {
			get { return lastLocation; }
			set { lastLocation = value; }
		}
		
		[NonSerialized]
		static DzQ_Editor.Location lastLocation;

}
}
