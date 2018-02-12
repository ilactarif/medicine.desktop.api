namespace Medicine.Desktop.Api.Models {

    /// <summary>
    ///     İlaç bilgileri
    /// </summary>
    public class Drug : DrugEssential {
        /// <summary>
        ///     İlacın adı
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     İlacın Rapor kısmında yazan bilgi
        /// </summary>
        public string Report { get; set; }

        /// <summary>
        ///     İlacın fiyatı
        /// </summary>
        public float? Price { get; set; }

        /// <summary>
        ///     İlacın farkı
        /// </summary>
        public float? Difference { get; set; }

        /// <summary>
        ///     İlacın verilebileceği tarih
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        ///     İlacın Msj kısmında yazan bilgi. ("var" veya "yok")
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///     İlacın adedi
        /// </summary>
        public int Quantity { get; set; }
    }

}