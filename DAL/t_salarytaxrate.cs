using Maticsoft.DBUtility;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WalleProject.DAL
{   /// <summary>
    /// 数据访问类:t_salarytaxrate
    /// </summary>
    public partial class t_salarytaxrate
    {
        public t_salarytaxrate()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("Str_ID", "t_salarytaxrate");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Str_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from t_salarytaxrate");
            strSql.Append(" where Str_ID=@Str_ID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@Str_ID", MySqlDbType.Int32)
            };
            parameters[0].Value = Str_ID;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WalleProject.Model.t_salarytaxrate model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into t_salarytaxrate(");
            strSql.Append("Sta_threshold,Str_date,Str_aged,Str_medical,Str_unemployment,Str_housing,Sta_supplement,Sta_individualTax)");
            strSql.Append(" values (");
            strSql.Append("@Sta_threshold,@Str_date,@Str_aged,@Str_medical,@Str_unemployment,@Str_housing,@Sta_supplement,@Sta_individualTax)");
            MySqlParameter[] parameters = {
                 new MySqlParameter("@Sta_threshold", MySqlDbType.Decimal,10) ,
                    new MySqlParameter("@Str_date", MySqlDbType.DateTime),
                    new MySqlParameter("@Str_aged", MySqlDbType.Float),
                    new MySqlParameter("@Str_medical", MySqlDbType.Float),
                    new MySqlParameter("@Str_unemployment", MySqlDbType.Float),
                    new MySqlParameter("@Str_housing", MySqlDbType.Float),
                    new MySqlParameter("@Sta_supplement", MySqlDbType.Float),
                    new MySqlParameter("@Sta_individualTax", MySqlDbType.Float)};
            parameters[0].Value = model.Sta_threshold;
            parameters[1].Value = model.Str_date;
            parameters[2].Value = model.Str_aged;
            parameters[3].Value = model.Str_medical;
            parameters[4].Value = model.Str_unemployment;
            parameters[5].Value = model.Str_housing;
            parameters[6].Value = model.Sta_supplement;
            parameters[7].Value = model.Sta_individualTax;

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
        public bool Update(WalleProject.Model.t_salarytaxrate model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update t_salarytaxrate set ");
            strSql.Append(" Sta_threshold = @Sta_threshold , ");
            strSql.Append("Str_date=@Str_date,");
            strSql.Append("Str_aged=@Str_aged,");
            strSql.Append("Str_medical=@Str_medical,");
            strSql.Append("Str_unemployment=@Str_unemployment,");
            strSql.Append("Str_housing=@Str_housing,");
            strSql.Append("Sta_supplement=@Sta_supplement,");
            strSql.Append("Sta_individualTax=@Sta_individualTax");
            strSql.Append(" where Str_ID=@Str_ID");
            MySqlParameter[] parameters = {
                 new MySqlParameter("@Sta_threshold", MySqlDbType.Decimal,10) ,

                    new MySqlParameter("@Str_date", MySqlDbType.DateTime),
                    new MySqlParameter("@Str_aged", MySqlDbType.Float),
                    new MySqlParameter("@Str_medical", MySqlDbType.Float),
                    new MySqlParameter("@Str_unemployment", MySqlDbType.Float),
                    new MySqlParameter("@Str_housing", MySqlDbType.Float),
                    new MySqlParameter("@Sta_supplement", MySqlDbType.Float),
                    new MySqlParameter("@Sta_individualTax", MySqlDbType.Float),
                    new MySqlParameter("@Str_ID", MySqlDbType.Int32,10)};
            parameters[0].Value = model.Sta_threshold;
            parameters[1].Value = model.Str_date;
            parameters[2].Value = model.Str_aged;
            parameters[3].Value = model.Str_ID;
            parameters[4].Value = model.Str_medical;
            parameters[5].Value = model.Str_unemployment;
            parameters[6].Value = model.Str_housing;
            parameters[7].Value = model.Sta_supplement;
            parameters[8].Value = model.Sta_individualTax;

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
        public bool Delete(int Str_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from t_salarytaxrate ");
            strSql.Append(" where Str_ID=@Str_ID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@Str_ID", MySqlDbType.Int32)
            };
            parameters[0].Value = Str_ID;

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
        public bool DeleteList(string Str_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from t_salarytaxrate ");
            strSql.Append(" where Str_ID in (" + Str_IDlist + ")  ");
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
        public WalleProject.Model.t_salarytaxrate GetModel(int Str_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Sta_threshold,Str_date,Str_aged,Str_ID,Str_medical,Str_unemployment,Str_housing,Sta_supplement,Sta_individualTax from t_salarytaxrate ");
            strSql.Append(" where Str_ID=@Str_ID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@Str_ID", MySqlDbType.Int32)
            };
            parameters[0].Value = Str_ID;

            WalleProject.Model.t_salarytaxrate model = new WalleProject.Model.t_salarytaxrate();
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
        public WalleProject.Model.t_salarytaxrate DataRowToModel(DataRow row)
        {
            WalleProject.Model.t_salarytaxrate model = new WalleProject.Model.t_salarytaxrate();
            if (row != null)
            {
                if (row["Sta_threshold"].ToString() != "")
                {
                    model.Sta_threshold = decimal.Parse(row["Sta_threshold"].ToString());
                }
                if (row["Str_date"] != null && row["Str_date"].ToString() != "")
                {
                    model.Str_date = DateTime.Parse(row["Str_date"].ToString());
                }
                if (row["Str_aged"] != null && row["Str_aged"].ToString() != "")
                {
                    model.Str_aged = decimal.Parse(row["Str_aged"].ToString());
                }
                if (row["Str_ID"] != null && row["Str_ID"].ToString() != "")
                {
                    model.Str_ID = int.Parse(row["Str_ID"].ToString());
                }
                if (row["Str_medical"] != null && row["Str_medical"].ToString() != "")
                {
                    model.Str_medical = decimal.Parse(row["Str_medical"].ToString());
                }
                if (row["Str_unemployment"] != null && row["Str_unemployment"].ToString() != "")
                {
                    model.Str_unemployment = decimal.Parse(row["Str_unemployment"].ToString());
                }
                if (row["Str_housing"] != null && row["Str_housing"].ToString() != "")
                {
                    model.Str_housing = decimal.Parse(row["Str_housing"].ToString());
                }
                if (row["Sta_supplement"] != null && row["Sta_supplement"].ToString() != "")
                {
                    model.Sta_supplement = decimal.Parse(row["Sta_supplement"].ToString());
                }
                if (row["Sta_individualTax"] != null && row["Sta_individualTax"].ToString() != "")
                {
                    model.Sta_individualTax = decimal.Parse(row["Sta_individualTax"].ToString());
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
            strSql.Append("select Sta_threshold,Str_date,Str_aged,Str_ID,Str_medical,Str_unemployment,Str_housing,Sta_supplement,Sta_individualTax ");
            strSql.Append(" FROM t_salarytaxrate ");
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
            strSql.Append("select count(1) FROM t_salarytaxrate ");
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
                strSql.Append("order by T.Str_ID desc");
            }
            strSql.Append(")AS Row, T.*  from t_salarytaxrate T ");
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
			parameters[0].Value = "t_salarytaxrate";
			parameters[1].Value = "Str_ID";
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
