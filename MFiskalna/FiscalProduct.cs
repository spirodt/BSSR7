using System;
using System.Data;

namespace MFiskalna.Fiskalna
{
    public static class FiskalnaHelper
    {
        public static FiscalProduct ConvertDataRowToFiscalProduct(this DataRow dataRowItem)
        {
                return new FiscalProduct
            {
                Artikal = dataRowItem["Naziv"].ToString(),
                Cena = Tools.PrazenStringToDecimal_dec(dataRowItem["CenaSoRabatIddv"].ToString()),
                Kolicina = Tools.PrazenStringToDecimal_dec(dataRowItem["Kolicina"].ToString()),
                DDVGrupa = byte.Parse(Tools.VratiGrupaDDV(dataRowItem["Danok"].ToString()).ToString()),
                MkProizvod = dataRowItem["MkProizvod"].ToString().ToUpper() == "TRUE"
                };
        }

        public static string ConvertLineToSeverec(this FiscalProduct fiscalProduct)
        {
            var GrupaNaDDV = string.Empty;
            if (fiscalProduct.DDVGrupa == 192)
                GrupaNaDDV = "A";
            if (fiscalProduct.DDVGrupa == 193)
                GrupaNaDDV = "B";
            if (fiscalProduct.DDVGrupa == 194)
                GrupaNaDDV = "C";

            return $"{fiscalProduct.Artikal.Replace("#"," ")}#{fiscalProduct.Kolicina:F3}#{GrupaNaDDV}#{fiscalProduct.Cena:F}#{(fiscalProduct.MkProizvod ? 1 : 0) }#{0}{Environment.NewLine}";
        }
    }
    public class FiscalProduct
    {
       
        /**
    *
    * TaxCategory:
    * 192 = А (default)
    * 193 = Б
    * 194 = В
    * 195 = Г
    * */
        private string productName;
        private decimal productPrice;
        private decimal quantity = 1;
        private byte taxCategory = 192;
        private bool mkProizvod1 = true;



        public string Artikal
        {
            get => productName;
            set
            {
                productName = value.Replace("\n", String.Empty).Replace("\r", String.Empty).Replace("\t", String.Empty);
                if (productName.Length > 19)
                {
                    productName = productName.Substring(0, 19);
                }
                productName.RemoveCharactersThatAreNotvalid();
            }
        }

        public decimal Cena { get => productPrice; set => productPrice = value; }

        public decimal Kolicina { get => quantity; set => quantity = value; }
        public byte DDVGrupa { get => taxCategory; set => taxCategory = value; }
        public bool MkProizvod { get => mkProizvod1; set => mkProizvod1 = value; }
    }
}