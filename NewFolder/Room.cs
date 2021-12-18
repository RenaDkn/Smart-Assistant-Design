using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Smart_Assistant_Design.NewFolder
{

    public partial class Room : Form
    {
        public Roomclass r1 = new Roomclass();
        public Room(Roomclass room)
        {

            r1.image = room.image;
            r1.lights = room.lights;
            r1.room = room.room;
            InitializeComponent();


        }
        public void showroom()
        {


        }
    }
}
