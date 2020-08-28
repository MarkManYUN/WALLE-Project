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
    /// 数据访问类:t_staffmenu
    /// </summary>
    public partial class t_staffmenu
    {
        public t_staffmenu()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("StaM_ID", "t_staffmenu");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int StaM_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from t_staffmenu");
            strSql.Append(" where StaM_ID=@StaM_ID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@StaM_ID", MySqlDbType.Int32)
            };
            parameters[0].Value = StaM_ID;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WalleProject.Model.t_staffmenu model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into t_staffmenu(");
            strSql.Append("StaM_User,StaM_Boss,StaM_Admin,StaM_Staff,StaM_Url,StaM_Name,StaM_Delete,StaM_MenuClass,StaM_Valid,StaM_Icon)");
            strSql.Append(" values (");
            strSql.Append("@StaM_User,@StaM_Boss,@StaM_Admin,@StaM_Staff,@StaM_Url,@StaM_Name,@StaM_Delete,@StaM_MenuClass,@StaM_Valid,@StaM_Icon)");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@StaM_User", MySqlDbType.Int32,1),
                    new MySqlParameter("@StaM_Boss", MySqlDbType.Int32,1),
                    new MySqlParameter("@StaM_Admin", MySqlDbType.Int32,1),
                    new MySqlParameter("@StaM_Staff", MySqlDbType.Int32,1),
                    new MySqlParameter("@StaM_Url", MySqlDbType.VarChar,100),
                    new MySqlParameter("@StaM_Name", MySqlDbType.VarChar,50),
                    new MySqlParameter("@StaM_Delete", MySqlDbType.Int32,1),
                    new MySqlParameter("@StaM_MenuClass", MySqlDbType.Int32,10),
                    new MySqlParameter("@StaM_Valid", MySqlDbType.Int32,1),
 new MySqlParameter("@StaM_Icon", MySqlDbType.VarChar,50)};
            parameters[0].Value = model.StaM_User;
            parameters[1].Value = model.StaM_Boss;
            parameters[2].Value = model.StaM_Admin;
            parameters[3].Value = model.StaM_Staff;
            parameters[4].Value = model.StaM_Url;
            parameters[5].Value = model.StaM_Name;
            parameters[6].Value = model.StaM_Delete;
            parameters[7].Value = model.StaM_MenuClass;
            parameters[8].Value = model.StaM_Valid;
            parameters[9].Value = model.StaM_Icon;
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
        public bool Update(WalleProject.Model.t_staffmenu model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update t_staffmenu set ");
            strSql.Append("StaM_User=@StaM_User,");
            strSql.Append("StaM_Boss=@StaM_Boss,");
            strSql.Append("StaM_Admin=@StaM_Admin,");
            strSql.Append("StaM_Staff=@StaM_Staff,");
            strSql.Append("StaM_Url=@StaM_Url,");
            strSql.Append("StaM_Name=@StaM_Name,");
            strSql.Append("StaM_Delete=@StaM_Delete,");
            strSql.Append("StaM_MenuClass=@StaM_MenuClass,");
            strSql.Append("StaM_Valid=@StaM_Valid");
            strSql.Append("StaM_Icon=@StaM_Icon");
            strSql.Append(" where StaM_ID=@StaM_ID");

            MySqlParameter[] parameters = {
                    new MySqlParameter("@StaM_User", MySqlDbType.Int32,1),
                    new MySqlParameter("@StaM_Boss", MySqlDbType.Int32,1),
                    new MySqlParameter("@StaM_Admin", MySqlDbType.Int32,1),
                    new MySqlParameter("@StaM_Staff", MySqlDbType.Int32,1),
                    new MySqlParameter("@StaM_Url", MySqlDbType.VarChar,100),
                    new MySqlParameter("@StaM_Name", MySqlDbType.VarChar,50),
                    new MySqlParameter("@StaM_Delete", MySqlDbType.Int32,1),
                    new MySqlParameter("@StaM_MenuClass", MySqlDbType.Int32,10),
                    new MySqlParameter("@StaM_Valid", MySqlDbType.Int32,1),
                    new MySqlParameter("@StaM_Icon",MySqlDbType.VarChar,50),
                    new MySqlParameter("@StaM_ID", MySqlDbType.Int32,10)};
            parameters[0].Value = model.StaM_User;
            parameters[1].Value = model.StaM_Boss;
            parameters[2].Value = model.StaM_Admin;
            parameters[3].Value = model.StaM_Staff;
            parameters[4].Value = model.StaM_Url;
            parameters[5].Value = model.StaM_Name;
            parameters[6].Value = model.StaM_Delete;
            parameters[7].Value = model.StaM_MenuClass;
            parameters[8].Value = model.StaM_Valid;
            parameters[9].Value = model.StaM_ID;

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
        public bool Delete(int StaM_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from t_staffmenu ");
            strSql.Append(" where StaM_ID=@StaM_ID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@StaM_ID", MySqlDbType.Int32)
            };
            parameters[0].Value = StaM_ID;

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
        public bool DeleteList(string StaM_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from t_staffmenu ");
            strSql.Append(" where StaM_ID in (" + StaM_IDlist + ")  ");
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
        public WalleProject.Model.t_staffmenu GetModel(int StaM_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select StaM_User,StaM_Boss,StaM_Admin,StaM_Staff,StaM_Url,StaM_Name,StaM_ID,StaM_Delete,StaM_MenuClass,StaM_Valid from t_staffmenu ");
            strSql.Append(" where StaM_ID=@StaM_ID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@StaM_ID", MySqlDbType.Int32)
            };
            parameters[0].Value = StaM_ID;

            WalleProject.Model.t_staffmenu model = new WalleProject.Model.t_staffmenu();
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
        public WalleProject.Model.t_staffmenu DataRowToModel(DataRow row)
        {
            WalleProject.Model.t_staffmenu model = new WalleProject.Model.t_staffmenu();
            if (row != null)
            {
                if (row["StaM_User"] != null && row["StaM_User"].ToString() != "")
                {
                    model.StaM_User = int.Parse(row["StaM_User"].ToString());
                }
                if (row["StaM_Boss"] != null && row["StaM_Boss"].ToString() != "")
                {
                    model.StaM_Boss = int.Parse(row["StaM_Boss"].ToString());
                }
                if (row["StaM_Admin"] != null && row["StaM_Admin"].ToString() != "")
                {
                    model.StaM_Admin = int.Parse(row["StaM_Admin"].ToString());
                }
                if (row["StaM_Staff"] != null && row["StaM_Staff"].ToString() != "")
                {
                    model.StaM_Staff = int.Parse(row["StaM_Staff"].ToString());
                }
                if (row["StaM_Url"] != null)
                {
                    model.StaM_Url = row["StaM_Url"].ToString();
                }
                if (row["StaM_Name"] != null)
                {
                    model.StaM_Name = row["StaM_Name"].ToString();
                }
                if (row["StaM_ID"] != null && row["StaM_ID"].ToString() != "")
                {
                    model.StaM_ID = int.Parse(row["StaM_ID"].ToString());
                }
                if (row["StaM_Delete"] != null && row["StaM_Delete"].ToString() != "")
                {
                    model.StaM_Delete = int.Parse(row["StaM_Delete"].ToString());
                }
                if (row["StaM_MenuClass"] != null && row["StaM_MenuClass"].ToString() != "")
                {
                    model.StaM_MenuClass = int.Parse(row["StaM_MenuClass"].ToString());
                }
                if (row["StaM_Valid"] != null && row["StaM_Valid"].ToString() != "")
                {
                    model.StaM_Valid = int.Parse(row["StaM_Valid"].ToString());
                }
                if (row["StaM_Icon"] != null && row["StaM_Icon"].ToString() != "")
                {
                    model.StaM_Icon = int.Parse(row["StaM_Icon"].ToString());
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
            strSql.Append("select StaM_User,StaM_Boss,StaM_Admin,StaM_Staff,StaM_Url,StaM_Name,StaM_ID,StaM_Delete,StaM_MenuClass,StaM_Valid ");
            strSql.Append(" FROM t_staffmenu ");
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
            strSql.Append("select count(1) FROM t_staffmenu ");
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
                strSql.Append("order by T.StaM_ID desc");
            }
            strSql.Append(")AS Row, T.*  from t_staffmenu T ");
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
			parameters[0].Value = "t_staffmenu";
			parameters[1].Value = "StaM_ID";
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
