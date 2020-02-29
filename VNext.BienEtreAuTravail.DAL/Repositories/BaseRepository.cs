using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using VNext.BienEtreAuTravail.DAL.Models.Settings;

namespace VNext.BienEtreAuTravail.DAL.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly ConnectionStrings _connectionstrings;
        public BaseRepository(IOptions<ConnectionStrings> option)
        {
            _connectionstrings = option.Value;
        }

        public SqlConnection GetConnection()
        {
            try
            {
                return new SqlConnection(_connectionstrings.SqlConnectionString);

            }catch(Exception e)
            {
                throw e;
            }
        }
    }
}
