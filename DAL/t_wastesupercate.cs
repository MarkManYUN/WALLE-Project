using Maticsoft.DBUtility;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace WalleProject.DAL
{
    /// <summary>
    /// 数据访问类:t_wastesupercate
    /// </summary>
    public partial class t_wastesupercate
    {
        public t_wastesupercate()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("wastecc_ID", "t_wastesupercate");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int wastecc_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from t_wastesupercate");
            strSql.Append(" where wastecc_ID=@wastecc_ID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@wastecc_ID", MySqlDbType.Int32)
            };
            parameters[0].Value = wastecc_ID;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WalleProject.Model.t_wastesupercate model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into t_wastesupercate(");
            strSql.Append("wastecc_name)");
            strSql.Append(" values (");
            strSql.Append("@wastecc_name)");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@wastecc_name", MySqlDbType.VarChar,20)};
            parameters[0].Value = model.wastecc_name;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WalleProject.Model.t_wastesupercate model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update t_wastesupercate set ");
            strSql.Append("wastecc_name=@wastecc_name");
            strSql.Append(" where wastecc_ID=@wastecc_ID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@wastecc_name", MySqlDbType.VarChar,20),
                    new MySqlParameter("@wastecc_ID", MySqlDbType.Int32,10)};
            parameters[0].Value = model.wastecc_name;
            parameters[1].Value = model.wastecc_ID;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int wastecc_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from t_wastesupercate ");
            strSql.Append(" where wastecc_ID=@wastecc_ID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@wastecc_ID", MySqlDbType.Int32)
            };
            parameters[0].Value = wastecc_ID;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string wastecc_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from t_wastesupercate ");
            strSql.Append(" where wastecc_ID in (" + wastecc_IDlist + ")  ");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WalleProject.Model.t_wastesupercate GetModel(int wastecc_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select wastecc_name,wastecc_ID from t_wastesupercate ");
            strSql.Append(" where wastecc_ID=@wastecc_ID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@wastecc_ID", MySqlDbType.Int32)
            };
            parameters[0].Value = wastecc_ID;

            WalleProject.Model.t_wastesupercate model = new WalleProject.Model.t_wastesupercate();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WalleProject.Model.t_wastesupercate DataRowToModel(DataRow row)
        {
            WalleProject.Model.t_wastesupercate model = new WalleProject.Model.t_wastesupercate();
            if (row != null)
            {
                if (row["wastecc_name"] != null)
                {
                    model.wastecc_name = row["wastecc_name"].ToString();
                }
                if (row["wastecc_ID"] != null && row["wastecc_ID"].ToString() != "")
                {
                    model.wastecc_ID = int.Parse(row["wastecc_ID"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select wastecc_name,wastecc_ID ");
            strSql.Append(" FROM t_wastesupercate ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM t_wastesupercate ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.wastecc_ID desc");
            }
            strSql.Append(")AS Row, T.*  from t_wastesupercate T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			MySqlParameter[] parameters = {
					new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@PageSize", MySqlDbType.Int32),
					new MySqlParameter("@PageIndex", MySqlDbType.Int32),
					new MySqlParameter("@IsReCount", MySqlDbType.Bit),
					new MySqlParameter("@OrderType", MySqlDbType.Bit),
					new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
					};
			parameters[0].Value = "t_wastesupercate";
			parameters[1].Value = "wastecc_ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
