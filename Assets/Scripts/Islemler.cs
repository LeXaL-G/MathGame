using System;
using UnityEngine;
using Random = System.Random;

public class Islemler : MonoBehaviour
{
    public UnityEngine.UI.Button kontrolEt,kapat;
    private Random random = new Random();
    private char[] islemler = {'+','-','x','/'};
    public UnityEngine.UI.Text sayi1,sayi2,islem,oyuncuCevap,cevapKontrol,puanText;
    public UnityEngine.UI.InputField sonucInput;
    private int index,puan=0;

    private void Start()
    {
        sayi1.text = random.Next(0,11).ToString();
        sayi2.text = random.Next(0, 11).ToString();
        index = random.Next(0, 4);
        islem.text = islemler[index].ToString() ;
    }

    public void Degerler()
    {
        sonucInput.enabled = true;
        kontrolEt.enabled = true;
        cevapKontrol.text = "Cevap";
        sonucInput.text = "";
        sayi1.text = random.Next(0, 11).ToString();
        sayi2.text = random.Next(1,11).ToString();
        index=random.Next(0, 4);
        islem.text = islemler[index].ToString();
    }
    public void Kontrol()
    {
        sonucInput.enabled = false;
        kontrolEt.enabled = false;
        int s1 = Convert.ToInt32(sayi1.text),s2 = Convert.ToInt32(sayi2.text);
        switch (islemler[index])
        {
            case '+':
                if (Convert.ToInt32(oyuncuCevap.text) == s1 + s2)
                {
                    cevapKontrol.text = "Doğru!";
                    puanText.text=(Convert.ToInt32(puanText.text) + 1).ToString();
                }
                else
                {
                    cevapKontrol.text = "Yanlış!" + "=" + " " + (s1 + s2);
                    puanText.text=(Convert.ToInt32(puanText.text) - 1).ToString();
                }
                break;
            case '-':
                if (Convert.ToInt32(oyuncuCevap.text) == s1 - s2)
                {
                    cevapKontrol.text = "Doğru!";
                    puanText.text=(Convert.ToInt32(puanText.text) + 1).ToString();
                }
                else
                {
                    cevapKontrol.text = "Yanlış!" + "=" + " " + (s1 - s2);
                    puanText.text=(Convert.ToInt32(puanText.text) - 1).ToString();
                }
                break;
            case 'x':
                if (Convert.ToInt32(oyuncuCevap.text) == s1 * s2)
                {
                    cevapKontrol.text = "Doğru!";
                    puanText.text=(Convert.ToInt32(puanText.text) + 1).ToString();
                }
                else
                {
                    cevapKontrol.text = "Yanlış!" + "=" + " " + (s1 * s2);
                    puanText.text=(Convert.ToInt32(puanText.text) - 1).ToString();
                }
                break;
            case '/':
                if (Convert.ToInt32(oyuncuCevap.text) == s1 / s2)
                {
                    cevapKontrol.text = "Doğru!";
                    puanText.text=(Convert.ToInt32(puanText.text) + 1).ToString();
                }
                else
                {
                    cevapKontrol.text = "Yanlış!" + "=" + " " + (s1 / s2);
                    puanText.text=(Convert.ToInt32(puanText.text) - 1).ToString();
                }
                break;
        }
    }

    public void oyunuKapat()
    {
        Application.Quit();
    }

}
   
