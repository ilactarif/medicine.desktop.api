using System.Collections.Generic;

namespace Medicine.Desktop.Api.Models {

    /// <summary>
    ///     İlaç bilgisinin olmazsa olmaz propertyleri
    /// </summary>
    public class DrugEssential {
        /// <summary>
        ///     İlacın barkod numarası.
        ///     İlk barkod numarası ilacın kendi barkod numarası olmalıdır.
        ///     Diğer barkodlar ise muadil/yan ürünlerin barkod numaraları olabilir.
        /// </summary>
        public List<string> Barcodes { get; set; }

        /// <summary>
        ///     İlacın kullanım periyodu
        /// </summary>
        public int Period1 { get; set; }

        /// <summary>
        ///     İlacın kullanım periyodu
        /// </summary>
        public PeriodTypes Period2 { get; set; }

        /// <summary>
        ///     İlacın ilk doz bilgisi
        /// </summary>
        public int Dosage1 { get; set; }

        /// <summary>
        ///     İlacın ikinci doz bilgisi
        /// </summary>
        public float Dosage2 { get; set; }
    }

}