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
			// PictureBox'�n hareketini d�zeltmek i�in PictureBox'�n boyutlar�n� ve hareket mesafesini ayarlay�n
			int movementSpaceship= 15;
			int formWidth = this.ClientSize.Width;

			// PictureBox'�n hareketini s�n�rlamak i�in s�n�rlar
			int maxX = formWidth - spaceshipPanel.Width;

			// Klavye tu�lar�na g�re hareketi ayarla
			if (e.KeyCode == Keys.A && spaceshipPanel.Left > 0) // Sol s�n�ra ula�mad�ysa
			{
				spaceshipPanel.Left -= movementSpaceship;
			}
			else if (e.KeyCode == Keys.D && spaceshipPanel.Right < formWidth) // Sa� s�n�ra ula�mad�ysa
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
