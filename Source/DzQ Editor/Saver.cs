/*
 * Created by SharpDevelop.
 * User: ?????????????
 * Date: 05.12.2010
 * Time: 15:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.IO; 
using System.Runtime.Serialization; 
using System.Runtime.Serialization.Formatters.Binary;
namespace DzQ_Editor
{
	/// <summary>
	/// Description of Saver.
	/// </summary>
	public partial class Saver : Form
	{
		Storage store;
		MainForm mf;
		public Saver(Storage s)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			store = s;
			
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void save(string fn)
		{
            FileStream fs = new FileStream(fn, FileMode.Create, FileAccess.Write); 
            IFormatter bf = new BinaryFormatter(); 
            bf.Serialize(fs, store.dt); 
            fs.Close(); 
		}
		public void load(string fn)
		{
			IFormatter bf = new BinaryFormatter(); 
			FileStream fs = new FileStream(fn, FileMode.Open, FileAccess.Read);
            store.dt = (Storage.Dt)bf.Deserialize(fs); 
            fs.Close();
		}
		
		public void import(string fn)
		{
			IFormatter bf = new BinaryFormatter(); 
			FileStream fs = new FileStream(fn, FileMode.Open, FileAccess.Read);
			store.dt.Append((Storage.Dt)bf.Deserialize(fs));
            fs.Close();
		}
		
		void SaverLoad(object sender, EventArgs e)
		{
			
		}
	}
}
