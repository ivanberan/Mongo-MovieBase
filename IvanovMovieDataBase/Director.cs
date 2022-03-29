using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace IvanovMovieDataBase
{
    public class Director
    {
        [BsonId]
        public ObjectId _MovieID { get; set; }
        private string _Name;
        private string _Surname;
        private string _BirthDate;
        private string _Nationality;
        public string Name { get => _Name; set => _Name = value; }
        public string Surname { get => _Surname; set => _Surname = value; }
        public string BirthDate { get => _BirthDate; set => _BirthDate = value; }
        public string Nationality { get => _Nationality; set => _Nationality = value; }



    }
}
