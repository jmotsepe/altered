namespace Altered
{
    class Connection
    {
        public static string ConnectionString()
        {
            string username = Login.username;
            string password = Login.password;
            //return "Data Source=HPC0028568\\SQLEXPRESS;Initial Catalog=altered;Persist Security Info=True;User ID=" + username + ";Password=" + password;
            return "Data Source=.\\SQLEXPRESS;Initial Catalog=altered;Persist Security Info=True;User ID=hpc\\u29282536;Password=UPnet19640628AS#";
        }
    }
}
