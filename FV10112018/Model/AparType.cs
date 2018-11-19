using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FV10112018.Model
{
    public class AparType
    {
        public int StarNr { get; set; }
        public int RoomNr { get; set; }
        public int Size { get; set; }
        public bool Pool { get; set; }
        public bool Parking { get; set; }
        public bool Safe { get; set; }
        public bool Aircon { get; set; }
        public String Description { get; set; }

        public AparType()
        { }

        public AparType(int starNr, int roomNr, int size, bool pool, bool parking, bool safe, bool airCon, string descrip)
        {
            StarNr = starNr;
            RoomNr = roomNr;
            Size = size;
            Pool = pool;
            Parking = parking;
            Safe = safe;
            Aircon = airCon;
            Description = descrip;

        }

        public override string ToString()
        {
            return string.Format("StarNr: {0}, RoomNr: {1}, Size: {2}, Pool: {3}, Aircon: {4}, Description: {5}", StarNr, RoomNr, Size, Pool, Aircon, Description);
        }


    }
}
