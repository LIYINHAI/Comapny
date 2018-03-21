using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Model;

namespace Company.IDAL
{
  public partial  interface IBaseDAL<T> where T:class,new()
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
        IQueryable<T> GetModels(Expressino<Func<T, bool>> whereLambda);
    }
}
