﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FV10112018.Model
{
    class FVCatalog
    {
        private static FVCatalog _instance/* = new AparCatalogSingle()*/;

        public static FVCatalog Instance
        {
            //get
            //{
            //    if (_instance == null)
            //        _instance = new EventCatalogSingleton();
            //    return _instance;
            //}

            get { return _instance ?? (_instance = new FVCatalog()); }

        }

        public ObservableCollection<Apartment> Apartments { get; set; }
        public ObservableCollection<Apartment> CityApartments { get; set; }
        public ObservableCollection<Owner> Owners { get; set; }
        public ObservableCollection<FrCity> Cities { get; set; }
        public FrCity SelectedCity { get; set; }

        public void SetSelectedCity(FrCity selectedCity)
        {
            SelectedCity = selectedCity;
            FindApartmentsByCityName(SelectedCity.Name);
        }

        private FVCatalog()
        {
            Apartments = new ObservableCollection<Apartment>();
            CityApartments = new ObservableCollection<Apartment>();
            Owners = new ObservableCollection<Owner>();
            Cities = new ObservableCollection<FrCity>();
            //  LoadEventsAsync();
            LoadApartments();
            for (int i = 0; i < Apartments.Count; i++)
            {
                Owners.Add(Apartments[i].ApartmentOwner);
            }
            for (int i = 0; i < Apartments.Count; i++)
            {
                Cities.Add(Apartments[i].AparCity);

            }
        }

        public void LoadApartments()
        {
            Apartments.Add(new Apartment(1001, "street 1", 1, "3 star",
                                          new AparType(3, 3, 50, true, true, true, true, "very well located")));

            Apartments.Add(new Apartment(1002, "street 2", 1, "3 star",
                                         new AparType(3, 3, 50, true, true, true, true, "very well located")));

            Apartments.Add(new Apartment(1003, "street 2", 1, "3 star",
                                         new AparType(3, 3, 50, true, true, true, true, "very well located")));

            Apartments.Add(new Apartment(2001, "street 1", 1, "3 star",
                                         new AparType(3, 3, 50, true, true, true, true, "very well located")));

            Apartments.Add(new Apartment(2002, "street 2", 1, "3 star",
                                         new AparType(3, 3, 50, true, true, true, true, "very well located")));

            Apartments.Add(new Apartment(2003, "street 2", 1, "3 star",
                                        new AparType(3, 3, 50, true, true, true, true, "very well located")));

            Apartments.Add(new Apartment(3001, "street 1", 1, "3 star",
                                          new AparType(3, 3, 50, true, true, true, true, "very well located")));

            Apartments.Add(new Apartment(3002, "street 2", 1, "3 star",
                                         new FrCity { Name = "Marseille", ImageUrl = "../assets/Marsay.jpg" },
                                         new AparType(3, 3, 50, true, true, true, true, "very well located"),
                                         new Owner("id 1", "mmm", "123456")));
            Apartments.Add(new Apartment(3003, "street 2", 1, "3 star",
                                        new FrCity { Name = "Marseille", ImageUrl = "../assets/Marsay.jpg" },
                                        new AparType(3, 3, 50, true, true, true, true, "very well located"),
                                        new Owner("id 1", "ttt", "123456")));
            Apartments.Add(new Apartment(4001, "street 1", 1, "3 star",
                                         new FrCity { Name = "Montpellie", ImageUrl = "../assets/Nice.jpg" },
                                         new AparType(3, 3, 50, true, true, true, true, "very well located"),
                                         new Owner("id 1", "ggg", "123456")));
            Apartments.Add(new Apartment(4002, "street 2", 1, "3 star",
                                         new FrCity { Name = "Nice", ImageUrl = "../assets/Nice.jpg" },
                                         new AparType(3, 3, 50, true, true, true, true, "very well located"),
                                         new Owner("id 1", "sss", "123456")));
            Apartments.Add(new Apartment(4003, "street 2", 1, "3 star",
                                        new FrCity { Name = "Lion", ImageUrl = "../assets/Nice.jpg" },
                                        new AparType(3, 3, 50, true, true, true, true, "very well located"),
                                        new Owner("id 1", "xxx", "123456")));
        }

        public void LoadCities()
        {
            AddCity(new FrCity { Name = "Montpellie", ImageUrl = "../assets/Nice.jpg", Description=".............", LongDescription=".............................." });
            AddCity(new FrCity { Name = "Paris", ImageUrl = "../assets/paris.jpg", Description = "Paris, France's capital, is a major European city and a global center for art, fashion, gastronomy and culture.",
                LongDescription = "France's capital, is a major European city and a global center for art, fashion, gastronomy and culture. Its 19th-century cityscape is crisscrossed by wide boulevards and the River Seine. Beyond such landmarks as the Eiffel Tower and the 12th-century, Gothic Notre-Dame cathedral, the city is known for its cafe culture and designer boutiques along the Rue du Faubourg Saint-Honoré." });
            AddCity(new FrCity { Name = "Dingeo", ImageUrl = "../assets/Dingeo.jpg", Description = "The village of Dingé is a small french village located north west of France.",
                LongDescription = "The village of Dingé is a small french village located north west of France. The town of Dingé is located in the department of Ille-et-Vilaine of the french region Bretagne.	The town of Dingé is located in the township of Hédé part of the district of Rennes. The area code for Dingé is 35094 (also known as code INSEE), and the Dingé zip code is 35440. " });
            AddCity(new FrCity { Name = "Orange", ImageUrl = "../assets/Orange.jpg", Description = "*********************************" });
            AddCity(new FrCity { Name = "Nice", ImageUrl = "../assets/Nice.jpg", Description = "*************************************" });
            AddCity(new FrCity { Name = "Nice", ImageUrl = "../assets/Nice.jpg", Description = "*************************************" });
        }

        public void LoadOwners()
        {
            AddOwner(new Owner("id1801", "Hansen", "123456"));
            AddOwner(new Owner("id1802", "jacob", "123456"));
            AddOwner(new Owner("id1803", "poul", "123456"));
            AddOwner(new Owner("id1804", "Ib", "123456"));
            AddOwner(new Owner("id1805", "Ib", "123456"));

        }

        public void AddAparToCity(string cityName, Apartment apar)
        {
            for (int i = 0; i < Cities.Count; i++)
            {

                if (Cities[i].Name == cityName)
                    Cities[i].Apartments.Add(apar);
            }
        }

        public void AddTypeToApar(int aparId, Apartment apar)
        {

        }

        public void AddOwnerToApar(string ownerId, Apartment apar)
        {

        }

        public void AddCity(FrCity city)
        {
            Cities.Add(city);
        }

        public void AddOwner(Owner owner)
        {
            Owners.Add(owner);
        }

        public void FindApartmentsByCityName(string cityname)
        {
            CityApartments.Clear();
            for (int i = 0; i < Apartments.Count; i++)
            {

                if (Apartments[i].AparCity.Name == cityname)
                    CityApartments.Add(Apartments[i]);
            }
        }

        public void AddApartments(Apartment apr)
        {
            Apartments.Add(apr);
        }

        public void RemoveApartments(Apartment apr)
        {
            Apartments.Remove(apr);
        }

    }
}
