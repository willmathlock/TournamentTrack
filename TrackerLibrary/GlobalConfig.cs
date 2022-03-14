using System;
using System.Collections.Generic;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        /*
        static string ServerName = "127.0.0.1";                                          //localhost
        static string Port = "5432";                                                            //porta default
        static string UserName = "postgres";                                               //nome do administrador
        static string Password = "5544";                                             //senha do administrador
        static string DatabaseName = "tournaments";                                       //nome do banco de dados
        */
        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO - set up the SQL connector properly.
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);

                /*NpgsqlConnection pgsqlConnection = null;
                string connString = null;

                connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                                ServerName, Port, UserName, Password, DatabaseName);
                */
            }

            if (textFiles)
            {
                TextConnection text = new TextConnection();
                Connections.Add(text);

            }
        }
    }
}
