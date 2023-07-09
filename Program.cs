using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace NguyenThiMyPhuong__BTL3
{
    class Program
    {
        static void Main(string[] args)
        {
           
                // Khai bao va nhap n:
                int n = 0;
                Console.Write("Nhap so luong phan tu: ");
                int.TryParse(Console.ReadLine(), out n);
                //Khai bao va cap phat danh sach:
                LinkedList l = new LinkedList();
             
                //Cau 1
                NhapDS(l, n);
                //Cau2
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Xuat danh sach tai khoan vua nhap: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                XuatDS(l);

                // Cau 3
                LKTKhoan(l, "TKSDToiDaTB.txt");
            ////Cau 4:
            LietKetkhh(l,"TKSDHetHan.txt");
                // Cau 5
                Console.Write("Nhap so dien thoai can xoa x = ");
                string x = Console.ReadLine();
                Node pI = l.Find(x);
                l.RemoveAt(pI);
                Console.WriteLine("Danh sach tai khoan sau khi xoa");
                XuatDS(l);
                //cau 6
                Console.Write("Nhap so dien thoai can cap nhat: ");
                string y = Console.ReadLine();
                Node q = l.Find(y);
                if (q != null)
                {
                    Console.WriteLine($"So thiet bi dang su dung la: {q.Data.SoLuong}");
                    Console.Write("Nhap them so luong thiet bi: ");
                    int.TryParse(Console.ReadLine(), out pI.Data.SoLuong);
                    Console.WriteLine("Danh sach tai khoan sau khi cap nhat so luong:");
                    XuatDS(l);
                }
                Console.WriteLine("Xuat danh sach sau khi cap nhat tinh trang: ");
                XuatDS(l);

            //Cau 7
            Console.ForegroundColor = ConsoleColor.Blue;
                l.InterchangeSort();
                Console.WriteLine("Danh sach sau khi sap xep theo ho ten: ");
                XuatDS(l);
                Console.ReadKey();
            }

            /// <summary>
            /// Liet ke cac tai khoan su dung toi da 2 thiet bi:
            /// </summary>
            /// <param name="l"></param>
            /// <param name="path"></param>
            static void LKTKhoan(LinkedList l, string path)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        for (Node p = l.First; p != null; p = p.Next)
                        {
                            if (p.Data.SoLuong == 2)
                            {
                                sw.WriteLine("---------------------------------------------------------------");
                                sw.WriteLine($"{"\t-HoTen:",-18}{p.Data.HoTen}");
                                sw.WriteLine($"{"\t-SoDT:",-18}{p.Data.SoDT}");
                                sw.WriteLine($"{"\t-DiaChi:",-18}{p.Data.DiaChi}");
                                sw.WriteLine($"{"\t-MaKH:",-18}{p.Data.MaKH}");
                                sw.WriteLine($"{"\t-NgayKichHoat:",-18}{p.Data.NgayKH.ToString("dd/MM/yyyy")}");
                                sw.WriteLine($"{"\t-SoLuong:",-18}{p.Data.SoLuong}");
                                if (p.Data.SoLuong == 2)
                                {
                                    sw.WriteLine($"{"\t\t-ID Thiet Bi 1:",-18}{p.Data.TB[0].ID}");
                                    sw.WriteLine($"{"\t\t-Ten Thiet Bi 1:",-18}{p.Data.TB[1].TenTB}");
                                    sw.WriteLine($"{"\t\t-ID Thiet Bi 2:",-18}{p.Data.TB[0].ID}");
                                    sw.WriteLine($"{"\t\t-Ten Thiet Bi 2:",-18}{p.Data.TB[1].TenTB}");
                                }
                                sw.WriteLine("---------------------------------------------------------------");
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ghi file that bai!!!");
                    throw;
                }
            }
            //Ham liet ke tai khoan het han :
            static void LietKetkhh(LinkedList l, string path)
            {
                try
                {
                using (StreamWriter sw = new StreamWriter(path))
                {

                    Console.WriteLine("Nhung bien lai da het han la: ");
                    for (Node p = l.First; p != null; p = p.Next)
                    {
                        if (p.Data.NgayKH.AddMonths(12) < DateTime.Now)
                        {
                            p.Data
                            Console.WriteLine();

                        }
                    }
                }
                }
                
                catch (Exception)
                {
                    Console.WriteLine("Ghi file that bai!!!!!");
                    throw;
                }
            }
            //Ham xuat danh sach tai khoan:
            static void XuatDS(LinkedList l)
            {
                for (Node p = l.First; p != null; p = p.Next)
                {
                    Xuat(p.Data);
                }
            }
            //Ham xuat tai khoan:
            static void Xuat(KhachHang KH)
            {
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine($"{"MaKH:",-18}{KH.MaKH}");
                Console.WriteLine($"{"HoTen:",-18}{KH.HoTen}");
                Console.WriteLine($"{"SoDT:",-18}{KH.SoDT}");
                Console.WriteLine($"{"DiaChi:",-18}{KH.DiaChi}");
                Console.WriteLine($"{"SoLuong:",-18}{KH.SoLuong}");
                Console.WriteLine($"{"NgayKichHoat:",-18}{KH.NgayKH.ToString("dd/MM/yyyy")}");
                
                Console.WriteLine("---------------------------------------------------------------");

            }
            //Ham nhap danh sach lien ket:
            static void NhapDS(LinkedList l, int n)
            {
                for (int i = 1; i <= n; i++)
                {
                    l.AddLast(Nhap());
                }
            }
            /// <summary>
            /// Ham nhap tai khoan
            /// </summary>
            /// <returns></returns>    
            static KhachHang Nhap()
            {
                KhachHang tkhoan = new KhachHang();
                Console.Write("\t Nhap HoTen: ");
                tkhoan.HoTen = Console.ReadLine();
                Console.Write("\t Nhap Ma kich hoat: ");
                tkhoan.MaKH = Console.ReadLine();
                do
                {
                    Console.Write("\t Nhap SDT: ");
                    tkhoan.SoDT = Console.ReadLine();
                } while (tkhoan.SoDT.Length < 10 || tkhoan.SoDT.Length > 11);
                Console.Write("\t Nhap DiaChi: ");
                tkhoan.DiaChi = Console.ReadLine();
               
                Console.Write("\t Nhap ngay kich hoat: ");
                DateTime.TryParse(Console.ReadLine(), out tkhoan.NgayKH);
            int Sl;
            do
            {
                Console.Write("Nhap so luong thiet bi su dung (max=2):");
                Sl = int.Parse(Console.ReadLine());
                if (Sl>2)
                {
                    Console.WriteLine("So luong qua gioi han! Nhap lai:");
                }
            } while (Sl > 2);
            ThietBi[] temp = new ThietBi[Sl];
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write("Nhap ID:");
                string ID = Console.ReadLine();
                Console.Write("Nhap ten thiet bi:");
                string TenTB = Console.ReadLine();
                temp[i] = new ThietBi(ID, TenTB);
            }
                return tkhoan;
            }
        }
    }

