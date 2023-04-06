
using nHibernate.Models;
using NHibernate;

namespace nHibernate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
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
