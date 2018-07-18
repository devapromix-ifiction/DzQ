// LOCATION OF FULL VERSION OF THE LICENSE: source\license.txt;
// DzQ Platform
// Copyright (C) 2010 - 2011 Petrov "DzafT" Pyotr
// 
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
/*
 * Created by SharpDevelop.
 * User: ????????
 * Date: 17.11.2010
 * Time: 20:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections;
using System.Windows.Forms;
using System.Threading;
namespace DzQ
{
	/// <summary>
	/// Description of Core.
	/// </summary>

	public class Core
	{

		MainForm mf;
		MultimediaManager mediaMan;
		public Core(MainForm p)
		{
			Reset();
			mf = p;
			globals = new Location(mf);
			mediaMan = new MultimediaManager();
		}
			[Serializable]
		public class Vd
		{
			public ArrayList vars = new ArrayList();
			public ArrayList itms = new ArrayList();
			public ArrayList rooms = new ArrayList();
		}
		//Vd is "Variable Data", it is used in saving process
		public Vd VD {
			get { return vd; }
			set { vd = value; }
		}
		Vd vd = new Vd();
		
		
		Location curloc, prevloc, globals;
		Variab vari;
		Random rnd = new Random();
		
		public string Questname {
			get { return questname; }
			set { questname = value; }
		}
		string questname;
		public void Reset()
		{
			vd.rooms.Clear();
			vd.vars.Clear();
			vd.itms.Clear();
			AddVar("text","curloc","");
			AddVar("number","visit","");
			
		}

		int WordQ(string st)
		{
			int ans = 1;
			for(int i=0;i<st.Length;i++)
				if(st[i]==' ')ans++;
			return ans;
		}
		
		string GetWord(string st, int cn)
		{
			int i=0, counter=0;
			string result = "";
			for(i=0;i<st.Length;i++)
				{
			
				if(st[i]==' ')
					{
					if (counter == cn) return result;else
					{
						result="";
						++counter;
					}
					}else
					result=result+st[i];

			}
			if (counter != cn) result = ""; //!!!
			return result;
		}
		string GetLine(string st, int cn)
		{
			
			int i=0, counter=0;
			string result = "";
			for(i=0;i<st.Length;i++)
				{
				if(counter>=cn) result+=st[i];
				if(st[i]==' ') ++counter; 
				}
		
			return result;
		}
		public void AddItem(myItem itm)
		{
			
			vd.itms.Add(itm);
		}
		public void AddRoom(Location lc)
		{
			vd.rooms.Add(lc);
		}
		public void userClickAction(string nm)
		{
			curloc.GetCmBlock(nm).ReanimateLinks(mf);
			curloc.GetCmBlock(nm).Execute();
		}
		
		public void userItemClick(string nm)
		{
			myItem obj = GetItem(nm);
			
			if (obj==null) return;
			ExecCommand(obj.Onclick);
		}
		
		Location GetRoom(string nm) //must be private
		{
			foreach(Location obj in vd.rooms)
				if(obj.name==nm)return obj;
			return null;
		}
		myItem GetItem(string nm)
		{

			foreach(myItem obj in vd.itms)
			{
				iwdc = WordQ(obj.name);	
				if(obj.name==nm)return obj;
				if(GetWord(obj.name,0)==nm)return obj;
			}
			return null;
		}
		void GoRoom(string nm)
		{
			
			mf.AllClear();
			ChangeRoom(nm);
		}
		void XGoRoom(string nm)
		{
			mf.Actlist.Items.Clear();
			ChangeRoom(nm);
		}
		void ChangeRoom(string nm)
		{
			if(GetRoom(nm)!=null)
				{
				prevloc=curloc;
				curloc=GetRoom(nm);
				}else 
				{
				if((GetVar(nm)!=null)&&(GetVar(nm).getTp()=="text"))
				   {
				   	GoRoom(GetVar(nm).getVal());
				   }else return;
				}
			GetVar("curloc").asT = curloc.name;
			curloc.ReanimateLinks(mf);
			curloc.Show();
			curloc.Visit++;
			GetVar("visit").asN = curloc.Visit;
			RunCmBlock(curloc.Auto);
		}
		
		void AddVar(string iden, string nm, string val)
		{
			if(GetVar(nm)!=null)return;
			vari = new Variab(iden);
			vari.name=nm;
			vari.setVal(val);
			vd.vars.Add(vari);
			vari=null;
		}
		Variab GetVar(string nm)
		{
			foreach(Variab obj in vd.vars)
				if(obj.name==nm)return obj;
			return null;
		}
		
		Variab toVar(string val)
		{
			Variab v = new Variab("");
			try{v.asN=Convert.ToSingle(val);}
			catch{
				if(GetVar(val)!=null) v = GetVar(val);
					else v.asT = val;
			}
			return v;
		}
		
		void Compute(string varresult, string var1, string ac,string var2)
		{ //?????????? ??? ????????
			Variab v1 = toVar(var1);
			Variab v2 = toVar(var2);
			Variab vr = GetVar(varresult);
			if(ac=="+")vr.asN=v1.asN+v2.asN;
			if(ac=="-")vr.asN=v1.asN-v2.asN;
			if(ac=="*")vr.asN=v1.asN*v2.asN;
			if(ac=="/")vr.asN=v1.asN/v2.asN;
			if(ac=="^")vr.asN=Convert.ToSingle(Math.Exp(v2.asN*Math.Log(v1.asN)));
		}
		void wr(string st)
		{
			mf.RichTextBox1.AppendText(st);
			mf.RichTextBox1.ScrollToCaret();
		}
		public Location getGlobPtr()
		{
			return globals;
		}
		
		void DoRandom(string vr, string ildown, string ilup)
		{
			int ldown = Convert.ToInt16(toVar(ildown).asN);
			int lup = Convert.ToInt16(toVar(ilup).asN);
			GetVar(vr).asN = rnd.Next(ldown, lup);
			
		}
		
		void RunCmBlock(string nm)
		{
			CmBlock obj;
			obj = curloc.GetCmBlock(nm);
			if(obj==null) obj = globals.GetCmBlock(nm);
			if((obj!=null)) obj.Execute();
			//if(obj==null) MessageBox.Show("Block "+nm+" is bad!");
		}
		void PlusItem(string nm)
		{
			myItem obj = GetItem(nm);
		
			if(obj!=null)
			{
			obj.InBag = true;
			mf.Itemlist.Items.Add(obj.name );
			}
		}
		void MinusItem(string nm)
		{
			myItem obj = GetItem(nm);
			if((obj!=null)&&(obj.InBag==true))
			{
			obj.InBag = false;
			mf.Itemlist.Items.Remove(obj.name );
			}
		}
		
		public void RefreshItems()
		{
			mf.Itemlist.Items.Clear();
			foreach(myItem obj in vd.itms)
			{
				if(obj.InBag)
					mf.Itemlist.Items.Add(obj.name);
			}
		}
		
		bool compare(string left, string znk, string right)
		{
			Variab lft = new Variab("lft");
			Variab rgt = new Variab("rgt");
			
			lft = toVar(left);
			rgt = toVar(right);
			
			
			float l = lft.asN;
			float r = rgt.asN;
			
			if (znk=="==")
				if(l==r) return true;
			if (znk=="!=")
				if(l!=r) return true;
			if (znk==">")
				if(l>r)return true;
			if (znk=="<")
				if(l<r)return true;
			if (znk==">=")
				if(l>=r)return true;
			if (znk=="<=")
				if(l<=r)return true;
			
			
			return false;
		}
		
		void ifText(string cm)
		{
			int pos=1;
			string l;
			string r;
			bool rs=false;
			if (GetWord(cm,pos)=="textvar")
			{
				l = GetVar(GetWord(cm,2)).asT;
				pos = 2;
			}
			else 
			{
				l = GetWord(cm,1);
				pos = 1;
			}
			pos++;
			string znk =  GetWord(cm,pos);
			pos++;
			if (GetWord(cm,pos)=="textvar")
				r = GetVar(GetWord(cm,(++pos))).asT;
			else 
				r = GetWord(cm,pos);
			++pos;
			if ((l==r)&&(znk=="==")) rs=true;
			if ((l!=r)&&(znk=="!=")) rs=true;
			if(rs)ExecCommand(GetLine(cm,pos));
				//else if(GetWord(cm,pos)=="or")ExecCommand(GetLine(cm,pos));
				else lastIfResult = false;
		}
			
		
		int iwdc = 0;
		void bagItem(string cm)
		{
			iwdc = 0;
			if ((GetWord(cm,1)=="have")&&
			    (GetItem(GetWord(cm,2))!=null)&&
			    (GetItem(GetWord(cm,2)).InBag)) ExecCommand(GetLine(cm,iwdc+2));
			//else if(GetWord(cm,3)=="or")ExecCommand(GetLine(cm,iwdc+2));
			else if ((GetWord(cm,1)=="havent")&&
			    (GetItem(GetWord(cm,2))!=null)&&
			    (!GetItem(GetWord(cm,2)).InBag)) ExecCommand(GetLine(cm,iwdc+2));
			//else if(GetWord(cm,3)=="or")ExecCommand(GetLine(cm,iwdc+2));
			else lastIfResult = false;
		}
		
		bool lastIfResult;
		bool lastIf;
		void operIf(string cm)
		{
			lastIf = true;
			lastIfResult = true;
			if ((GetWord(cm,1)=="textvar")||(GetWord(cm,4)=="textvar")) ifText(cm);
			else
			if ((GetWord(cm,1)=="have")||(GetWord(cm,1)=="havent")) bagItem(cm);
			else
			if (compare(GetWord(cm,1),GetWord(cm,2),GetWord(cm,3)))
				ExecCommand(GetLine(cm,4));
			//else if(GetWord(cm,4)=="or") ExecCommand(GetLine(cm,4));
			else lastIfResult = false;
		}
		
		void operElse(string opr)
		{
			lastIf = false;
			if (!lastIfResult) ExecCommand(opr);
		}
		void operMore(string opr)
		{
			if ((lastIfResult)&&(lastIf)) ExecCommand(opr);
			if ((!(lastIfResult))&&(!(lastIf))) ExecCommand(opr);
		}
		
		public string InputText {
			get { return inputText; }
			set { inputText = value; }
		}
		string inputText;
		void Input(string vr, string lb)
		{
			InputBox ib = new InputBox(this,lb);
			ib.ShowDialog();
			GetVar(vr).setVal(InputText);
		}
		
		void Equal(string cm)
		{
			if( GetVar(GetWord(cm,0)).getTp() == "number")
			{
				float ans = toVar(GetWord(cm,2)).asN;
				int w = 3;
				do
				{
					if (GetWord(cm,w)=="+") ans = ans + toVar(GetWord(cm,++w)).asN;
					if (GetWord(cm,w)=="-") ans = ans - toVar(GetWord(cm,++w)).asN;
					if (GetWord(cm,w)=="*") ans = ans * toVar(GetWord(cm,++w)).asN;
					if (GetWord(cm,w)=="/") ans = ans / toVar(GetWord(cm,++w)).asN;
					if (GetWord(cm,w)=="^") ans = Convert.ToSingle(Math.Exp(toVar(GetWord(cm,++w)).asN*Math.Log(ans)));
					w++;
				}
				while(GetWord(cm,w)!="");
					GetVar(GetWord(cm,0)).asN = ans;
			}
			else
				GetVar(GetWord(cm,0)).asT = GetLine(cm,2);//toVar(GetWord(cm,2)).asT;
		}
		
		void Wait(int i)
		{
			mf.RichTextBox1.Refresh();
			Thread.Sleep(i);
		
		}
		
		void ClearInv()
		{
			mf.Itemlist.Items.Clear();
			foreach(myItem obj in vd.itms)
				obj.InBag = false;
		}
		
		void RestartQuest()
		{
			mf.StartQuest(Questname);
		}
		
		public void ExecCommand(string cm)
		{
			if (GetWord(cm,0)=="go") GoRoom(GetLine(cm,1));
			if (GetWord(cm,0)=="xgo") XGoRoom(GetLine(cm,1));
			if (GetWord(cm,0)=="settimer") mf.SetTimer(GetWord(cm,1),toVar(GetWord(cm,2)).asN.ToString());
			if (GetWord(cm,0)=="clear") mf.RichTextBox1.Clear();
			if (GetWord(cm,0)=="clearall") mf.AllClear();
			if (GetWord(cm,0)=="exit") Application.Exit();
			if (GetWord(cm,0)=="hide") curloc.HideAction(GetLine(cm,1));
			if (GetWord(cm,0)=="show") curloc.ShowAction(GetLine(cm,1));
			if (GetWord(cm,0)=="var") AddVar(GetWord(cm,1), GetWord(cm,2), GetWord(cm,3));
			if (GetWord(cm,0)=="+item") PlusItem(GetLine(cm,1));
			if (GetWord(cm,0)=="-item") MinusItem(GetLine(cm,1));
			if ((GetWord(cm,0)=="if")||(GetWord(cm,0)=="and")||(GetWord(cm,0)=="or") )operIf(cm);
			if ((GetWord(cm,0)=="else")) operElse(GetLine(cm,1));
			if ((GetWord(cm,0)=="&")||(GetWord(cm,0)=="more")) operMore(GetLine(cm,1));
			if (GetWord(cm,0)=="compute") Compute(GetWord(cm,1),GetWord(cm,2),GetWord(cm,3),GetWord(cm,4));
			if (GetWord(cm,1)=="=") Equal(cm);
			if ((GetWord(cm,0)=="w")&&(GetWord(cm,1)!="var")) wr(GetLine(cm,1));
			if ((GetWord(cm,0)=="wln")&&(GetWord(cm,1)!="var")) wr(GetLine(cm,1)+'\n');
			if ((GetWord(cm,0)=="w")&&(GetWord(cm,1)=="var")) wr(GetVar(GetWord(cm,2)).getVal());
			if ((GetWord(cm,0)=="wln")&&(GetWord(cm,1)=="var")) wr(GetVar(GetWord(cm,2)).getVal()+'\n');
			if ((GetWord(cm,0)=="set")||(GetWord(cm,0)=="setvar")) Equal(GetWord(cm,1)+" = "+GetLine(cm,2)); //Знаю, слева костыль! GetVar(GetWord(cm,1)).setVal(GetLine(cm,2));
			if (GetWord(cm,0)=="run") RunCmBlock(GetWord(cm,1));
			if (GetWord(cm,0)=="runauto") RunCmBlock(curloc.Auto);
			if (GetWord(cm,0)=="goprev") GoRoom(prevloc.name);
			if (GetWord(cm,0)=="space") GetVar(GetWord(cm,1)).asT+=" ";
			if (GetWord(cm,0)=="connect") GetVar(GetWord(cm,1)).asT=(GetVar(GetWord(cm,2))).asT + (toVar(GetLine(cm,3))).asT;
			if (GetWord(cm,0)=="clone") GetVar(GetWord(cm,1)).asT=(GetVar(GetWord(cm,2))).asT;
			if (GetWord(cm,0)=="random") DoRandom(GetWord(cm,1),GetWord(cm,2),GetWord(cm,3));
			if (GetWord(cm,0)=="input") Input(GetWord(cm,1),GetLine(cm,2));
			if (GetWord(cm,0)=="wait") Wait(Convert.ToInt32(toVar((GetWord(cm,1))).asN));
			if (GetWord(cm,0)=="clearinv") ClearInv();
			if (GetWord(cm,0)=="restartquest") RestartQuest();
			if (GetWord(cm,0)=="image") mediaMan.ShowImage(GetWord(cm,1));
			if (GetWord(cm,0)=="playwave") mediaMan.PlayWave(GetWord(cm,1));
			if (GetWord(cm,0)=="showall") curloc.ShowAllActions();
			if (GetWord(cm,0)=="hideall") curloc.HideAllActions();
			if (GetWord(cm,0)=="sin") GetVar(GetWord(cm,1)).asN = (float)(Math.Sin(toVar(GetWord(cm,2)).asNDouble));
			if (GetWord(cm,0)=="cos") GetVar(GetWord(cm,1)).asN = (float)(Math.Cos(toVar(GetWord(cm,2)).asNDouble));
			if (GetWord(cm,0)=="trunc") GetVar(GetWord(cm,1)).asN = (float)(Math.Truncate(toVar(GetWord(cm,1)).asNDouble));
			if (GetWord(cm,0)=="round") GetVar(GetWord(cm,1)).asN = (float)(Math.Round(toVar(GetWord(cm,1)).asNDouble));
			if (GetWord(cm,0)=="stopblock") CmBlock.NeedStop = true;
			if (GetWord(cm,0)=="for") 
			{
				for(double w = GetVar(GetWord(cm,1)).asN-1; w<=toVar(GetWord(cm,2)).asN-1; w++)
				{
				toVar(GetWord(cm,1)).asN++;
				ExecCommand("run "+GetWord(cm,3));
				
				}
			}
			
			
		}
	}
}
