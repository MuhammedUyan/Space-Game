namespace Space_Game
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			panel1 = new Panel();
			pictureBox5 = new PictureBox();
			pictureBox4 = new PictureBox();
			button2 = new Button();
			pictureBox3 = new PictureBox();
			pictureBox2 = new PictureBox();
			pictureBox1 = new PictureBox();
			button1 = new Button();
			label2 = new Label();
			timeLabel = new Label();
			spaceshipBox = new PictureBox();
			timer1 = new System.Windows.Forms.Timer(components);
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)spaceshipBox).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ActiveCaption;
			panel1.Controls.Add(pictureBox5);
			panel1.Controls.Add(pictureBox4);
			panel1.Controls.Add(button2);
			panel1.Controls.Add(pictureBox3);
			panel1.Controls.Add(pictureBox2);
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(timeLabel);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(598, 100);
			panel1.TabIndex = 0;
			// 
			// pictureBox5
			// 
			pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
			pictureBox5.Location = new Point(192, 42);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(39, 41);
			pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox5.TabIndex = 9;
			pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new Point(147, 42);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(39, 41);
			pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox4.TabIndex = 8;
			pictureBox4.TabStop = false;
			// 
			// button2
			// 
			button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			button2.Location = new Point(478, 48);
			button2.Name = "button2";
			button2.Size = new Size(108, 35);
			button2.TabIndex = 7;
			button2.Text = "Çıkış";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(102, 42);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(39, 41);
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 6;
			pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(57, 42);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(39, 41);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 5;
			pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(12, 42);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(39, 41);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 4;
			pictureBox1.TabStop = false;
			// 
			// button1
			// 
			button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			button1.Location = new Point(478, 12);
			button1.Name = "button1";
			button1.Size = new Size(108, 35);
			button1.TabIndex = 3;
			button1.Text = "Başla";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label2.ForeColor = Color.Crimson;
			label2.Location = new Point(92, 9);
			label2.Name = "label2";
			label2.Size = new Size(61, 30);
			label2.TabIndex = 2;
			label2.Text = "0000";
			// 
			// timeLabel
			// 
			timeLabel.AutoSize = true;
			timeLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
			timeLabel.ForeColor = Color.DarkGreen;
			timeLabel.Location = new Point(12, 9);
			timeLabel.Name = "timeLabel";
			timeLabel.Size = new Size(76, 30);
			timeLabel.TabIndex = 0;
			timeLabel.Text = "SKOR :";
			// 
			// spaceshipBox
			// 
			spaceshipBox.Image = (Image)resources.GetObject("spaceshipBox.Image");
			spaceshipBox.Location = new Point(240, 466);
			spaceshipBox.Name = "spaceshipBox";
			spaceshipBox.Size = new Size(101, 155);
			spaceshipBox.SizeMode = PictureBoxSizeMode.StretchImage;
			spaceshipBox.TabIndex = 1;
			spaceshipBox.TabStop = false;
			// 
			// timer1
			// 
			timer1.Interval = 50;
			timer1.Tick += timer1_Tick;
			// 
			// Form1
			// 
			AutoScaleMode = AutoScaleMode.None;
			BackColor = SystemColors.ActiveCaptionText;
			BackgroundImageLayout = ImageLayout.None;
			ClientSize = new Size(598, 698);
			Controls.Add(spaceshipBox);
			Controls.Add(panel1);
			ForeColor = Color.Black;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Metostorm";
			Load += Form1_Load;
			KeyDown += Form1_KeyDown;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)spaceshipBox).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label timeLabel;
		private Label label2;
		private PictureBox spaceshipBox;
		private System.Windows.Forms.Timer timer1;
		private Button button1;
		private PictureBox pictureBox3;
		private PictureBox pictureBox2;
		private PictureBox pictureBox1;
		private Button button2;
		private PictureBox pictureBox5;
		private PictureBox pictureBox4;
	}
}
