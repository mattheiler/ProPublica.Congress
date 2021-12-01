using System;
using System.Collections.Generic;
using System.Linq;

namespace ProPublica.Congress
{
    public sealed class ExpensesQuarter
    {
        private ExpensesQuarter(DateTime start, DateTime end, int year, int ordinal)
        {
            Start = start;
            End = end;
            Year = year;
            Ordinal = ordinal;
        }

        public DateTime Start { get; }

        public DateTime End { get; }

        public int Year { get; }

        public int Ordinal { get; }

        public static IEnumerable<ExpensesQuarter> Between(DateTime start, DateTime? end = null)
        {
            return Between(start, end ?? DateTime.UtcNow);
        }

        public static IEnumerable<ExpensesQuarter> Between(DateTime start, DateTime end)
        {
            return Enumerable.Range(start.Year, end.Year - start.Year + 1).SelectMany(ForYear)
                .Where(quarter => start < quarter.End && quarter.Start < end);
        }

        public bool IsInRange(DateTime start, DateTime? end = null)
        {
            return Start <= start && end <= End;
        }

        public static ExpensesQuarter ForYear(int year, int quarter)
        {
            return quarter switch
            {
                1 => new ExpensesQuarter(DateTime.Parse($"01/01/{year}"),
                    DateTime.Parse($"03/31/{year}").AddDays(1).AddTicks(-1), year, 1),
                2 => new ExpensesQuarter(DateTime.Parse($"04/01/{year}"),
                    DateTime.Parse($"06/30/{year}").AddDays(1).AddTicks(-1), year, 2),
                3 => new ExpensesQuarter(DateTime.Parse($"07/01/{year}"),
                    DateTime.Parse($"09/30/{year}").AddDays(1).AddTicks(-1), year, 3),
                4 => new ExpensesQuarter(DateTime.Parse($"10/01/{year}"),
                    DateTime.Parse($"12/31/{year}").AddDays(1).AddTicks(-1), year, 4),
                _ => throw new ArgumentOutOfRangeException(nameof(quarter))
            };
        }

        public static IEnumerable<ExpensesQuarter> ForYear(int year)
        {
            yield return ForYear(year, 1);
            yield return ForYear(year, 2);
            yield return ForYear(year, 3);
            yield return ForYear(year, 4);
        }
    }
}