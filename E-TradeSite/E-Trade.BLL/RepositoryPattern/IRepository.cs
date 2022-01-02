using E_Trade.Model.Helpers;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace E_Trade.BLL.RepositoryPattern
{
    public interface IRepository<T> where T : class
    {
        List<T> SelectAll();
        //Burada genericten gelen classı yani ifadeyi alıp geriye bool olarak döndürme işlemi.
        List<T> SearchList(Expression<Func<T,bool>> predicate); //Buraya ifade yazılacak
        T SelectById(int Id);
        T SearchEntity(Expression<Func<T, bool>> predicate);

        ResultModel<T> Insert(T item);
        ResultModel<T> Update(T item);
        ResultModel<T> Delete(int Id);
    }
}
