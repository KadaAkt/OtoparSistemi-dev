using UnityEngine;

public class OtoparkSistemi : MonoBehaviour // Scripti tanımladım
{
    [SerializeField] private int kalinanSure; // Inspector üzerinden değeri değiştirebilmek için SerializedField kullandım

    void Start() // Oyunu başlattığımda tek seferlik çalışması için Start kullandım
    {

        switch (kalinanSure) // Kalınan süre değişkeninin farklı değerleri için çıktılar hazırladım
        {
            case 0: // 0 saat girildiğinde hata vermemesi için case 0 ekledim
            case 1:
                Debug.Log("Park Süresi: 1 Saat \n Ücret: 120 TL"); 
                break;

            case 2:
                Debug.Log("Park Süresi: 2 Saat \n Ücret: 200 TL");
                break;

            case 3:
                Debug.Log("Park Süresi: 3 Saat \n Ücret: 300 TL");
                break;

            case 4:
                Debug.Log("Park Süresi: 4 Saat \n Ücret: 400 TL");
                break;

            default: // Belirlediğim değerlerden farklı bir girdide nasıl tepki vereceğini ayarladım
                if (kalinanSure >= 5)
                {

                    Debug.Log("Park Süresi: 5 saat ve üzerinde \n Ücret: 550 TL");
                }
                else
                {
                    Debug.Log("Geçersiz değer girdiniz"); // Negatif sayılar için geçersiz değer olmasını sağladım
                }
                break;
        }       
    }
}
