using System;

namespace Currency.Converter.Model.Entities
{
    public class CurrencyModel
    {
        public int? CurrencyId { get; set; }
        public string Type { get; set; }
        public decimal Value { get; set; }
        public DateTime? Date { get; set; }

        public CurrencyModel()
        {

        }

        public CurrencyModel(int? currencyId, string type, decimal value, DateTime? date)
        {
            CurrencyId = currencyId;
            Type = type;
            Value = value;
            Date = date;
        }
    }
}
