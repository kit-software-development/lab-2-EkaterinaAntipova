using Practice.Common;
using Practice.HR.Events;
using System;

namespace Practice.HR
{
    /// <summary>
    ///     Абстрактная база для описания конкретных реализаций типа "Человек".
    ///     Используется для дальнейшего наследования.
    /// </summary>
    internal abstract class AbstractPerson : IPerson
    {
        
        /*
         * TODO #3: Реализуйте интерфейс IPerson для класса AbstractPerson
         */

	private IName o_name;

        public IName Name
        {
            get { return o_name; }
            set
            {
                throw new System.NotImplementedException();
                var old_name = o_name;
                o_name = value;
                if (NameChange != null) 
                {
                    NameChange.Invoke(this, new ValueChangeEventArgs<IName>(old_name));
                }
            }
        }	

	public event EventHandler<ValueChangeEventArgs<IName>> NameChange;
    }
}
