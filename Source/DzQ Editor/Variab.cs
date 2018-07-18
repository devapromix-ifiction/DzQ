/*
 * Created by SharpDevelop.
 * User: ????????
 * Date: 17.11.2010
 * Time: 22:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace DzQ_Editor
{
	/// <summary>
	/// Description of Variab.
	/// </summary>
	[Serializable]
	public class Variab : QuestObject
	{
		bool isNumber=false, isText=false;
		public void SetType(string st)
		{
			if(st=="number")isNumber=true;
			if(st=="text")isText=true;
			
		}
		string t;
		float n;
		public float asN
		{
			set{n=value;}
			get{return n;}
		}
		public string asT
		{
			set{t=value;}
			get{return t;}
		}
		public string getTp()
		{
			if(isNumber)return "number";
			return "text";
		}
		public string getVal()
		{
			
			if(isNumber) return n.ToString();
			return t;
		}
		public void setVal(string inp)
		{
			if((isNumber)&&(inp!="")) 
			{
				try{n=Convert.ToSingle (inp);}
				catch{n=0;}
				return;
			}
			t = inp;
		}
	}
}
