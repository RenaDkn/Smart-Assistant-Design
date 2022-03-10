using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Assistant_Design.smart_shoe_rack
{
    public class Shoes
    {
        private String nickname;
        private String image;
        private String attributes;
        private String index;
        public String GetNickname()
        {
            return nickname;
        }

        public void SetNickname(String nickname1)
        {
            nickname = nickname1;
        }
        
        public String GetImage()
        {
            return image;
        }

        public void SetImage(String image1)
        {
            image = image1;
        }
        public String GetAttributes()
        {
            return attributes;
        }

        public void SetAttributes(String attributes1)
        {
            attributes = attributes1;
        }
        public String GetIndex()
        {
            return index;
        }

        public void SetIndex(String index1)
        {
            index = index1;
        }
    }
}
