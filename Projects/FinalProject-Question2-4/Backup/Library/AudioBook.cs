using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    class AudioBook : Book
    {
        private DigitalDisc.DiscType mediaType;

        internal DigitalDisc.DiscType MediaType
        {
            get { return mediaType; }
            set { mediaType = value; }
        }
        private uint lengthSeconds;

        public uint LengthSeconds
        {
            get { return lengthSeconds; }
            set { lengthSeconds = value; }
        }

        public AudioBook()
            : base()
        {
            lengthSeconds = 0;
            mediaType = DigitalDisc.DiscType.CD;
        }

        public AudioBook(uint myISBN, ushort myYear, string myTitle, DigitalDisc.DiscType disc, uint sec)
            : base(myISBN, myYear, 0, myTitle)
        {
            mediaType = disc;
            lengthSeconds = sec;
        }
    }
}
