namespace LibrariyOtomation
{
    partial class BookSave
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
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblWriterName = new System.Windows.Forms.Label();
            this.lblPublisherName = new System.Windows.Forms.Label();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.lblPublishedYear = new System.Windows.Forms.Label();
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.lblBookStuation = new System.Windows.Forms.Label();
            this.cmBoxPublisherName = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.cmBoxBookStuation = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblBookShelf = new System.Windows.Forms.Label();
            this.cmBoxBookshelf = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmBoxBookShelfSection = new System.Windows.Forms.ComboBox();
            this.cmBoxBookName = new System.Windows.Forms.ComboBox();
            this.lblVolumeNumber = new System.Windows.Forms.Label();
            this.cmBoxVolumeNumber = new System.Windows.Forms.ComboBox();
            this.lblBookType = new System.Windows.Forms.Label();
            this.cmBoxBookType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookName.Location = new System.Drawing.Point(84, 148);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(129, 25);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "Book Name :";
            // 
            // lblWriterName
            // 
            this.lblWriterName.AutoSize = true;
            this.lblWriterName.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWriterName.Location = new System.Drawing.Point(76, 199);
            this.lblWriterName.Name = "lblWriterName";
            this.lblWriterName.Size = new System.Drawing.Size(137, 25);
            this.lblWriterName.TabIndex = 1;
            this.lblWriterName.Text = "Writer Name :";
            // 
            // lblPublisherName
            // 
            this.lblPublisherName.AutoSize = true;
            this.lblPublisherName.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPublisherName.Location = new System.Drawing.Point(49, 250);
            this.lblPublisherName.Name = "lblPublisherName";
            this.lblPublisherName.Size = new System.Drawing.Size(164, 25);
            this.lblPublisherName.TabIndex = 2;
            this.lblPublisherName.Text = "Publisher Name :";
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPageNumber.Location = new System.Drawing.Point(70, 387);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(143, 25);
            this.lblPageNumber.TabIndex = 3;
            this.lblPageNumber.Text = "Page Number :";
            // 
            // lblPublishedYear
            // 
            this.lblPublishedYear.AutoSize = true;
            this.lblPublishedYear.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPublishedYear.Location = new System.Drawing.Point(57, 440);
            this.lblPublishedYear.Name = "lblPublishedYear";
            this.lblPublishedYear.Size = new System.Drawing.Size(156, 25);
            this.lblPublishedYear.TabIndex = 4;
            this.lblPublishedYear.Text = "Published Year :";
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookPrice.Location = new System.Drawing.Point(91, 492);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(122, 25);
            this.lblBookPrice.TabIndex = 5;
            this.lblBookPrice.Text = "Book Price :";
            // 
            // lblBookStuation
            // 
            this.lblBookStuation.AutoSize = true;
            this.lblBookStuation.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookStuation.Location = new System.Drawing.Point(64, 540);
            this.lblBookStuation.Name = "lblBookStuation";
            this.lblBookStuation.Size = new System.Drawing.Size(149, 25);
            this.lblBookStuation.TabIndex = 6;
            this.lblBookStuation.Text = "Book Stuation :";
            // 
            // cmBoxPublisherName
            // 
            this.cmBoxPublisherName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmBoxPublisherName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmBoxPublisherName.BackColor = System.Drawing.Color.OldLace;
            this.cmBoxPublisherName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmBoxPublisherName.FormattingEnabled = true;
            this.cmBoxPublisherName.ItemHeight = 20;
            this.cmBoxPublisherName.Location = new System.Drawing.Point(243, 250);
            this.cmBoxPublisherName.MaxDropDownItems = 12;
            this.cmBoxPublisherName.Name = "cmBoxPublisherName";
            this.cmBoxPublisherName.Size = new System.Drawing.Size(373, 28);
            this.cmBoxPublisherName.TabIndex = 5;
            this.cmBoxPublisherName.SelectedIndexChanged += new System.EventHandler(this.cmBoxPublisherName_SelectedIndexChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(243, 388);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(184, 26);
            this.maskedTextBox1.TabIndex = 8;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(243, 441);
            this.maskedTextBox2.Mask = "0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(184, 26);
            this.maskedTextBox2.TabIndex = 9;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(243, 493);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(184, 26);
            this.maskedTextBox3.TabIndex = 10;
            // 
            // cmBoxBookStuation
            // 
            this.cmBoxBookStuation.BackColor = System.Drawing.Color.OldLace;
            this.cmBoxBookStuation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxBookStuation.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmBoxBookStuation.FormattingEnabled = true;
            this.cmBoxBookStuation.Items.AddRange(new object[] {
            "Want to read",
            "Currently reading",
            "Read"});
            this.cmBoxBookStuation.Location = new System.Drawing.Point(243, 541);
            this.cmBoxBookStuation.Name = "cmBoxBookStuation";
            this.cmBoxBookStuation.Size = new System.Drawing.Size(184, 30);
            this.cmBoxBookStuation.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(243, 196);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(373, 28);
            this.comboBox2.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(243, 628);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(373, 52);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblBookShelf
            // 
            this.lblBookShelf.AutoSize = true;
            this.lblBookShelf.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookShelf.Location = new System.Drawing.Point(12, 32);
            this.lblBookShelf.Name = "lblBookShelf";
            this.lblBookShelf.Size = new System.Drawing.Size(201, 25);
            this.lblBookShelf.TabIndex = 16;
            this.lblBookShelf.Text = "Choose a Bookshelf :";
            // 
            // cmBoxBookshelf
            // 
            this.cmBoxBookshelf.FormattingEnabled = true;
            this.cmBoxBookshelf.Location = new System.Drawing.Point(243, 32);
            this.cmBoxBookshelf.Name = "cmBoxBookshelf";
            this.cmBoxBookshelf.Size = new System.Drawing.Size(373, 28);
            this.cmBoxBookshelf.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Choose a section :";
            // 
            // cmBoxBookShelfSection
            // 
            this.cmBoxBookShelfSection.FormattingEnabled = true;
            this.cmBoxBookShelfSection.Location = new System.Drawing.Point(243, 88);
            this.cmBoxBookShelfSection.Name = "cmBoxBookShelfSection";
            this.cmBoxBookShelfSection.Size = new System.Drawing.Size(373, 28);
            this.cmBoxBookShelfSection.TabIndex = 2;
            // 
            // cmBoxBookName
            // 
            this.cmBoxBookName.FormattingEnabled = true;
            this.cmBoxBookName.Location = new System.Drawing.Point(243, 145);
            this.cmBoxBookName.Name = "cmBoxBookName";
            this.cmBoxBookName.Size = new System.Drawing.Size(373, 28);
            this.cmBoxBookName.TabIndex = 3;
            // 
            // lblVolumeNumber
            // 
            this.lblVolumeNumber.AutoSize = true;
            this.lblVolumeNumber.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVolumeNumber.Location = new System.Drawing.Point(46, 298);
            this.lblVolumeNumber.Name = "lblVolumeNumber";
            this.lblVolumeNumber.Size = new System.Drawing.Size(167, 25);
            this.lblVolumeNumber.TabIndex = 21;
            this.lblVolumeNumber.Text = "Volume Number :";
            // 
            // cmBoxVolumeNumber
            // 
            this.cmBoxVolumeNumber.FormattingEnabled = true;
            this.cmBoxVolumeNumber.Location = new System.Drawing.Point(243, 299);
            this.cmBoxVolumeNumber.Name = "cmBoxVolumeNumber";
            this.cmBoxVolumeNumber.Size = new System.Drawing.Size(184, 28);
            this.cmBoxVolumeNumber.TabIndex = 6;
            // 
            // lblBookType
            // 
            this.lblBookType.AutoSize = true;
            this.lblBookType.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookType.Location = new System.Drawing.Point(70, 343);
            this.lblBookType.Name = "lblBookType";
            this.lblBookType.Size = new System.Drawing.Size(121, 25);
            this.lblBookType.TabIndex = 22;
            this.lblBookType.Text = "Book Type :";
            // 
            // cmBoxBookType
            // 
            this.cmBoxBookType.FormattingEnabled = true;
            this.cmBoxBookType.Location = new System.Drawing.Point(243, 344);
            this.cmBoxBookType.Name = "cmBoxBookType";
            this.cmBoxBookType.Size = new System.Drawing.Size(184, 28);
            this.cmBoxBookType.TabIndex = 7;
            // 
            // BookSave
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 703);
            this.Controls.Add(this.cmBoxBookType);
            this.Controls.Add(this.lblBookType);
            this.Controls.Add(this.cmBoxVolumeNumber);
            this.Controls.Add(this.lblVolumeNumber);
            this.Controls.Add(this.cmBoxBookName);
            this.Controls.Add(this.cmBoxBookShelfSection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmBoxBookshelf);
            this.Controls.Add(this.lblBookShelf);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cmBoxBookStuation);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.cmBoxPublisherName);
            this.Controls.Add(this.lblBookStuation);
            this.Controls.Add(this.lblBookPrice);
            this.Controls.Add(this.lblPublishedYear);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.lblPublisherName);
            this.Controls.Add(this.lblWriterName);
            this.Controls.Add(this.lblBookName);
            this.Name = "BookSave";
            this.Text = "BookSave";
            this.Load += new System.EventHandler(this.BookSave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblWriterName;
        private System.Windows.Forms.Label lblPublisherName;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.Label lblPublishedYear;
        private System.Windows.Forms.Label lblBookPrice;
        private System.Windows.Forms.Label lblBookStuation;
        private System.Windows.Forms.ComboBox cmBoxPublisherName;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.ComboBox cmBoxBookStuation;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblBookShelf;
        private System.Windows.Forms.ComboBox cmBoxBookshelf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmBoxBookShelfSection;
        private System.Windows.Forms.ComboBox cmBoxBookName;
        private System.Windows.Forms.Label lblVolumeNumber;
        private System.Windows.Forms.ComboBox cmBoxVolumeNumber;
        private System.Windows.Forms.Label lblBookType;
        private System.Windows.Forms.ComboBox cmBoxBookType;
    }
}