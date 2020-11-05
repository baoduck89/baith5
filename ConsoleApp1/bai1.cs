using System;

namespace ConsoleApp1
{
   
    class TienDien

    {
        private string chuho;
        private string diachi;
        private int SDTN, SDTT;
        public TienDien()
        {
            chuho = diachi = "";
            SDTT = SDTN;
        }
        public TienDien(string chuho, string diachi, int SDTT, int SDTN)
        {
            this.chuho = chuho;
            this.diachi = diachi;
            this.SDTN = SDTN;
            this.SDTT = SDTT;
        }
        public void nhap()
        {           
            Console.WriteLine("nhap ten chu ho");
            chuho = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("nhap dia chi");
            diachi = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("nhap so dien thang truoc");
            SDTT = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so dien thang nay");
            SDTN = int.Parse(Console.ReadLine());


        }
        public void Hien()
        {
            Console.WriteLine("thông tin hiển thị");
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", chuho, diachi, SDTN, SDTT);
            Console.WriteLine();
        }
        public int sodiendadung
        {
            get
            {
                return (SDTN - SDTT);

            }

        }
        public int tiendien()
        {
            return sodiendadung * 500;
        }

    }
    class TienDienMoi: TienDien
    {
        private int dinhmuc;
        public TienDienMoi() : base()
        {
            dinhmuc = 50;
        }
        public TienDienMoi(string tenchuho, string diachi, int SDTT, int SDTN, int dinhmuc) : base(tenchuho, diachi, SDTT, SDTN)
        {
            this.dinhmuc = dinhmuc;
        }
        public new void nhap()
        {
            base.nhap();
            Console.Write("Nhap he so dinh muc: ");
            dinhmuc = int.Parse(Console.ReadLine());

        }
        public new int tiendien()
        {
            if (sodiendadung < dinhmuc) return sodiendadung * 500;
            else return sodiendadung * 600;
        }
    }
    class Test1
    {
        static void Main1(string[] args)
        {
            TienDienMoi t = new TienDienMoi();
            t.nhap();
            t.Hien();
            Console.WriteLine("Tien dien phai tra:{0}", t.tiendien());
            Console.ReadKey();
        }
    }
}