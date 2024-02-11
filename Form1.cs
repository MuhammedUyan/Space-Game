using System.Diagnostics.Metrics;
using System.Windows.Forms;

namespace Space_Game
{
	public partial class Form1 : Form
	{

		int movementMeteor = 10;
		int movementSpaceship = 15;
		int time = 0;
		int formWidth;

		Random random = new Random();

		List<PictureBox> meteors = new List<PictureBox>();

		public Form1()
		{
			InitializeComponent();
			this.KeyPreview = true;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			AddMeteor();
		}

		// baþlama fonksiyonu
		private void start()
		{
			meteors[0].Location = new Point(random.Next(1, this.ClientSize.Width - meteors[0].Width), 0);
			timer1.Start();
		}

		// uzay gemisini kontrol etme
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			formWidth = this.ClientSize.Width - 5;
			if (e.KeyCode == Keys.A && spaceshipBox.Left > 0) // Sol sýnýra ulaþmadýysa
			{
				spaceshipBox.Left -= movementSpaceship;
			}
			else if (e.KeyCode == Keys.D && spaceshipBox.Right < formWidth) // Sað sýnýra ulaþmadýysa
			{
				spaceshipBox.Left += movementSpaceship;
			}
		}

		// oyun baþladýðýnda geliþen olaylar
		private void timer1_Tick(object sender, EventArgs e)
		{
			time++;
			label2.Text = time.ToString();

			MoveMeteors();
			if(time > 0 && time < 300)
			{
				movementMeteor = 15;
			}
			else if(time >= 300 && time < 600)
			{
				movementMeteor = 20;
			}
			else if (time >= 600 && time < 1000)
			{
				movementMeteor = 25;
				movementSpaceship = 20;
			}
			else if (time >= 1000 && time < 1500)
			{
				movementMeteor = 30;
				movementSpaceship = 25;
			}
			else if (time >= 1500 && time < 2000)
			{
				movementMeteor = 35;
				movementSpaceship = 30;
			}
			else if(time == 2000)
			{
				timer1.Stop();
				MessageBox.Show("Tebrikler, Kazandýnýz !!!", "Oyun Bitti!", MessageBoxButtons.OK);
				label2.Text = "0000";
				time = 0;
			}

			if (spaceshipBox.Bounds.IntersectsWith(meteors[0].Bounds))
			{
				if (pictureBox5.Visible != false)
				{
					timer1.Stop();
					pictureBox5.Visible = false;
					start();
				}
				else if (pictureBox4.Visible != false)
				{
					timer1.Stop();
					pictureBox4.Visible = false;
					start();
				}
				else if (pictureBox3.Visible != false)
				{
					timer1.Stop();
					pictureBox3.Visible = false;
					start();
				}
				else if (pictureBox2.Visible != false)
				{
					timer1.Stop();
					pictureBox2.Visible = false;
					start();
				}
				else if (pictureBox1.Visible != false)
				{
					timer1.Stop();
					pictureBox1.Visible = false;
					DialogResult result = MessageBox.Show(" Skor : " + label2.Text, "Oyun Bitti!", MessageBoxButtons.OK);
					if (result == DialogResult.OK)
					{
						label2.Text = "0000";
						time = 0;
					}
				}
			}

		}

		// Oyunu baþlatma butonu
		private void button1_Click(object sender, EventArgs e)
		{
			pictureBox1.Visible = true;
			pictureBox2.Visible = true;
			pictureBox3.Visible = true;
			pictureBox4.Visible = true;
			pictureBox5.Visible = true;
			start();
		}

		// Oyunu kapatma butonu
		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// meteor ekleme fonksiyonu
		private void AddMeteor()
		{
			PictureBox meteor = new PictureBox();
			meteor.Size = new Size(60, 70);
			meteor.BackColor = Color.Transparent;
			meteor.Image = Image.FromFile("C:\\Users\\User\\Desktop\\meteor.png");
			meteor.SizeMode = PictureBoxSizeMode.StretchImage;
			meteor.Location = new Point(random.Next(1, this.ClientSize.Width - meteor.Width),0);
			this.Controls.Add(meteor);
			meteors.Add(meteor);
		}

		// meteorlarý hareket ettirme
		private void MoveMeteors()
		{
			for (int i=0; i < meteors.Count; i++)
			{
				meteors[0].Top += movementMeteor;
				if (meteors[0].Bottom >= this.ClientSize.Height)
				{
					// Meteor ekranýn dýþýna çýktýysa, onu kaldýrýn ve yeni bir meteor ekleyin
					this.Controls.Remove(meteors[0]);
					meteors.Remove(meteors[0]);
					AddMeteor();
				}
			}
		}
	}
}
