using System;
using System.Collections.Generic;
using Medicine.Desktop.Api;
using Medicine.Desktop.Api.Models;
using Newtonsoft.Json;

namespace ConsoleApp1 {

    public static class Program {
        [STAThread]
        private static void Main() {
            IJsonSerializer serializer = new JsonSerializer();
            MedicineHelper helper = new MedicineHelper(serializer);
            Prescription prescription = new Prescription();
            prescription.DoctorName = "Doktor Ad";
            prescription.DoctorSurname = "Doctor Soyad";
            prescription.Name = "Hasta Ad";
            prescription.Surname = "Hasta Soyad";
            prescription.PrescriptionNo = "Recete No";
            prescription.Tc = "hasta tc";
            prescription.SenderApplication = "Demo Otomasyon Uygulamasi";
            prescription.Drugs = new List<Drug> {
                new Drug {
                    Barcodes = new List<string> {
                        "8699546031870"
                    },
                    Name = "ILAC ADI",
                    Report = "91.24",
                    Price = 15,
                    Difference = 0,
                    EndDate = "13/01/2018",
                    Message = "yok",
                    Dosage1 = 1,
                    Dosage2 = 1F,
                    Period1 = 1,
                    Period2 = PeriodTypes.Gunde,
                    Quantity = 10,
                },
                new Drug {
                    Barcodes = new List<string> {
                        "8699546032297"
                    },
                    Name = "ILAC ADI",
                    Report = "91.24",
                    Price = 15,
                    Difference = 0,
                    EndDate = "13/01/2018",
                    Message = "yok",
                    Dosage1 = 8,
                    Dosage2 = 0.5F,
                    Period1 = 6,
                    Period2 = PeriodTypes.Haftada,
                    Quantity = 3,
                },
            };
            //Örnek fiyat etiketi
            prescription.Amount = new PrescriptionAmount();
            prescription.Amount.DrugContribution = 2.1F;
            prescription.Amount.ExaminationContribution_Hand = 0;
            prescription.Amount.ExaminationContribution_Salary = 59;
            prescription.Amount.PrescriptionContribution_Hand = 0;
            prescription.Amount.PrescriptionContribution_Salary = 3;
            prescription.Amount.PharmacyDiscountAmount = 1.92F;
            prescription.Amount.PriceDifference = 0;
            prescription.Amount.Tax18 = 0;
            prescription.Amount.Tax8 = 0;
            prescription.Amount.TotalPrice = 40;
            prescription.Amount.TotalAmountDueToPharmacy = 10;
            prescription.Amount.RetirementStatus = true;

            helper.Send(prescription);
        }
    }

    public class JsonSerializer : IJsonSerializer {
        public string ToJson(object o) {
            return JsonConvert.SerializeObject(o);
        }
    }

}