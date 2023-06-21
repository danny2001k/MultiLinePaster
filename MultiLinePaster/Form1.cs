using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MultiLinePaster
{
	public partial class Form1 : Form
	{
		// Define DLL Import methods
		[DllImport("user32.dll")]
		public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

		[DllImport("user32.dll")]
		public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		// Define constants
		public const int MOD_CONTROL = 0x0002;
		public const int MAX_HOTKEYS = 10;
		public const int HOTKEY_ID_1 = 1;
		public const int HOTKEY_ID_2 = 2;
		// Add more IDs for more hotkeys

		// List to store lines of text
		List<string> lines = new List<string>();

		public Form1()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// Save lines from TextBox to the List.
			lines = txtInput.Lines.ToList();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < MAX_HOTKEYS; i++)
			{
				RegisterHotKey(this.Handle, i + 1, MOD_CONTROL, (int)Keys.D1 + i);
			}
			// Handle the 0 key separately
			RegisterHotKey(this.Handle, 0, MOD_CONTROL, (int)Keys.D0);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			for (int i = 0; i < MAX_HOTKEYS; i++)
			{
				UnregisterHotKey(this.Handle, i);
			}
		}

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 0x0312)
			{
				int id = m.WParam.ToInt32();
				if (id == 0) id = 10;  // Treat 0 as the 10th line
				if (id <= lines.Count && !string.IsNullOrWhiteSpace(lines[id - 1]))
				{
					Clipboard.SetText(lines[id - 1]);
					SendKeys.Send("^v");
				}
			}

			base.WndProc(ref m);
		}



		private void label1_Click(object sender, EventArgs e)
		{
			string url = "https://elliris.ro";

			try
			{
				var psi = new System.Diagnostics.ProcessStartInfo
				{
					FileName = url,
					UseShellExecute = true
				};
				System.Diagnostics.Process.Start(psi);
			}
			catch
			{
				// Browser not found, handle appropriately for your scenario
			}
		}
	}
}
