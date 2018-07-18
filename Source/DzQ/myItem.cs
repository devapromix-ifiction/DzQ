/*
 * Created by SharpDevelop.
 * User: ????????
 * Date: 18.11.2010
 * Time: 18:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace DzQ
{
	/// <summary>
	/// Description of myItem.
	/// </summary>
	[Serializable]
	public class myItem : QuestObject
	{
		public myItem()
		{
		}
		public string Onclick {
			get { return onclick; }
			set { onclick = value; }
		}
		public bool InBag {
			get { return inBag; }
			set { inBag = value; }
		}
		bool inBag;
		string onclick;
	}
}
