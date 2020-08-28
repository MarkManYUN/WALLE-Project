using Maticsoft.DBUtility;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace WalleProject.DAL
{/// <summary>
 /// 数据访问类:t_staffsalary
 /// </summary>
    public partial class t_staffsalary
    {
        public t_staffsalary()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("sal_ID", "t_staffsalary");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int sal_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from t_staffsalary");
            strSql.Append(" where sal_ID=@sal_ID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@sal_ID", MySqlDbType.Int32)
            };
            parameters[0].Value = sal_ID;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }
 

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WalleProject.Model.t_staffsalary model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into t_staffsalary(");
            strSql.Append("Sal_absenteeismDay,sal_bonusM,sal_describe,sal_deductM,sal_totalM,sal_incrementM,sal_month,sal_year,sal_date,sal_sta_id,Sal_leaveDay)");
            strSql.Append(" values (");
            strSql.Append("@Sal_absenteeismDay,@sal_bonusM,@sal_describe,@sal_deductM,@sal_totalM,@sal_incrementM,@sal_month,@sal_year,@sal_date,@sal_sta_id,@Sal_leaveDay)");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@Sal_absenteeismDay", MySqlDbType.Int32,10),
                    new MySqlParameter("@sal_bonusM", MySqlDbType.Decimal,10),
                    new MySqlParameter("@sal_describe", MySqlDbType.Text),
                    new MySqlParameter("@sal_deductM", MySqlDbType.Decimal,10),
                    new MySqlParameter("@sal_totalM", MySqlDbType.Decimal,10),
                    new MySqlParameter("@sal_incrementM", MySqlDbType.Decimal,10),
                    new MySqlParameter("@sal_month", MySqlDbType.Int32,10),
                    new MySqlParameter("@sal_year", MySqlDbType.Int32,10),
                    new MySqlParameter("@sal_date", MySqlDbType.DateTime),
                    new MySqlParameter("@sal_sta_id", MySqlDbType.Int32,10),
                    new MySqlParameter("@Sal_leaveDay", MySqlDbType.Int32,10)};
            parameters[0].Value = model.Sal_absenteeismDay;
            parameters[1].Value = model.sal_bonusM;
            parameters[2].Value = model.sal_describe;
            parameters[3].Value = model.sal_deductM;
            parameters[4].Value = model.sal_totalM;
            parameters[5].Value = model.sal_incrementM;
            parameters[6].Value = model.sal_month;
            parameters[7].Value = model.sal_year;
            parameters[8].Value = model.sal_date;
            parameters[9].Value = model.sal_sta_id;
            parameters[10].Value = model.Sal_leaveDay;

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
        public bool Update(WalleProject.Model.t_staffsalary model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update t_staffsalary set ");
            strSql.Append("Sal_absenteeismDay=@Sal_absenteeismDay,");
            strSql.Append("sal_bonusM=@sal_bonusM,");
            strSql.Append("sal_describe=@sal_describe,");
            strSql.Append("sal_deductM=@sal_deductM,");
            strSql.Append("sal_totalM=@sal_totalM,");
            strSql.Append("sal_incrementM=@sal_incrementM,");
            strSql.Append("sal_month=@sal_month,");
            strSql.Append("sal_year=@sal_year,");
            strSql.Append("sal_date=@sal_date,");
            strSql.Append("sal_sta_id=@sal_sta_id,");
            strSql.Append("Sal_leaveDay=@Sal_leaveDay");
            strSql.Append(" where sal_ID=@sal_ID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@Sal_absenteeismDay", MySqlDbType.Int32,10),
                    new MySqlParameter("@sal_bonusM", MySqlDbType.Decimal,10),
                    new MySqlParameter("@sal_describe", MySqlDbType.Text),
                    new MySqlParameter("@sal_deductM", MySqlDbType.Decimal,10),
                    new MySqlParameter("@sal_totalM", MySqlDbType.Decimal,10),
                    new MySqlParameter("@sal_incrementM", MySqlDbType.Decimal,10),
                    new MySqlParameter("@sal_month", MySqlDbType.Int32,10),
                    new MySqlParameter("@sal_year", MySqlDbType.Int32,10),
                    new MySqlParameter("@sal_date", MySqlDbType.DateTime),
                    new MySqlParameter("@sal_sta_id", MySqlDbType.Int32,10),
                    new MySqlParameter("@Sal_leaveDay", MySqlDbType.Int32,10),
                    new MySqlParameter("@sal_ID", MySqlDbType.Int32,10)};
            parameters[0].Value = model.Sal_absenteeismDay;
            parameters[1].Value = model.sal_bonusM;
            parameters[2].Value = model.sal_describe;
            parameters[3].Value = model.sal_deductM;
            parameters[4].Value = model.sal_totalM;
            parameters[5].Value = model.sal_incrementM;
            parameters[6].Value = model.sal_month;
            parameters[7].Value = model.sal_year;
            parameters[8].Value = model.sal_date;
            parameters[9].Value = model.sal_sta_id;
            parameters[10].Value = model.Sal_leaveDay;
            parameters[11].Value = model.sal_ID;

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
        public bool Delete(int sal_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from t_staffsalary ");
            strSql.Append(" where sal_ID=@sal_ID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@sal_ID", MySqlDbType.Int32)
            };
            parameters[0].Value = sal_ID;

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
        public bool DeleteList(string sal_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from t_staffsalary ");
            strSql.Append(" where sal_ID in (" + sal_IDlist + ")  ");
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
        public WalleProject.Model.t_staffsalary GetModel(int sal_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Sal_absenteeismDay,sal_ID,sal_bonusM,sal_describe,sal_deductM,sal_totalM,sal_incrementM,sal_month,sal_year,sal_date,sal_sta_id,Sal_leaveDay from t_staffsalary ");
            strSql.Append(" where sal_ID=@sal_ID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@sal_ID", MySqlDbType.Int32)
            };
            parameters[0].Value = sal_ID;

            WalleProject.Model.t_staffsalary model = new WalleProject.Model.t_staffsalary();
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
        public WalleProject.Model.t_staffsalary DataRowToModel(DataRow row)
        {
            WalleProject.Model.t_staffsalary model = new WalleProject.Model.t_staffsalary();
            if (row != null)
            {
                if (row["Sal_absenteeismDay"] != null && row["Sal_absenteeismDay"].ToString() != "")
                {
                    model.Sal_absenteeismDay = int.Parse(row["Sal_absenteeismDay"].ToString());
                }
                if (row["sal_ID"] != null && row["sal_ID"].ToString() != "")
                {
                    model.sal_ID = int.Parse(row["sal_ID"].ToString());
                }
                if (row["sal_bonusM"] != null && row["sal_bonusM"].ToString() != "")
                {
                    model.sal_bonusM = decimal.Parse(row["sal_bonusM"].ToString());
                }
                if (row["sal_describe"] != null)
                {
                    model.sal_describe = row["sal_describe"].ToString();
                }
                if (row["sal_deductM"] != null && row["sal_deductM"].ToString() != "")
                {
                    model.sal_deductM = decimal.Parse(row["sal_deductM"].ToString());
                }
                if (row["sal_totalM"] != null && row["sal_totalM"].ToString() != "")
                {
                    model.sal_totalM = decimal.Parse(row["sal_totalM"].ToString());
                }
                if (row["sal_incrementM"] != null && row["sal_incrementM"].ToString() != "")
                {
                    model.sal_incrementM = decimal.Parse(row["sal_incrementM"].ToString());
                }
                if (row["sal_month"] != null && row["sal_month"].ToString() != "")
                {
                    model.sal_month = int.Parse(row["sal_month"].ToString());
                }
                if (row["sal_year"] != null && row["sal_year"].ToString() != "")
                {
                    model.sal_year = int.Parse(row["sal_year"].ToString());
                }
                if (row["sal_date"] != null && row["sal_date"].ToString() != "")
                {
                    model.sal_date = DateTime.Parse(row["sal_date"].ToString());
                }
                if (row["sal_sta_id"] != null && row["sal_sta_id"].ToString() != "")
                {
                    model.sal_sta_id = int.Parse(row["sal_sta_id"].ToString());
                }
                if (row["Sal_leaveDay"] != null && row["Sal_leaveDay"].ToString() != "")
                {
                    model.Sal_leaveDay = int.Parse(row["Sal_leaveDay"].ToString());
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
            strSql.Append("select Sal_absenteeismDay,sal_ID,sal_bonusM,sal_describe,sal_deductM,sal_totalM,sal_incrementM,sal_month,sal_year,sal_date,sal_sta_id,Sal_leaveDay ");
            strSql.Append(" FROM t_staffsalary ");
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
            strSql.Append("select count(1) FROM t_staffsalary ");
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
                strSql.Append("order by T.sal_ID desc");
            }
            strSql.Append(")AS Row, T.*  from t_staffsalary T ");
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
			parameters[0].Value = "t_staffsalary";
			parameters[1].Value = "sal_ID";
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
