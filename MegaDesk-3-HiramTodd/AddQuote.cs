using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_HiramTodd
{
	public partial class AddQuote : Form
	{
		#region
		public string CustomerName = String.Empty;
		private int DeskWidth = 0;
		private int DeskDepth = 0;
		private int NumDrawers = 0;
		private int RushDays = 0;
		private int TotalQuote;
		Desk.Material Material;
		#endregion

		public AddQuote()
		{
			InitializeComponent();
			textLabelRemoval();

			List<Desk.Material> Materials = Enum.GetValues(typeof(Desk.Material)).Cast<Desk.Material>().ToList();
			desktopMaterialComboBox.DataSource = Materials;
		}

		private void AddQuote_Load(object sender, EventArgs e)
		{

		}

		private void cancelQuote_Click(object sender, EventArgs e)
		{
			var mainMenu = (MainMenu)Tag;
			mainMenu.Show();
			Close();
		}

		private void DateQuoteLabel_Click(object sender, EventArgs e)
		{

		}

		private void rushOrderLabel_Click(object sender, EventArgs e)
		{

		}

		private void dateTimePicker_ValueChanged(object sender, EventArgs e)
		{

		}

		private void rushdateTimePicker_ValueChanged(object sender, EventArgs e)
		{

		}

		private void rushDateLabel_Click(object sender, EventArgs e)
		{

		}

		private void rushOcomboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void submitButton_Click(object sender, EventArgs e)
		{

		}

		// These are the rush order days radio buttons
		private void rushRadioButtonNull_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void rushRadioButton3_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void rushRadioButton5_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void rushRadioButton7_CheckedChanged(object sender, EventArgs e)
		{

		}

		// The radio button for selecting the Rush Order option
		private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
