namespace IvanovMovieDataBase
{
    partial class AddDirectorForm
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
            this._tbName = new System.Windows.Forms.TextBox();
            this._btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._tbNationality = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._tbSurname = new System.Windows.Forms.TextBox();
            this._dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this._btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // _tbName
            // 
            this._tbName.Location = new System.Drawing.Point(160, 41);
            this._tbName.Name = "_tbName";
            this._tbName.Size = new System.Drawing.Size(140, 20);
            this._tbName.TabIndex = 1;
            this._tbName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // _btnBack
            // 
            this._btnBack.Location = new System.Drawing.Point(12, 12);
            this._btnBack.Name = "_btnBack";
            this._btnBack.Size = new System.Drawing.Size(42, 23);
            this._btnBack.TabIndex = 21;
            this._btnBack.Text = "<--";
            this._btnBack.UseVisualStyleBackColor = true;
            this._btnBack.Click += new System.EventHandler(this._btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Birth Date";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Surname";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // _tbNationality
            // 
            this._tbNationality.Location = new System.Drawing.Point(160, 119);
            this._tbNationality.Name = "_tbNationality";
            this._tbNationality.Size = new System.Drawing.Size(140, 20);
            this._tbNationality.TabIndex = 1;
            this._tbNationality.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nationality";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // _tbSurname
            // 
            this._tbSurname.Location = new System.Drawing.Point(160, 67);
            this._tbSurname.Name = "_tbSurname";
            this._tbSurname.Size = new System.Drawing.Size(140, 20);
            this._tbSurname.TabIndex = 1;
            this._tbSurname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // _dtpBirthdate
            // 
            this._dtpBirthdate.Location = new System.Drawing.Point(160, 93);
            this._dtpBirthdate.Name = "_dtpBirthdate";
            this._dtpBirthdate.Size = new System.Drawing.Size(140, 20);
            this._dtpBirthdate.TabIndex = 22;
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(225, 155);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(75, 23);
            this._btnAdd.TabIndex = 23;
            this._btnAdd.Text = "Add";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // AddDirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 487);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._dtpBirthdate);
            this.Controls.Add(this._btnBack);
            this.Controls.Add(this._tbSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._tbNationality);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._tbName);
            this.Controls.Add(this.label1);
            this.Name = "AddDirectorForm";
            this.Text = "AddDirectorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _tbName;
        private System.Windows.Forms.Button _btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tbNationality;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _tbSurname;
        private System.Windows.Forms.DateTimePicker _dtpBirthdate;
        private System.Windows.Forms.Button _btnAdd;
    }
}