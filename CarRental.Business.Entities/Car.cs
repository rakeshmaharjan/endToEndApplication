using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Core.Common.Core;
using Core.Common.Contracts;


namespace CarRental.Business.Entities
{
    //rules of datacontract serializer is that if the class is decorated 
    //with datacontract serializer then any member to obtain for 
    //serialization must be decorated with datamember

    [DataContract]
    public class Car : EntityBase, IIdentifiableEntity
    {
        [DataMember]
        public int CarId { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Color { get; set; }

        [DataMember]
        public int Year { get; set; }

        [DataMember]
        public decimal RentalPrice { get; set; }

        [DataMember]
        public bool CurrentlyRented { get; set; }
 

        // IIdentifiableEntity Members
        public int EntityId
        { 
            get { return CarId; }
            set { CarId = value; } 
        }
    }
}
