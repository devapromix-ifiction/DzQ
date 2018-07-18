/*
 * Created by SharpDevelop.
 * User: ????????
 * Date: 17.11.2010
 * Time: 20:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace DzQ
{
	/// <summary>
	/// Description of Decoder.
	/// </summary>
	public class Decoder
	{
		MainForm mf;
		string[] tf;
		Location loca;
		myItem itm;
		CmBlock cmb;
		bool waitloc ,waitact, waitblc,waitaut,waititm ,waitclk;
		int lastsmb=0;
		int str=0, smb=0;
		int roomcount=0;
	    string curline;
		public Decoder(MainForm p)
		{
			mf = p;
		}
		string readnextword(int nst, int nsb)
		{
			int i = 0;
			string result="";
			for(i=nsb;i<tf[nst].Length;i++)
			{
				lastsmb = i;
				if ((tf[nst][i]!=' ')&&(tf[nst][i]!='\n'))result+=tf[nst][i];
				else break;
			}

			curline = result;
			for(i=i;i<(tf[nst].Length);i++) curline+=tf[nst][i];
			
			return result;
		}
		
		void processing(string curword)
		{
			if((waitact)||(waitblc))
			{
				if(waitact)
					cmb = new myAction(mf);
				else cmb = new CmBlock(mf);
				cmb.name = curline;
				
				do
				{
					str++;
					if((tf[str]!="/act")&&(tf[str]!="/block")&&(tf[str]!="/b"))
						cmb.AddCommand(tf[str]);
					
				}
				while((tf[str]!="/act")&&(tf[str]!="/block")&&(tf[str]!="/b"));
				str--;
				if(waitact) waitact = false; else waitblc = false;
			}
			if(waitloc)
				{
				loca = new Location(mf);
				loca.name = curword;
				do
				{
					str++;
					if(tf[str]!="/descr")
						loca.discr += tf[str]+'\n';
					
				}
				while(tf[str]!="/descr");
				waitloc = false;
				}
				if(curword=="*loc")
				{
					roomcount++;
					waitloc=true;
				}
				if(curword=="/loc")
				{
					waitloc = false;
					waitact = false;
					waitblc = false;
					waitaut = false;
					mf.theCore.AddRoom(loca);
					if(roomcount==1)mf.FirstRoom = loca.name;
					loca=null;
				}
				if(curword=="*act")
				{
					waitact=true;
				}
				if(curword=="/act")
				{
					waitact = false;
					(cmb as IAction).visible = true;
					loca.AddCmBlock(cmb);
					cmb=null;
				}
				if((curword=="/block")||(curword=="/b"))
				{
					waitblc = false;
					if(loca!=null)
						loca.AddCmBlock(cmb);
						else
						mf.theCore.getGlobPtr().AddCmBlock(cmb);
						
					cmb=null;
				}
				if(waitaut)
				{
					loca.Auto = curword;
					waitaut = false;
				}
				if(waititm)
				{
					itm.name = curline;//.Remove((curline.Length-1),1);
					waititm = false;
				}
				if(waitclk)
				{
					itm.Onclick = curline;
					waitclk = false;
				}
				if((curword=="*block")||(curword=="*b"))
				{
					waitblc=true;
				}
				if(curword=="*auto")
		      	{
		      		waitaut=true;
		      	}
				if(curword=="*item")
				{
					itm = new myItem();
					waititm=true;
				}
				if(curword=="*onclick")
				{
					waitclk=true;
				}
				if(curword=="/item")
				{
					waitclk=false;
					waititm=false;
					mf.theCore.AddItem(itm);
					
					itm = null;
				}
		}
		public void openfile(string nm)
		{
			lastsmb=0;
			str=0;smb=0;
		    roomcount=0;
		    mf.theCore.Questname=nm;
			if (File.Exists(@nm))
			tf = File.ReadAllLines(@nm);
			else {System.Windows.Forms.MessageBox.Show("File "+@nm+" is not exist!","!!!"); return;};
			
			string curword="";
			do
			{
				curword = readnextword(str, smb);
				processing(curword);
				smb = lastsmb;
				smb++;
				if (smb>=tf[str].Length)
				{
					str++;
					smb = 0;
				}
			
			
		
		}
			while(str<tf.Length);
	}
	}
	}

