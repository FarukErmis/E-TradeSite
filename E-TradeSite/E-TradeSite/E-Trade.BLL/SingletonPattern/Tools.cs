using Proje.DAL.Context;

namespace Proje.BLL.SingletonPattern
{
    public class Tools
    {
        //Burada DataContext için yapılacak her bir instance RAM'i şişireceği için Singleton Pattern ile biz tek bir kere instance alınması sağlıyoruz. Ve bütün projede sadece tek bir instance ile çalışıyoruz. Yani eğer 100 tane class'ım varsa 100 tane form'da 100 tane instance almıyorum. Tek bir sefer instance alınıyor daha sonra if durumu false olacağı RAM'i boşuna şişirmiş olmuyoruz.
        private static DataContext _dbInstance;
        
        public static DataContext DbInstance
        {
            get
            {
                if (_dbInstance == null)
                    _dbInstance = new DataContext();
                return _dbInstance;
            }
        }
    }
}
