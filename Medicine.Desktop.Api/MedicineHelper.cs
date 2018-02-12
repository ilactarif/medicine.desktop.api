using System.Diagnostics;
using System.IO;
using Medicine.Desktop.Api.Models;

namespace Medicine.Desktop.Api {

    public class MedicineHelper {
        public const string MEDICINE_PATH = @"C:\Program Files\ALTERNET\Medicine\Medicine.exe";
        public const string WEB_SITE = "https://ilactarif.com.tr";

        public MedicineHelper(IJsonSerializer serializer) {
            Serializer = serializer;
        }

        public IJsonSerializer Serializer { get; }

        /// <summary>
        ///     Eğer İlaç Tarif varsa, reçete bilgisini uygulamaya gönderir,
        ///     Eğer İlaç Tarif yoksa, İlaç Tarif web sayfasına yönlendirir.
        /// </summary>
        /// <param name="prescription"></param>
        public void Send(Prescription prescription) {
            string arguments = $"api.prescription={Serializer.ToJson(prescription)}";
            Send(arguments);
        }

        private static void Send(string arguments) {
            if (File.Exists(MEDICINE_PATH)) {
                Process.Start(MEDICINE_PATH, arguments);
            } else {
                Process.Start(WEB_SITE);
            }
        }
    }

}