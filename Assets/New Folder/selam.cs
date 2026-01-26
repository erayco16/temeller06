using UnityEngine;

public class selam : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] public int sayý1;
    

    void Start()
    {
        //print("bombaaaaaa");
        //deðiþken tanýmlama
        /*string ad = "Eray";
        string soyad = "SAN";

        Debug.Log("Sayýn : " + ad + " " + soyad);
        */
        //int yas = 24;
        //Debug.Log(yas);
        /*float ondalikliBir = 1 / 3f;
        Debug.Log("float hassasiyeti " + ondalikliBir);
        double ondalikliiki = 1 / 3d;
        print("double hassasiyet " + ondalikliiki);
        */
        //karakter tanýmlama
        //char cinsiyet = 'E';

        //print("Cinsiyetiniz : " + cinsiyet);
        //Boolean Tanýmlama     0,1   true,false
        /*bool isDeath;
        isDeath = true;
        print("karakter öldü mü " + isDeath);
        */
        //Aritmetik Operatörler +, -,/, *, %(mod alma)
        //hard code
        /*int say1= 16;
        int say2 = 12;
        int toplam = say1 + say2;
        print("sayýlarýn toplamý " + toplam);

        int fark= say1 - say2;
        print("sayýlarýn farký " + fark);

        int carpim = say1 * say2;
        print("sayýlarýn carpimlari " + carpim);

        int bölüm = say1 / say2;
        print("sayýlarýn bölümü " + bölüm);

        int kalan = say1 % say2;
        print("sayýlarýn kalan " + kalan);
        */
        /*int toplam = say1 + say2;
        print("Girdiginiz sayilarin toplami " + toplam);

        int fark = say1 - say2;
        print("Girdiginiz sayilarin farki " + fark);

        int carpim = say1 * say2;
        print("Girdiginiz sayilarin carpimi " + carpim);

        int bolum = say1 / say2;
        print("Girdiginiz sayilarin bölümü " + bolum);

        int kalan = say1 % say2;
        print("Girdiginiz sayilarin bölümünden kalan " + kalan);
        */
        /*int score = 10;
        score += 10;
        score -= 5;
        score *= 2;
        score /= 6;
        Debug.Log("Skorumuz : " + score);
        */
        /*int sayim1 = 15;
        int sayim2 = 25;
        print(sayim1 > sayim2);
        print(sayim1 != sayim2);
        print(sayim1 < sayim2);
        print(sayim1 == sayim2);
        */
        //float ondaliklisayi = 10 / 3f;
        //print(ondaliklisayi);
        //print((int)ondaliklisayi);

        //if else

        /*if (not<44)
        {
            print("1");
        }
        else if (not<54)
        {
            print("2");
        }
        else if (not<69)
        {
            print("3");
        }
        else if (not<84)
        {
            print("4");
        }
        else 
        {
            print("5");
        }
        */

        /*int ortalama=(not+not2+performans)/ 3;
        if (ortalama > 50)
        {
            print("Basarili");
        }
        else
        {
            print("Basarisiz");
        }
        */

        /*int ucgen = (aci1 + aci2 + aci3);
        if (ucgen==180)
        {
            print("Bu bir üçgendir");
        }
        else
        {
            print("Bu bir ücgen deðildir");
        }
        */

        /*int aradakitutar = kilo - 20;
        if (kilo<=20)
        {
            print("ücrete gerek yok");
        }
        */

        /*switch (secim)
        {
            case "+":
            sonuc= sayi1 + sayi2;
                print("sonuc" + sonuc);
                break;
            case "-":
                sonuc = sayi1 - sayi2;
                print("sonuc" + sonuc);
            case "/":
                sonuc = sayi1 / sayi2;
                print("sonuc" + sonuc);
                break;
            case "*":
                sonuc = sayi1 * sayi2;
                print("sonuc" + sonuc);
                break;
            default:

        }
        */
        /*int sonuc = 0;
        for (int sayý = sayi1; sayý1 <= sayý2; sayý1++)
        {
            sonuc = sonuc + sayý1;
        }
        print(sonuc);
        */

        /*for (int i=0;i<51;i++)
        {
            if (i % 5 == 0)
                print("bombaaaaaa");
            else
                print(i);
            
        }
        */
        /*int result = 1;
        int i = 1;
        while (i <= sayý1) ;
        {
            result *= i;
            i++;
        }
        print("sayýnýn faktöriyeli " + result);
        */

        /*string[] isimler = new string[11];

        isimler[0] = "osman gülec";
        isimler[1] = "selim";
        isimler[2] = "eray";
        isimler[3] = "ömer";
        isimler[4] = "burak";
        isimler[5] = "buse";
        isimler[6] = "görkem";
        isimler[7] = "umut";
        isimler[8] = "erkan";
        isimler[9] = "þimþek";
        isimler[10] = "osman arý";

        for (int i=0;1<isimler.Length;i++)
        {
            print(isimler[i]);
        }
        */

        /*List<string> isimler = new List<string>();
        isimler.Add("osman güleç");
        isimler.Add("selim");
        isimler.Add("eray");
        isimler.Add("ömer");
        isimler.Add("burak");
        isimler.Add("buse");
        isimler.Add("görkem");
        isimler.Add("umut");
        isimler.Add("erkan");
        isimler.Add("þimþek");
        isimler.Add("abdurrahman");
        isimler.Add("osman arý");
        foreach (string isim in isimler)
        {
            print(isim);
        }
        isimler.Insert(10, "Ali");
        foreach(string isim in isimler)
        {
            Debug.Log(isim);
        }
        if (isimler.Contains("Ali")) ;
        {

        }
        */
        /*for (int i = 0;i<10;i++)
        {
            Ilkfonksiyon();
        }
        */

        int toplam = stp(8, 9);
        print("sayýlarýn toplamý " + toplam);













    }


    int stp(int a,int b)
    {
        return a + b;
    }

    /*void sayýlarýntoplami(int a,int b)
    {
        print("sayýlarýntoplamý ": (a + b));
    }

    void Ilkfonksiyon()
    {
        print("merhabalar ben Ilkfonksiyondan geliyorum");
    }
    */

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("merhaba unitye hosgeldin");
    }
}
