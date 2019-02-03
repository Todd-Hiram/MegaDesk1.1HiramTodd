using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace MegaDesk_3_HiramTodd
{
	public partial class AddQuote : Form
	{
		DesktopMaterial material;

		#region
		public string CustomerName = String.Empty;
		private int DeskWidth = 0;
		private int DeskDepth = 0;
		private int NumDrawers = 0;
		private int RushDays = 0;
		private int TotalQuote;
		//Desk.Material Materials;
		#endregion

		public AddQuote()
		{
			InitializeComponent();

			// use List<> to populate combobox
			List<DesktopMaterial> MaterialList = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
			MaterialComboBox.DataSource = MaterialList;
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

		private void MaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				material = (DesktopMaterial)MaterialComboBox.SelectedValue;
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
