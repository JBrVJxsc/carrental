using System;
using CarRentalLibrary.Classes.Managers;

namespace CarRentalLibrary.Classes.Objects
{
    public class LendObject
    {
        public LendObject()
        {
            if (LendID == null || LendID == string.Empty)
            {
                LendID = GuidManager.GetNewGuid();
            }
        }

        public string LendID
        {
            get;
            set;
        }

        public string Lender
        {
            get;
            set;
        }

        public string PersonName
        {
            get;
            set;
        }

        public string PersonID
        {
            get;
            set;
        }

        public string PersonPhone
        {
            get;
            set;
        }

        public string CarNumber
        {
            get;
            set;
        }

        public DateTime LendDate
        {
            get;
            set;
        }

        public DateTime BackDate
        {
            get;
            set;
        }

        public bool IsBack
        {
            get;
            set;
        }
    }
}
