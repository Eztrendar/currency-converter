using System;

namespace Currency.Converter.Model.Entities
{
    public class Currency
    {
        public int? CurrencyId { get; set; }
        public string Type { get; set; }
        public decimal Value { get; set; }
        public DateTime? Date { get; set; }

        public Currency()
        {

        }

        public Currency(int? currencyId, string type, decimal value, DateTime? date)
        {
            CurrencyId = currencyId;
            Type = type;
            Value = value;
            Date = date;
        }
    }
}
