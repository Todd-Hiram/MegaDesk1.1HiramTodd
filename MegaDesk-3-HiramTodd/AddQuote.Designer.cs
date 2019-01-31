namespace MegaDesk_3_HiramTodd
{
	partial class AddQuote
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
			this.cancelQuote = new System.Windows.Forms.Button();
			this.cusomterNameBox = new System.Windows.Forms.TextBox();
			this.customerLabel = new System.Windows.Forms.Label();
			this.deskLabel = new System.Windows.Forms.Label();
			this.DateQuoteLabel = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.rushOrderLabel = new System.Windows.Forms.Label();
			this.rushOCheckBoxYes = new System.Windows.Forms.CheckBox();
			this.rushOCheckBoxNo = new System.Windows.Forms.CheckBox();
			this.rushDateLabel = new System.Windows.Forms.Label();
			this.drawerLabel = new System.Windows.Forms.Label();
			this.deskComboBox = new System.Windows.Forms.ComboBox();
			this.numOfDrawers = new System.Windows.Forms.NumericUpDown();
			this.rushOcomboBox = new System.Windows.Forms.ComboBox();
			this.submitButton = new System.Windows.Forms.Button();
			this.widthLabel = new System.Windows.Forms.Label();
			this.depthLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.widthComboBox = new System.Windows.Forms.ComboBox();
			this.depthComboBox = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.numOfDrawers)).BeginInit();
			this.SuspendLayout();
			// 
			// cancelQuote
			// 
			this.cancelQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelQuote.Location = new System.Drawing.Point(588, 388);
			this.cancelQuote.Name = "cancelQuote";
			this.cancelQuote.Size = new System.Drawing.Size(200, 50);
			this.cancelQuote.TabIndex = 0;
			this.cancelQuote.Text = "Cancel Quote";
			this.cancelQuote.UseVisualStyleBackColor = true;
			this.cancelQuote.Click += new System.EventHandler(this.cancelQuote_Click);
			// 
			// cusomterNameBox
			// 
			this.cusomterNameBox.BackColor = System.Drawing.Color.WhiteSmoke;
			this.cusomterNameBox.Location = new System.Drawing.Point(12, 42);
			this.cusomterNameBox.Name = "cusomterNameBox";
			this.cusomterNameBox.Size = new System.Drawing.Size(200, 20);
			this.cusomterNameBox.TabIndex = 1;
			// 
			// customerLabel
			// 
			this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customerLabel.Location = new System.Drawing.Point(12, 9);
			this.customerLabel.Name = "customerLabel";
			this.customerLabel.Size = new System.Drawing.Size(150, 30);
			this.customerLabel.TabIndex = 2;
			this.customerLabel.Text = "Customer Name";
			this.customerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// deskLabel
			// 
			this.deskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deskLabel.Location = new System.Drawing.Point(146, 80);
			this.deskLabel.Name = "deskLabel";
			this.deskLabel.Size = new System.Drawing.Size(180, 29);
			this.deskLabel.TabIndex = 3;
			this.deskLabel.Text = "Desk Dimensions";
			this.deskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// DateQuoteLabel
			// 
			this.DateQuoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateQuoteLabel.Location = new System.Drawing.Point(142, 219);
			this.DateQuoteLabel.Name = "DateQuoteLabel";
			this.DateQuoteLabel.Size = new System.Drawing.Size(150, 30);
			this.DateQuoteLabel.TabIndex = 5;
			this.DateQuoteLabel.Text = "Date Quote";
			this.DateQuoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.DateQuoteLabel.Click += new System.EventHandler(this.DateQuoteLabel_Click);
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Location = new System.Drawing.Point(142, 253);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker.TabIndex = 6;
			this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
			// 
			// rushOrderLabel
			// 
			this.rushOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rushOrderLabel.Location = new System.Drawing.Point(142, 291);
			this.rushOrderLabel.Name = "rushOrderLabel";
			this.rushOrderLabel.Size = new System.Drawing.Size(150, 30);
			this.rushOrderLabel.TabIndex = 7;
			this.rushOrderLabel.Text = "Rush Order";
			this.rushOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.rushOrderLabel.Click += new System.EventHandler(this.rushOrderLabel_Click);
			// 
			// rushOCheckBoxYes
			// 
			this.rushOCheckBoxYes.AutoSize = true;
			this.rushOCheckBoxYes.Location = new System.Drawing.Point(146, 324);
			this.rushOCheckBoxYes.Name = "rushOCheckBoxYes";
			this.rushOCheckBoxYes.Size = new System.Drawing.Size(44, 17);
			this.rushOCheckBoxYes.TabIndex = 8;
			this.rushOCheckBoxYes.Text = "Yes";
			this.rushOCheckBoxYes.UseVisualStyleBackColor = true;
			// 
			// rushOCheckBoxNo
			// 
			this.rushOCheckBoxNo.AutoSize = true;
			this.rushOCheckBoxNo.Location = new System.Drawing.Point(146, 347);
			this.rushOCheckBoxNo.Name = "rushOCheckBoxNo";
			this.rushOCheckBoxNo.Size = new System.Drawing.Size(40, 17);
			this.rushOCheckBoxNo.TabIndex = 9;
			this.rushOCheckBoxNo.Text = "No";
			this.rushOCheckBoxNo.UseVisualStyleBackColor = true;
			// 
			// rushDateLabel
			// 
			this.rushDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rushDateLabel.Location = new System.Drawing.Point(497, 219);
			this.rushDateLabel.Name = "rushDateLabel";
			this.rushDateLabel.Size = new System.Drawing.Size(200, 30);
			this.rushDateLabel.TabIndex = 10;
			this.rushDateLabel.Text = "Rush Order Option";
			this.rushDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.rushDateLabel.Click += new System.EventHandler(this.rushDateLabel_Click);
			// 
			// drawerLabel
			// 
			this.drawerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.drawerLabel.Location = new System.Drawing.Point(497, 291);
			this.drawerLabel.Name = "drawerLabel";
			this.drawerLabel.Size = new System.Drawing.Size(200, 30);
			this.drawerLabel.TabIndex = 12;
			this.drawerLabel.Text = "Number of Drawers";
			this.drawerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// deskComboBox
			// 
			this.deskComboBox.FormattingEnabled = true;
			this.deskComboBox.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
			this.deskComboBox.Location = new System.Drawing.Point(302, 112);
			this.deskComboBox.Name = "deskComboBox";
			this.deskComboBox.Size = new System.Drawing.Size(121, 21);
			this.deskComboBox.TabIndex = 14;
			// 
			// numOfDrawers
			// 
			this.numOfDrawers.Location = new System.Drawing.Point(501, 324);
			this.numOfDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
			this.numOfDrawers.Name = "numOfDrawers";
			this.numOfDrawers.Size = new System.Drawing.Size(120, 20);
			this.numOfDrawers.TabIndex = 15;
			// 
			// rushOcomboBox
			// 
			this.rushOcomboBox.FormattingEnabled = true;
			this.rushOcomboBox.Items.AddRange(new object[] {
            "3 Days",
            "5 Days",
            "7 Days"});
			this.rushOcomboBox.Location = new System.Drawing.Point(501, 252);
			this.rushOcomboBox.Name = "rushOcomboBox";
			this.rushOcomboBox.Size = new System.Drawing.Size(121, 21);
			this.rushOcomboBox.TabIndex = 17;
			this.rushOcomboBox.SelectedIndexChanged += new System.EventHandler(this.rushOcomboBox_SelectedIndexChanged);
			// 
			// submitButton
			// 
			this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.submitButton.Location = new System.Drawing.Point(16, 388);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(200, 50);
			this.submitButton.TabIndex = 18;
			this.submitButton.Text = "Submit Quote";
			this.submitButton.UseVisualStyleBackColor = true;
			this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
			// 
			// widthLabel
			// 
			this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.widthLabel.Location = new System.Drawing.Point(146, 137);
			this.widthLabel.Name = "widthLabel";
			this.widthLabel.Size = new System.Drawing.Size(65, 29);
			this.widthLabel.TabIndex = 19;
			this.widthLabel.Text = "Width:";
			this.widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// depthLabel
			// 
			this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.depthLabel.Location = new System.Drawing.Point(146, 166);
			this.depthLabel.Name = "depthLabel";
			this.depthLabel.Size = new System.Drawing.Size(65, 29);
			this.depthLabel.TabIndex = 20;
			this.depthLabel.Text = "Depth:";
			this.depthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(146, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 29);
			this.label1.TabIndex = 21;
			this.label1.Text = "Surface Material:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// widthComboBox
			// 
			this.widthComboBox.FormattingEnabled = true;
			this.widthComboBox.Items.AddRange(new object[] {
            "24\"",
            "36\"",
            "48\"",
            "60\"",
            "72\"",
            "84\"",
            "96\""});
			this.widthComboBox.Location = new System.Drawing.Point(217, 144);
			this.widthComboBox.Name = "widthComboBox";
			this.widthComboBox.Size = new System.Drawing.Size(121, 21);
			this.widthComboBox.TabIndex = 22;
			// 
			// depthComboBox
			// 
			this.depthComboBox.FormattingEnabled = true;
			this.depthComboBox.Items.AddRange(new object[] {
            "12\"",
            "24\"",
            "36\"",
            "48\""});
			this.depthComboBox.Location = new System.Drawing.Point(217, 171);
			this.depthComboBox.Name = "depthComboBox";
			this.depthComboBox.Size = new System.Drawing.Size(121, 21);
			this.depthComboBox.TabIndex = 23;
			// 
			// AddQuote
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.depthComboBox);
			this.Controls.Add(this.widthComboBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.depthLabel);
			this.Controls.Add(this.widthLabel);
			this.Controls.Add(this.submitButton);
			this.Controls.Add(this.rushOcomboBox);
			this.Controls.Add(this.numOfDrawers);
			this.Controls.Add(this.deskComboBox);
			this.Controls.Add(this.drawerLabel);
			this.Controls.Add(this.rushDateLabel);
			this.Controls.Add(this.rushOCheckBoxNo);
			this.Controls.Add(this.rushOCheckBoxYes);
			this.Controls.Add(this.rushOrderLabel);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.DateQuoteLabel);
			this.Controls.Add(this.deskLabel);
			this.Controls.Add(this.customerLabel);
			this.Controls.Add(this.cusomterNameBox);
			this.Controls.Add(this.cancelQuote);
			this.Name = "AddQuote";
			this.Text = "AddQuote";
			this.Load += new System.EventHandler(this.AddQuote_Load);
			((System.ComponentModel.ISupportInitialize)(this.numOfDrawers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cancelQuote;
		private System.Windows.Forms.TextBox cusomterNameBox;
		private System.Windows.Forms.Label customerLabel;
		private System.Windows.Forms.Label deskLabel;
		private System.Windows.Forms.Label DateQuoteLabel;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Label rushOrderLabel;
		private System.Windows.Forms.CheckBox rushOCheckBoxYes;
		private System.Windows.Forms.CheckBox rushOCheckBoxNo;
		private System.Windows.Forms.Label rushDateLabel;
		private System.Windows.Forms.Label drawerLabel;
		private System.Windows.Forms.ComboBox deskComboBox;
		private System.Windows.Forms.NumericUpDown numOfDrawers;
		private System.Windows.Forms.ComboBox rushOcomboBox;
		private System.Windows.Forms.Button submitButton;
		private System.Windows.Forms.Label widthLabel;
		private System.Windows.Forms.Label depthLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox widthComboBox;
		private System.Windows.Forms.ComboBox depthComboBox;
	}
}