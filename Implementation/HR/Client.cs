using Practice.HR.Events;
using System;

namespace Practice.HR
{
    /// <summary>
    ///     Скрытая реализация представления о клиенте.
    /// </summary>
    internal class Client : AbstractPerson, IClient
    {
        /*
         * TODO #4: Реализуйте интерфейс IClient для класса Client
         */

	private float o_discount;

        public float Discount
        {
            get
            {
                return o_discount;
            }

            set
            {
                var oldDiscount = o_discount;
                o_discount = value;
                if (DiscountChange != null)
                {
                    DiscountChange.Invoke(this, new ValueChangeEventArgs<float>(oldDiscount));   
                }
            }
        }

        public event EventHandler<ValueChangeEventArgs<float>> DiscountChange;
    }
}
