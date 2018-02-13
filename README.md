ilaçtarif®'e veri aktarımı
============================

Bu dökümantasyon ilaçtarif® uygulamasına nasıl veri aktarabileceğinizi
anlatır.

Veri aktarımı ilaçtarif® uygulamasına argüman göndererek gerçekleşir.

# 1. Veri aktarımı genel yapısı

    "C:\Program Files\ALTERNET\Medicine\Medicine.exe" api.prescription={json}  

### 1.1 Jsonda bulunabilecek bütün değerler

``` json
{
  "SenderApplication": "Veriyi gönderen uygulama",
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

### Örnek Json

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

#### NOT: Veri gönderme aşamasında bir ilacın oluşabilmesi için en az 1 barkod numarası göndermek zorunludur.

### Örnek Kullanım

```
"C:\Program Files\ALTERNET\Medicine\Medicine.exe" api.prescription= {"DoctorName":"","DoctorSurname":null,"Drugs":[{"Barcodes":["123412341"]},{"Barcodes":["123412395"]}]}
```

# 2. Property Listesi

-   **Name**: Hastanın Adı  
    ![text](./Documentation/Resources/patientname.png)  
-   **Surname** Hastanın Soyadı ![text](./Documentation/Resources/patientsurname.png)
-   **PrescriptionNo** Reçete Numarası  
    ![text](./Documentation/Resources/prescriptionno.png)  
-   **Tc** Hastanın Tc Numarası  
    ![text](./Documentation/Resources/patienttc.png)  
-   **DoctorName** Reçete üzerinde olan doktorun adı  
    ![Doktor Adı](./Documentation/Resources/doctorname.png)  
-   **DoctorSurname** Doktorun soyadı  
    ![Doktor Soyadı](./Documentation/Resources/doctorsurname.png)  

-   **Drugs**: İlaçların bilgileri
    -   **Barcodes** İlacın barkod listesi
    ![text](./Documentation/Resources/barcode_no.png)
    -   **Quantity**
    ![text](./Documentation/Resources/quantity.png)
    -   **Period1**
    ![text](./Documentation/Resources/period1.png)
    -   **Period2**
    ![text](./Documentation/Resources/period2.png)
    -   **Dosage1**
    ![text](./Documentation/Resources/dosage1.png)
    -   **Dosage2**
    ![text](./Documentation/Resources/dosage2.png)
    -   **Name**
    ![text](./Documentation/Resources/name.png)
    -   **Price**
    ![text](./Documentation/Resources/price.png)  
    -   **Difference**
    ![text](./Documentation/Resources/difference.png)  
    -   **Report**
    ![text](./Documentation/Resources/report.png)
    -   **EndDate**
    ![text](./Documentation/Resources/enddate.png)
    -   **Message**
    ![text](./Documentation/Resources/message.png)
-   **PrescriptionAmount**: Reçete Fiyat Bilgileri
    ----------------------------------------------

    -   **PrescriptionContribution\_Hand**
    ![text](./Documentation/Resources/PrescriptionContribution_Hand.png)
    -   **PrescriptionContribution\_Salary**
    ![text](./Documentation/Resources/PrescriptionContribution_Salary.png)
    -   **ExaminationContribution\_Hand**
    ![text](./Documentation/Resources/ExaminationContribution_Hand.png)
    -   **ExaminationContribution\_Salary**
    ![text](./Documentation/Resources/ExaminationContribution_Salary.png)
    -   **PharmacyDiscountAmount**
    ![text](./Documentation/Resources/PharmacyDiscountAmount.png)
    -   **DrugContribution**
    ![text](./Documentation/Resources/DrugContribution.png)
    -   **PriceDifference**
    ![text](./Documentation/Resources/PriceDifference.png)
    -   **Tax8**
    ![text](./Documentation/Resources/Tax8.png)
    -   **Tax18**
    ![text](./Documentation/Resources/Tax18.png)
    -   **TotalPrice**
    ![text](./Documentation/Resources/TotalPrice.png)
    -   **TotalAmountDueToPharmacy**
    ![text](./Documentation/Resources/TotalAmountDueToPharmacy.png)


# 3. `MedicineHelper` Sınıfı

`MedicineHelper` sınıfı ilaçtarif® uygulamasına reçete ve elden ilaç listesi aktarırken kullanılır.

## 3.1 `MedicineHelper` sınıfı ile reçete aktarımı

Demo uygulama ![Program.cs](/ConsoleApp1/Program.cs)

``` C#
Prescription prescription = new Prescription();
...
//Gerekli reçete bilgilerini doldurunuz.

IJsonSerializer serializer = new JsonSerializer();
MedicineHelper helper = new MedicineHelper(serializer);
helper.Send(prescription);
```

### Newtonsoft.Json ile JsonSerializer sınıfı örneği

https://github.com/erkantaylan/medicine.desktop.api/blob/e63420ef510637c4eefcf2ad52a8370fe6eed81e/ConsoleApp1/Program.cs#L32-L36


``` C#
public class JsonSerializer : IJsonSerializer {
    public string ToJson(object o) {
        return Newtonsoft.Json.JsonConvert.SerializeObject(o);
    }
}
````
