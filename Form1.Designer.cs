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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			panel1 = new Panel();
			label2 = new Label();
			timeLabel = new Label();
			spaceshipPanel = new Panel();
			meteorPanel = new Panel();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ActiveBorder;
			panel1.Controls.Add(label2);
			panel1.Controls.Add(timeLabel);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(598, 100);
			panel1.TabIndex = 0;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(92, 21);
			label2.Name = "label2";
			label2.Size = new Size(38, 15);
			label2.TabIndex = 2;
			label2.Text = "label2";
			// 
			// timeLabel
			// 
			timeLabel.AutoSize = true;
			timeLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
			timeLabel.ForeColor = Color.DarkGreen;
			timeLabel.Location = new Point(12, 9);
			timeLabel.Name = "timeLabel";
			timeLabel.Size = new Size(74, 30);
			timeLabel.TabIndex = 0;
			timeLabel.Text = "SÜRE :";
			// 
			// spaceshipPanel
			// 
			spaceshipPanel.BackColor = Color.Transparent;
			spaceshipPanel.BackgroundImage = (Image)resources.GetObject("spaceshipPanel.BackgroundImage");
			spaceshipPanel.BackgroundImageLayout = ImageLayout.Stretch;
			spaceshipPanel.Location = new Point(240, 456);
			spaceshipPanel.Name = "spaceshipPanel";
			spaceshipPanel.Size = new Size(131, 134);
			spaceshipPanel.TabIndex = 1;
			// 
			// meteorPanel
			// 
			meteorPanel.BackgroundImage = (Image)resources.GetObject("meteorPanel.BackgroundImage");
			meteorPanel.BackgroundImageLayout = ImageLayout.Stretch;
			meteorPanel.Location = new Point(92, 106);
			meteorPanel.Name = "meteorPanel";
			meteorPanel.Size = new Size(87, 90);
			meteorPanel.TabIndex = 2;
			// 
			// Form1
			// 
			AutoScaleMode = AutoScaleMode.None;
			BackColor = SystemColors.ActiveCaptionText;
			BackgroundImageLayout = ImageLayout.None;
			ClientSize = new Size(598, 698);
			Controls.Add(meteorPanel);
			Controls.Add(spaceshipPanel);
			Controls.Add(panel1);
			ForeColor = Color.Black;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			Load += Form1_Load;
			KeyDown += Form1_KeyDown;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label timeLabel;
		private Label label2;
		private Panel spaceshipPanel;
		private Panel meteorPanel;
	}
}
