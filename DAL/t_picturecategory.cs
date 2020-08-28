﻿using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WalleProject.DAL
{
	/// <summary>
	/// 数据访问类:t_picturecategory
	/// </summary>
	public partial class t_picturecategory
	{
		public t_picturecategory()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("picca_ID", "t_picturecategory"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int picca_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_picturecategory");
			strSql.Append(" where picca_ID=@picca_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@picca_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = picca_ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WalleProject.Model.t_picturecategory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_picturecategory(");
			strSql.Append("picca_name)");
			strSql.Append(" values (");
			strSql.Append("@picca_name)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@picca_name", MySqlDbType.VarChar,10)};
			parameters[0].Value = model.picca_name;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(WalleProject.Model.t_picturecategory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_picturecategory set ");
			strSql.Append("picca_name=@picca_name");
			strSql.Append(" where picca_ID=@picca_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@picca_name", MySqlDbType.VarChar,10),
					new MySqlParameter("@picca_ID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.picca_name;
			parameters[1].Value = model.picca_ID;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int picca_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_picturecategory ");
			strSql.Append(" where picca_ID=@picca_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@picca_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = picca_ID;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string picca_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_picturecategory ");
			strSql.Append(" where picca_ID in ("+picca_IDlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
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
		public WalleProject.Model.t_picturecategory GetModel(int picca_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select picca_ID,picca_name from t_picturecategory ");
			strSql.Append(" where picca_ID=@picca_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@picca_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = picca_ID;

			WalleProject.Model.t_picturecategory model=new WalleProject.Model.t_picturecategory();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public WalleProject.Model.t_picturecategory DataRowToModel(DataRow row)
		{
			WalleProject.Model.t_picturecategory model=new WalleProject.Model.t_picturecategory();
			if (row != null)
			{
				if(row["picca_ID"]!=null && row["picca_ID"].ToString()!="")
				{
					model.picca_ID=int.Parse(row["picca_ID"].ToString());
				}
				if(row["picca_name"]!=null)
				{
					model.picca_name=row["picca_name"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select picca_ID,picca_name ");
			strSql.Append(" FROM t_picturecategory ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM t_picturecategory ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.picca_ID desc");
			}
			strSql.Append(")AS Row, T.*  from t_picturecategory T ");
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
			parameters[0].Value = "t_picturecategory";
			parameters[1].Value = "picca_ID";
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

