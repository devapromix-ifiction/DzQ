/*
 * Created by SharpDevelop.
 * User: ?????????????
 * Date: 05.12.2010
 * Time: 14:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DzQ_Editor
{
	partial class LocEd
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button7 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(425, 556);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(299, 24);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(336, 559);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Автозапуск";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(425, 593);
			this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(338, 24);
			this.comboBox2.TabIndex = 2;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(7, 559);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(168, 33);
			this.button1.TabIndex = 4;
			this.button1.Text = "ОК";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(7, 619);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(168, 33);
			this.button2.TabIndex = 5;
			this.button2.Text = "Отмена";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(7, 59);
			this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(756, 492);
			this.richTextBox1.TabIndex = 6;
			this.richTextBox1.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(7, 30);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(181, 22);
			this.label3.TabIndex = 7;
			this.label3.Text = "Описание:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(7, 5);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(183, 25);
			this.label4.TabIndex = 8;
			this.label4.Text = "Название:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(135, 5);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(297, 22);
			this.textBox1.TabIndex = 9;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(425, 626);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(122, 26);
			this.button3.TabIndex = 10;
			this.button3.Text = "Добавить";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(665, 625);
			this.button4.Margin = new System.Windows.Forms.Padding(4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(98, 26);
			this.button4.TabIndex = 11;
			this.button4.Text = "Удалить";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(555, 625);
			this.button5.Margin = new System.Windows.Forms.Padding(4);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(102, 26);
			this.button5.TabIndex = 12;
			this.button5.Text = "Изм-ть";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(336, 593);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "Действия:";
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(513, 2);
			this.button6.Margin = new System.Windows.Forms.Padding(4);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(100, 49);
			this.button6.TabIndex = 14;
			this.button6.Text = "Сделать стартовой";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(621, 2);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(133, 33);
			this.label5.TabIndex = 15;
			this.label5.Text = "Текущая стартовая:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(621, 29);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(133, 22);
			this.label6.TabIndex = 16;
			// 
			// button7
			// 
			this.button7.AccessibleDescription = "Открыть блок автозапуска";
			this.button7.Location = new System.Drawing.Point(731, 556);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(32, 23);
			this.button7.TabIndex = 17;
			this.button7.Text = "см";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// LocEd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(767, 655);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(785, 700);
			this.MinimumSize = new System.Drawing.Size(785, 700);
			this.Name = "LocEd";
			this.Text = "Редактор локаций";
			this.Load += new System.EventHandler(this.LocEdLoad);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LocEdMouseMove);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}
