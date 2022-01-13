using System.Configuration;

namespace RIS
{
    public static class AppConfig
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["DBEntities"].ConnectionString;
    }
}
