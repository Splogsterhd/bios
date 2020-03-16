using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;

namespace BiosSpoofer
{
	// Token: 0x02000002 RID: 2
	internal class Program
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		private static void Main(string[] args)
		{
			string path = "C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/656398121974235136/677935869016932372/AMIDEWINx64.exe", "C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\Mobo.exe");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/656398121974235136/677935864847794190/amifldrv64.sys", "C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\amifldrv64.sys");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/656398121974235136/677934319326724126/amifldrv32.sys", "C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\amifldrv32.sys");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /SS %random%-S-P-O-O-F-E-R-%random%");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /BS %random%-S-P-O-O-F-E-R-%random%");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /SV %random%-S-P-O-O-F-E-R-%random%");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /BV %random%-S-P-O-O-F-E-R-%random%");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /BS %random%-S-P-O-O-F-E-R-%random%");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /CS %random%-S-P-O-O-F-E-R-%random%");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /PSN %random%-S-P-O-O-F-E-R-%random%");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /PAT %random%-S-P-O-O-F-E-R-%random%");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /PPN %random%-S-P-O-O-F-E-R-%random%");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /IV %random%-S-P-O-O-F-E-R-%random%");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /SM %random%-S-P-O-O-F-E-R-%random%");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /SP %random%-S-P-O-O-F-E-R-%random%");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /SF %random%-S-P-O-O-F-E-R-%random%");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /BM %random%-S-P-O-O-F-E-R-%random%");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /BP %random%-S-P-O-O-F-E-R-%random%");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /BT %random%-S-P-O-O-F-E-R-%random%");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /BLC %random%-S-P-O-O-F-E-R-%random%");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /CM %random%-S-P-O-O-F-E-R-%random%");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /CT %random%-S-P-O-O-F-E-R-%random%");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /CV %random%-S-P-O-O-F-E-R-%random%");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /CA %random%-S-P-O-O-F-E-R-%random%");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /CO %random%-S-P-O-O-F-E-R-%random%");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /CSK %random%-S-P-O-O-F-E-R-%random%");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /SK %random%-S-P-O-O-F-E-R-%random%");
			Program.g__RunBios("C:\\\\Windows\\\\Installer\\\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\\\Mobo.exe /SU auto");
			Program.g__RunBios("net stop winmgmt /y >nul");
			Program.g__RunBios("net start winmgmt /y >nul");
			Program.g__RunBios("sc stop winmgmt");
			Program.g__RunBios("sc start winmgmt");
			//Program.g__RunBios("ipconfig /release");
			Program.g__RunBios("ipconfig /flushdns");
			File.Delete("C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\Mobo.exe");
			File.Delete("C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\amifldrv32.sys");
			File.Delete("C:\\Windows\\Installer\\{69CD1F2D-DF68-4E23-9108-1B70783F2852}\\amifldrv64.sys");
			if (Directory.Exists(path))
			{
				Directory.Delete(path, true);
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000021DC File Offset: 0x000003DC
		[CompilerGenerated]
		internal static void g__RunBios(string dir)
		{
			Process process = new Process();
		process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.RedirectStandardError = false;
			process.StartInfo.RedirectStandardOutput = false;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "-R C:\\";
			process.Start();
			Thread.Sleep(80);
			process.StandardInput.WriteLine(dir ?? "");
			Thread.Sleep(120);
			process.Kill();
			process.Close();
		}
}
}
