using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WalleProject.DAL
{
	/// <summary>
	/// 数据访问类:t_menucategory
	/// </summary>
	public partial class t_menucategory
	{
		public t_menucategory()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("menuc_ID", "t_menucategory"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int menuc_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_menucategory");
			strSql.Append(" where menuc_ID=@menuc_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@menuc_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = menuc_ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WalleProject.Model.t_menucategory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_menucategory(");
			strSql.Append("menuc_name)");
			strSql.Append(" values (");
			strSql.Append("@menuc_name)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@menuc_name", MySqlDbType.VarChar,10)};
			parameters[0].Value = model.menuc_name;

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
		public bool Update(WalleProject.Model.t_menucategory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_menucategory set ");
			strSql.Append("menuc_name=@menuc_name");
			strSql.Append(" where menuc_ID=@menuc_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@menuc_name", MySqlDbType.VarChar,10),
					new MySqlParameter("@menuc_ID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.menuc_name;
			parameters[1].Value = model.menuc_ID;

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
		public bool Delete(int menuc_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_menucategory ");
			strSql.Append(" where menuc_ID=@menuc_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@menuc_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = menuc_ID;

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
		public bool DeleteList(string menuc_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_menucategory ");
			strSql.Append(" where menuc_ID in ("+menuc_IDlist + ")  ");
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
		public WalleProject.Model.t_menucategory GetModel(int menuc_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select menuc_ID,menuc_name from t_menucategory ");
			strSql.Append(" where menuc_ID=@menuc_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@menuc_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = menuc_ID;

			WalleProject.Model.t_menucategory model=new WalleProject.Model.t_menucategory();
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
		public WalleProject.Model.t_menucategory DataRowToModel(DataRow row)
		{
			WalleProject.Model.t_menucategory model=new WalleProject.Model.t_menucategory();
			if (row != null)
			{
				if(row["menuc_ID"]!=null && row["menuc_ID"].ToString()!="")
				{
					model.menuc_ID=int.Parse(row["menuc_ID"].ToString());
				}
				if(row["menuc_name"]!=null)
				{
					model.menuc_name=row["menuc_name"].ToString();
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
			strSql.Append("select menuc_ID,menuc_name ");
			strSql.Append(" FROM t_menucategory ");
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
			strSql.Append("select count(1) FROM t_menucategory ");
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
				strSql.Append("order by T.menuc_ID desc");
			}
			strSql.Append(")AS Row, T.*  from t_menucategory T ");
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
			parameters[0].Value = "t_menucategory";
			parameters[1].Value = "menuc_ID";
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

