using System;
using System.Collections.Generic;
using System.Text;
using VNext.BienEtreAuTravail.DAL.Models.Database;
using VNext.BienEtreAuTravail.DAL.Models.DTO;

namespace VNext.BienEtreAuTravail.DAL.Interfaces
{
    public interface IUserRepository
    {
        
           IEnumerable<Employee> GetUsers();
           void AddUser(Employee nom);
           void UpdateUser(int id,string value);
           IEnumerable<Employee> GetAllUsers();
        IEnumerable<Employee> DeleteEmp(int person);
          
           IEnumerable<Employee> DisplayById();


    }
}
