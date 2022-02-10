using Smart_Assistant_Design.general_usage;
using System;
using System.Collections;
using System.Collections.Generic;
using Smart_Assistant_Design.smart_broom.status;
using Smart_Assistant_Design.smart_broom.rooms;

namespace Smart_Assistant_Design.smart_broom
{

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
