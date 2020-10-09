using BlazorCrud.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Server.Interfaces
{
    public interface IEmployee
    {
        public IEnumerable<Contact> GetAllEmployees();
        public void AddEmployee(Contact employee);
        public void UpdateEmployee(Contact employee);
        public Contact GetEmployeeData(int id);
        public void DeleteEmployee(int id);
    }
}
