/*
 * Created by SharpDevelop.
 * User: ????????
 * Date: 17.11.2010
 * Time: 20:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace DzQ_Editor
{
	/// <summary>
	/// Description of QuestObject.
	/// </summary>
	[Serializable]
	abstract public class QuestObject
	{
		public QuestObject()
		{
		}
		string thename;
		public string name
		{
			set{thename = value;}
			get{return thename;}
		}
		[NonSerialized]
		protected Storage st;
	}

}
