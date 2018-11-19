using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FV10112018.Model
{
    public class Apartment
    {
        public int Id { get; set; }
        public string StreetName { get; set; }
        public int Number { get; set; }
        public string AparType { get; set; }
        public int RoomNr { get; set; }

        public FrCity AparCity { get; set; }
        public AparType ApartmentType { get; set; }
        public Owner ApartmentOwner { get; set; }


        // adding constructor

        public Apartment()
        {

        }

        public Apartment(int id, string streetName, int number, string aprType, FrCity city, AparType type, Owner owner)
        {
            Id = id;
            StreetName = streetName;
            Number = number;
            AparType = aprType;
            AparCity = city;
            ApartmentType = type;
            ApartmentOwner = owner;
        }

        public Apartment(int id, string streetName, int number, string aprType, AparType type)
        {
            Id = id;
            StreetName = streetName;
            Number = number;
            AparType = aprType;
           
            ApartmentType = type;
           
        }


        public override string ToString()
        {
            // return Id.ToString();
            return string.Format("Id: {0}, Adrress: {1} {2} {3} ", Id, StreetName, Number, AparType);
        }




        // Following part needs to be removed
        //public ObservableCollection<Apartment> AprByName(string cityName)
        //{
        //    ObservableCollection<Apartment> aprList = new ObservableCollection<Apartment>();
        //    string cityId = "";

        //    if (cityName == "paris")
        //        cityId = "1000";
        //    else if (cityName == "Marseille")
        //        cityId = "2000";
        //    else if (cityName == "Lion")
        //        cityId = "3000";
        //    else if (cityName == "Nice")
        //        cityId = "4000";



        //    for (int i = 0; i < Apartments().Length; i++)
        //    {
        //        //if (Apartments().GetValue(i).ToString() == cityId )
        //        //    aprList.Add((Apartment)Apartments().GetValue(i));
        //        Apartment myApartment = (Apartment)Apartments().GetValue(i);
        //        if (myApartment.Id == Convert.ToInt32(cityId))
        //            aprList.Add((Apartment)Apartments().GetValue(i));
        //    }

        //    return aprList;
        //}

        //public static Apartment[] Apartments()
        //{
        //    return new[]
        //    {
        //        new Apartment {StreetName = "ad1", AparType = "Apartment type 1", Id = 1000, RoomNr = 1, ApartmentType = new AparType{StarNr = 3, Description = "3 star apartment"},
        //            AparCity = new FrCity{Name = "Lion"}, ApartmentOwner = new Owner("1002","vvv hansen","123456") },
        //        new Apartment {StreetName = "ad2", AparType = "Apartment type 2", Id = 1000, RoomNr = 2, ApartmentType = new AparType{StarNr = 3, Description = "3 star apartment"},
        //            AparCity = new FrCity {Name = "Lion"}, ApartmentOwner = new Owner("1002","xxx hansen","123456") },
        //        new Apartment {StreetName = "ad3", AparType = "Apartment type 3", Id = 1000, RoomNr = 3, ApartmentType = new AparType{StarNr = 3, Description = "3 star apartment"},
        //            AparCity = new FrCity {Name = "Lion"}, ApartmentOwner = new Owner("1002","bbb hansen","123456")},
        //        new Apartment {StreetName = "ad4", AparType = "Apartment type 1", Id = 2000, RoomNr = 4, ApartmentType = new AparType{StarNr = 3, Description = "3 star apartment"}, AparCity = new FrCity {Name = "Paris"}, ApartmentOwner = new Owner("1002","fff hansen","123456")},
        //        new Apartment {StreetName = "ad5", AparType = "Apartment type 2", Id = 2000, RoomNr = 1, ApartmentType = new AparType{StarNr = 3, Description = "3 star apartment"}, AparCity = new FrCity {Name = "Paris"}, ApartmentOwner = new Owner("1002","hhhh hansen","123456")},
        //        new Apartment {StreetName = "ad6", AparType = "Apartment type 3", Id = 2000, RoomNr = 2, ApartmentType = new AparType{StarNr = 3, Description = "3 star apartment"}, AparCity = new FrCity {Name = "Paris"}, ApartmentOwner = new Owner("1002","hans hansen","123456")},
        //        new Apartment {StreetName = "ad7", AparType = "Apartment type 1", Id = 2002, RoomNr = 3, ApartmentType = new AparType{StarNr = 3, Description = "3 star apartment"}, AparCity = new FrCity {Name = "Nice"}, ApartmentOwner = new Owner("1002","wwww hansen","123456")},
        //        new Apartment {StreetName = "ad8", AparType = "Apartment type 2", Id = 2003, RoomNr = 4, ApartmentType = new AparType{StarNr = 3, Description = "3 star apartment"}, AparCity = new FrCity {Name = "Nice"}, ApartmentOwner = new Owner("1002","hhhh hansen","123456")},
        //        new Apartment {StreetName = "ad9", AparType = "Apartment type 3", Id = 2004, RoomNr = 1, ApartmentType = new AparType{StarNr = 3, Description = "3 star apartment"}, AparCity = new FrCity {Name = "Nice"}, ApartmentOwner = new Owner("1002","hans hansen","123456")},
        //        new Apartment {StreetName = "ad10", AparType = "Apartment type 1", Id = 3000, RoomNr = 2, ApartmentType = new AparType{StarNr = 3, Description = "3 star apartment"}, AparCity = new FrCity {Name = "Can"}, ApartmentOwner = new Owner("1002","hans hansen","123456")},
        //        new Apartment {StreetName = "ad11", AparType = "Apartment type 2", Id = 3001, RoomNr = 3, ApartmentType = new AparType{StarNr = 3, Description = "3 star apartment"}, AparCity = new FrCity {Name = "Can"}, ApartmentOwner = new Owner("1002","hans hansen","123456")},
        //        new Apartment {StreetName = "ad12", AparType = "Apartment type 3", Id = 3002, RoomNr = 4, ApartmentType = new AparType{StarNr = 3, Description = "3 star apartment"}, AparCity = new FrCity {Name = "Can"}, ApartmentOwner = new Owner("1002","hans hansen","123456")},
        //        new Apartment {StreetName = "ad13", AparType = "Apartment type 1", Id = 4000, RoomNr = 1, ApartmentType = new AparType{StarNr = 3, Description = "3 star apartment"}, AparCity = new FrCity {Name = "Toulos"}, ApartmentOwner = new Owner("1002","hans hansen","123456")},
        //        new Apartment {StreetName = "ad14", AparType = "Apartment type 2", Id = 4001, RoomNr = 2, ApartmentType = new AparType{StarNr = 3, Description = "3 star apartment"}, AparCity = new FrCity {Name = "Toulos"}, ApartmentOwner = new Owner("1002","hans hansen","123456")}
        //    };
        //}
    }
}

