using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Gui;

namespace Terminal_Illness
{
	class Program
	{
		static void Main(string[] args)
		{
			ColorScheme colorScheme = new ColorScheme();
			
			colorScheme.Normal = new Terminal.Gui.Attribute(15);
			colorScheme.Focus = new Terminal.Gui.Attribute();
			Colors.Base = colorScheme;

			Application.Init();
			Application.Top.ColorScheme = colorScheme;
			var Driver = Application.Driver;
			var top = Application.Top;
			top.ColorScheme = colorScheme;
			var win = new Window(new Rect(0, 1, top.Frame.Width, top.Frame.Height - 2),"My App");
			win.ColorScheme = colorScheme;
			top.Add(win);

			var textView = new TextView(new Rect(win.Frame.Location,win.Frame.Size));



			textView.ColorScheme = colorScheme;
			textView.Text = "hey hey \r\n you you";
			textView.ReadOnly = true;
			textView.CanFocus = false;
			win.Add(textView);
			textView.Text += "\r\n" + top.ColorScheme.Normal.ToString();
			Application.Run();
			

		}
	}
}
