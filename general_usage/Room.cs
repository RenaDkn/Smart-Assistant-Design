using System;
using System.Collections.Generic;
using System.Text;

/**
 *  Basic informations to constract and represent a room.
 */
namespace Smart_Assistant_Design.general_usage
{
    class Room
    {
        private String room_name;
        // TODO - Add more attributes to make more useful.

        public Room(String room_name)
        {
            this.room_name = room_name;
        }

        public String Room_name
        {
            get
            {
                return this.room_name;
            }
        }
    }
}
