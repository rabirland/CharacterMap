namespace CharacterMap
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.characterTableControl1 = new CharacterMap.CharacterTableControl();
			this.jumpToButton = new System.Windows.Forms.Button();
			this.outputBox = new System.Windows.Forms.TextBox();
			this.textCodeBox = new System.Windows.Forms.TextBox();
			this.jumpToInput = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
			this.vScrollBar1.Location = new System.Drawing.Point(783, 0);
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(17, 450);
			this.vScrollBar1.TabIndex = 0;
			// 
			// characterTableControl1
			// 
			this.characterTableControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.characterTableControl1.CharacterPosition = 0;
			this.characterTableControl1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.characterTableControl1.HighlightEnd = -1;
			this.characterTableControl1.HighlightStart = -1;
			this.characterTableControl1.HorizontalMargin = 5;
			this.characterTableControl1.Location = new System.Drawing.Point(12, 41);
			this.characterTableControl1.Name = "characterTableControl1";
			this.characterTableControl1.Size = new System.Drawing.Size(768, 331);
			this.characterTableControl1.TabIndex = 1;
			this.characterTableControl1.Text = "characterTableControl1";
			this.characterTableControl1.VerticalMargin = 5;
			this.characterTableControl1.OnPositionChange += new System.EventHandler<int>(this.characterTableControl1_OnPositionChange);
			// 
			// jumpToButton
			// 
			this.jumpToButton.Location = new System.Drawing.Point(118, 10);
			this.jumpToButton.Name = "jumpToButton";
			this.jumpToButton.Size = new System.Drawing.Size(75, 23);
			this.jumpToButton.TabIndex = 3;
			this.jumpToButton.Text = "Jump to";
			this.jumpToButton.UseVisualStyleBackColor = true;
			this.jumpToButton.Click += new System.EventHandler(this.jumpToButton_Click);
			// 
			// outputBox
			// 
			this.outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.outputBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.outputBox.Location = new System.Drawing.Point(12, 378);
			this.outputBox.Multiline = true;
			this.outputBox.Name = "outputBox";
			this.outputBox.Size = new System.Drawing.Size(390, 57);
			this.outputBox.TabIndex = 4;
			this.outputBox.TextChanged += new System.EventHandler(this.outputBox_TextChanged);
			// 
			// textCodeBox
			// 
			this.textCodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.textCodeBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.textCodeBox.Location = new System.Drawing.Point(408, 378);
			this.textCodeBox.Multiline = true;
			this.textCodeBox.Name = "textCodeBox";
			this.textCodeBox.ReadOnly = true;
			this.textCodeBox.Size = new System.Drawing.Size(372, 57);
			this.textCodeBox.TabIndex = 4;
			// 
			// jumpToInput
			// 
			this.jumpToInput.Location = new System.Drawing.Point(12, 10);
			this.jumpToInput.Name = "jumpToInput";
			this.jumpToInput.Size = new System.Drawing.Size(100, 23);
			this.jumpToInput.TabIndex = 6;
			this.jumpToInput.Text = "0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.jumpToInput);
			this.Controls.Add(this.textCodeBox);
			this.Controls.Add(this.outputBox);
			this.Controls.Add(this.jumpToButton);
			this.Controls.Add(this.characterTableControl1);
			this.Controls.Add(this.vScrollBar1);
			this.DoubleBuffered = true;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.VScrollBar vScrollBar1;
		private CharacterTableControl characterTableControl1;
		private System.Windows.Forms.Button jumpToButton;
		private System.Windows.Forms.TextBox outputBox;
		private System.Windows.Forms.TextBox textCodeBox;
		private System.Windows.Forms.TextBox jumpToInput;
	}
}

