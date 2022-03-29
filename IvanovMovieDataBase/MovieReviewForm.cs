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
    public partial class MovieReviewForm : Form
    {
        MongoClient client;
        IMongoDatabase db;
        IMongoCollection<Movie> collection;
        IMongoCollection<MovieReview> MovieReviews;
        List<MovieReview> Reviews;
        List<Movie> FilmList;
        public MovieReviewForm()
        {
            InitializeComponent();

            client = new MongoClient();
            db = client.GetDatabase("IvanovMovieDataBase");
            collection = db.GetCollection<Movie>("Movie");
            MovieReviews = db.GetCollection<MovieReview>("MovieReview");

            FilmList = new List<Movie>();
            FilmList = collection.Find(x => true).ToList();
            for (int i = 0; i < FilmList.Count(); i++)
            {
                _cbMovieTitles.Items.Add(FilmList[i].Title);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MovieReviewForm_Load(object sender, EventArgs e)
        {

        }

        private void _btnAddReview_Click(object sender, EventArgs e)
        {
            if (_rtbReview.Text != "" )
            {
                var Score = 0;
                if (_rb1.Checked == true) {
                    Score = 1;
                }
                else if(_rb2.Checked == true){
                    Score = 2;
                }
                else if (_rb3.Checked == true) {
                    Score = 3;
                }
                else if (_rb4.Checked == true){
                    Score = 4;
                }
                else
                {
                    Score = 5;
                }
                try
                {
                    MovieReview Review = new MovieReview
                    {
                        Title = _cbMovieTitles.Text,
                        Review = _rtbReview.Text,
                        Score = Score.ToString(),

                    };
                    MovieReviews.InsertOne(Review);
                    MessageBox.Show("Review added!");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
                _cbMovieTitles.ResetText();
                _rtbReview.ResetText();
                _rb1.Checked=false;
                _rb2.Checked = false;
                _rb3.Checked = false;
                _rb4.Checked = false;
                _rb5.Checked = false;
            }
            else
            {
                MessageBox.Show("Fill all boxes!");
                return;
            }
        }

        private void _cbMovieTitles_SelectedIndexChanged(object sender, EventArgs e)
        {

            Reviews = MovieReviews.Find(x => x.Title == _cbMovieTitles.Text).ToList();
            float prosjek = 0;
            for (int i = 0; i < Reviews.Count(); i++)
            {
                prosjek += int.Parse(Reviews[i].Score);
            }
            prosjek = prosjek / Reviews.Count();
            _lScoreText.Text=prosjek.ToString();
            _dgvData.Visible = true;
            _dgvData.DataSource = Reviews;
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
