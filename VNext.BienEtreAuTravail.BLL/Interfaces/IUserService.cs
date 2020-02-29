using System;
using System.Collections.Generic;
using System.Text;
using VNext.BienEtreAuTravail.DAL.Models.Database;
using VNext.BienEtreAuTravail.DAL.Models.DTO;

namespace VNext.BienEtreAuTravail.BLL.Interfaces
{
    public interface IUserService
    {
        IEnumerable<Employee> GetUsers();
        void UpdateUser(int id, string value);
        void AddUser(Employee user);
        IEnumerable<Employee> GetAllUsers();
        bool Authentification(string pseudo, string password);

        IEnumerable<Employee> DisplayById(int employee);
        

        IEnumerable<Employee> DeleteEmp(int person);

    }
}
