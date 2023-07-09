using System;
using System.Collections.Generic;
using System.Text;

namespace NguyenThiMyPhuong__BTL3
{
    class ThietBi
    {
        //Truong du lieu
        private string iD;
        private string tenTB;
       
     

        public ThietBi()
            {
            }
        public ThietBi( string TenTB, string ID)
        {
            this.ID = ID;
            this.TenTB = TenTB;
       
        }

        public string ID { get => iD; set => iD = value; }
        public string TenTB { get => tenTB; set => tenTB = value; }
    }
}
