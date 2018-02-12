using System.Collections.Generic;

namespace Medicine.Desktop.Api.Models {

    /// <summary>
    ///     Reçete bilgilerini içerir
    /// </summary>
    public class Prescription {
        /// <summary>
        ///     Reçete Numarası
        /// </summary>
        public string PrescriptionNo { get; set; }

        /// <summary>
        ///     Reçetedeki ilaçların bilgileri
        /// </summary>
        public List<Drug> Drugs { get; set; }

        /// <summary>
        ///     Doktorun adı
        /// </summary>
        public string DoctorName { get; set; }

        /// <summary>
        ///     Doktorun soyadi
        /// </summary>
        public string DoctorSurname { get; set; }

        /// <summary>
        ///     Hastanın adı
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Hastanın soyadı
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        ///     Hastanın T.C. numarası
        /// </summary>
        public string Tc { get; set; }

        /// <summary>
        ///     Gönderen Uygulamanın Adı
        /// </summary>
        public string SenderApplication { get; set; }
    }

}