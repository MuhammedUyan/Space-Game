using System.Windows.Forms;

namespace Space_Game
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.KeyPreview = true;
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			// PictureBox'ýn hareketini düzeltmek için PictureBox'ýn boyutlarýný ve hareket mesafesini ayarlayýn
			int movementSpaceship= 15;
			int formWidth = this.ClientSize.Width;

			// PictureBox'ýn hareketini sýnýrlamak için sýnýrlar
			int maxX = formWidth - spaceshipPanel.Width;

			// Klavye tuþlarýna göre hareketi ayarla
			if (e.KeyCode == Keys.A && spaceshipPanel.Left > 0) // Sol sýnýra ulaþmadýysa
			{
				spaceshipPanel.Left -= movementSpaceship;
			}
			else if (e.KeyCode == Keys.D && spaceshipPanel.Right < formWidth) // Sað sýnýra ulaþmadýysa
			{
				spaceshipPanel.Left += movementSpaceship;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			int movementMeteor = 1;
			for (int i = 0; i < 200; i++)
			{
				meteorPanel.Top += movementMeteor;
			}
		}
	}
}
