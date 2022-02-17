using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Assistant_Design.smart_lights
{
    public class Roomclass
    {
        private String room;
        private String lights;
        private String image;
        public String GetRoom()
        {
            return room;
        }

        public void SetRoom(String room1)
        {
            room = room1;
        }
        public String GetLights()
        {
            return lights;
        }

        public void SetLights(String lights1)
        {
            lights = lights1;
        }
        public String GetImage()
        {
            return image;
        }

        public void SetImage(String image1)
        {
            image = image1;
        }
    }
}
