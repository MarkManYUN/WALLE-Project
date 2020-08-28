﻿using Maticsoft.DBUtility;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace WalleProject.DAL
{
    /// <summary>
    /// 数据访问类:t_wastesmailcate
    /// </summary>
    public partial class t_wastesmailcate
    {
        public t_wastesmailcate()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("wastecate_id", "t_wastesmailcate");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int wastecate_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from t_wastesmailcate");
            strSql.Append(" where wastecate_id=@wastecate_id");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@wastecate_id", MySqlDbType.Int32)
            };
            parameters[0].Value = wastecate_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WalleProject.Model.t_wastesmailcate model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into t_wastesmailcate(");
            strSql.Append("wastecate_name,wastecate_cid)");
            strSql.Append(" values (");
            strSql.Append("@wastecate_name,@wastecate_cid)");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@wastecate_name", MySqlDbType.VarChar,20),
                    new MySqlParameter("@wastecate_cid", MySqlDbType.Int32,10)};
            parameters[0].Value = model.wastecate_name;
            parameters[1].Value = model.wastecate_cid;

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
        public bool Update(WalleProject.Model.t_wastesmailcate model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update t_wastesmailcate set ");
            strSql.Append("wastecate_name=@wastecate_name,");
            strSql.Append("wastecate_cid=@wastecate_cid");
            strSql.Append(" where wastecate_id=@wastecate_id");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@wastecate_name", MySqlDbType.VarChar,20),
                    new MySqlParameter("@wastecate_cid", MySqlDbType.Int32,10),
                    new MySqlParameter("@wastecate_id", MySqlDbType.Int32,10)};
            parameters[0].Value = model.wastecate_name;
            parameters[1].Value = model.wastecate_cid;
            parameters[2].Value = model.wastecate_id;

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
        public bool Delete(int wastecate_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from t_wastesmailcate ");
            strSql.Append(" where wastecate_id=@wastecate_id");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@wastecate_id", MySqlDbType.Int32)
            };
            parameters[0].Value = wastecate_id;

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
        public bool DeleteList(string wastecate_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from t_wastesmailcate ");
            strSql.Append(" where wastecate_id in (" + wastecate_idlist + ")  ");
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
        public WalleProject.Model.t_wastesmailcate GetModel(int wastecate_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select wastecate_name,wastecate_id,wastecate_cid from t_wastesmailcate ");
            strSql.Append(" where wastecate_id=@wastecate_id");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@wastecate_id", MySqlDbType.Int32)
            };
            parameters[0].Value = wastecate_id;

            WalleProject.Model.t_wastesmailcate model = new WalleProject.Model.t_wastesmailcate();
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
        public WalleProject.Model.t_wastesmailcate DataRowToModel(DataRow row)
        {
            WalleProject.Model.t_wastesmailcate model = new WalleProject.Model.t_wastesmailcate();
            if (row != null)
            {
                if (row["wastecate_name"] != null)
                {
                    model.wastecate_name = row["wastecate_name"].ToString();
                }
                if (row["wastecate_id"] != null && row["wastecate_id"].ToString() != "")
                {
                    model.wastecate_id = int.Parse(row["wastecate_id"].ToString());
                }
                if (row["wastecate_cid"] != null && row["wastecate_cid"].ToString() != "")
                {
                    model.wastecate_cid = int.Parse(row["wastecate_cid"].ToString());
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
            strSql.Append("select wastecate_name,wastecate_id,wastecate_cid ");
            strSql.Append(" FROM t_wastesmailcate ");
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
            strSql.Append("select count(1) FROM t_wastesmailcate ");
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
                strSql.Append("order by T.wastecate_id desc");
            }
            strSql.Append(")AS Row, T.*  from t_wastesmailcate T ");
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
			parameters[0].Value = "t_wastesmailcate";
			parameters[1].Value = "wastecate_id";
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
