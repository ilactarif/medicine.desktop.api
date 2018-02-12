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
            prescription.DoctorName = "Bora";
            prescription.Drugs = new List<Drug> {
                new Drug {
                    Barcodes = new List<string> {
                        "123412341"
                    }
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