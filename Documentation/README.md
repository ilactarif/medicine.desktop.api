İLAÇ TARİF'e reçete aktarımı
============================

Bu dökümantasyon İlaç Tarif uygulamasına nasıl reçete aktarabileceğinizi
anlatır.

Reçete aktarımla İlaç Tarif uygulamasına argüman göndererek gerçekleşir.

İki farklı veri aktarımı mevcuttur:

# 1. Reçete aktarımı  

    "C:\Program Files\ALTERNET\Medicine\Medicine.exe" api.prescription={json}  

### 1.1 Jsonda (Reçetede) bulunabilecek bütün değerler

``` json
{
  "SenderApplication": "Reçeteyi gönderen uygulama",
  "DoctorName": "Doktor Ad",
  "DoctorSurname": "Doktor Soyad",
  "Drugs": [
    {
      "Barcodes": [
        "123412341",
        "123412342",
        "123412343"
      ],
      "Difference": 0.0,
      "Dosage1": 1,
      "Dosage2": 5.0,
      "EndDate": "21/02/2018",
      "Message": "1b.3d",
      "Name": "NEXIUM 40 MG.28 TABLET",
      "Period1": 1,
      "Period2": 3,
      "Price": 50.0,
      "Quantity": 1,
      "Report": "04.03"
    }
  ],
  "Name": "Hasta Adi",
  "PrescriptionNo": "1b2b3b4",
  "Surname": "Hasta Soyadi",
  "Tc": "12345678901"
}
```

Olmayan bilgileri `null`, `""` olarak gönderebilir veya o fieldi hiç jsona eklemeden de gönderebilirsiniz.

Örnek Json

``` json
{
  "DoctorName": "",
  "DoctorSurname": null,
  "Drugs": [
    {
      "Barcodes": [
        "123412341"
      ]
    },
    {
      "Barcodes": [
        "123412395"
      ]
    }
  ]
}
```


# 2. Property Listesi

-   **Name**: Hastanın Adı  
    ![text](./Resources/patientname.png)  
-   **Surname** Hastanın Soyadı ![text](./Resources/patientsurname.png)
-   **PrescriptionNo** Reçete Numarası  
    ![text](./Resources/prescriptionno.png)  
-   **Tc** Hastanın Tc Numarası  
    ![text](./Resources/patienttc.png)  
-   **DoctorName** Reçete üzerinde olan doktorun adı  
    ![Doktor Adı](./Resources/doctorname.png)  
-   **DoctorSurname** Doktorun soyadı  
    ![Doktor Soyadı](./Resources/doctorsurname.png)  

-   **Drugs**: İlaçların bilgileri
    -   **Barcodes** İlacın barkod listesi
    ![text](./Resources/barcode_no.png)
    -   **Quantity**
    ![text](./Resources/quantity.png)
    -   **Period1**
    ![text](./Resources/period1.png)
    -   **Period2**
    ![text](./Resources/period2.png)
    -   **Dosage1**
    ![text](./Resources/dosage1.png)
    -   **Dosage2**
    ![text](./Resources/dosage2.png)
    -   **Name**
    ![text](./Resources/name.png)
    -   **Price**
    ![text](./Resources/price.png)  
    -   **Difference**
    ![text](./Resources/difference.png)  
    -   **Report**
    ![text](./Resources/report.png)
    -   **EndDate**
    ![text](./Resources/enddate.png)
    -   **Message**
    ![text](./Resources/message.png)
-   **PrescriptionAmount**: Reçete Fiyat Bilgileri
    ----------------------------------------------

    -   **PrescriptionContribution\_Hand**
    ![text](./Resources/PrescriptionContribution_Hand.png)
    -   **PrescriptionContribution\_Salary**
    ![text](./Resources/PrescriptionContribution_Salary.png)
    -   **ExaminationContribution\_Hand**
    ![text](./Resources/ExaminationContribution_Hand.png)
    -   **ExaminationContribution\_Salary**
    ![text](./Resources/ExaminationContribution_Salary.png)
    -   **PharmacyDiscountAmount**
    ![text](./Resources/PharmacyDiscountAmount.png)
    -   **DrugContribution**
    ![text](./Resources/DrugContribution.png)
    -   **PriceDifference**
    ![text](./Resources/PriceDifference.png)
    -   **Tax8**
    ![text](./Resources/Tax8.png)
    -   **Tax18**
    ![text](./Resources/Tax18.png)
    -   **TotalPrice**
    ![text](./Resources/TotalPrice.png)
    -   **TotalAmountDueToPharmacy**
    ![text](./Resources/TotalAmountDueToPharmacy.png)


# 3. `MedicineHelper` Sınıfı

`MedicineHelper` sınıfı İlaç Tarif uygulamasına reçete ve elden ilaç listesi aktarırken kullanılır.

## 3.1 `MedicineHelper` sınıfı ile reçete aktarımı

``` C#
Prescription prescription = new Prescription();
...
//Gerekli reçete bilgilerini doldurunuz.

IJsonSerializer serializer = new JsonSerializer();
MedicineHelper helper = new MedicineHelper(jsonSerializer);
helper.Send(prescription);
```

### Newtonsoft.Json ile JsonSerializer sınıfı örneği

``` C#
public class JsonSerializer : IJsonSerializer {
    public string ToJson(object o) {
        return Newtonsoft.Json.JsonConvert.SerializeObject(o);
    }
}
````
