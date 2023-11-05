using WannabeNetflix.src.roles;
using WannabeNetflix.src.utils;

namespace WannabeNetflix.src.core
{
    internal struct EmployeePayload
    {
        internal EmployeePayload(string error, Employee? employee)
        {
            _error = error;
            _employee = employee;
        }

        internal string _error;
        internal Employee? _employee;
    }

    internal class EmployeeManager
    {
        internal Dictionary<string, Employee> GetEmployees() => _employees;
        private Dictionary<string, Employee> _employees;

        internal EmployeeManager()
        {
            _employees = PopulateEmployees();
        }

        private Dictionary<string, Employee> PopulateEmployees()
        {
            Employee readOnly = new Employee(DateTime.Now, "read", Encryption.MD5Hash("only"), true);
            Employee fullAccess = new Employee(DateTime.Now, "full", Encryption.MD5Hash("access"), false);

            return new Dictionary<string, Employee> {
                { readOnly.UserName, readOnly},
                { fullAccess.UserName, fullAccess }
            };
        }

        internal EmployeePayload TryGetEmployee(string username, string password)
        {
            if (_employees.TryGetValue(username, out Employee? employee))
            {
                if (Encryption.MD5Hash(password) == employee.Password)
                {
                    return new EmployeePayload(Error.NONE, employee);
                }

                return new EmployeePayload(Error.WRONG_PASSWORD, null);
            }

            return new EmployeePayload(Error.WRONG_USERNAME, null);
        }
    }
}
