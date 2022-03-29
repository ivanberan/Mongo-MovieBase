using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;


namespace IvanovMovieDataBase
{
    public partial class MainForm : Form
    {
        MongoClient client;
        IMongoDatabase db;
        IMongoCollection<Movie> collection;
        IMongoCollection<Director> directors;
        List<Movie> FilmList;
        public MainForm()
        {
            InitializeComponent();
            

            client = new MongoClient();
            db = client.GetDatabase("IvanovMovieDataBase");

            collection = db.GetCollection<Movie>("Movie");

            directors = db.GetCollection<Director>("Director");

            FilmList = new List<Movie>();
            FilmList = collection.Find(x => true).ToList();
            for (int i = 0; i < FilmList.Count(); i++)
            {
                _cbDelete.Items.Add(FilmList[i].Title );
            }

            List<Director> directorList = new List<Director>();
            directorList = directors.Find(x => true).ToList();


            for (int i = 0; i < directorList.Count(); i++)
            {
                _cbDirector.Items.Add(directorList[i].Name + " " + directorList[i].Surname);
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

          
            FilmList = collection.Find(x => true).ToList();
            _dgvData.Visible = true;
            _dgvData.DataSource = FilmList;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMovieForm myForm = new AddMovieForm();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

      

        private void _btnDelete_Click(object sender, EventArgs e)
        {
            var MovieTitle = _cbDelete.Text;
            var deleteFilter = Builders<Movie>.Filter.Eq("Title", MovieTitle);
            collection.DeleteOne(deleteFilter);
            MessageBox.Show("Movie Deleted");
            this.Refresh();
        }

        private void _btnMovieReviews_Click(object sender, EventArgs e)
        {
            MovieReviewForm myForm = new MovieReviewForm();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void _dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _cbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Genre = _cbGenre.SelectedItem.ToString();
            FilmList = collection.Find(x => x.Genre == Genre).ToList();
            _dgvData.DataSource = FilmList;

        }

        private void _cbDirector_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Director = _cbDirector.SelectedItem.ToString();
            FilmList = collection.Find(x => x.Director == Director).ToList();
            _dgvData.DataSource = FilmList;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UpdateMovieForm myForm = new UpdateMovieForm();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void _btnAddDirector_Click(object sender, EventArgs e)
        {
            AddDirectorForm myForm = new AddDirectorForm();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
