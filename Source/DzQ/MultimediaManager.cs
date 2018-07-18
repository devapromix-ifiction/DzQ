/*
 * Coder: DzafT
 * Date: 11.05.2011
 * Time: 21:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Media;

namespace DzQ
{
	/// <summary>
	/// Description of MultimediaManager.
	/// </summary>
	public class MultimediaManager
	{
		ImageBox imgb;
		SoundPlayer sndp;
		public MultimediaManager()
		{
			imgb = new ImageBox();
			sndp = new SoundPlayer();
		}
		
		public void ShowImage(string path)
		{
			try
			{
			imgb.SetImage(path);
			imgb.Show();
			}
			catch
			{
			imgb.SetImage(@"Quests\"+path);
			imgb.Show();
			}
		}
		
		public void PlayWave(string path)
		{
			try
			{
			sndp = new SoundPlayer(path);
			sndp.Play();
			}
			catch
			{
			sndp = new SoundPlayer(@"Quests\"+path);
			sndp.Play();
			}
			
		}
		
	}
}
