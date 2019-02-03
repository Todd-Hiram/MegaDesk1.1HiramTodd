namespace MegaDesk_3_HiramTodd
{
	partial class SearchQuotes
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.searchQuoteButton = new System.Windows.Forms.Button();
			this.searchQuoteComboBox = new System.Windows.Forms.ComboBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.cancelSearch = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// searchQuoteButton
			// 
			this.searchQuoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.searchQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchQuoteButton.Location = new System.Drawing.Point(445, 15);
			this.searchQuoteButton.Name = "searchQuoteButton";
			this.searchQuoteButton.Size = new System.Drawing.Size(250, 35);
			this.searchQuoteButton.TabIndex = 0;
			this.searchQuoteButton.Text = "Search By Material Type";
			this.searchQuoteButton.UseVisualStyleBackColor = true;
			this.searchQuoteButton.Click += new System.EventHandler(this.searchQuoteButton_Click);
			// 
			// searchQuoteComboBox
			// 
			this.searchQuoteComboBox.FormattingEnabled = true;
			this.searchQuoteComboBox.Location = new System.Drawing.Point(26, 25);
			this.searchQuoteComboBox.Name = "searchQuoteComboBox";
			this.searchQuoteComboBox.Size = new System.Drawing.Size(250, 21);
			this.searchQuoteComboBox.TabIndex = 1;
			this.searchQuoteComboBox.SelectedIndexChanged += new System.EventHandler(this.searchQuoteComboBox_SelectedIndexChanged);
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(26, 78);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(669, 291);
			this.listView1.TabIndex = 2;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// cancelSearch
			// 
			this.cancelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelSearch.Location = new System.Drawing.Point(248, 388);
			this.cancelSearch.Name = "cancelSearch";
			this.cancelSearch.Size = new System.Drawing.Size(200, 50);
			this.cancelSearch.TabIndex = 3;
			this.cancelSearch.Text = "Cancel Search";
			this.cancelSearch.UseVisualStyleBackColor = true;
			this.cancelSearch.Click += new System.EventHandler(this.cancelSearch_Click);
			// 
			// SearchQuotes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(718, 450);
			this.Controls.Add(this.cancelSearch);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.searchQuoteComboBox);
			this.Controls.Add(this.searchQuoteButton);
			this.Name = "SearchQuotes";
			this.Text = "SearchQuotes";
			this.Load += new System.EventHandler(this.SearchQuotes_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button searchQuoteButton;
		private System.Windows.Forms.ComboBox searchQuoteComboBox;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button cancelSearch;
	}
}