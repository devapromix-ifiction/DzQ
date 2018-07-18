/*
 * Created by SharpDevelop.
 * User: ????????
 * Date: 18.11.2010
 * Time: 8:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace DzQ
{
	/// <summary>
	/// Description of CommandItem.
	/// </summary>
	[Serializable]
	public class CmBlock : QuestObject
	{
	
		static CmBlock lastExecutedBlock;
		public static bool NeedStop {
			set { needStop = value; }
		}
		static bool needStop = false;
		
		public CmBlock(MainForm p)
		{
			mf = p;
		}
		public CmBlock()
		{
			
		}
		
		
		System.Collections.ArrayList commands = new System.Collections.ArrayList();
		public void AddCommand(string cm)
		{
			commands.Add(cm);
		}
		public void Execute()
		{
			foreach(string st in commands)
			{
				lastExecutedBlock = this;
				if(needStop)
				{
					needStop = false;
					break;
				}
				else mf.theCore.ExecCommand(st);
			}
					
		}
	}
}
