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
                    EndDate = "13/13/2323",
                    Message = "yok",
                    Dosage1 = 1,
                    Dosage2 = 2.5F,
                    Period1 = 1,
                    Period2 = PeriodTypes.Gunde,
                    Quantity = 1
                },
                new Drug {
                    Barcodes = new List<string> {
                        "123412341"
                    }
                }
            };
            helper.Send(prescription);
        }
    }

    public class JsonSerializer : IJsonSerializer {
        public string ToJson(object o) {
            return JsonConvert.SerializeObject(o);
        }
    }

}