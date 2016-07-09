using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    class AudioBook : Book, IDigital
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

        public AudioBook()
            : base()
        {
            lengthSeconds = 0;
            mediaType = DigitalDisc.DiscType.CD;
            isAvailable = false;
            isOnHold = false;
        }

        public AudioBook(uint myISBN, ushort myYear, string myTitle, DigitalDisc.DiscType disc, uint sec)
            : base(myISBN, myYear, 0, myTitle)
        {
            mediaType = disc;
            lengthSeconds = sec;

            isAvailable = true;
            isOnHold = false;
        }

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
            string text = "Type: AudioBook Year: " + this.Year + " Title: " + this.title + " ISBN:" + this.ISBN + " DiscType: " + this.MediaType + " Seconds: " + this.LengthInSeconds;

            return text;
        }
    }
}
