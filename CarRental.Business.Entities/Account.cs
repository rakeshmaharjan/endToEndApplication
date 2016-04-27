using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Common.Core;
using Core.Common.Contracts;
using System.Runtime.Serialization;

namespace CarRental.Business.Entities
{
      [DataContract]
    public class Account : EntityBase, IIdentifiableEntity
    {
        [DataMember]
        public int AccountId { get; set; }

        [DataMember]
        public string LoginEmail { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string ZipCode { get; set; }

        [DataMember]
        public string CreditCard { get; set; }

        [DataMember]
        public string ExpDate { get; set; }

        #region IIdentifiableEntity members

        public int EntityId
        {
            get { return AccountId; }
            set { AccountId = value; }
        }

        #endregion
    }
}
