using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using VNext.BienEtreAuTravail.DAL.Interfaces;
using VNext.BienEtreAuTravail.DAL.Models.Database;
using VNext.BienEtreAuTravail.DAL.Models.Settings;
using AutoMapper;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using Dapper.Contrib.Extensions;
using System.Linq;
using VNext.BienEtreAuTravail.DAL.Context;
using Microsoft.EntityFrameworkCore;
using VNext.BienEtreAuTravail.DAL.Models.DTO;

namespace VNext.BienEtreAuTravail.DAL.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(IOptions<ConnectionStrings> option) : base(option) { }
        public IEnumerable<Employee> GetUsers()
        {
            using (var connection = GetConnection())
            {
                var context = new WorkContext();

                return context.Employees;

            }


        }
        public void AddUser(Employee nom)
        {


            using (var context = new WorkContext())
            {
                

                context.Employees.Add(nom);

                context.SaveChanges();
            }



        }

        public void UpdateUser(int id, string value)
        {
            using (var context = new WorkContext())
            {
                var user = context.Employees.First(a => a.IdEmployee == id);
                user.Pseudo = value;
                context.SaveChanges();

            }

        }

        public IEnumerable<Employee> DisplayById()
        {
            using (var context = new WorkContext())
            {

                return context.Employees.ToList();

            }
        }


        public IEnumerable<Employee> GetAllUsers()
        {
            using (var context = new WorkContext())
            {

                return context.Employees.ToList();
            }
        }
        public IEnumerable<Employee> DeleteEmp(int person)
        {
            using (var context = new WorkContext())
            {
                try
                {

                    var author = context.Employees.Single(a => a.IdEmployee == person);
                    context.Remove(author);
                    context.SaveChanges();
                    return context.Employees.ToList();

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

       

        //var result = new List<User>();
        //result.Add(new User()
        //{
        //    Id = 1,
        //    Name = "Alice"
        //});
        //result.Add(new User()
        //{
        //    Id = 2,
        //    Name = "Bob"
        //});

        //return result;
    }

}

