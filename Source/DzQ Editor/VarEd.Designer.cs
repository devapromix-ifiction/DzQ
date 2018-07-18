/*
 * Created by SharpDevelop.
 * User: ?????????????
 * Date: 05.12.2010
 * Time: 12:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DzQ_Editor
{
	partial class VarEd
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(125, 11);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(267, 22);
			this.textBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(7, 10);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Название";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(11, 48);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(381, 63);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Тип";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(192, 20);
			this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(139, 30);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "Текстовый";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(20, 20);
			this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(139, 30);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Числовой";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(11, 114);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 30);
			this.label2.TabIndex = 3;
			this.label2.Text = "Начальное значение:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(173, 113);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(216, 22);
			this.textBox2.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 145);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(179, 32);
			this.button1.TabIndex = 5;
			this.button1.Text = "Применить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(203, 145);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(188, 32);
			this.button2.TabIndex = 6;
			this.button2.Text = "Отмена";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// VarEd
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(388, 178);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(406, 225);
			this.MinimumSize = new System.Drawing.Size(406, 225);
			this.Name = "VarEd";
			this.Text = "Редактор переменных";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
	}
}
