namespace IvanovMovieDataBase
{
    partial class MovieReviewForm
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
            this._cbMovieTitles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._lScoreText = new System.Windows.Forms.Label();
            this._rb1 = new System.Windows.Forms.RadioButton();
            this._rb2 = new System.Windows.Forms.RadioButton();
            this._rb3 = new System.Windows.Forms.RadioButton();
            this._rb4 = new System.Windows.Forms.RadioButton();
            this._rb5 = new System.Windows.Forms.RadioButton();
            this._rtbReview = new System.Windows.Forms.RichTextBox();
            this._btnAddReview = new System.Windows.Forms.Button();
            this._dgvData = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this._btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // _cbMovieTitles
            // 
            this._cbMovieTitles.FormattingEnabled = true;
            this._cbMovieTitles.Location = new System.Drawing.Point(121, 26);
            this._cbMovieTitles.Name = "_cbMovieTitles";
            this._cbMovieTitles.Size = new System.Drawing.Size(180, 21);
            this._cbMovieTitles.TabIndex = 0;
            this._cbMovieTitles.SelectedIndexChanged += new System.EventHandler(this._cbMovieTitles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chose Movie";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rate movie";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Review";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // _lScoreText
            // 
            this._lScoreText.AutoSize = true;
            this._lScoreText.Location = new System.Drawing.Point(419, 362);
            this._lScoreText.Name = "_lScoreText";
            this._lScoreText.Size = new System.Drawing.Size(0, 13);
            this._lScoreText.TabIndex = 1;
            this._lScoreText.Click += new System.EventHandler(this.label1_Click);
            // 
            // _rb1
            // 
            this._rb1.AutoSize = true;
            this._rb1.Location = new System.Drawing.Point(121, 72);
            this._rb1.Name = "_rb1";
            this._rb1.Size = new System.Drawing.Size(31, 17);
            this._rb1.TabIndex = 2;
            this._rb1.TabStop = true;
            this._rb1.Tag = "1";
            this._rb1.Text = "1";
            this._rb1.UseVisualStyleBackColor = true;
            // 
            // _rb2
            // 
            this._rb2.AutoSize = true;
            this._rb2.Location = new System.Drawing.Point(158, 72);
            this._rb2.Name = "_rb2";
            this._rb2.Size = new System.Drawing.Size(31, 17);
            this._rb2.TabIndex = 2;
            this._rb2.TabStop = true;
            this._rb2.Tag = "2";
            this._rb2.Text = "2";
            this._rb2.UseVisualStyleBackColor = true;
            // 
            // _rb3
            // 
            this._rb3.AutoSize = true;
            this._rb3.Location = new System.Drawing.Point(195, 72);
            this._rb3.Name = "_rb3";
            this._rb3.Size = new System.Drawing.Size(31, 17);
            this._rb3.TabIndex = 2;
            this._rb3.TabStop = true;
            this._rb3.Tag = "3";
            this._rb3.Text = "3";
            this._rb3.UseVisualStyleBackColor = true;
            // 
            // _rb4
            // 
            this._rb4.AutoSize = true;
            this._rb4.Location = new System.Drawing.Point(232, 72);
            this._rb4.Name = "_rb4";
            this._rb4.Size = new System.Drawing.Size(31, 17);
            this._rb4.TabIndex = 2;
            this._rb4.TabStop = true;
            this._rb4.Tag = "4";
            this._rb4.Text = "4";
            this._rb4.UseVisualStyleBackColor = true;
            // 
            // _rb5
            // 
            this._rb5.AutoSize = true;
            this._rb5.Location = new System.Drawing.Point(269, 72);
            this._rb5.Name = "_rb5";
            this._rb5.Size = new System.Drawing.Size(31, 17);
            this._rb5.TabIndex = 2;
            this._rb5.TabStop = true;
            this._rb5.Tag = "5";
            this._rb5.Text = "5";
            this._rb5.UseVisualStyleBackColor = true;
            // 
            // _rtbReview
            // 
            this._rtbReview.Location = new System.Drawing.Point(121, 119);
            this._rtbReview.Name = "_rtbReview";
            this._rtbReview.Size = new System.Drawing.Size(180, 222);
            this._rtbReview.TabIndex = 3;
            this._rtbReview.Text = "";
            // 
            // _btnAddReview
            // 
            this._btnAddReview.Location = new System.Drawing.Point(225, 357);
            this._btnAddReview.Name = "_btnAddReview";
            this._btnAddReview.Size = new System.Drawing.Size(75, 23);
            this._btnAddReview.TabIndex = 4;
            this._btnAddReview.Text = "Add Review";
            this._btnAddReview.UseVisualStyleBackColor = true;
            this._btnAddReview.Click += new System.EventHandler(this._btnAddReview_Click);
            // 
            // _dgvData
            // 
            this._dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvData.Location = new System.Drawing.Point(337, 74);
            this._dgvData.Name = "_dgvData";
            this._dgvData.Size = new System.Drawing.Size(452, 267);
            this._dgvData.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Average score:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // _btnBack
            // 
            this._btnBack.Location = new System.Drawing.Point(1, 3);
            this._btnBack.Name = "_btnBack";
            this._btnBack.Size = new System.Drawing.Size(42, 23);
            this._btnBack.TabIndex = 22;
            this._btnBack.Text = "<--";
            this._btnBack.UseVisualStyleBackColor = true;
            this._btnBack.Click += new System.EventHandler(this._btnBack_Click);
            // 
            // MovieReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnBack);
            this.Controls.Add(this._dgvData);
            this.Controls.Add(this._btnAddReview);
            this.Controls.Add(this._rtbReview);
            this.Controls.Add(this._rb5);
            this.Controls.Add(this._rb4);
            this.Controls.Add(this._rb3);
            this.Controls.Add(this._rb2);
            this.Controls.Add(this._rb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._lScoreText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cbMovieTitles);
            this.Name = "MovieReviewForm";
            this.Text = "MovieReview";
            this.Load += new System.EventHandler(this.MovieReviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _cbMovieTitles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label _lScoreText;
        private System.Windows.Forms.RadioButton _rb1;
        private System.Windows.Forms.RadioButton _rb2;
        private System.Windows.Forms.RadioButton _rb3;
        private System.Windows.Forms.RadioButton _rb4;
        private System.Windows.Forms.RadioButton _rb5;
        private System.Windows.Forms.RichTextBox _rtbReview;
        private System.Windows.Forms.Button _btnAddReview;
        private System.Windows.Forms.DataGridView _dgvData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _btnBack;
    }
}