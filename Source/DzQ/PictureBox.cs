/*
 * Created by SharpDevelop.
 * User: ?????????????
 * Date: 24.11.2010
 * Time: 21:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace DzQ
{
	/// <summary>
	/// Description of PictureBox.
	/// </summary>
	public partial class ImageBox : Form
	{
		public ImageBox()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void SetImage(string pth)
		{
			pictureBox1.Load(pth);
			this.Size = pictureBox1.Image.Size;
			this.TopMost = true;
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
			
		}
		
		void ImageBoxLoad(object sender, EventArgs e)
		{
			
		}
		
		void ImageBoxResize(object sender, EventArgs e)
		{
			
		}
	}
}
