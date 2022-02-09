using Smart_Assistant_Design.general_usage;
using System;
using System.Collections;
using System.Collections.Generic;

using System.Text;

namespace Smart_Assistant_Design.smart_broom
{
    enum Broom_Status
    {
        SLEEP,
        IN_PROCESS,
        CHARGING
    }

    enum Room_Status
    {
        IN_PROCESS,
        DONE,
        WAITING
    }

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

    class Smart_Broom
    {
        private Broom_Status status;
        private short presentage;
        private Queue<Room_To_Clean> rooms_to_clean;

        public Smart_Broom()
        {
            status = Broom_Status.SLEEP;
            presentage = 100;
            rooms_to_clean = new Queue<Room_To_Clean>();
        }

        public Broom_Status Status
        {
            get
            {
                return this.status;
            }
            set
            {
                this.status = value;
            }
        }

        public short Presentage
        {
            get
            {
                return this.presentage;
            }
            set 
            {
                this.presentage = value;
            }
        }

        public Queue<Room_To_Clean> get_rooms_to_clean()
        {
            return this.rooms_to_clean;
        }

        public void set_room_to_clean(Room_To_Clean room)
        {
            this.rooms_to_clean.Enqueue(room);
        }

    }
}
