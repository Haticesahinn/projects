using System;

namespace KartOyunu
{
    class Program
    {
        static string[] P1 = new string[6];
        static string[] P2 = new string[6];
        static string[] P3 = new string[6];
        static Random rstgl = new Random();
        static string gecicikartsonhamle;
        static int say = 0;
        static string[] cards = { "Renk", "Renk", "Renk", "K1", "K2", "K3", "K4", "K5", "S1", "S2", "S3", "S4", "S5", "M1", "M2", "M3", "M4", "M5" };

        static bool gecerliHamlemi(string card, string sonhamle)
        {
            if (sonhamle == "BB"&&card=="Renk")
            {
                Console.WriteLine("İlk tur özel kart oynayamazsınız.");
                return false;
            }
            else if (sonhamle == "BB")
            {
                return true;
            }
            else if (sonhamle[0] == card[0])
            {
                return true;
            }
            else if (sonhamle[1] == card[1])
            {
                return true;
            }
            else if (card == "Renk")
            {
                return true;
            }
            else if (card == "pas")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string P2HamleYap(string sonhamle)
        {
            string card;
            switch (sonhamle[1])
            {
                case '1':
                    for (int i = 0; i < P2.Length; i++)
                    {
                        if (P2[i][1] == '1')
                        {
                            card = P2[i];
                            P2[i] = "BOS";
                            return card;
                        }
                    }
                    break;
                case '2':
                    for (int i = 0; i < P2.Length; i++)
                    {
                        if (P2[i][1] == '2')
                        {
                            card = P2[i];
                            P2[i] = "BOS";
                            return card;
                        }
                    }
                    break;
                case '3':
                    for (int i = 0; i < P2.Length; i++)
                    {
                        if (P2[i][1] == '3')
                        {
                            card = P2[i];
                            P2[i] = "BOS";
                            return card;
                        }
                    }
                    break;
                case '4':
                    for (int i = 0; i < P2.Length; i++)
                    {
                        if (P2[i][1] == '4')
                        {
                            card = P2[i];
                            P2[i] = "BOS";
                            return card;
                        }
                    }
                    break;
                case '5':
                    for (int i = 0; i < P2.Length; i++)
                    {
                        if (P2[i][1] == '5')
                        {
                            card = P2[i];
                            P2[i] = "BOS";
                            return card;
                        }
                    }
                    break;
               
            }
            switch (sonhamle[0])
            {
                case 'S':
                    for (int i = 0; i < P2.Length; i++)
                    {
                        if (P2[i][0] == 'S')
                        {
                            card = P2[i];
                            P2[i] = "BOS";
                            return card;
                        }
                    }
                    break;
                case 'K':
                    for (int i = 0; i < P2.Length; i++)
                    {
                        if (P2[i][0] == 'K')
                        {
                            card = P2[i];
                            P2[i] = "BOS";
                            return card;
                        }
                    }
                    break;
                case 'M':
                    for (int i = 0; i < P2.Length; i++)
                    {
                        if (P2[i][0] == 'M')
                        {
                            card = P2[i];
                            P2[i] = "BOS";
                            return card;
                        }
                    }
                    break;
            }
            if (sonhamle == "BB")
            {
                for (int i = 0; i < P2.Length; i++)
                {
                    if (P2[i] != "Renk")
                    {
                        card = P2[i];
                        P2[i] = "BOS";
                        return card;
                    }
                }
            }
            for (int i = 0; i < P2.Length; i++)
            {
                if (P2[i] == "Renk")
                {
                    Console.WriteLine("Oyuncu 2 Renk Değiştirdi..");
                     card = (RenkSecimi(P2)) + sonhamle[1].ToString();
                    P2[i] = "BOS";
                    return card;
                }
            }
            return "pas";

        }
        static string P3HamleYap(string sonhamle)
        {
            string card;
            switch (sonhamle[1])
            {
                case '1':
                    for (int i = 0; i < P3.Length; i++)
                    {
                        if (P3[i][1] == '1')
                        {
                            card = P3[i];
                            P3[i] = "BOS";
                            return card;
                        }
                    }
                    break;
                case '2':
                    for (int i = 0; i < P3.Length; i++)
                    {
                        if (P3[i][1] == '2')
                        {
                            card = P3[i];
                            P3[i] = "BOS";
                            return card;
                        }
                    }
                    break;
                case '3':
                    for (int i = 0; i < P3.Length; i++)
                    {
                        if (P3[i][1] == '3')
                        {
                            card = P3[i];
                            P3[i] = "BOS";
                            return card;
                        }
                    }
                    break;
                case '4':
                    for (int i = 0; i < P3.Length; i++)
                    {
                        if (P3[i][1] == '4')
                        {
                            card = P3[i];
                            P3[i] = "BOS";
                            return card;
                        }
                    }
                    break;
                case '5':
                    for (int i = 0; i < P3.Length; i++)
                    {
                        if (P3[i][1] == '5')
                        {
                            card = P3[i];
                            P3[i] = "BOS";
                            return card;
                        }
                    }
                    break;
            }
            switch (sonhamle[0])
            {
                case 'K':
                    for (int i = 0; i < P3.Length; i++)
                    {
                        if (P3[i][0] == 'K')
                        {
                            card = P3[i];
                            P3[i] = "BOS";
                            return card;
                        }
                    }
                    break;
                case 'S':
                    for (int i = 0; i < P3.Length; i++)
                    {
                        if (P3[i][0] == 'S')
                        {
                            card = P3[i];
                            P3[i] = "BOS";
                            return card;
                        }
                    }
                    break;
                case 'M':
                    for (int i = 0; i < P3.Length; i++)
                    {
                        if (P3[i][0] == 'M')
                        {
                            card = P3[i];
                            P3[i] = "BOS";
                            return card;
                        }
                    }
                    break;
            }
             if(sonhamle=="BB")
            {
                for (int i = 0; i < P3.Length; i++)
                {
                    if (P3[i]!="Renk")
                    {
                        card = P3[i];
                        P3[i] = "BOS";
                        return card;
                    }
                }
            }
            for (int i = 0; i < P3.Length; i++)
            {
                if (P3[i] == "Renk")
                {
                    Console.WriteLine("Oyuncu 3 Renk Değiştirdi.");
                     card = (RenkSecimi(P3)) + sonhamle[1].ToString();
                    P3[i] = "BOS";
                    return card;
                }
            }
            return "pas";
        }
       
        static void KartlariGoster(string[] el)
        {
            for (int i = 0; i < el.Length; i++)
            {
                Console.Write(el[i] + " | ");
            }
            Console.WriteLine();
        }
        static string RenkSecimi(string[] el)
        {
            int sari = 0, kirmizi = 0, mavi = 0;
            for (int i = 0; i < el.Length; i++)
            {
                switch (el[i][0])
                {
                    case 'K':
                        kirmizi++;
                        break;
                    case 'M':
                        mavi++;
                        break;
                    case 'S':
                        sari++;
                        break;
                }
            }
            if (mavi >= sari && mavi >= kirmizi)
            {
                return "M";
            }
            else if (kirmizi >= mavi && kirmizi >= sari)
            {
                return "K";
            }
            else return "S";
        }
        static bool DevamEdiyormu(string sonhamle)
        {
            if (gecicikartsonhamle == sonhamle)
            {
                say++;
            }
            else
            {
                say = 0;
            }
            gecicikartsonhamle = sonhamle;
            if (say == 3)
            {
                Console.WriteLine("3 el boyunca kart değişmedi ve oyun bitti.");
                return true;
            }
            if (KartKaldimi(P1))
            {
                Console.WriteLine("Oyuncu 1'in kartları bitti ve oyunu kazandı!");
                return true;
            }
            if (KartKaldimi(P2))
            {
                Console.WriteLine("Oyuncu 2'nin kartları bitti ve oyunu kazandı!");
                return true;
            }
            if (KartKaldimi(P3))
            {
                Console.WriteLine("Oyuncu 3'ün kartları bitti ve oyunu kazandı!");
                return true;
            }
            return false;
        }
        static bool KartKaldimi(string[] el)
        {
            bool bittimi = true;
            for (int i = 0; i < el.Length; i++)
            {
                if (el[i] != "BOS")
                {
                    bittimi = false;
                }
            }
            return bittimi;
        }
        static void HamleYap(string card)
        {
            for (int i = 0; i < P1.Length; i++)
            {
                if (card == P1[i])
                {
                    P1[i] = "BOS";
                    break;
                }
            }
        }
        static bool KartVarmi(string card)
        {
            bool varmi = false;
            for (int i = 0; i < P1.Length; i++)
            {
                if (card == P1[i])
                {
                    varmi = true;
                }
            }
            return varmi;
        }
        static void Main(string[] args)
        {
            int rastgele;
            bool[] kontrol = new bool[18];
            for (int i = 0; i < kontrol.Length; i++)
            {
                kontrol[i] = false;
            }
            for (int i = 0; i < P3.Length; i++)
            {
                do
                {
                    rastgele = rstgl.Next(0, 18);

                } while (kontrol[rastgele]);
                P3[i] = cards[rastgele];
                kontrol[rastgele] = true;
            }
            for (int i = 0; i < P2.Length; i++)
            {
                do
                {
                    rastgele = rstgl.Next(0, 18);

                } while (kontrol[rastgele]);
                P2[i] = cards[rastgele];
                kontrol[rastgele] = true;
            }
            for (int i = 0; i < P1.Length; i++)
            {
                do
                {
                    rastgele = rstgl.Next(0, 18);

                } while (kontrol[rastgele]);
                P1[i] = cards[rastgele];
                kontrol[rastgele] = true;
            }
            string sonhamle = "BB";
            string gecicikart = sonhamle;
            Console.WriteLine("Yer: {0}", sonhamle);
            int sira = new Random().Next(1, 4);
            while (true)
            {
                if (sira==1)
                {
                    do
                    {
                        do
                        {
                            KartlariGoster(P1);
                            Console.WriteLine("Bir Hamle Yapın: ");
                            gecicikart = Console.ReadLine();
                            if (gecicikart == "pas" && sonhamle == "BB")
                            {
                                Console.WriteLine("İlk tur bir kart oynamalısınız.");
                            }
                            else if (gecicikart == "pas") break;
                            if (!KartVarmi(gecicikart))
                            {
                                Console.WriteLine("Geçersiz hamle! Yerdeki karta göre oynamalısınız. Yer: {0}", sonhamle);
                            }
                        } while (!KartVarmi(gecicikart));

                    } while ((!gecerliHamlemi(gecicikart, sonhamle)));
                    if (gecicikart == "Renk")
                    {
                        string renk;
                        do
                        {
                            Console.Write("S -  K  -  M:");
                            renk = Console.ReadLine();
                            if (renk == "S")
                            {
                                break;
                            }
                            else if (renk == "K")
                            {
                                break;
                            }
                            else if (renk == "M")
                            {
                                break;
                            }
                        } while (true);
                        HamleYap("Renk");
                        sonhamle = renk + sonhamle[1];
                        Console.WriteLine("Hamleniz :{0}", sonhamle);
                    }
                    else if (gecicikart != "pas")
                    {
                        HamleYap(gecicikart);
                        sonhamle = gecicikart;
                        Console.WriteLine("Hamleniz :{0}", sonhamle);
                    }
                    else Console.WriteLine("pas dediniz.");
                    if (DevamEdiyormu(sonhamle))
                        break;
                }
                if (sira==2)
                {
                    gecicikart = P2HamleYap(sonhamle);
                    if (gecicikart != "pas")
                    {
                        sonhamle = gecicikart;
                        Console.WriteLine("Oyuncu 2'nin attığı Kart: {0}", sonhamle);
                    }
                    else Console.WriteLine("Oyuncu 2 pas dedi.");
                    if (DevamEdiyormu(sonhamle))
                        break;
                };
                if (sira==3)
                {
                    gecicikart = P3HamleYap(sonhamle);
                    if (gecicikart != "pas")
                    {
                        sonhamle = gecicikart;
                        Console.WriteLine("Oyuncu 3'ün attığı Kart: {0}", sonhamle);
                    }
                    else Console.WriteLine("Oyuncu 3 pas dedi.");
                    if (DevamEdiyormu(sonhamle))
                        break;
                }
                sira++;
                if (sira>3)
                {
                    sira = 1;
                }
            }
            Console.ReadKey();
        }
    }
}
