﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_HiramTodd
{
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
		}

		private void AddNewQuote_Click(object sender, EventArgs e)
		{
			AddQuote addNewQuoteForm = new AddQuote();
			addNewQuoteForm.Tag = this;
			addNewQuoteForm.Show(this);
			Hide();
		}

		private void ViewQuotes_Click(object sender, EventArgs e)
		{

		}

		private void SearchQuotes_Click (object sender, EventArgs e)
		{
			SearchQuotes SearchQuotesForm = new SearchQuotes();
			SearchQuotesForm.Tag = this;
			SearchQuotesForm.Show(this);
			Hide();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void MainMenu_Load(object sender, EventArgs e)
		{

		}
	}
}
