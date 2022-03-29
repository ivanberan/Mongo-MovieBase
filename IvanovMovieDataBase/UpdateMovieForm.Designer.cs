namespace IvanovMovieDataBase
{
    partial class UpdateMovieForm
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
            this._cbDirector = new System.Windows.Forms.ComboBox();
            this._btnBack = new System.Windows.Forms.Button();
            this._btnUpdate = new System.Windows.Forms.Button();
            this._cbGenre = new System.Windows.Forms.ComboBox();
            this._dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this._rtbSummary = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._tbCountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._cbMovieTitle = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _cbDirector
            // 
            this._cbDirector.FormattingEnabled = true;
            this._cbDirector.Location = new System.Drawing.Point(152, 149);
            this._cbDirector.Name = "_cbDirector";
            this._cbDirector.Size = new System.Drawing.Size(144, 21);
            this._cbDirector.TabIndex = 21;
            // 
            // _btnBack
            // 
            this._btnBack.Location = new System.Drawing.Point(12, 10);
            this._btnBack.Name = "_btnBack";
            this._btnBack.Size = new System.Drawing.Size(42, 23);
            this._btnBack.TabIndex = 20;
            this._btnBack.Text = "<--";
            this._btnBack.UseVisualStyleBackColor = true;
            this._btnBack.Click += new System.EventHandler(this._btnBack_Click);
            // 
            // _btnUpdate
            // 
            this._btnUpdate.Location = new System.Drawing.Point(221, 389);
            this._btnUpdate.Name = "_btnUpdate";
            this._btnUpdate.Size = new System.Drawing.Size(75, 23);
            this._btnUpdate.TabIndex = 19;
            this._btnUpdate.Text = "Update";
            this._btnUpdate.UseVisualStyleBackColor = true;
            this._btnUpdate.Click += new System.EventHandler(this._btnUpdate_Click);
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
            this._cbGenre.Location = new System.Drawing.Point(152, 68);
            this._cbGenre.Name = "_cbGenre";
            this._cbGenre.Size = new System.Drawing.Size(144, 21);
            this._cbGenre.Sorted = true;
            this._cbGenre.TabIndex = 18;
            // 
            // _dtpReleaseDate
            // 
            this._dtpReleaseDate.Location = new System.Drawing.Point(152, 94);
            this._dtpReleaseDate.Name = "_dtpReleaseDate";
            this._dtpReleaseDate.Size = new System.Drawing.Size(144, 20);
            this._dtpReleaseDate.TabIndex = 17;
            // 
            // _rtbSummary
            // 
            this._rtbSummary.Location = new System.Drawing.Point(152, 178);
            this._rtbSummary.Name = "_rtbSummary";
            this._rtbSummary.Size = new System.Drawing.Size(144, 205);
            this._rtbSummary.TabIndex = 16;
            this._rtbSummary.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Director:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Summary:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Release date:";
            // 
            // _tbCountry
            // 
            this._tbCountry.Location = new System.Drawing.Point(152, 120);
            this._tbCountry.Name = "_tbCountry";
            this._tbCountry.Size = new System.Drawing.Size(144, 20);
            this._tbCountry.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Country:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Genre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Choose movie:";
            // 
            // _cbMovieTitle
            // 
            this._cbMovieTitle.FormattingEnabled = true;
            this._cbMovieTitle.Location = new System.Drawing.Point(152, 12);
            this._cbMovieTitle.Name = "_cbMovieTitle";
            this._cbMovieTitle.Size = new System.Drawing.Size(144, 21);
            this._cbMovieTitle.TabIndex = 22;
            // 
            // UpdateMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this._cbMovieTitle);
            this.Controls.Add(this._cbDirector);
            this.Controls.Add(this._btnBack);
            this.Controls.Add(this._btnUpdate);
            this.Controls.Add(this._cbGenre);
            this.Controls.Add(this._dtpReleaseDate);
            this.Controls.Add(this._rtbSummary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._tbCountry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateMovieForm";
            this.Text = "UpdateMovieForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _cbDirector;
        private System.Windows.Forms.Button _btnBack;
        private System.Windows.Forms.Button _btnUpdate;
        private System.Windows.Forms.ComboBox _cbGenre;
        private System.Windows.Forms.DateTimePicker _dtpReleaseDate;
        private System.Windows.Forms.RichTextBox _rtbSummary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tbCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cbMovieTitle;
    }
}