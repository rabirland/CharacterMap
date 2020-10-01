using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace CharacterMap
{
	class CharacterTableControl : Control
	{
		private int horizontalCharacterCount = 0;
		private int verticalCharacterCount = 0;
		private double cellWidth = 0;
		private double cellHeight = 0;
		private int hMargin = 0;
		private int vMargin = 0;
		private int charPos = 0;
		private bool mouseOver = false;
		private int mouseX = 0;
		private int mouseY = 0;
		private int highlightedCharCode = 0;
		private int highlightStart = -1;
		private int highlightEnd = -1;

		public int HorizontalMargin
		{
			get => this.hMargin;
			set
			{
				this.hMargin = value;
				this.Refresh();
			}
		}

		public int VerticalMargin
		{
			get => this.vMargin;
			set
			{
				this.vMargin = value;
				this.Refresh();
			}
		}

		public int CharacterPosition
		{
			get => this.charPos;
			set
			{
				this.charPos = value;
				this.Refresh();
			}
		}

		public int HighlightStart
		{
			get => this.highlightStart;
			set
			{
				this.highlightStart = value;
				this.Refresh();
			}
		}

		public int HighlightEnd
		{
			get => this.highlightEnd;
			set
			{
				this.highlightEnd = value;
				this.Refresh();
			}
		}

		public int HorizontalCharacterCount => this.horizontalCharacterCount;
		public int VerticalCharacterCount => this.verticalCharacterCount;
		public event EventHandler<int> OnClickCharacter;

		public CharacterTableControl()
		{
			this.DoubleBuffered = true;
		}

		protected override void OnSizeChanged(EventArgs e)
		{
			this.Refresh();
		}

		protected override void OnMouseWheel(MouseEventArgs e)
		{
			if (e.Delta < 0)
			{
				this.charPos += this.HorizontalCharacterCount;
			}
			else if (e.Delta > 0)
			{
				this.charPos -= this.HorizontalCharacterCount;
			}

			if (this.charPos < 0)
			{
				this.charPos = 0;
			}

			this.Refresh();
		}

		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
			pevent.Graphics.FillRectangle(Brushes.White, this.ClientRectangle);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			var glyphSize = TextRenderer.MeasureText("A", this.Font);

			int width = this.ClientRectangle.Width;
			int height = this.ClientRectangle.Height;

			var cellWidthMin = (double)(glyphSize.Width + (this.HorizontalMargin * 2));
			var cellHeightMin = (double)(glyphSize.Height + (this.VerticalMargin * 2));

			var cellCountHorizontal = Math.Round(width / cellWidthMin);
			var cellCountVertical = Math.Round(height / cellHeightMin);

			this.horizontalCharacterCount = (int)cellCountHorizontal;
			this.verticalCharacterCount = (int)cellCountVertical;

			bool drawTooltip = false;

			if (this.horizontalCharacterCount > 0 && this.verticalCharacterCount > 0)
			{
				this.cellWidth = width / cellCountHorizontal;
				this.cellHeight = height / cellCountVertical;

				// Draw glyphs
				for (int i = 0; i < this.verticalCharacterCount; i++)
				{
					for (int j = 0; j < this.horizontalCharacterCount; j++)
					{
						var xPos = (int)(j * cellWidth);
						var yPos = (int)(i * cellHeight);

						var rect = new Rectangle(xPos, yPos, (int)cellWidth, (int)cellHeight);
						int charCode = this.charPos + (i * this.horizontalCharacterCount) + j;

						if (charCode >= this.highlightStart && charCode <= this.highlightEnd)
						{
							e.Graphics.FillRectangle(Brushes.LightGreen, new RectangleF(xPos, yPos, (float)cellWidth, (float)cellHeight));
						}

						if (this.mouseOver && rect.Contains(this.mouseX, this.mouseY))
						{
							e.Graphics.FillRectangle(Brushes.SkyBlue, new RectangleF(xPos, yPos, (float)cellWidth, (float)cellHeight));
							this.highlightedCharCode = charCode;
							drawTooltip = true;
						}

						TextRenderer.DrawText(e.Graphics, ((char)charCode).ToString(), this.Font, rect, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
					}
				}

				// Draw vertical lines
				for (int i = 1; i < this.horizontalCharacterCount; i++)
				{
					var xPos = (int)(i * cellWidth);

					e.Graphics.DrawLine(Pens.Black, new Point(xPos, 0), new Point(xPos, height));
				}

				// Draw horizontal lines
				for (int i = 1; i < this.verticalCharacterCount; i++)
				{
					var yPos = (int)(i * cellHeight);

					e.Graphics.DrawLine(Pens.Black, new Point(0, yPos), new Point(width, yPos));
				}

				if (drawTooltip)
				{
					string text = $"U+{this.highlightedCharCode:X}";
					var box = TextRenderer.MeasureText(text, this.Font);
					e.Graphics.FillRectangle(Brushes.White, this.mouseX, this.mouseY, box.Width, box.Height);
					e.Graphics.DrawRectangle(Pens.Black, this.mouseX, this.mouseY, box.Width, box.Height);
					TextRenderer.DrawText(e.Graphics, text, this.Font, new Point(this.mouseX, this.mouseY), this.ForeColor);
				}
			}
		}

		protected override void OnMouseEnter(EventArgs e)
		{
			this.mouseOver = true;
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			this.mouseX = e.X;
			this.mouseY = e.Y;
			this.Refresh();
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			this.mouseOver = false;
			this.Refresh();
		}

		protected override void OnClick(EventArgs e)
		{
			this.OnClickCharacter.Invoke(this, this.highlightedCharCode);
		}
	}
}
