using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FV10112018.Model
{
    public class FrCity
    {
        private string _name;

        private string _description;
        private string _imageUrl;
        private FrCity _franceCity;
        public string LongDescription { get; set; }
        public string BGColor { get; set; }
        //private enum FranceCities
        //{
        //    Paris,
        //    Marseille,
        //    Nice,
        //    Lion,
        //    Can,
        //    Toulos,
        //    Montpellie,
        //    Orange,
        //    Dinge
        //};

        public string ZipCode { get; set; }
        public List<Apartment> Apartments;



        //public FrCity FranceCity
        //{
        //    get
        //    {
        //        return Cities()[(int)FranceCities.Paris];
        //    }
        //}

        public string ImageUrl
        {
            get { return _imageUrl; }
            set { _imageUrl = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set { _name = value; }
        }

        public override string ToString()
        {
            return Name.ToString();
        }

        public FrCity()
        {
            // InternalCities= Cities();
        }
        //public static FrCity[] Cities()
        //{
        //    return new[]
        //    {
        //        new FrCity{Name = "Paris", BGColor = "Red", Description = "Capital of France",
        //                                                  LongDescription =  "mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm" +
        //                                                 "llllllllllllllllllllllllllllllllllllllllllllllll\nllllllllllllllllllllllllllllllllllllll" +
        //                                                 "mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmml",ImageUrl = "../assets/Paris.jpg", ZipCode = "1111"},
        //        new FrCity{Name = "Marseille", BGColor = "Green", Description = "port of France", ImageUrl = "../assets/marsay.jpg", ZipCode = "2222"},
        //        new FrCity{Name = "Nice", BGColor = "Yellow",Description = "Capital of France riveria", ImageUrl = "../assets/nice.jpg", ZipCode = "3333"},
        //         new FrCity{Name = "Lion", Description = "Capital of France", ImageUrl = "../assets/Paris.jpg", ZipCode = "4444"},
        //        new FrCity{Name = "Can", Description = "port of France", ImageUrl = "../assets/marsay.jpg", ZipCode = "5555"},
        //        new FrCity{Name = "Toulos", Description = "Capital of France riveria", ImageUrl = "../assets/nice.jpg", ZipCode = "6666"},
        //         new FrCity{Name = "Montpellie", Description = "Capital of France", ImageUrl = "../assets/Paris.jpg", ZipCode = "7777"},
        //        new FrCity{Name = "Orange", Description = "port of France", ImageUrl = "../assets/marsay.jpg", ZipCode = "8888"},
        //        new FrCity{Name = "Dinge", Description = "Capital of France riveria", ImageUrl = "../assets/nice.jpg", ZipCode = "9999"},
        //    };
        //}
    }
}
