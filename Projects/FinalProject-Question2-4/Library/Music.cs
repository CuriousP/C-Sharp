﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    class Music : Item, Iloanable, IDigital
    {
        private DigitalDisc.DiscType mediaType;

        public DigitalDisc.DiscType MediaType
        {
            get { return mediaType; }
            set { mediaType = value; }
        }
        private uint lengthSeconds;

        public uint LengthInSeconds
        {
            get { return lengthSeconds; }
            set { lengthSeconds = value; }
        }

        public Music()
            : base()
        {
            lengthSeconds = 0;
            mediaType = DigitalDisc.DiscType.CD;
            isAvailable = false;
            isOnHold = false;
        }

        public Music(ushort myYear, string myTitle, DigitalDisc.DiscType disc, uint sec)
            : base(myTitle, myYear)
        {
            mediaType = disc;
            lengthSeconds = sec;

            isAvailable = true;
            isOnHold = false;
        }


        #region Iloanable Members

        public User currentUser { get; set; }

        public DateTime checkOutTime { get; set; }

        public DateTime checkInTime { get; set; }

        public bool isAvailable { get; set; }

        public bool isOnHold { get; set; }

        public void issue(User u)
        {
            if (isAvailable)
            {
                currentUser = u;
                checkOutTime = DateTime.Now;
                checkInTime = DateTime.MinValue;
                isAvailable = false;
                isOnHold = false;
                Console.WriteLine(title + " is issued to " + currentUser.UserName + " at " + checkOutTime);

            }
            else
            {
                Console.WriteLine(title + " is not available to check-out");
            }
        }

        public void returnIt()
        {
            if (!isAvailable)
            {
                checkInTime = DateTime.Now;
                Console.WriteLine(title + " is returned by " + currentUser.UserName + " at " + checkInTime);
                currentUser = null;
                isAvailable = true;
                isOnHold = false;
            }
            else
            {
                Console.WriteLine("This item is not checked-out yet");
            }
        }

        public void holdIt(User u)
        {
            if (isAvailable && !isOnHold)
            {
                currentUser = u;
                isAvailable = true;
                isOnHold = false;
                checkOutTime = DateTime.Now;
                Console.WriteLine(title + " is on hold for " + currentUser.UserName + " at " + checkOutTime);
            }
            else
            {
                Console.WriteLine("This item can not be put on hold");
            }
        }

        public void removeHolds()
        {
            if (!isAvailable && isOnHold)
            {
                currentUser = null;
                isAvailable = true;
                isOnHold = false;
                checkOutTime = DateTime.MaxValue;
                Console.WriteLine("Hold is removed");
            }
            else
            {
                Console.WriteLine("This item is not on hold");
            }
        }

        #endregion

        #region IDigital members        
        public string getHMS()
        {
            uint sec = this.LengthInSeconds;
            uint hr = sec / 3600;
            sec = sec % 3600;
            uint min = sec / 60;
            sec = sec % 60;

            return "The duration of '" + this.title + "' is " + hr + ":" + min + ":" + sec;
        }
        #endregion

        public override string ToTextFormat()
        {
            string text = "Type: Music Year: " + this.Year + " Title: " + this.title + " DiscType: " + this.MediaType + " Seconds: " + this.LengthInSeconds;

            return text;
        }
    }
}
