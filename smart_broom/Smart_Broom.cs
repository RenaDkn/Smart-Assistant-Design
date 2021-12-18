using Smart_Assistant_Design.general_usage;
using System;
using System.Collections;
using System.Collections.Generic;

using System.Text;

namespace Smart_Assistant_Design.smart_broom
{

    class Smart_Broom
    {
        private short     battery_precentage;
        private Boolean   is_on_base;
        private Boolean   is_cleaning;
        private Queue     rooms_to_clean;
        private Room      current_room;
        private short     room_progress;

        public Smart_Broom()
        {
            this.battery_precentage = 100;
            this.is_on_base = true;
            this.is_cleaning = false;
            this.rooms_to_clean = new Queue();
            this.current_room = null;
        }

        /**
         * Returns the battery precentage of the broom.
         */
        public short Batter_precentage
        {
            get
            {
                return this.battery_precentage;
            }
        }

        /**
         * Returns if the broom is currently in the base
         * or not.
         */
        public Boolean Is_on_base
        {
            get
            {
                return this.is_on_base;
            }
        }

        /**
         * Returns if the broom is currently cleaning
         * a room or not.
         */
        public Boolean Is_cleaning
        {
            get
            {
                return this.Is_cleaning;
            }
        }

        /**
         *  Current progress of the broom in the current room.
         *  The return value is a number 0 to 100.
         */
        // TODO - Make the neccesery thigs, to check and increase the progress.
        public short Room_progress
        {
            get
            {
                return this.Room_progress;
            }
        }

        /**
         * Adds a new room to the queue.
         */
        public void clean_room(Room room)
        {
            this.rooms_to_clean.Enqueue(room);
            if (this.current_room == null) this.current_room = room;
        }

        /**
         * Remove a room from the queue. Finished 
         * the cleaning on this room.
         */
        public void move_to_next_room()
        {
            this.rooms_to_clean.Dequeue();
            if (this.rooms_to_clean.Count != 0) 
                this.current_room = (Room) rooms_to_clean.Peek();
        }


    }
}
