using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace IvanovMovieDataBase
{
    public class MovieReview
    {
        [BsonId]
        public ObjectId _MovieID { get; set; }
        private string _Title;
        private string _Score;
        private string _Review;

        public string Title { get => _Title; set => _Title = value; }
        public string Score { get => _Score; set => _Score = value; }
        public string Review { get => _Review; set => _Review = value; }




    }
}
