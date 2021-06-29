using System;
using BaseLibrary.Interfaces;

namespace BaseLibrary
{
    public class BaseSqlServerConnections : BaseExceptionsHandler, IConnection
    {
        /// <summary>
        /// This points to your database server
        /// </summary>
        protected string DatabaseServer = ".\\SQLEXPRESS";
        /// <summary>
        /// Name of database containing required tables
        /// </summary>
        protected string DefaultCatalog = "";
        /// <summary>
        /// Determines if running on Karen Payne's computer
        /// </summary>
        public bool IsKarenMachine => Environment.UserName == "Karens";
        /// <summary>
        /// Determine if server name has been set from the default on Karen Payne's computer
        /// </summary>
        public bool IsKarensDatabaseServer => DatabaseServer == "KARENS-PC";

        public string ConnectionString => $"Data Source={DatabaseServer};" +
                                          $"Initial Catalog={DefaultCatalog};Integrated Security=True";
        /// <summary>
        /// Determine if server name needs to change.
        /// If using SQL-Express DatabaseServer should be ".]SQLEXPRESS" and if using a named server
        /// provide it's name for DatabaseServer.
        /// </summary>
        public BaseSqlServerConnections()
        {
            if (!IsKarenMachine && IsKarensDatabaseServer)
            {
                mHasException = true;
                throw new Exception($"Please change the DatabaseServer from '{DatabaseServer}' to your server name!");
            }
        }
    }
}
