using System.Collections.Generic;

namespace ProPublica.Congress
{
    public sealed class ExpensesCategory
    {
        public static readonly ExpensesCategory Travel = new ExpensesCategory("travel");

        public static readonly ExpensesCategory Personnel = new ExpensesCategory("personnel");

        public static readonly ExpensesCategory RentUtilities = new ExpensesCategory("rent-utilities");

        public static readonly ExpensesCategory OtherServices = new ExpensesCategory("other-services");

        public static readonly ExpensesCategory Supplies = new ExpensesCategory("supplies");

        public static readonly ExpensesCategory FrankedMail = new ExpensesCategory("franked-mail");

        public static readonly ExpensesCategory Printing = new ExpensesCategory("printing");

        public static readonly ExpensesCategory Equipment = new ExpensesCategory("equipment");

        public static readonly ExpensesCategory Total = new ExpensesCategory("total");

        private ExpensesCategory(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public static IEnumerable<ExpensesCategory> Values
        {
            get
            {
                yield return Travel;
                yield return Personnel;
                yield return RentUtilities;
                yield return OtherServices;
                yield return Supplies;
                yield return FrankedMail;
                yield return Printing;
                yield return Equipment;
                yield return Total;
            }
        }


        public static explicit operator string(ExpensesCategory category)
        {
            return category.ToString();
        }

        public override string ToString()
        {
            return Value;
        }
    }
}