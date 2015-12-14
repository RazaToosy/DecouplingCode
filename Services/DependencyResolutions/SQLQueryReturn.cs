using System;
using Intermediary;
using Logic;

namespace DecouplingCode.DependencyResolutions
{
    public class SqlQueryReturn
    {
        ISqlQueryable _theQuery;

        public ISqlQueryable ResolveDependency(String location)
        {
            switch (location)
            {
                case "England":
                    _theQuery = new SqlEngland();
                    break;
                case "Scotland":
                    _theQuery = new SqlScotland();
                    break;
                case "Wales":
                    _theQuery = new SqlWales();
                    break;
                default:
                    _theQuery = new SqlEngland();
                    break;
            }
            return _theQuery;
        }
    }
}
