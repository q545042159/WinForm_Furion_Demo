using Furion;
using Furion.DatabaseAccessor;
using Microsoft.Extensions.DependencyInjection;

namespace WinFormsApp1
{
    public class Startup:AppStartup
    {
        public void abc(IServiceCollection service)
        {
            // 配置数据库上下文，支持N个数据库
            service.AddDatabaseAccessor(options =>
            {
                // 配置默认数据库
                options.AddDbPool<DefaultDBContext>(DbProvider.MySql);

                // 配置多个数据库，多个数据库必须指定数据库上下文定位器
                //  options.AddDbPool<SqliteDbContext, SqliteDbContextLocaotr>();
            });
        }
    }
}
