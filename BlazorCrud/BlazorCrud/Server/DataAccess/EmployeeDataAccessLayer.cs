using BlazorCrud.Server.Interfaces;
using BlazorCrud.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Server.DataAccess
{
    public class EmployeeDataAccessLayer: IEmployee
    {
        EmployeeContext db = new EmployeeContext();

        //To Get all employees details   
        public IEnumerable<Contact> GetAllEmployees()
        {
            try
            {
                return db.Contacttbl.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new employee record     
        public void AddEmployee(Contact employee)
        {
            try
            {
                db.Contacttbl.Add(employee);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar employee    
        public void UpdateEmployee(Contact employee)
        {
            try
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular employee    
        public Contact GetEmployeeData(int id)
        {
            try
            {
                Contact employee = db.Contacttbl.Find(id);
                return employee;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular employee    
        public void DeleteEmployee(int id)
        {
            try
            {
                Contact emp = db.Contacttbl.Find(id);
                db.Contacttbl.Remove(emp);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
