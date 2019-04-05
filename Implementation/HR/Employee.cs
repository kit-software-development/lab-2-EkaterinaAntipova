using System;
using Practice.HR.Events;
using Practice.Organization;

namespace Practice.HR
{
    /// <summary>
    ///     Скрытая реализация представления о сотруднике.
    /// </summary>
    internal class Employee : AbstractPerson, IEmployee
    {
        /*
         * TODO #5: Реализуйте интерфейс IEmployee для класса Employee
         */

	private IDepartment o_department;

        public IDepartment Department
        {
            get { return o_department; }

            set
            {
                var oldDepartment = o_department;
                o_department = value;
                if (DepartmentChange != null)
                {
                    DepartmentChange.Invoke(this, new ValueChangeEventArgs<IDepartment>(oldDepartment));
                }
            }
        }

        public event EventHandler<ValueChangeEventArgs<IDepartment>> DepartmentChange;
    }
}
