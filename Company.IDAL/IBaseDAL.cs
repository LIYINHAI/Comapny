using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Model;
using System.Linq.Expressions;

namespace Company.IDAL
{
    public partial interface IBaseDAL<T> where T : class, new()
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="t"></param>
        void Add(T t);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="t"></param>
        void Delete(T t);
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="t"></param>
        void Update(T t);
        IQueryable<T> GetModels(Expression<Func<T, bool>> whereLambda);
        IQueryable<T> GetModelsByPage<type>(int pageSize, int pageIndex, bool isAsc, Expression<Func<T, type>> OrderByLambda, Expression<Func<T, bool>> WhereLambda);
        /// <summary>
        /// 一个业务中有可能涉及到对多张表的操作,那么可以将操作的数据,打上相应的标记,最后调用该方法,将数据一次性提交到数据库中,避免了多次链接数据库。
        /// </summary>
        bool SaveChanges();
    }
}
