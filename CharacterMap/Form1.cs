using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterMap
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.ResizeEnd += this.OnResizeWindow;
			this.characterTableControl1.OnClickCharacter += (o, e) =>
			{
				this.outputBox.Text += (char)e;
			};
		}

		

		private void OnResizeWindow(object sender, EventArgs e)
		{
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void jumpToButton_Click(object sender, EventArgs e)
		{
			this.characterTableControl1.CharacterPosition = Convert.ToInt32(this.jumpToInput.Text, 16);
		}

		private void outputBox_TextChanged(object sender, EventArgs e)
		{
			this.textCodeBox.Text = string.Join(' ', this.outputBox.Text.Select(c => $"U+{(int)c:X}"));
		}

		private void jumpToGroupBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (this.jumpToGroupBox.SelectedIndex)
			{
				case 0:
					this.characterTableControl1.HighlightStart = 0x300;
					this.characterTableControl1.HighlightEnd = 0x36F;
					this.characterTableControl1.CharacterPosition = 0x300;
					break;
			}
		}
	}
}
