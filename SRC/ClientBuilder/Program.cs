using System;
using System.Windows.Forms;

namespace ClientBuilder
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002F25 File Offset: 0x00001125
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Builder());
		}
	}
}
