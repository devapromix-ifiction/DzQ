/*
 * Created by SharpDevelop.
 * User: ?????????????
 * Date: 05.12.2010
 * Time: 16:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DzQ_Editor
{
	partial class CmbEd
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(2, 46);
			this.listBox1.Margin = new System.Windows.Forms.Padding(4);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(594, 484);
			this.listBox1.TabIndex = 0;
			this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox1MouseDoubleClick);
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 27);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(251, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Комманды:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(143, 536);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(142, 28);
			this.button1.TabIndex = 3;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(292, 571);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(130, 28);
			this.button2.TabIndex = 4;
			this.button2.Text = "Удалить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(429, 535);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(167, 28);
			this.button3.TabIndex = 5;
			this.button3.Text = "Вверх";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(429, 571);
			this.button4.Margin = new System.Windows.Forms.Padding(4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(167, 28);
			this.button4.TabIndex = 6;
			this.button4.Text = "Вниз";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(3, 536);
			this.button5.Margin = new System.Windows.Forms.Padding(4);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(132, 28);
			this.button5.TabIndex = 7;
			this.button5.Text = "ОК";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(3, 572);
			this.button6.Margin = new System.Windows.Forms.Padding(4);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(132, 28);
			this.button6.TabIndex = 8;
			this.button6.Text = "Отмена";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(143, 572);
			this.button7.Margin = new System.Windows.Forms.Padding(4);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(39, 28);
			this.button7.TabIndex = 9;
			this.button7.Text = "&&";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(292, 537);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(130, 27);
			this.button8.TabIndex = 10;
			this.button8.Text = "Редактировать";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(104, 2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(268, 22);
			this.textBox1.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(3, 2);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 23);
			this.label2.TabIndex = 12;
			this.label2.Text = "Название:";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// CmbEd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(609, 600);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(627, 645);
			this.MinimumSize = new System.Drawing.Size(627, 645);
			this.Name = "CmbEd";
			this.Text = "Редактор блоков";
			this.Load += new System.EventHandler(this.CmbEdLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBox1;
		
		void Button7Click(object sender, System.EventArgs e)
		{
		Lstcom = "";
		NewCom newcom = new NewCom(st,this);
		newcom.ShowDialog();
		if(Lstcom!="")listBox1.Items.Add("& "+Lstcom);										
		}
	}
}
