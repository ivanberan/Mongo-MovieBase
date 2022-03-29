namespace IvanovMovieDataBase
{
    partial class MainForm
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
            this._dgvData = new System.Windows.Forms.DataGridView();
            this._btnSearch = new System.Windows.Forms.Button();
            this._cbGenre = new System.Windows.Forms.ComboBox();
            this._btnAddMovie = new System.Windows.Forms.Button();
            this._btnDelete = new System.Windows.Forms.Button();
            this._cbDelete = new System.Windows.Forms.ComboBox();
            this._btnMovieReviews = new System.Windows.Forms.Button();
            this._cbDirector = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Director = new System.Windows.Forms.Label();
            this._btnUpdateMovie = new System.Windows.Forms.Button();
            this._btnAddDirector = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dgvData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _dgvData
            // 
            this._dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvData.Location = new System.Drawing.Point(12, 134);
            this._dgvData.Name = "_dgvData";
            this._dgvData.Size = new System.Drawing.Size(776, 304);
            this._dgvData.TabIndex = 0;
            this._dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgvData_CellContentClick);
            // 
            // _btnSearch
            // 
            this._btnSearch.Location = new System.Drawing.Point(206, 23);
            this._btnSearch.Name = "_btnSearch";
            this._btnSearch.Size = new System.Drawing.Size(93, 36);
            this._btnSearch.TabIndex = 1;
            this._btnSearch.Text = "Search all";
            this._btnSearch.UseVisualStyleBackColor = true;
            this._btnSearch.Click += new System.EventHandler(this.button1_Click);
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
            this._cbGenre.Location = new System.Drawing.Point(59, 45);
            this._cbGenre.Name = "_cbGenre";
            this._cbGenre.Size = new System.Drawing.Size(121, 21);
            this._cbGenre.Sorted = true;
            this._cbGenre.TabIndex = 3;
            this._cbGenre.SelectedIndexChanged += new System.EventHandler(this._cbGenre_SelectedIndexChanged);
            // 
            // _btnAddMovie
            // 
            this._btnAddMovie.Location = new System.Drawing.Point(12, 12);
            this._btnAddMovie.Name = "_btnAddMovie";
            this._btnAddMovie.Size = new System.Drawing.Size(90, 42);
            this._btnAddMovie.TabIndex = 4;
            this._btnAddMovie.Text = "Add Movie";
            this._btnAddMovie.UseVisualStyleBackColor = true;
            this._btnAddMovie.Click += new System.EventHandler(this.button2_Click);
            // 
            // _btnDelete
            // 
            this._btnDelete.Location = new System.Drawing.Point(676, 92);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(119, 36);
            this._btnDelete.TabIndex = 5;
            this._btnDelete.Text = "Delete";
            this._btnDelete.UseVisualStyleBackColor = true;
            this._btnDelete.Click += new System.EventHandler(this._btnDelete_Click);
            // 
            // _cbDelete
            // 
            this._cbDelete.FormattingEnabled = true;
            this._cbDelete.Location = new System.Drawing.Point(674, 65);
            this._cbDelete.Name = "_cbDelete";
            this._cbDelete.Size = new System.Drawing.Size(121, 21);
            this._cbDelete.Sorted = true;
            this._cbDelete.TabIndex = 6;
            // 
            // _btnMovieReviews
            // 
            this._btnMovieReviews.Location = new System.Drawing.Point(204, 12);
            this._btnMovieReviews.Name = "_btnMovieReviews";
            this._btnMovieReviews.Size = new System.Drawing.Size(90, 42);
            this._btnMovieReviews.TabIndex = 7;
            this._btnMovieReviews.Text = "Movie Reviews";
            this._btnMovieReviews.UseVisualStyleBackColor = true;
            this._btnMovieReviews.Click += new System.EventHandler(this._btnMovieReviews_Click);
            // 
            // _cbDirector
            // 
            this._cbDirector.FormattingEnabled = true;
            this._cbDirector.Location = new System.Drawing.Point(59, 23);
            this._cbDirector.Name = "_cbDirector";
            this._cbDirector.Size = new System.Drawing.Size(121, 21);
            this._cbDirector.TabIndex = 8;
            this._cbDirector.SelectedIndexChanged += new System.EventHandler(this._cbDirector_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Director);
            this.groupBox1.Controls.Add(this._cbDirector);
            this.groupBox1.Controls.Add(this._cbGenre);
            this.groupBox1.Controls.Add(this._btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(329, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 81);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Genre";
            // 
            // Director
            // 
            this.Director.AutoSize = true;
            this.Director.Location = new System.Drawing.Point(-1, 28);
            this.Director.Name = "Director";
            this.Director.Size = new System.Drawing.Size(44, 13);
            this.Director.TabIndex = 9;
            this.Director.Text = "Director";
            // 
            // _btnUpdateMovie
            // 
            this._btnUpdateMovie.Location = new System.Drawing.Point(12, 60);
            this._btnUpdateMovie.Name = "_btnUpdateMovie";
            this._btnUpdateMovie.Size = new System.Drawing.Size(90, 42);
            this._btnUpdateMovie.TabIndex = 10;
            this._btnUpdateMovie.Text = "Update movie";
            this._btnUpdateMovie.UseVisualStyleBackColor = true;
            this._btnUpdateMovie.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // _btnAddDirector
            // 
            this._btnAddDirector.Location = new System.Drawing.Point(108, 12);
            this._btnAddDirector.Name = "_btnAddDirector";
            this._btnAddDirector.Size = new System.Drawing.Size(90, 42);
            this._btnAddDirector.TabIndex = 11;
            this._btnAddDirector.Text = "Add director";
            this._btnAddDirector.UseVisualStyleBackColor = true;
            this._btnAddDirector.Click += new System.EventHandler(this._btnAddDirector_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnAddDirector);
            this.Controls.Add(this._btnUpdateMovie);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._btnMovieReviews);
            this.Controls.Add(this._cbDelete);
            this.Controls.Add(this._btnDelete);
            this.Controls.Add(this._btnAddMovie);
            this.Controls.Add(this._dgvData);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._dgvData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _dgvData;
        private System.Windows.Forms.Button _btnSearch;
        private System.Windows.Forms.ComboBox _cbGenre;
        private System.Windows.Forms.Button _btnAddMovie;
        private System.Windows.Forms.Button _btnDelete;
        private System.Windows.Forms.ComboBox _cbDelete;
        private System.Windows.Forms.Button _btnMovieReviews;
        private System.Windows.Forms.ComboBox _cbDirector;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Director;
        private System.Windows.Forms.Button _btnUpdateMovie;
        private System.Windows.Forms.Button _btnAddDirector;
    }
}

