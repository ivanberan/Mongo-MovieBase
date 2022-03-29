using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using MongoDB.Driver;

namespace IvanovMovieDataBase
{
    public partial class AddDirectorForm : Form
    {

        MongoClient client;
        IMongoDatabase db;
        IMongoCollection<Director> directors;
        public AddDirectorForm()
        {
            InitializeComponent();
            client = new MongoClient();
            db = client.GetDatabase("IvanovMovieDataBase");
            directors = db.GetCollection<Director>("Director");

            List<Director> directorList = new List<Director>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            if (_tbName.Text != "" && _tbSurname.Text != "" && _dtpBirthdate.Text != "" && _tbNationality.Text != "")
            {
                try
                {
                    Director director = new Director
                    {
                        Name = _tbName.Text,
                        Surname = _tbSurname.Text,
                        BirthDate = _dtpBirthdate.Text,
                        Nationality = _tbNationality.Text,

                    };
                    directors.InsertOne(director);
                    MessageBox.Show("Director added!");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
                _tbName.Clear();
                _tbSurname.ResetText();
                _dtpBirthdate.ResetText();
                _tbNationality.ResetText();

            }
            else
            {
                MessageBox.Show("Fill all boxes!");
                return;
            }
        }

        private void _btnBack_Click(object sender, EventArgs e)
        {
            MainForm myForm = new MainForm();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
