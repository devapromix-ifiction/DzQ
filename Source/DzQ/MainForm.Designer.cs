/*
 * Created by SharpDevelop.
 * User: ????????
 * Date: 17.11.2010
 * Time: 20:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DzQ
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.квестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.запускКвестаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.загрузитьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.перезапуститьКвестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.actlist = new System.Windows.Forms.ListBox();
			this.itemlist = new System.Windows.Forms.ListBox();
			this.menuStrip1.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(516, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "v 1.2.1 BETA";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.квестToolStripMenuItem,
									this.настройкиToolStripMenuItem,
									this.оПрограммеToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(640, 28);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1ItemClicked);
			// 
			// квестToolStripMenuItem
			// 
			this.квестToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.запускКвестаToolStripMenuItem,
									this.сохранитьИгруToolStripMenuItem,
									this.загрузитьИгруToolStripMenuItem,
									this.перезапуститьКвестToolStripMenuItem,
									this.выходToolStripMenuItem});
			this.квестToolStripMenuItem.Name = "квестToolStripMenuItem";
			this.квестToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
			this.квестToolStripMenuItem.Text = "Квест";
			// 
			// запускКвестаToolStripMenuItem
			// 
			this.запускКвестаToolStripMenuItem.Name = "запускКвестаToolStripMenuItem";
			this.запускКвестаToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
			this.запускКвестаToolStripMenuItem.Text = "Запуск квеста...";
			this.запускКвестаToolStripMenuItem.Click += new System.EventHandler(this.ЗапускКвестаToolStripMenuItemClick);
			// 
			// сохранитьИгруToolStripMenuItem
			// 
			this.сохранитьИгруToolStripMenuItem.Name = "сохранитьИгруToolStripMenuItem";
			this.сохранитьИгруToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
			this.сохранитьИгруToolStripMenuItem.Text = "Сохранить игру...";
			this.сохранитьИгруToolStripMenuItem.Click += new System.EventHandler(this.СохранитьИгруToolStripMenuItemClick);
			// 
			// загрузитьИгруToolStripMenuItem
			// 
			this.загрузитьИгруToolStripMenuItem.Name = "загрузитьИгруToolStripMenuItem";
			this.загрузитьИгруToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
			this.загрузитьИгруToolStripMenuItem.Text = "Загрузить игру...";
			this.загрузитьИгруToolStripMenuItem.Click += new System.EventHandler(this.ЗагрузитьИгруToolStripMenuItemClick);
			// 
			// перезапуститьКвестToolStripMenuItem
			// 
			this.перезапуститьКвестToolStripMenuItem.Name = "перезапуститьКвестToolStripMenuItem";
			this.перезапуститьКвестToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
			this.перезапуститьКвестToolStripMenuItem.Text = "Перезапустить квест";
			this.перезапуститьКвестToolStripMenuItem.Click += new System.EventHandler(this.ПерезапуститьКвестToolStripMenuItemClick);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItemClick);
			// 
			// настройкиToolStripMenuItem
			// 
			this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
			this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
			this.настройкиToolStripMenuItem.Text = "Настройки";
			this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.НастройкиToolStripMenuItemClick);
			// 
			// оПрограммеToolStripMenuItem
			// 
			this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
			this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
			this.оПрограммеToolStripMenuItem.Text = "О программе...";
			this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItemClick);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 100000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "\"DzQ files (*.dzq)|*.dzq";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1FileOk);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 28);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.itemlist);
			this.splitContainer1.Size = new System.Drawing.Size(640, 486);
			this.splitContainer1.SplitterDistance = 523;
			this.splitContainer1.TabIndex = 5;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.richTextBox1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.actlist);
			this.splitContainer2.Size = new System.Drawing.Size(523, 486);
			this.splitContainer2.SplitterDistance = 380;
			this.splitContainer2.TabIndex = 0;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Location = new System.Drawing.Point(0, 0);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(523, 380);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// actlist
			// 
			this.actlist.Dock = System.Windows.Forms.DockStyle.Fill;
			this.actlist.FormattingEnabled = true;
			this.actlist.ItemHeight = 16;
			this.actlist.Location = new System.Drawing.Point(0, 0);
			this.actlist.Name = "actlist";
			this.actlist.Size = new System.Drawing.Size(523, 100);
			this.actlist.TabIndex = 0;
			this.actlist.SelectedIndexChanged += new System.EventHandler(this.ActlistSelectedIndexChanged);
			this.actlist.DoubleClick += new System.EventHandler(this.ActlistDoubleClick);
			this.actlist.Click += new System.EventHandler(this.ActlistClick);
			// 
			// itemlist
			// 
			this.itemlist.Dock = System.Windows.Forms.DockStyle.Fill;
			this.itemlist.FormattingEnabled = true;
			this.itemlist.ItemHeight = 16;
			this.itemlist.Location = new System.Drawing.Point(0, 0);
			this.itemlist.Name = "itemlist";
			this.itemlist.Size = new System.Drawing.Size(113, 484);
			this.itemlist.TabIndex = 0;
			this.itemlist.DoubleClick += new System.EventHandler(this.ItemlistDoubleClick);
			this.itemlist.Click += new System.EventHandler(this.ItemlistDoubleClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 514);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "DzQ Platform";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ToolStripMenuItem перезапуститьКвестToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem загрузитьИгруToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem сохранитьИгруToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem запускКвестаToolStripMenuItem;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ListBox itemlist;
		private System.Windows.Forms.ListBox actlist;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem квестToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		
		void MenuStrip1ItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
		{
			
		}
		
		void СохранитьИгруToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			saveFileDialog1.FileName = "";
			saveFileDialog1.Filter = "DzQ save files (*.sav)|*.sav";
			saveFileDialog1.ShowDialog();
			if (saveFileDialog1.FileName!="")
			{
				Saver saver = new Saver(core);
				saver.save(saveFileDialog1.FileName);
			}
		}
		
		void OpenFileDialog1FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
		}
	}
}
