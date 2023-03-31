using FluentValidation;
using LemonadeStand.Results;
using System.ComponentModel.DataAnnotations;

namespace LemonadeStand.Helpers.Validation
{
    //---------- Test note---------
    // Detta är mer en POC, än en fullständig lösning.
    // Ville bara visa hur jag tänker kring validering.
    // Det är lite overkill här med med tanke på att valideringen lätt hade kunna gjorts på enklare sätt.
    // Dock bra för skalbarhet!=)
    public static class ValidationHelper
    {
        public static void ValidateOrderedQuantity(int orderedQuantity)
        {
            var validator = new OrderedQuantityValidator();
            validator.ValidateAndThrow(orderedQuantity);
        }
        public static void ValidateMoneyPaidQuantity(int moneyPaid)
        {
            var validator = new MoneyPaidValidator();
            validator.ValidateAndThrow(moneyPaid);
        }

        private class OrderedQuantityValidator : AbstractValidator<int>
        {
            public OrderedQuantityValidator()
            {
                RuleFor(x => x).GreaterThan(0).WithMessage("Ordered quantity must be greater than zero.");
            }
        }

        private class MoneyPaidValidator : AbstractValidator<int>
        {
            public MoneyPaidValidator()
            {
                RuleFor(x => x).GreaterThan(0).WithMessage("Money paid must be greater than zero.");
            }
        }
    }

}
