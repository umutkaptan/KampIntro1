using System;
using System.Collections.Generic;
using System.Text;

namespace _5.derssonudeneme
{
    class Kullanicibilgisi
    {
        string _Adi;
        public string Adi 
        {
            get { return "Bayan" +  _Adi; }           
            set { _Adi = value; }   
        }
        public long TcNo { get; set; }
        public int Yasi { get; set; }

    }
}
