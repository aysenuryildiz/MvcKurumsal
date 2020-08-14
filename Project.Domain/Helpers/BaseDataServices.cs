﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace Project.Domain
{
    public abstract class BaseDataServices<T> where T : BaseDataEntities 
    {
        readonly string ConnectionString = @"Data Source:LENOVO;Initial Catalog=MvcKurumsal;Integrated Security=True";
        protected IDbConnection Connection
        {
            get { return new SqlConnection(ConnectionString); }
        }

        protected T GetData(string query,object param=null)
        {
            return Connection.QueryFirstOrDefault<T>(query, param);
        }

        protected List<T> GetDataList(string query, object param=null)
        {
            return Connection.Query<T>(query, param).ToList();
        }

        protected int ExecuteCommandText(string query, object param = null)
        {
            return Connection.Execute(query, param, commandType: CommandType.Text);
        }



    }
}
