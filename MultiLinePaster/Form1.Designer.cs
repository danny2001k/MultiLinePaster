namespace MultiLinePaster
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
			txtInput = new TextBox();
			btnSave = new Button();
			label1 = new Label();
			SuspendLayout();
			// 
			// txtInput
			// 
			txtInput.Location = new Point(12, 12);
			txtInput.Multiline = true;
			txtInput.Name = "txtInput";
			txtInput.ScrollBars = ScrollBars.Vertical;
			txtInput.Size = new Size(496, 296);
			txtInput.TabIndex = 0;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(12, 314);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(496, 36);
			btnSave.TabIndex = 1;
			btnSave.Text = "Click Here to Save the above list and enable Pasting each line with: Ctrl+0 to Ctrl+9";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(348, 364);
			label1.Name = "label1";
			label1.Size = new Size(149, 15);
			label1.TabIndex = 2;
			label1.Text = "© Elliris Solutions SRL 2023";
			label1.Click += label1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(520, 388);
			Controls.Add(label1);
			Controls.Add(btnSave);
			Controls.Add(txtInput);
			Name = "Form1";
			Text = "MultiLinePaster";
			FormClosing += Form1_FormClosing;
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtInput;
		private Button btnSave;
		private Label label1;
	}
}