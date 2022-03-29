namespace IvanovMovieDataBase
{
    partial class AddMovieForm
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
            this.label1 = new System.Windows.Forms.Label();
            this._tbTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._rtbSummary = new System.Windows.Forms.RichTextBox();
            this._cbGenre = new System.Windows.Forms.ComboBox();
            this._btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this._tbCountry = new System.Windows.Forms.TextBox();
            this._btnBack = new System.Windows.Forms.Button();
            this._dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this._cbDirector = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // _tbTitle
            // 
            this._tbTitle.Location = new System.Drawing.Point(115, 40);
            this._tbTitle.Name = "_tbTitle";
            this._tbTitle.Size = new System.Drawing.Size(144, 20);
            this._tbTitle.TabIndex = 1;
            this._tbTitle.TextChanged += new System.EventHandler(this._tbTitle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Genre:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Release date:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Summary:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // _rtbSummary
            // 
            this._rtbSummary.Location = new System.Drawing.Point(115, 176);
            this._rtbSummary.Name = "_rtbSummary";
            this._rtbSummary.Size = new System.Drawing.Size(144, 205);
            this._rtbSummary.TabIndex = 2;
            this._rtbSummary.Text = "";
            this._rtbSummary.TextChanged += new System.EventHandler(this._rtbSummary_TextChanged);
            // 
            // _cbGenre
            // 
            this._cbGenre.FormattingEnabled = true;
            this._cbGenre.Items.AddRange(new object[] {
            "Action",
            "Animated",
            "Comedy",
            "Documentary",
            "Drama",
            "Family",
            "Fantasy",
            "History",
            "Horror",
            "Musical",
            "Romance",
            "SF",
            "Thriller",
            "Western"});
            this._cbGenre.Location = new System.Drawing.Point(115, 66);
            this._cbGenre.Name = "_cbGenre";
            this._cbGenre.Size = new System.Drawing.Size(144, 21);
            this._cbGenre.Sorted = true;
            this._cbGenre.TabIndex = 4;
            this._cbGenre.SelectedIndexChanged += new System.EventHandler(this._cbGenre_SelectedIndexChanged);
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(184, 387);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(75, 23);
            this._btnAdd.TabIndex = 5;
            this._btnAdd.Text = "Add";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Country:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // _tbCountry
            // 
            this._tbCountry.Location = new System.Drawing.Point(115, 118);
            this._tbCountry.Name = "_tbCountry";
            this._tbCountry.Size = new System.Drawing.Size(144, 20);
            this._tbCountry.TabIndex = 1;
            this._tbCountry.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // _btnBack
            // 
            this._btnBack.Location = new System.Drawing.Point(12, 12);
            this._btnBack.Name = "_btnBack";
            this._btnBack.Size = new System.Drawing.Size(42, 23);
            this._btnBack.TabIndex = 6;
            this._btnBack.Text = "<--";
            this._btnBack.UseVisualStyleBackColor = true;
            this._btnBack.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // _dtpReleaseDate
            // 
            this._dtpReleaseDate.Location = new System.Drawing.Point(115, 92);
            this._dtpReleaseDate.Name = "_dtpReleaseDate";
            this._dtpReleaseDate.Size = new System.Drawing.Size(144, 20);
            this._dtpReleaseDate.TabIndex = 3;
            this._dtpReleaseDate.ValueChanged += new System.EventHandler(this._dtpReleaseDate_ValueChanged);
            // 
            // _cbDirector
            // 
            this._cbDirector.FormattingEnabled = true;
            this._cbDirector.Location = new System.Drawing.Point(115, 147);
            this._cbDirector.Name = "_cbDirector";
            this._cbDirector.Size = new System.Drawing.Size(144, 21);
            this._cbDirector.TabIndex = 7;
            this._cbDirector.SelectedIndexChanged += new System.EventHandler(this._cbDirector_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Director:";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 450);
            this.Controls.Add(this._cbDirector);
            this.Controls.Add(this._btnBack);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._cbGenre);
            this.Controls.Add(this._dtpReleaseDate);
            this.Controls.Add(this._rtbSummary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._tbCountry);
            this.Controls.Add(this._tbTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddMovieForm";
            this.Text = "AddMovieForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _tbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox _rtbSummary;
        private System.Windows.Forms.ComboBox _cbGenre;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _tbCountry;
        private System.Windows.Forms.Button _btnBack;
        private System.Windows.Forms.DateTimePicker _dtpReleaseDate;
        private System.Windows.Forms.ComboBox _cbDirector;
        private System.Windows.Forms.Label label5;
    }
}