﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Intermediary;

namespace Logic
{
    public class SqlEngland : ISqlQueryable
    {
        public string ReturnSqlQuery()
        {
            return "This is the query for England";
        }
    }
}
