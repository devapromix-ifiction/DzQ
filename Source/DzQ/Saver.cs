/*
 * Created by SharpDevelop.
 * User: ?????????????
 * Date: 21.11.2010
 * Time: 22:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DzQ
{
	/// <summary>
	/// Description of Saver.
	/// </summary>
	public class Saver
	{
		Core core;
		public Saver(Core ptr)
		{
			core = ptr;
		}
		public void save(string nm)
		{
			FileStream fs = new FileStream(nm, FileMode.Create, FileAccess.Write); 
            IFormatter bf = new BinaryFormatter(); 
            bf.Serialize(fs, core.Questname); 
            bf.Serialize(fs, core.VD);
            fs.Close(); 

		}
		Core.Vd data;
		public void load(string nm)
		{
			data = new Core.Vd();
			 FileStream fs = new FileStream(nm, FileMode.Open, FileAccess.Read); 
			 IFormatter bf = new BinaryFormatter();
			 core.Questname = (bf.Deserialize(fs) as string);

			 data = (bf.Deserialize(fs) as Core.Vd);
			 
            fs.Close(); 

		}
		public void returndata()
		{
			core.VD = data;
			core.RefreshItems();
		}
	}
}
