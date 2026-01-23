using UnityEngine;

public class selam : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] public int not;
    void Start()
    {
        //print("bombaaaaaa");
        //değişken tanımlama
        /*string ad = "Eray";
        string soyad = "SAN";

        Debug.Log("Sayın : " + ad + " " + soyad);
        */
        //int yas = 24;
        //Debug.Log(yas);
        /*float ondalikliBir = 1 / 3f;
        Debug.Log("float hassasiyeti " + ondalikliBir);
        double ondalikliiki = 1 / 3d;
        print("double hassasiyet " + ondalikliiki);
        */
        //karakter tanımlama
        //char cinsiyet = 'E';

        //print("Cinsiyetiniz : " + cinsiyet);
        //Boolean Tanımlama     0,1   true,false
        /*bool isDeath;
        isDeath = true;
        print("karakter öldü mü " + isDeath);
        */
        //Aritmetik Operatörler +, -,/, *, %(mod alma)
        //hard code
        /*int say1= 16;
        int say2 = 12;
        int toplam = say1 + say2;
        print("sayıların toplamı " + toplam);

        int fark= say1 - say2;
        print("sayıların farkı " + fark);

        int carpim = say1 * say2;
        print("sayıların carpimlari " + carpim);

        int bölüm = say1 / say2;
        print("sayıların bölümü " + bölüm);

        int kalan = say1 % say2;
        print("sayıların kalan " + kalan);
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

        if (not<44)
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








    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("merhaba unitye hosgeldin");
    }
}
