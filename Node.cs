using System;
using System.Collections.Generic;
using System.Text;

namespace NguyenThiMyPhuong__BTL3
{
    class Node
    {
        internal KhachHang Data;
        internal Node Next;

        public Node(KhachHang value)
        {
            Data = value;
            Next = null;
        }
    }
}
