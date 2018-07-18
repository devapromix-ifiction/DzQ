/*
 * Created by SharpDevelop.
 * User: ????????
 * Date: 18.11.2010
 * Time: 8:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace DzQ_Editor
{
	/// <summary>
	/// Description of CommandItem.
	/// </summary>
	[Serializable]
	public class CmBlock : QuestObject
	{
		public CmBlock(Storage st)
		{
			this.st = st;
		}
		public CmBlock()
		{
			
		}
		public System.Collections.ArrayList commands = new System.Collections.ArrayList();
		public void AddCommand(string cm)
		{
			commands.Add(cm);
		}
		
		public void InsCommands(System.Windows.Forms.ListBox lb)
		{
			lb.Items.Clear();
			foreach(string obj in commands)
			lb.Items.Add(obj);
		}
		
		public void Clear()
		{
			commands.Clear();
		}
		
	}
}
