using System;

namespace ödev
{


    class SifreOlustur
    {
        private string kullaniciadi1;
        private string kullaniciadi2;
        private string kullaniciadi3;
        private string kullaniciadi4;
        private string kullaniciadi5;

        private string[] OlusanSifre1 = new string[8];
        private string[] OlusanSifre2 = new string[8];
        private string[] OlusanSifre3 = new string[8];
        private string[] OlusanSifre4 = new string[8];
        private string[] OlusanSifre5 = new string[8];
        public SifreOlustur()
        {
            Random rnd = new Random();
            string[] OlusanSifre = new string[8];
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    char[] cr = "0123456789abcdefghıijklmnopqrstuvwxyzABCDEFGHIİJKLMNOPQRSTUVWXYZ".ToCharArray();
                    int randomeleman = rnd.Next(0, cr.Length);
                    OlusanSifre[i] = cr[randomeleman].ToString();
                }
                if (j == 0)
                    for (int i = 0; i < 8; i++)
                        OlusanSifre1[i] = OlusanSifre[i];
                else if (j == 1)
                    for (int i = 0; i < 8; i++)
                        OlusanSifre2[i] = OlusanSifre[i];
                else if (j == 2)
                    for (int i = 0; i < 8; i++)
                        OlusanSifre3[i] = OlusanSifre[i];
                else if (j == 3)
                    for (int i = 0; i < 8; i++)
                        OlusanSifre4[i] = OlusanSifre[i];
                else if (j == 4)
                    for (int i = 0; i < 8; i++)
                        OlusanSifre5[i] = OlusanSifre[i];
                Array.Clear(OlusanSifre, 0, 8);
            }
        }
        public void Kullaniciadi(string Kad1, string Kad2, string Kad3, string Kad4, string Kad5)
        {
            kullaniciadi1 = Kad1;
            kullaniciadi2 = Kad2;
            kullaniciadi3 = Kad3;
            kullaniciadi4 = Kad4;
            kullaniciadi5 = Kad5;
        }
        public void Bilgi()
        {
            Console.Write("Kullanıcı Adı1 :{0}", kullaniciadi1);
            Console.Write("\t" + "Şifre1 :");
            for (int i = 0; i < 8; i++)
                Console.Write(OlusanSifre1[i]);
            Console.Write("\n" + "Kullanıcı Adı2 :{0}", kullaniciadi2);
            Console.Write("\t" + "Şifre2 :");
            for (int i = 0; i < 8; i++)
                Console.Write(OlusanSifre2[i]);
            Console.Write("\n" + "Kullanıcı Adı3 :{0}", kullaniciadi3);
            Console.Write("\t" + "Şifre3 :");
            for (int i = 0; i < 8; i++)
                Console.Write(OlusanSifre3[i]);
            Console.Write("\n" + "Kullanıcı Adı4 :{0}", kullaniciadi4);
            Console.Write("\t" + "Şifre4 :");
            for (int i = 0; i < 8; i++)
                Console.Write(OlusanSifre4[i]);
            Console.Write("\n" + "Kullanıcı Adı5 :{0}", kullaniciadi5);
            Console.Write("\t" + "Şifre5 :");
            for (int i = 0; i < 8; i++)
                Console.Write(OlusanSifre5[i]);

        }
    }


    internal class Program
        {
            static void Main(string[] args)
            {
                string[] kullaniciadidizi = new string[5];
                Console.WriteLine("Kullanıcı Adınızı Girin Şifre Oluşturalım...");
                string Kullaniciadi;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine((i + 1) + ".ci kullanıcı adını giriniz.");
                    Kullaniciadi = Console.ReadLine();
                    kullaniciadidizi[i] = Kullaniciadi;
                }
                SifreOlustur erisim = new SifreOlustur();
                erisim.Kullaniciadi(kullaniciadidizi[0], kullaniciadidizi[1], kullaniciadidizi[2], kullaniciadidizi[3], kullaniciadidizi[4]);
                Console.WriteLine("Kullanıcı Adları ve Şifreler");
                Console.WriteLine("-----------------------------------------------------");
                erisim.Bilgi();
                Console.ReadKey();
            }
        }
    }

