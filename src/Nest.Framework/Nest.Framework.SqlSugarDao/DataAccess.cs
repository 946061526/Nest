using SqlSugar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;

namespace Nest.Framework.SqlSugarDao
{
    public class DataAccess : IDataAccess
    {
        SqlSugarClient _db;
        public DataAccess()
        {
            _db = DbFactory.DbClient;
        }

        #region 插入
        /// <summary>
        /// 插入一个实体
        /// </summary>
        /// <typeparam name="T">表实体</typeparam>
        /// <param name="entity">实体内容</param>
        /// <param name="pk">要忽略的主键</param>
        /// <returns>long</returns>
        public long Add<T>(T entity, Expression<Func<T, object>> pk = null) where T : class, new()
        {
            IInsertable<T> r = _db.Insertable(entity);
            if (pk != null)
                r = r.IgnoreColumns(pk);

            return r.ExecuteReturnIdentity();
        }
        /// <summary>
        /// 插入一个实体
        /// </summary>
        /// <typeparam name="T">表实体</typeparam>
        /// <param name="entity">实体内容</param>
        /// <param name="pk">要忽略的主键</param>
        /// <returns>本批次最大主键ID</returns>
        public long Add<T>(T[] entitys, Expression<Func<T, object>> pk = null) where T : class, new()
        {
            IInsertable<T> r = _db.Insertable(entitys);
            if (pk != null)
                r = r.IgnoreColumns(pk);

            return r.ExecuteReturnIdentity();
        }
        #endregion

        #region 删除
        /// <summary>
        /// 按主键批量删除(物理删除)
        /// </summary>
        /// <typeparam name="T">表实体</typeparam>
        /// <param name="primaryKeys">主键集合</param>
        /// <returns>受影响行数</returns>
        public int Delete<T>(int[] primaryKeys) where T : class, new()
        {
            return _db.Deleteable<T>(primaryKeys).ExecuteCommand();
        }
        /// <summary>
        /// 按主键删除(物理删除)
        /// </summary>
        /// <typeparam name="T">表实体</typeparam>
        /// <param name="primaryKey">主键值</param>
        /// <returns>受影响行数</returns>
        public int Delete<T>(int primaryKey) where T : class, new()
        {
            return _db.Deleteable<T>(primaryKey).ExecuteCommand();
        }
        /// <summary>
        /// 按条件删除(物理删除)
        /// </summary>
        /// <typeparam name="T">表实体</typeparam>
        /// <param name="where">条件语句，如："id=@id"</param>
        /// <param name="parameters">参数，如：new{id=0}</param>
        /// <returns>int</returns>
        public int Delete<T>(string where, object parameters) where T : class, new()
        {
            IDeleteable<T> r = _db.Deleteable<T>();
            if (!string.IsNullOrEmpty(where))
                r = r.Where(where, parameters);

            return r.ExecuteCommand();
        }
        /// <summary>
        /// 按条件删除(物理删除)
        /// </summary>
        /// <typeparam name="T">表实体</typeparam>
        /// <param name="where">条件语句</param>
        /// <returns>int</returns>
        public int Delete<T>(Expression<Func<T, bool>> where) where T : class, new()
        {
            return _db.Deleteable(where).ExecuteCommand();
        }
        #endregion

        #region 修改
        /// <summary>
        /// 更新实体
        /// </summary>
        /// <typeparam name="T">表实体</typeparam>
        /// <param name="entity">实体内容</param>
        /// <returns>受影响行数</returns>
        public int Edit<T>(T entity) where T : class, new()
        {
            return _db.Updateable(entity).ExecuteCommand();
        }
        /// <summary>
        /// 编辑
        /// </summary>
        /// <typeparam name="T">表实体</typeparam>
        /// <param name="entity">实体内容</param>
        /// <param name="columns">要编辑的列</param>
        /// <param name="where">条件</param>
        /// <returns>受影响行数</returns>        
        public int Edit<T>(T entity, Expression<Func<T, T>> columns, Expression<Func<T, bool>> where) where T : class, new()
        {
            IUpdateable<T> r = _db.Updateable(entity);
            if (columns != null)
                r = r.UpdateColumns(columns);

            return r.Where(where).ExecuteCommand();
        }
        #endregion

        #region 查询单个
        /// <summary>
        /// 查询单个实体
        /// </summary>
        /// <typeparam name="T">表实体</typeparam>
        /// <param name="id">主键</param>
        /// <returns>实体内容</returns>
        public T Get<T>(int id) where T : class, new()
        {
            return _db.Queryable<T>().InSingle(id);
        }
        /// <summary>
        /// 查询单个实体
        /// </summary>
        /// <typeparam name="T">表实体</typeparam>
        /// <param name="where">查询条件,如 "id=@id"</param>
        /// <param name="parameters">条件参数，如new SugarParameter("@id",1) 或 new { id = 1 }</param>
        /// <returns></returns>
        public T Get<T>(string where, object parameters) where T : class, new()
        {
            return _db.Queryable<T>().Where(where, parameters).Single();
        }
        /// <summary>
        /// 查询单个实体
        /// </summary>
        /// <typeparam name="T">表实体</typeparam>
        /// <param name="where">查询条件</param>
        /// <returns></returns>
        public T Get<T>(Expression<Func<T, bool>> where) where T : class, new()
        {
            return _db.Queryable<T>().Where(where).Single();
        }
        #endregion

        #region 查询总条数
        /// <summary>
        /// 查询汇总条数
        /// </summary>
        /// <typeparam name="T">表实体</typeparam>
        /// <param name="where">查询条件,如 "id=@id"</param>
        /// <param name="parameters">条件参数，如new SugarParameter("@id",1) 或 new { id = 1 }</param>
        /// <returns></returns>
        public int GetCount<T>(string where, object parameters) where T : class, new()
        {
            ISugarQueryable<T> r = _db.Queryable<T>();
            if (!string.IsNullOrEmpty(where))
                r = r.Where(where, parameters);

            return r.Count();
        }
        /// <summary>
        /// 查询单个实体
        /// </summary>
        /// <typeparam name="T">表实体</typeparam>
        /// <param name="where">查询条件</param>
        /// <returns></returns>
        public int GetCount<T>(Expression<Func<T, bool>> where) where T : class, new()
        {
            ISugarQueryable<T> r = _db.Queryable<T>();
            if (where != null)
                r = r.Where(where);

            return r.Count();
        }
        #endregion

        #region 查询列表
        /// <summary>
        /// 查询列表
        /// </summary>
        /// <typeparam name="T">表实体</typeparam>
        /// <param name="where">查询条件,如 "id=@id"</param>
        /// <param name="parameters">条件参数，如 new SugarParameter("@id",1) 或 new { id = 1 }</param>
        /// <param name="orderBy">排序语句，如 "id asc"</param>
        /// <returns></returns>
        public List<T> GetList<T>(string where, object parameters, string orderBy) where T : class, new()
        {
            ISugarQueryable<T> r = _db.Queryable<T>();
            if (!string.IsNullOrEmpty(where))
                r = r.Where(where);
            if (!string.IsNullOrEmpty(orderBy))
                r = r.OrderBy(orderBy);

            return r.ToList();
        }
        /// <summary>
        /// 查询列表
        /// </summary>
        /// <typeparam name="T">表实体</typeparam>
        /// <param name="where">查询条件</param>
        /// <param name="orderBy">排序语句</param>
        /// <returns></returns>
        public List<T> GetList<T>(Expression<Func<T, bool>> where, Expression<Func<T, object>> orderBy) where T : class, new()
        {
            ISugarQueryable<T> r = _db.Queryable<T>();
            if (where != null)
                r = r.Where(where);
            if (orderBy != null)
                r = r.OrderBy(orderBy);

            return r.ToList();
        }
        #endregion

        #region 查询分页
        /// <summary>
        /// 查询分页
        /// </summary>
        /// <typeparam name="T">表实体</typeparam>
        /// <param name="where">查询条件,如 "id=@id"</param>
        /// <param name="parameters">条件参数，如 new SugarParameter("@id",1) 或 new { id = 1 }</param>
        /// <param name="orderBy">排序语句，如 "id asc"</param>
        /// <param name="pageIndex">页索引</param>
        /// <param name="pageSize">页大小</param>
        /// <param name="total">总条数</param>
        /// <returns></returns>
        public List<T> GetListPage<T>(string where, object parameters, string orderBy, int pageIndex, int pageSize, ref int total) where T : class, new()
        {
            ISugarQueryable<T> r = _db.Queryable<T>();
            if (!string.IsNullOrEmpty(where))
                r = r.Where(where);
            if (!string.IsNullOrEmpty(orderBy))
                r = r.OrderBy(orderBy);

            return r.ToPageList(pageIndex, pageSize, ref total);
        }
        /// <summary>
        /// 查询分页
        /// </summary>
        /// <typeparam name="T">表实体</typeparam>
        /// <param name="where">查询条件</param>
        /// <param name="orderBy">排序语句</param>
        /// <param name="pageIndex">页索引</param>
        /// <param name="pageSize">页大小</param>
        /// <param name="total">总条数</param>
        /// <returns></returns>
        public List<T> GetListPage<T>(Expression<Func<T, bool>> where, Expression<Func<T, object>> orderBy, int pageIndex, int pageSize, ref int total) where T : class, new()
        {
            ISugarQueryable<T> r = _db.Queryable<T>();
            if (where != null)
                r = r.Where(where);
            if (orderBy != null)
                r = r.OrderBy(orderBy);

            return r.ToPageList(pageIndex, pageSize, ref total);
        }
        #endregion

        #region 多表查询
        /// <summary>
        /// 两表join
        /// </summary>
        /// <typeparam name="T">表1</typeparam>
        /// <typeparam name="T2">表2</typeparam>
        /// <typeparam name="TResult">返回的内容实体</typeparam>
        /// <param name="joinExpression">连接条件</param>
        /// <param name="where">查询条件</param>
        /// <param name="orderBy">排序条件</param>
        /// <param name="selectColumns">返回的实体字段</param>
        /// <returns></returns>
        public List<TResult> GetList<T, T2, TResult>(Expression<Func<T, T2, object[]>> joinExpression, Expression<Func<T, bool>> where, Expression<Func<T, T2, object>> orderBy, Expression<Func<T, T2, TResult>> selectColumns) where T : class, new()
        {
            //var pageJoin = db.Queryable<Student, School>((st, sc) => new object[] {
            //  JoinType.Left,st.SchoolId==sc.Id
            //})
            //.Where(st => st.Id == 1)
            //.Where(st => st.Id == 2)
            //.Select((st, sc) => new { id = st.Id, name = sc.Name })
            //.MergeTable().Where(XXX => XXX.id == 1).OrderBy("name asc").ToList();

            ISugarQueryable<T, T2> q = _db.Queryable(joinExpression);
            if (where != null)
                q = q.Where(where);
            if (orderBy != null)
                q = q.OrderBy(orderBy);

            return q.Select(selectColumns).ToList();
        }
        /// <summary>
        /// 三表join
        /// </summary>
        /// <typeparam name="T">表1</typeparam>
        /// <typeparam name="T2">表2</typeparam>
        /// <typeparam name="T3">表3</typeparam>
        /// <typeparam name="TResult">返回的内容实体</typeparam>
        /// <param name="joinExpression">连接条件</param>
        /// <param name="where">查询条件</param>
        /// <param name="orderBy">排序条件</param>
        /// <param name="selectColumns">返回的实体字段</param>
        /// <returns></returns>
        public List<TResult> GetList<T, T2, T3, TResult>(Expression<Func<T, T2, T3, object[]>> joinExpression, Expression<Func<T, bool>> where, Expression<Func<T, T2, object>> orderBy, Expression<Func<T, T2, T3, TResult>> selectColumns) where T : class, new()
        {
            // var list = db.Queryable<Student, School, Student>((st, sc, st2) => new object[] {
            //   JoinType.Left,st.SchoolId==sc.Id,
            //   JoinType.Left,st.SchoolId==st2.Id
            // })
            //.Where((st, sc, st2) => st2.Id == 1 || sc.Id == 1 || st.Id == 1)
            //.OrderBy((sc) => sc.Id)
            //.OrderBy((st, sc) => st.Name, OrderByType.Desc)
            //.Select((st, sc, st2) => new { st = st, sc = sc }).ToList();

            ISugarQueryable<T, T2, T3> q = _db.Queryable(joinExpression);
            if (where != null)
                q = q.Where(where);
            if (orderBy != null)
                q = q.OrderBy(orderBy);

            return q.Select(selectColumns).ToList();
        }
        /// <summary>
        /// 四表join
        /// </summary>
        /// <typeparam name="T">表1</typeparam>
        /// <typeparam name="T2">表2</typeparam>
        /// <typeparam name="T3">表3</typeparam>
        /// <typeparam name="T4">表4</typeparam>
        /// <typeparam name="TResult">返回的内容实体</typeparam>
        /// <param name="joinExpression">连接条件</param>
        /// <param name="where">查询条件</param>
        /// <param name="orderBy">排序条件</param>
        /// <param name="selectColumns">返回的实体字段</param>
        /// <returns></returns>
        public List<TResult> GetList<T, T2, T3, T4, TResult>(Expression<Func<T, T2, T3, T4, object[]>> joinExpression, Expression<Func<T, bool>> where, Expression<Func<T, T2, object>> orderBy, Expression<Func<T, T2, T3, T4, TResult>> selectColumns) where T : class, new()
        {
            ISugarQueryable<T, T2, T3, T4> q = _db.Queryable(joinExpression);
            if (where != null)
                q = q.Where(where);
            if (orderBy != null)
                q = q.OrderBy(orderBy);

            return q.Select(selectColumns).ToList();
        }
        #endregion

        #region Ado操作，执行sql语句
        /// <summary>
        /// sql查询
        /// </summary>
        /// <typeparam name="TReturn">实体</typeparam>
        /// <param name="sql">sql语句，示例："select * from table where id=@id"</param>
        /// <param name="pars">参数，示例：new { id = 1 }</param>
        /// <returns>实体集合</returns>
        public IEnumerable<TReturn> SqlQuery<TReturn>(string sql, object parameters) where TReturn : class, new()
        {
            //var dt = _db.Ado.GetDataTable("select * from table where id=@id", new SugarParameter("@id", 1));

            //var dt = _db.Ado.GetDataTable("select * from table where id=@id", new { id = 1 });

            //var dt = _db.Ado.GetDataTable("select * from table where id=@id and name=@name", new SugarParameter[]{
            //  new SugarParameter("@id",1),
            //  new SugarParameter("@name",2)
            //});
            return _db.Ado.SqlQuery<TReturn>(sql, parameters);
        }
        /// <summary>
        /// sql查询
        /// </summary>
        /// <typeparam name="TReturn"></typeparam>
        /// <param name="sql">sql语句，示例："select * from table where id=@id"</param>
        /// <param name="pars">参数，示例：new { id = 1 }</param>
        /// <returns>实体</returns>
        public TReturn SqlQuerySingle<TReturn>(string sql, object parameters) where TReturn : class, new()
        {
            return _db.Ado.SqlQuerySingle<TReturn>(sql, parameters);
        }
        /// <summary>
        /// sql查询
        /// </summary>
        /// <param name="sql">sql语句，示例："select * from table where id=@id"</param>
        /// <param name="pars">参数，示例：new { id = 1 }</param>
        /// <returns>DataSet</returns>
        public DataSet GetDataSet(string sql, object parameters)
        {
            return _db.Ado.GetDataSetAll(sql, parameters);
        }
        /// <summary>
        /// sql查询
        /// </summary>
        /// <param name="sql">sql语句，示例："select * from table where id=@id"</param>
        /// <param name="pars">参数，示例：new { id = 1 }</param>
        /// <returns>DataTable</returns>
        public DataTable GetDataTable(string sql, object parameters)
        {
            return _db.Ado.GetDataTable(sql, parameters);
        }
        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="sql">sql语句，示例："select * from table where id=@id"</param>
        /// <param name="pars">参数，示例：new { id = 1 }</param>
        /// <returns>int</returns>
        public int ExecuteSql(string sql, object parameters)
        {
            return _db.Ado.ExecuteCommand(sql, parameters);
        }
        /// <summary>
        /// 事物批量执行sql
        /// </summary>
        /// <param name="sqlList">sql语句集合</param>
        /// <returns>int</returns>
        public int ExecuteSql(List<string> sqlList)
        {
            var result = _db.Ado.UseTran(() =>
            {
                foreach (var sql in sqlList)
                    _db.Ado.ExecuteCommand(sql);
            });
            return result.IsSuccess ? 1 : 0;
        }
        /// <summary>
        /// 获取首行首列
        /// </summary>
        /// <param name="sql">sql语句，示例："select * from table where id=@id"</param>
        /// <param name="pars">参数，示例：new { id = 1 }</param>
        /// <returns>int</returns>
        public int GetInt(string sql, object parameters)
        {
            return _db.Ado.GetInt(sql, parameters);
        }
        /// <summary>
        /// 获取首行首列
        /// </summary>
        /// <param name="sql">sql语句，示例："select * from table where id=@id"</param>
        /// <param name="pars">参数，示例：new { id = 1 }</param>
        /// <returns>string</returns>
        public string GetString(string sql, object parameters)
        {
            return _db.Ado.GetString(sql, parameters);
        }
        /// <summary>
        /// 获取首行首列
        /// </summary>
        /// <param name="sql">sql语句，示例："select * from table where id=@id"</param>
        /// <param name="pars">参数，示例：new { id = 1 }</param>
        /// <returns>decimal</returns>
        public decimal GetDecimal(string sql, object parameters)
        {
            return _db.Ado.GetDecimal(sql, parameters);
        }
        #endregion
    }
}
