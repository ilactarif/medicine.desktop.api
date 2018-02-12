namespace Medicine.Desktop.Api.Models {

    public class PrescriptionAmount {
        /// <summary>
        ///     Reçete Kaykı Payı (Elden)
        /// </summary>
        public float PrescriptionContribution_Hand { get; set; }

        /// <summary>
        ///     Reçete Katkı Payı (Maaştan)
        /// </summary>
        public float PrescriptionContribution_Salary { get; set; }

        /// <summary>
        ///     Muayene Katkı Payı (Elden)
        /// </summary>
        public float ExaminationContribution_Hand { get; set; }

        /// <summary>
        ///     Muayene Katkı Payı (Maaştan)
        /// </summary>
        public float ExaminationContribution_Salary { get; set; }

        /// <summary>
        ///     Eczane İndirim Tutarı
        /// </summary>
        public float PharmacyDiscountAmount { get; set; }

        /// <summary>
        ///     İlaç Kaykı Payı Tutarı
        /// </summary>
        public float DrugContribution { get; set; }

        /// <summary>
        ///     Fiyat Farkı
        /// </summary>
        public float PriceDifference { get; set; }

        /// <summary>
        ///     %8 KDV
        /// </summary>
        public float Tax8 { get; set; }

        /// <summary>
        ///     %18 KDV
        /// </summary>
        public float Tax18 { get; set; }

        /// <summary>
        ///     Ödenecek Tutar
        /// </summary>
        public float TotalPrice { get; set; }

        /// <summary>
        ///     Hastanın eczaneye ödemesi gereken toplam tutar
        /// </summary>
        public float TotalAmountDueToPharmacy { get; set; }
    }

}