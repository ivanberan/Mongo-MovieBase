using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace IvanovMovieDataBase
{
    public class Movie
    {
        [BsonId]
        public ObjectId _MovieID { get; set; }
        private string _Title;
        private string _Genre;
        private string _ReleaseDate;
        private string _Summary;
        private string _Country;
        private string _Director;
        public string Title { get => _Title; set => _Title = value; }
        public string Director { get => _Director; set => _Director = value; }
        public string Genre { get => _Genre; set => _Genre = value; }
        public string ReleaseDate { get => _ReleaseDate; set => _ReleaseDate = value; }
        public string Country { get => _Country; set => _Country = value; }
        public string Summary { get => _Summary; set => _Summary = value; }



    }
}
