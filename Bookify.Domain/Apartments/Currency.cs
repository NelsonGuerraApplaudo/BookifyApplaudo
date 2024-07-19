using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Apartments;

public record Currency
{
    public static readonly Currency Usd = new Currency() { Code = "USD" };
    public static readonly Currency Eur = new Currency() { Code = "EUR" };
    public static Currency FromCode(string code) {
        return All.FirstOrDefault(c => c.Code == code) ?? throw new ApplicationException("The Currency is invalid"); }
    public string Code { get; init; }
    public static readonly IReadOnlyCollection<Currency> All = new List<Currency>() { Usd, Eur };
}
