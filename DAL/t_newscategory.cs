using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WalleProject.DAL
{
	/// <summary>
	/// 数据访问类:t_newscategory
	/// </summary>
	public partial class t_newscategory
	{
		public t_newscategory()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("newc_ID", "t_newscategory"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int newc_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_newscategory");
			strSql.Append(" where newc_ID=@newc_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@newc_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = newc_ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WalleProject.Model.t_newscategory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_newscategory(");
			strSql.Append("newc_name)");
			strSql.Append(" values (");
			strSql.Append("@newc_name)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@newc_name", MySqlDbType.VarChar,10)};
			parameters[0].Value = model.newc_name;

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
		public bool Update(WalleProject.Model.t_newscategory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_newscategory set ");
			strSql.Append("newc_name=@newc_name");
			strSql.Append(" where newc_ID=@newc_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@newc_name", MySqlDbType.VarChar,10),
					new MySqlParameter("@newc_ID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.newc_name;
			parameters[1].Value = model.newc_ID;

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
		public bool Delete(int newc_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_newscategory ");
			strSql.Append(" where newc_ID=@newc_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@newc_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = newc_ID;

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
		public bool DeleteList(string newc_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_newscategory ");
			strSql.Append(" where newc_ID in ("+newc_IDlist + ")  ");
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
		public WalleProject.Model.t_newscategory GetModel(int newc_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select newc_name,newc_ID from t_newscategory ");
			strSql.Append(" where newc_ID=@newc_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@newc_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = newc_ID;

			WalleProject.Model.t_newscategory model=new WalleProject.Model.t_newscategory();
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
		public WalleProject.Model.t_newscategory DataRowToModel(DataRow row)
		{
			WalleProject.Model.t_newscategory model=new WalleProject.Model.t_newscategory();
			if (row != null)
			{
				if(row["newc_name"]!=null)
				{
					model.newc_name=row["newc_name"].ToString();
				}
				if(row["newc_ID"]!=null && row["newc_ID"].ToString()!="")
				{
					model.newc_ID=int.Parse(row["newc_ID"].ToString());
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
			strSql.Append("select newc_name,newc_ID ");
			strSql.Append(" FROM t_newscategory ");
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
			strSql.Append("select count(1) FROM t_newscategory ");
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
				strSql.Append("order by T.newc_ID desc");
			}
			strSql.Append(")AS Row, T.*  from t_newscategory T ");
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
			parameters[0].Value = "t_newscategory";
			parameters[1].Value = "newc_ID";
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

