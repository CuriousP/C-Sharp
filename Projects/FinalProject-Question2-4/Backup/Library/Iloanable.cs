using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    interface Iloanable
    {
        User currentUser { get; set; }
        DateTime checkOutTime { get; set; }
        DateTime checkInTime { get; set; }
        bool isAvailable { get; set; }
        bool isOnHold { get; set; }

        void issue(User u);
        void returnIt();
        void holdIt(User u);
        void removeHolds();

    }
}
