using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk_3_HiramTodd
{
	public partial class SearchQuotes : Form
	{
		private bool UserClosing;

		public SearchQuotes()
		{
			InitializeComponent();

			// use List<> to populate combobox
			List<DesktopMaterial> MaterialList = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
			MaterialComboBox.DataSource = MaterialList;
		}

		private void SearchQuotes_Load(object sender, EventArgs e)
		{

		}

		private void searchQuoteButton_Click(object sender, EventArgs e)
		{
			try
			{
				string MaterialSelected = MaterialComboBox.SelectedItem.ToString();

				using (StreamReader sr = new StreamReader(@"quotes.txt"))
				{
					while (!sr.EndOfStream)
					{
						string[] fieldValue = sr.ReadLine().Split(',');

						if()//sr.ReadLine().Contains(MaterialSelected);
						{
							// yea ... add to our output ..... ListView			COMPLETE!!!!

						}
					}

				}
			}
			catch (Exception)
			{

				throw;
			}
		}

		private void searchQuoteComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cancelSearch_Click(object sender, EventArgs e)
		{
			UserClosing = true;
			var mainMenu = (MainMenu)Tag;
			mainMenu.Show();
			Close();
		}

	}
}
