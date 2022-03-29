using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace IvanovMovieDataBase
{
    public partial class UpdateMovieForm : Form
    {

        MongoClient client;
        IMongoDatabase db;
        IMongoCollection<Movie> collection;
        IMongoCollection<Director> directors;
        List<Movie> FilmList;

        public UpdateMovieForm()
        {
            InitializeComponent();

            client = new MongoClient();
            db = client.GetDatabase("IvanovMovieDataBase");
            collection = db.GetCollection<Movie>("Movie");

            FilmList = new List<Movie>();
            FilmList = collection.Find(x => true).ToList();
            for (int i = 0; i < FilmList.Count(); i++)
            {
                _cbMovieTitle.Items.Add(FilmList[i]._MovieID);
            }
        }

        private void _btnUpdate_Click(object sender, EventArgs e)
        {
            ObjectId id = new ObjectId(_cbMovieTitle.Text);
            var filter = Builders<Movie>.Filter.Eq("_MovieID", id);

            if (_cbGenre.Text != "") {
                UpdateDefinition<Movie> update = Builders<Movie>.Update.Set("Genre", _cbGenre.Text); ;
                collection.UpdateOne(filter, update);
            }
            if (_cbDirector.Text != "")
            {
                UpdateDefinition<Movie> update = Builders<Movie>.Update.Set("Director", _cbDirector.Text); ;
                collection.UpdateOne(filter, update);
            }
            if (_dtpReleaseDate.Text != "")
            {
                UpdateDefinition<Movie> update = Builders<Movie>.Update.Set("ReleaseDate", _dtpReleaseDate.Text); ;
                collection.UpdateOne(filter, update);
            }
            if (_tbCountry.Text != "")
            {
                UpdateDefinition<Movie> update = Builders<Movie>.Update.Set("Country", _tbCountry.Text); ;
                collection.UpdateOne(filter, update);
            }
            if (_rtbSummary.Text != "")
            {
                UpdateDefinition<Movie> update = Builders<Movie>.Update.Set("Summary", _rtbSummary.Text); ;
                collection.UpdateOne(filter, update);
            }
            
            MessageBox.Show("Success!");
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
