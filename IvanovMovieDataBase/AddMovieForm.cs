using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace IvanovMovieDataBase
{
    public partial class AddMovieForm : Form
    {

        MongoClient client;
        IMongoDatabase db;
        IMongoCollection<Movie> collection;
        IMongoCollection<Director> directors;
        public AddMovieForm()
        {

            InitializeComponent();
            
            client = new MongoClient();
            db = client.GetDatabase("IvanovMovieDataBase");
            collection = db.GetCollection<Movie>("Movie");
            directors = db.GetCollection<Director>("Director");

            List<Director> directorList = new List<Director>();
            directorList = directors.Find(x => true).ToList();


            for (int i = 0; i < directorList.Count(); i++)
            {
                _cbDirector.Items.Add(directorList[i].Name + " " + directorList[i].Surname);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_tbTitle.Text != "" && _rtbSummary.Text != "" && _dtpReleaseDate.Text != "" && _cbGenre.Text != "" && _tbCountry.Text != "" && _cbDirector.Text != "")
            {
                try
                {
                    Movie movie = new Movie
                    {
                        Title = _tbTitle.Text,
                        Genre = _cbGenre.Text,
                        Summary = _rtbSummary.Text,
                        Director = _cbDirector.Text,
                        ReleaseDate = _dtpReleaseDate.Text,
                        Country = _tbCountry.Text,
                    };
                    collection.InsertOne(movie);
                    MessageBox.Show("Movie added!");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
                _tbTitle.Clear();
                _cbGenre.ResetText();
                _rtbSummary.Clear();
                _dtpReleaseDate.ResetText();
                _tbCountry.Clear();
                _cbDirector.ResetText();
            }
            else
            {
                MessageBox.Show("Fill all boxes!");
                return;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MainForm myForm = new MainForm();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void _cbDirector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void _cbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void _dtpReleaseDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void _rtbSummary_TextChanged(object sender, EventArgs e)
        {

        }

        private void _tbTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
