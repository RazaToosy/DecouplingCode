using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using Intermediary;

namespace Services
{
    public class SqlQueryService
    {
        private readonly ISqlQueryable _retrieveSqlQuery;

        public String ReturnSqlQuey() //same signature as Interface
        {
            return _retrieveSqlQuery.ReturnSqlQuery();
        }
        
        public SqlQueryService(ISqlQueryable QueryToReturn)
        {
            _retrieveSqlQuery = QueryToReturn;
        }
    }
}
