/*
 * Created by SharpDevelop.
 * User: Boss
 * Date: 09.05.2011
 * Time: 17:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DzQ
{
	/// <summary>
	/// Description of Options.
	/// </summary>
	public partial class Options : Form
	{
		public Options(MainForm mf)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//

			InitializeComponent();
			vals = new Values();
			this.mf = mf;
			 //TODO: Add constructor code after the InitializeComponent() call.
			
		}
		MainForm mf;
		bool readfileok = true;
		
		[Serializable]
		public class Values
		{
			
			
			public Values()
			{
				
			}
			string nameFont;
			string htmlFont;
			string htmlBack; 
			float sizeFont;
			Font fontType;
			Color fontColor;
			Color backColor;
			int[] sdist = new int[1];
			
			
			public int[] Sdist {
				get { return sdist; }
				set { sdist = value; }
			}
			
			
			public void ConvertIt()
			{
				fontType = new Font(nameFont, sizeFont);
				fontColor = ColorTranslator.FromHtml(htmlFont);
				backColor = ColorTranslator.FromHtml(htmlBack);
			}
			
			public void ConvertToS()
			{
				sizeFont = fontType.Size;
				nameFont = fontType.Name;
				htmlBack = ColorTranslator.ToHtml(backColor);
				htmlFont = ColorTranslator.ToHtml(fontColor);
			}
			
			public Font FontType {
				get { return fontType; }
				set { fontType = value; }
			}
			
			public Color FontColor {
				get { return fontColor; }
				set { fontColor = value; }
			}
			
			public Color BackColor {
				get { return backColor; }
				set { backColor = value; }
			}
			
			public bool Allow2click {
				get { return allow2click; }
				set { allow2click = value; }
			}
			
			bool allow2click;
		}
		Values vals;
		void Button3Click(object sender, EventArgs e)
		{
			fontDialog1.ShowColor = true;
			fontDialog1.ShowDialog();
			vals.FontType = fontDialog1.Font;
			vals.FontColor = fontDialog1.Color;
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			colorDialog1.ShowDialog();
			vals.BackColor = colorDialog1.Color;
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			vals.Allow2click = checkBox1.Checked;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			vals.Sdist = mf.GetSplitContainersDistance();
		
			ThrowOptions(vals);
			saveOptions();
			this.Hide();
		}
		
		void saveOptions()
		{
			string nm = "dzqconfig.bin";
			
			vals.ConvertToS();
			FileStream fs = new FileStream(nm, FileMode.Create, FileAccess.Write); 
            IFormatter bf = new BinaryFormatter(); 
            bf.Serialize(fs, vals);
            fs.Close(); 
            
		}

		void loadOptions()
		{
			string nm = "dzqconfig.bin";
			vals = new Values();
			FileStream fs = new FileStream(nm, FileMode.Open, FileAccess.Read); 
			IFormatter bf = new BinaryFormatter();
			vals = (bf.Deserialize(fs) as Values);
            fs.Close(); 
            vals.ConvertIt();
            

		}
		
		public delegate void OptionsEventHandler(Values vals);
		public event OptionsEventHandler ThrowOptions;
		
		public void InstallOptions()
		{
			try
				
			{
				loadOptions();
			    readfileok = true;
			}
			catch
			{
				MessageBox.Show("Ошибка файла dzqconfig.bin! Откат к настройкам по умолчанию.","Внимание!");
				readfileok = false;
			}
			ThrowOptions(vals);
		}
		
		void OptionsLoad(object sender, EventArgs e)
		{
			
			
			if(readfileok)
			{
				fontDialog1.Font = vals.FontType;
				fontDialog1.Color = vals.FontColor;
				colorDialog1.Color = vals.BackColor;
				checkBox1.Checked = vals.Allow2click;
		
			}
		}
		
		void FontDialog1Apply(object sender, EventArgs e)
		{
			
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			
		}
	}
}
