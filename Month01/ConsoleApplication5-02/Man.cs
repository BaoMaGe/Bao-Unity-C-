using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5_02
{
    class Man
    {
        private    string hit;
        private  float  hp;
        private  int htp;
        private  int http;
        static int a = 2;
        public Man()
        {
            Console.WriteLine("1");
        }
        public Man(string hit)
            : this()
        {
            hit = hit + "2";
        }
        public Man(string hit, float hp)
            : this(hit )
        {
            hp = hp + 3;
        }
        
        public Man(int htp)
            : this()
        {
            htp = htp + 8;
        }
        public Man(int htp,int http): this(a)
        {
            http = http + 8;
        }
        public   float  Hp
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
            }
        }
        public string  Hit
        {
            get
            {
                return hit;
            }
            set
            {
                string hit = value;
            }
        }
    }
}
