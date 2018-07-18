/*
 * Created by SharpDevelop.
 * User: ?????????????
 * Date: 05.12.2010
 * Time: 17:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DzQ_Editor
{
	partial class NewCom
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.cB1 = new System.Windows.Forms.ComboBox();
			this.cB2 = new System.Windows.Forms.ComboBox();
			this.cB3 = new System.Windows.Forms.ComboBox();
			this.cB4 = new System.Windows.Forms.ComboBox();
			this.cB5 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.help = new System.Windows.Forms.Label();
			this.tb = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.ed1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(17, 150);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 28);
			this.button1.TabIndex = 0;
			this.button1.Text = "ОК";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(132, 150);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(109, 28);
			this.button2.TabIndex = 1;
			this.button2.Text = "Отмена";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// cB1
			// 
			this.cB1.FormattingEnabled = true;
			this.cB1.Items.AddRange(new object[] {
									"ПЕРЕХОД (go)",
									"УСТАНОВИТЬ (set)",
									"ПОСЧИТАТЬ (compute)",
									"ЗАПУСК (run)",
									"ЕСЛИ [число] (if)",
									"ЕСЛИ [текст] (if)",
									"ЕСЛИ [предмет] (if)",
									"ИНАЧЕ (else)",
									"ЕЩЕ КОММАНДА (&)",
									"ВЫВОД+ENTER (wln)",
									"ВЫВОД (w)",
									"ВЫВОД+ENTER [переменная] (wln)",
									"ВЫВОД [переменная] (w)",
									"ДОБАВИТЬ ПРЕДМЕТ В ИНВЕНТАРЬ (+item)",
									"УДАЛИТЬ ПРЕДМЕТ ИЗ ИНВЕНТАРЯ (-item)",
									"СКРЫТЬ ДЕЙСТВИЕ (hide)",
									"ПОКАЗАТЬ ДЕЙСТВИЕ (show)",
									"ПОКАЗАТЬ ВСЕ ДЕЙСТВИЯ (showall)",
									"СКРЫТЬ ВСЕ ДЕЙСТВИЯ (hideall)",
									"ВВОД (input)",
									"ИНКРЕМЕНТ (x = x + 1)",
									"ДЕКРЕМЕНТ (x = x - 1)",
									"ПЕРЕХОД БЕЗ ОБНОВЛЕНИЯ ОПИСАНИЯ (xgo)",
									"ИЗОБРАЖЕНИЕ (image)",
									"ПРОИГРАТЬ ЗВУК (playwave)",
									"ПАУЗА (wait)",
									"СЛУЧАЙНОЕ ЧИСЛО (random)",
									"ВЕРНУТЬСЯ НА ПРЕД. ЛОКАЦИЮ (goprev)",
									"ПРЕКРАТИТЬ ВЫПОЛНЕНИЕ БЛОКА (stopblock)",
									"УСТАНОВИТЬ БЛОК-ТАЙМЕР (settimer)",
									"ЦИКЛ FOR (for)",
									"ДУБЛЬ ТЕКСТОВОЙ ПЕРЕМЕННОЙ (clone)",
									"СОЕДИНЕНИЕ СТРОК (connect)",
									"ОЧИСТИТЬ ИНВЕНТАРЬ (clearinv)",
									"ОЧИСТИТЬ ОКНО (clear)",
									"ОЧИСТИТЬ ВСЁ (clearall)",
									"СИНУС (sin)",
									"КОСИНУС (cos)",
									"ОКРУГЛИТЬ (round)",
									"ОТБРОСИТЬ ДРОБЬ (trunc)",
									"ПЕРЕЗАПУСТИТЬ КВЕСТ (restartquest)",
									"ВЫХОД ИЗ ПЛАТФОРМЫ (exit)"});
			this.cB1.Location = new System.Drawing.Point(16, 41);
			this.cB1.Margin = new System.Windows.Forms.Padding(4);
			this.cB1.MaxDropDownItems = 25;
			this.cB1.Name = "cB1";
			this.cB1.Size = new System.Drawing.Size(455, 24);
			this.cB1.TabIndex = 2;
			this.cB1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// cB2
			// 
			this.cB2.FormattingEnabled = true;
			this.cB2.Location = new System.Drawing.Point(16, 97);
			this.cB2.Margin = new System.Windows.Forms.Padding(4);
			this.cB2.Name = "cB2";
			this.cB2.Size = new System.Drawing.Size(107, 24);
			this.cB2.TabIndex = 3;
			this.cB2.Visible = false;
			this.cB2.SelectedIndexChanged += new System.EventHandler(this.CB5SelectedIndexChanged);
			// 
			// cB3
			// 
			this.cB3.FormattingEnabled = true;
			this.cB3.Location = new System.Drawing.Point(132, 97);
			this.cB3.Margin = new System.Windows.Forms.Padding(4);
			this.cB3.Name = "cB3";
			this.cB3.Size = new System.Drawing.Size(107, 24);
			this.cB3.TabIndex = 4;
			this.cB3.Visible = false;
			this.cB3.SelectedIndexChanged += new System.EventHandler(this.CB5SelectedIndexChanged);
			// 
			// cB4
			// 
			this.cB4.FormattingEnabled = true;
			this.cB4.Location = new System.Drawing.Point(248, 97);
			this.cB4.Margin = new System.Windows.Forms.Padding(4);
			this.cB4.Name = "cB4";
			this.cB4.Size = new System.Drawing.Size(107, 24);
			this.cB4.TabIndex = 5;
			this.cB4.Visible = false;
			this.cB4.SelectedIndexChanged += new System.EventHandler(this.CB5SelectedIndexChanged);
			// 
			// cB5
			// 
			this.cB5.FormattingEnabled = true;
			this.cB5.Location = new System.Drawing.Point(364, 97);
			this.cB5.Margin = new System.Windows.Forms.Padding(4);
			this.cB5.Name = "cB5";
			this.cB5.Size = new System.Drawing.Size(107, 24);
			this.cB5.TabIndex = 6;
			this.cB5.Visible = false;
			this.cB5.SelectedIndexChanged += new System.EventHandler(this.CB5SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(17, 7);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(221, 22);
			this.label1.TabIndex = 7;
			this.label1.Text = "Команда:";
			// 
			// help
			// 
			this.help.Location = new System.Drawing.Point(16, 70);
			this.help.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.help.Name = "help";
			this.help.Size = new System.Drawing.Size(456, 23);
			this.help.TabIndex = 9;
			// 
			// tb
			// 
			this.tb.Location = new System.Drawing.Point(364, 144);
			this.tb.Margin = new System.Windows.Forms.Padding(4);
			this.tb.Name = "tb";
			this.tb.Size = new System.Drawing.Size(108, 34);
			this.tb.TabIndex = 13;
			this.tb.Text = "Команда";
			this.tb.UseVisualStyleBackColor = true;
			this.tb.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(437, 1);
			this.button4.Margin = new System.Windows.Forms.Padding(4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(35, 28);
			this.button4.TabIndex = 15;
			this.button4.Text = "S";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// ed1
			// 
			this.ed1.Location = new System.Drawing.Point(17, 98);
			this.ed1.Margin = new System.Windows.Forms.Padding(4);
			this.ed1.Name = "ed1";
			this.ed1.Size = new System.Drawing.Size(456, 22);
			this.ed1.TabIndex = 16;
			this.ed1.Visible = false;
			this.ed1.TextChanged += new System.EventHandler(this.Ed1TextChanged);
			// 
			// NewCom
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 180);
			this.Controls.Add(this.ed1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.tb);
			this.Controls.Add(this.help);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cB5);
			this.Controls.Add(this.cB4);
			this.Controls.Add(this.cB3);
			this.Controls.Add(this.cB2);
			this.Controls.Add(this.cB1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(490, 225);
			this.MinimumSize = new System.Drawing.Size(490, 225);
			this.Name = "NewCom";
			this.Text = "Новая команда";
			this.Load += new System.EventHandler(this.NewComLoad);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewComFormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label help;
		private System.Windows.Forms.TextBox ed1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button tb;
		private System.Windows.Forms.ComboBox cB1;
		private System.Windows.Forms.ComboBox cB5;
		private System.Windows.Forms.ComboBox cB4;
		private System.Windows.Forms.ComboBox cB3;
		private System.Windows.Forms.ComboBox cB2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}
