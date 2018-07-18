/*
 * Created by SharpDevelop.
 * User: ?????????????
 * Date: 05.12.2010
 * Time: 17:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace DzQ_Editor
{
	/// <summary>
	/// Description of NewCom.
	/// </summary>
	public partial class NewCom : Form
	{
		string oper;
		Storage store;
		CmbEd ce;
		public NewCom(Storage store, CmbEd ce)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.store = store;
			this.ce = ce;
		}
		
		void NewComLoad(object sender, EventArgs e)
		{
			
		}
		void SetZnak(ComboBox cb)
		{
			cb.Items.Clear();
			cb.Items.Add("+");
			cb.Items.Add("-");
			cb.Items.Add("*");
			cb.Items.Add("/");
			cb.Items.Add("^");
			cb.Show();
		}
		void SetSrvTx(ComboBox cb)
		{
			cb.Items.Clear();
			cb.Items.Add("==");
			cb.Items.Add("!=");
			cb.Show();
		}
		
		void SetSrvItm(ComboBox cb)
		{
			cb.Items.Clear();
			cb.Items.Add("have");
			cb.Items.Add("havent");
			cb.Show();
		}
		
		void SetSrv(ComboBox cb)
		{
			cb.Items.Clear();
			cb.Items.Add("==");
			cb.Items.Add("!=");
			cb.Items.Add("<=");
			cb.Items.Add(">=");
			cb.Items.Add(">");
			cb.Items.Add("<");
			cb.Show();
		}
		void SetVars(ComboBox cb)
		{
			cb.Items.Clear();
			store.RefreshVars(cb);
			cb.Items.Add("curloc");
			cb.Items.Add("visit");
			cb.Items.Add("New variable...");
			cb.Show();
		}
		void SetNumVars(ComboBox cb)
		{
			cb.Items.Clear();
			store.RefreshNumVars(cb);
			cb.Items.Add("visit");
			cb.Items.Add("New variable...");
			cb.Show();
		}
		void SetTxtVars(ComboBox cb)
		{
			cb.Items.Clear();
			store.RefreshTxtVars(cb);
			cb.Items.Add("textvar curloc");
			cb.Items.Add("New variable...");
			cb.Show();
		}
		void SetTxsVars(ComboBox cb)
		{
			cb.Items.Clear();
			store.RefreshTxsVars(cb);
			cb.Items.Add("curloc");
			cb.Items.Add("New variable...");
			cb.Show();
		}
		void SetItems(ComboBox cb)
		{
			cb.Items.Clear();
			store.RefreshItms(cb);
			cb.Items.Add("New item...");
			cb.Show();
		}
		void SetLoc(ComboBox cb)
		{
			cb.Items.Clear();
			store.RefreshLocs(cb);
			cb.Items.Add("New location...");
			cb.Show();
		}	
		void SetBlocks(ComboBox cb)
		{
			cb.Items.Clear();
			store.RefreshGBlocks(cb);
			cb.Items.Add("New block...");
			cb.Show();
		}
		
		void NewComFormClosed(object sender, FormClosedEventArgs e)
		{
			if(ed1.Visible)
				ce.Lstcom = oper + " " + ed1.Text; 
			else
			{
				//Lstcom = oper + " " + cB2.Text +" "+ cB3.Text+" "+cB4.Text+" "+cB5.Text + Lstcom;
				string old = ce.Lstcom;
				
				if(oper=="inc++")
					{
					ce.Lstcom += cB2.Text+" = "+cB2.Text+" + 1";
					return;
					}
				if(oper=="dec--")
					{
					ce.Lstcom += cB2.Text+" = "+cB2.Text+" - 1";
					return;
					}
				
				ce.Lstcom = oper;
				if (cB2.Visible)
					ce.Lstcom += " " + cB2.Text;
				if ((oper=="run")||(oper=="go")||(oper=="xgo")||(oper=="+item")||(oper=="-item"))return; //Caution!
				if(cB3.Visible)
					ce.Lstcom += " "+ cB3.Text;
				if(cB4.Visible)
					ce.Lstcom += " "+cB4.Text;
				if(cB5.Visible)
					ce.Lstcom+=" "+cB5.Text;
				if(old!="")
				ce.Lstcom += " " + old;
			}
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			help.Text = "";
			cB2.Hide();
			cB3.Hide();
			cB4.Hide();
			cB5.Hide();
			tb.Hide();
			ed1.Hide();
			if(cB1.SelectedItem.ToString()=="ПЕРЕХОД (go)"){oper = "go"; SetLoc(cB2); help.Text = "<локация>";}
			if(cB1.SelectedItem.ToString()=="УСТАНОВИТЬ (set)"){oper = "set"; SetVars(cB2); SetNumVars(cB3); help.Text = "<переменная_приемник> = <константа/образец>";}
			if(cB1.SelectedItem.ToString()=="ЗАПУСК (run)"){oper = "run"; SetBlocks(cB2); help.Text = "<блок>";}
			if(cB1.SelectedItem.ToString()=="ЕСЛИ [число] (if)")
			{
				oper = "if";
				tb.Show();
				SetNumVars(cB2);
				SetNumVars(cB4);
				SetSrv(cB3);
				help.Text = "<пременная/число1> <знак сравнения> <переменная/число2>";
			}
			if(cB1.SelectedItem.ToString()=="ЕСЛИ [текст] (if)")
			{
				oper = "if";
				tb.Show();
				SetTxtVars(cB2);
				SetTxtVars(cB4);
				SetSrvTx(cB3);
				help.Text = "<пременная/текст1> <равно/не равно> <переменная/текст2>";
			}
			if(cB1.SelectedItem.ToString()=="ЕСЛИ [предмет] (if)")
			{
				oper = "if";
				tb.Show();
				SetItems(cB3);
				SetSrvItm(cB2);
				help.Text = "<наличие у игрока> <предмет>";
			}
			if(cB1.SelectedItem.ToString()=="ИНАЧЕ (else)") {oper = "else";tb.Show();}
			if(cB1.SelectedItem.ToString()=="ВЫВОД (w)"){oper = "w"; ed1.Show(); help.Text = "<текст на вывод>";}
			if(cB1.SelectedItem.ToString()=="ВЫВОД+ENTER (wln)"){oper = "wln"; ed1.Show(); help.Text = "<текст на вывод>";}
			if(cB1.SelectedItem.ToString()=="ВЫВОД [переменная] (w)"){oper = "w var"; SetVars(cB2); help.Text = "<переменная>";}
			if(cB1.SelectedItem.ToString()=="ВЫВОД+ENTER [переменная] (wln)"){oper = "wln var"; SetVars(cB2); help.Text = "<переменная>";}
			if(cB1.SelectedItem.ToString()=="ДУБЛЬ ТЕКСТОВОЙ ПЕРЕМЕННОЙ (clone)"){oper = "clone"; SetTxsVars(cB2); cB3.Show(); SetTxsVars(cB3); help.Text = "<текстовая переменная_приёмник> <текстовая переменная_образец>";}
			if(cB1.SelectedItem.ToString()=="ДОБАВИТЬ ПРЕДМЕТ В ИНВЕНТАРЬ (+item)"){oper="+item"; SetItems(cB2);help.Text = "<предмет>";}
			if(cB1.SelectedItem.ToString()=="УДАЛИТЬ ПРЕДМЕТ ИЗ ИНВЕНТАРЯ (-item)"){oper="-item"; SetItems(cB2);help.Text = "<предмет>";}
			if(cB1.SelectedItem.ToString()=="ИЗОБРАЖЕНИЕ (image)"){oper="image"; ed1.Show();help.Text = "<путь к файлу *.jpg>";}
			if(cB1.SelectedItem.ToString()=="ПРОИГРАТЬ ЗВУК (playwave)"){oper="playwave"; ed1.Show();help.Text = "<путь к файлу *.wav>";}
			if(cB1.SelectedItem.ToString()=="СКРЫТЬ ДЕЙСТВИЕ (hide)")
			{
				oper="hide"; 
				cB2.Show();
				if(DzQ_Editor.Location.LastLocation!=null)
					DzQ_Editor.Location.LastLocation.RefreshActions(cB2);
				cB2.Items.Remove("New item...");
				help.Text = "Если в списке отсутствует нужное вам действие, введите вручную!";
			}
			if(cB1.SelectedItem.ToString()=="ПОКАЗАТЬ ДЕЙСТВИЕ (show)")
			{
				oper="show";
				cB2.Show();
				if(DzQ_Editor.Location.LastLocation!=null)
					DzQ_Editor.Location.LastLocation.RefreshActions(cB2);
				cB2.Items.Remove("New item...");
				help.Text = "Если в списке отсутствует нужное вам действие, введите вручную!";
			}
			if(cB1.SelectedItem.ToString()=="ПОКАЗАТЬ ВСЕ ДЕЙСТВИЯ (showall)"){oper="showall";}
			if(cB1.SelectedItem.ToString()=="СКРЫТЬ ВСЕ ДЕЙСТВИЯ (hideall)"){oper="hideall";}
			if(cB1.SelectedItem.ToString()=="ПОСЧИТАТЬ (compute)"){oper="compute"; SetNumVars(cB2); SetZnak(cB4); SetNumVars(cB3); SetNumVars(cB5); help.Text = "<переменная_приемник> = <перем1> <знак> <перем2>";}
			if(cB1.SelectedItem.ToString()=="ПЕРЕХОД БЕЗ ОБНОВЛЕНИЯ ОПИСАНИЯ (xgo)"){oper = "xgo"; SetLoc(cB2); help.Text = "<локация>";}
			if(cB1.SelectedItem.ToString()=="ОЧИСТИТЬ ИНВЕНТАРЬ (clearinv)") oper="clearinv";
			if(cB1.SelectedItem.ToString()=="ОЧИСТИТЬ ОКНО (clear)") oper="clear";
			if(cB1.SelectedItem.ToString()=="ОЧИСТИТЬ ВСЁ (clearall)") oper="clearall";
			if(cB1.SelectedItem.ToString()=="ВЫХОД ИЗ ПЛАТФОРМЫ (exit)") oper="exit";
			if(cB1.SelectedItem.ToString()=="ПАУЗА (wait)") {oper="wait"; SetNumVars(cB2); help.Text = "<время задержки, миллисекунды>";}
			if(cB1.SelectedItem.ToString()=="СЛУЧАЙНОЕ ЧИСЛО (random)") {oper="random"; SetNumVars(cB2); SetNumVars(cB3); SetNumVars(cB4);help.Text = "<переменная_приемник> <МИН> <МАКС-1>";}
			if(cB1.SelectedItem.ToString()=="ВЕРНУТЬСЯ НА ПРЕД. ЛОКАЦИЮ (goprev)") {oper="goprev";}
			if(cB1.SelectedItem.ToString()=="УСТАНОВИТЬ БЛОК-ТАЙМЕР (settimer)") {oper="settimer"; SetBlocks(cB2); SetVars(cB3); help.Text = "<блок> <интервал между повторами>";}
			if(cB1.SelectedItem.ToString()=="СОЕДИНЕНИЕ СТРОК (connect)") {oper="connect"; SetTxsVars(cB2); SetTxsVars(cB3); SetTxsVars(cB4); help.Text = "<переменная_приёмник> <переменная_текст1> <переменная_текст2>";}
			if(cB1.SelectedItem.ToString()=="ВВОД (input)") {oper="input"; SetVars(cB2); cB3.Show(); help.Text = "<переменная_приёмник> <подскзка (необязательно)>";}
			if(cB1.SelectedItem.ToString()=="ИНКРЕМЕНТ (x = x + 1)") {oper="inc++"; SetNumVars(cB2); help.Text = "<переменная>";}
			if(cB1.SelectedItem.ToString()=="ДЕКРЕМЕНТ (x = x - 1)") {oper="dec--"; SetNumVars(cB2); help.Text = "<переменная>";}
			if(cB1.SelectedItem.ToString()=="ЕЩЕ КОММАНДА (&)") {oper = "&";tb.Show();}
			if(cB1.SelectedItem.ToString()=="СИНУС (sin)") {oper = "sin"; SetNumVars(cB2); SetNumVars(cB3); help.Text = "<переменная_приёмник> <переменная/константа (в радианах)>";}
			if(cB1.SelectedItem.ToString()=="КОСИНУС (cos)") {oper = "cos"; SetNumVars(cB2); SetNumVars(cB3); help.Text = "<переменная_приёмник> <переменная/константа (в радианах)>";}
			if(cB1.SelectedItem.ToString()=="ОКРУГЛИТЬ (round)") {oper = "round"; SetNumVars(cB2); help.Text = "<переменная>";}
			if(cB1.SelectedItem.ToString()=="ОТБРОСИТЬ ДРОБЬ (trunc)") {oper = "trunc"; SetNumVars(cB2); help.Text = "<переменная>";}
			if(cB1.SelectedItem.ToString()=="ПЕРЕЗАПУСТИТЬ КВЕСТ (restartquest)") oper = "restartquest";
			if(cB1.SelectedItem.ToString()=="ПРЕКРАТИТЬ ВЫПОЛНЕНИЕ БЛОКА (stopblock)") oper = "stopblock";
			if(cB1.SelectedItem.ToString()=="ЦИКЛ FOR (for)") {oper = "for"; SetNumVars(cB2); SetNumVars(cB3); SetBlocks(cB4); help.Text="<переменная_счетчик> <последнее_значение> <блок>";}
			//actions!
		}
		
		
		void Button3Click(object sender, EventArgs e)
		{
			NewCom newcom = new NewCom(store,ce);
			newcom.ShowDialog();
			this.Close();
		}
		
		//lstcom was here
		
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(oper=="")ce.Lstcom="";
			this.Close();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			ce.Lstcom = "";
			this.Close();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			cB1.Sorted = true;
		}
		

		
		void CB5SelectedIndexChanged(object sender, EventArgs e)
		{
			AddSmth addsmth = new AddSmth();
			if((sender as ComboBox).Text=="New variable...")
			{
				addsmth.ShowDialog();
				if(addsmth.Input=="")return;
				store.AddVar(addsmth.Input);
				VarEd vared = new VarEd(store.GetVar(addsmth.Input));
				vared.ShowDialog();
				(sender as ComboBox).Items.Add(addsmth.Input);
				(sender as ComboBox).Text = addsmth.Input;
			}
			if((sender as ComboBox).Text=="New block...")
			{
				addsmth.ShowDialog();
				if(addsmth.Input=="")return;
				store.AddGBlock(addsmth.Input);
				CmbEd cmbed = new CmbEd(store.GetGBlock(addsmth.Input),null,store);

				cmbed.ShowDialog();
				(sender as ComboBox).Items.Add(addsmth.Input);
				(sender as ComboBox).Text = addsmth.Input;
				
			}
			if((sender as ComboBox).Text=="New location...")
			{
				addsmth.ShowDialog();
				if(addsmth.Input=="")return;
				store.AddLoc(addsmth.Input);
				LocEd loced = new LocEd(store.GetLoc(addsmth.Input),store);

				loced.ShowDialog();
				(sender as ComboBox).Items.Add(addsmth.Input);
				(sender as ComboBox).Text = addsmth.Input;
				
			}
			if((sender as ComboBox).Text=="New item...")
			{
				addsmth.ShowDialog();
				if(addsmth.Input=="")return;
				store.AddItm(addsmth.Input);
				ItmEd itmed = new ItmEd(store.GetItm(addsmth.Input),store);

				itmed.ShowDialog();
				(sender as ComboBox).Items.Add(addsmth.Input);
				(sender as ComboBox).Text = addsmth.Input;
				
			}
		}
		
		void Ed1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void andclick(object sender, EventArgs e)
		{
			
			
		}
	}
}
