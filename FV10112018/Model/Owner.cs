using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FV10112018.Model
{
   public class Owner
    {
        public string OwnerId { get; set; }
        public string Name { get; set; }
        public string PhoneNr { get; set; }

        // public List<Apartment> Apartments { get; set; }

        public Owner(string ownerId, string name, string phoneNr/*, Apartment apartment*/)
        {
            OwnerId = ownerId;
            Name = name;
            PhoneNr = phoneNr;
            // Apartments.Add(apartment);

        }

        //public static Owner[] owners()
        //{
        //    return new Owner[]
        //    {
        //        new Owner("1002", "Hans Hansen", "1234567", new Apartment(1,"street1",33,"3 star",new FrCity(),new AparType(3,3,60,true,true,true,true,"000000"), new Owner()  )), 
        //    };

        //}

        public override string ToString()
        {
            // return Id.ToString();
            return string.Format("Owner Id: {0}, Name: {1}, Phone {2} ", OwnerId, Name, PhoneNr);
        }
    }
}
