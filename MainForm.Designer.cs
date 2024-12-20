namespace CsvDataSplitter
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			TextBoxFilePath = new TextBox();
			BtnChooseFile = new Button();
			checkBox1 = new CheckBox();
			checkBox2 = new CheckBox();
			checkBox3 = new CheckBox();
			progressBar1 = new ProgressBar();
			progressBar2 = new ProgressBar();
			button2 = new Button();
			button3 = new Button();
			maskedTextBox1 = new MaskedTextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// TextBoxFilePath
			// 
			TextBoxFilePath.Enabled = false;
			TextBoxFilePath.Location = new Point(108, 12);
			TextBoxFilePath.Name = "TextBoxFilePath";
			TextBoxFilePath.PlaceholderText = "No File Chosen...";
			TextBoxFilePath.ReadOnly = true;
			TextBoxFilePath.ShortcutsEnabled = false;
			TextBoxFilePath.Size = new Size(545, 23);
			TextBoxFilePath.TabIndex = 0;
			TextBoxFilePath.TabStop = false;
			// 
			// BtnChooseFile
			// 
			BtnChooseFile.BackColor = Color.FromArgb(30, 113, 69);
			BtnChooseFile.FlatStyle = FlatStyle.Flat;
			BtnChooseFile.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			BtnChooseFile.Location = new Point(12, 12);
			BtnChooseFile.Name = "BtnChooseFile";
			BtnChooseFile.Size = new Size(90, 23);
			BtnChooseFile.TabIndex = 1;
			BtnChooseFile.Text = "Choose File";
			BtnChooseFile.UseVisualStyleBackColor = false;
			BtnChooseFile.Click += BtnChooseFile_Click;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Location = new Point(12, 50);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(132, 19);
			checkBox1.TabIndex = 2;
			checkBox1.Text = "File includes Header";
			checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			checkBox2.AutoSize = true;
			checkBox2.Location = new Point(12, 75);
			checkBox2.Name = "checkBox2";
			checkBox2.Size = new Size(125, 19);
			checkBox2.TabIndex = 3;
			checkBox2.Text = "Header is Multiline";
			checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			checkBox3.AutoSize = true;
			checkBox3.Location = new Point(12, 100);
			checkBox3.Name = "checkBox3";
			checkBox3.Size = new Size(160, 19);
			checkBox3.TabIndex = 5;
			checkBox3.Text = "Include Header in Output";
			checkBox3.UseVisualStyleBackColor = true;
			// 
			// progressBar1
			// 
			progressBar1.Location = new Point(12, 125);
			progressBar1.Name = "progressBar1";
			progressBar1.Size = new Size(641, 23);
			progressBar1.TabIndex = 6;
			// 
			// progressBar2
			// 
			progressBar2.Location = new Point(12, 154);
			progressBar2.Name = "progressBar2";
			progressBar2.Size = new Size(641, 23);
			progressBar2.TabIndex = 7;
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(30, 113, 69);
			button2.FlatStyle = FlatStyle.Flat;
			button2.Location = new Point(563, 183);
			button2.Name = "button2";
			button2.Size = new Size(90, 23);
			button2.TabIndex = 8;
			button2.Text = "Execute";
			button2.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			button3.Location = new Point(367, 73);
			button3.Name = "button3";
			button3.Size = new Size(90, 23);
			button3.TabIndex = 9;
			button3.Text = "View Snippet";
			button3.UseVisualStyleBackColor = true;
			// 
			// maskedTextBox1
			// 
			maskedTextBox1.Location = new Point(540, 50);
			maskedTextBox1.Name = "maskedTextBox1";
			maskedTextBox1.Size = new Size(100, 23);
			maskedTextBox1.TabIndex = 10;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(510, 81);
			label1.Name = "label1";
			label1.Size = new Size(131, 15);
			label1.TabIndex = 11;
			label1.Text = "Number of lines per file";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(666, 216);
			Controls.Add(label1);
			Controls.Add(maskedTextBox1);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(progressBar2);
			Controls.Add(progressBar1);
			Controls.Add(checkBox3);
			Controls.Add(checkBox2);
			Controls.Add(checkBox1);
			Controls.Add(BtnChooseFile);
			Controls.Add(TextBoxFilePath);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "MainForm";
			Text = "CSV Data Splitter";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox TextBoxFilePath;
		private Button BtnChooseFile;
		private CheckBox checkBox1;
		private CheckBox checkBox2;
		private CheckBox checkBox3;
		private ProgressBar progressBar1;
		private ProgressBar progressBar2;
		private Button button2;
		private Button button3;
		private MaskedTextBox maskedTextBox1;
		private Label label1;
	}
}
