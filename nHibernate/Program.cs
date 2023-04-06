
using nHibernate.Models;
using NHibernate;

namespace nHibernate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //string connStr = "Data Source=112.196.113.3,1535;Initial Catalog=Test;User ID=sa;Password=Mssql@chicmic2023;Trusted_Connection = True;TrustServerCertificate=True; Integrated Security=false";
            var config = new NHibernate.Cfg.Configuration();
            /*config.DataBaseIntegration(d=>{
                d.ConnectionString = connStr;
                d.Dialect<MsSql2012Dialect>();
                d.Driver<SqlClientDriver>();
            });*/
            config.Configure("C:/Users/ChicMic/source/repos/nHibernate/nHibernate/XMLFile1.cfg.xml");
            config.AddAssembly(typeof(Product).Assembly);
            ISessionFactory _sessionFactory = config.BuildSessionFactory();

            using (var session = _sessionFactory.OpenSession())
            {
                var product = new Product { Id= 1 ,Name = "Ajay",Role ="Intern"};
                session.Save(product);
            }
        }
    }
}
