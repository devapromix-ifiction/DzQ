/*
 * Created by SharpDevelop.
 * User: ????????
 * Date: 17.11.2010
 * Time: 20:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace DzQ
{
	/// <summary>
	/// Description of Action.
	/// </summary>
	[Serializable]
	public class myAction : CmBlock, IAction
	{

		public myAction(MainForm p)
		{
			mf = p;
		}
		bool visib;
		public bool visible
		{
			set{visib = value;}
			get{return visib;}
		}
		
	}
}
