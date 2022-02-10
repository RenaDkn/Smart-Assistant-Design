using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Assistant_Design.smart_broom.rooms
{

    class Room_To_Clean
    {
        private Room_Status room_status;
        private String room;

        public Room_To_Clean(Room_Status room_status, String room)
        {
            this.room_status = room_status;
            this.room = room;
        }

        public Room_Status Room_status
        {
            get
            {
                return this.room_status;
            }
        }

        public String Room
        {
            get
            {
                return this.room;
            }
        }
    }
}
