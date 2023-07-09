using System;
using System.Collections.Generic;
using System.Text;

namespace NguyenThiMyPhuong__BTL3
{
    class LinkedList
    {
        //Truong du lieu:
        private Node _first;
        private Node _last;
        private int _size;
        //Thuoc tinh:
        public Node First
        {
            get { return _first; }
        }
        public Node Last
        {
            get { return _last; }
        }
        public int Count
        {
            get { return _size; }
        }
        //Phuong thuc:
        // Ham khoi tao:
        public LinkedList()
        {
            _first = null;
            _last = null;
            _size = 0;
        }

        // Ham them cuoi danh sach:
        public void AddLast(KhachHang KH)
        {
            Node pNew = new Node(KH);
            if (_first == null)
            {
                _first = pNew;
                _last = pNew;
            }
            else
            {
                _last.Next = pNew;
                _last = pNew;
            }
            _size++;
        }

        //Ham xoa phan tu bat ky:
        public void RemoveAt(Node q)
        {
            if (q != null)
            {
                if (q == _first)
                {
                    _first = q.Next;
                    if (q == _last)
                    {
                        _last = null;
                    }
                }
                else
                {
                    for (Node p = _first; p != null; p = p.Next)
                    {
                        if (p.Next == q)
                        {
                            p.Next = q.Next;
                            if (q == _last)
                            {
                                _last = p;
                            }
                            break;
                        }
                    }
                }
                _size--;
            }
        }

        //Ham tim phan tu theo so dien thoai:
        public Node Find(string soDT)
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                if (p.Data.SoDT == soDT)
                {
                    return p;
                }
            }
            return null;
        }

        //Ham sap xep bien lai giam dan theo ho ten:
        public void InterchangeSort()
        {
            KhachHang temp;
            for (Node p = _first; p.Next != null; p = p.Next)
            {
                for (Node q = _first; q != null; q = q.Next)
                {
                    if (String.Compare(p.Data.HoTen, q.Data.HoTen) == 1)
                    {
                        temp = p.Data;
                        p.Data = q.Data;
                        q.Data = temp;
                    }
                }
            }
        }
    }
}
