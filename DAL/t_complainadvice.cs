using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WalleProject.DAL
{
	/// <summary>
	/// 数据访问类:t_complainadvice
	/// </summary>
	public partial class t_complainadvice
	{
		public t_complainadvice()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("comd_ID", "t_complainadvice"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int comd_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_complainadvice");
			strSql.Append(" where comd_ID=@comd_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@comd_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = comd_ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WalleProject.Model.t_complainadvice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_complainadvice(");
			strSql.Append("comd_date,comd_u_id,comd_staff_id,comd_content,comd_valid)");
			strSql.Append(" values (");
			strSql.Append("@comd_date,@comd_u_id,@comd_staff_id,@comd_content,@comd_valid)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@comd_date", MySqlDbType.DateTime),
					new MySqlParameter("@comd_u_id", MySqlDbType.Int32,10),
					new MySqlParameter("@comd_staff_id", MySqlDbType.Int32,10),
					new MySqlParameter("@comd_content", MySqlDbType.VarChar,50),
					new MySqlParameter("@comd_valid", MySqlDbType.VarChar,2)};
			parameters[0].Value = model.comd_date;
			parameters[1].Value = model.comd_u_id;
			parameters[2].Value = model.comd_staff_id;
			parameters[3].Value = model.comd_content;
			parameters[4].Value = model.comd_valid;

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
		public bool Update(WalleProject.Model.t_complainadvice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_complainadvice set ");
			strSql.Append("comd_date=@comd_date,");
			strSql.Append("comd_u_id=@comd_u_id,");
			strSql.Append("comd_staff_id=@comd_staff_id,");
			strSql.Append("comd_content=@comd_content,");
			strSql.Append("comd_valid=@comd_valid");
			strSql.Append(" where comd_ID=@comd_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@comd_date", MySqlDbType.DateTime),
					new MySqlParameter("@comd_u_id", MySqlDbType.Int32,10),
					new MySqlParameter("@comd_staff_id", MySqlDbType.Int32,10),
					new MySqlParameter("@comd_content", MySqlDbType.VarChar,50),
					new MySqlParameter("@comd_valid", MySqlDbType.VarChar,2),
					new MySqlParameter("@comd_ID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.comd_date;
			parameters[1].Value = model.comd_u_id;
			parameters[2].Value = model.comd_staff_id;
			parameters[3].Value = model.comd_content;
			parameters[4].Value = model.comd_valid;
			parameters[5].Value = model.comd_ID;

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
		public bool Delete(int comd_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_complainadvice ");
			strSql.Append(" where comd_ID=@comd_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@comd_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = comd_ID;

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
		public bool DeleteList(string comd_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_complainadvice ");
			strSql.Append(" where comd_ID in ("+comd_IDlist + ")  ");
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
		public WalleProject.Model.t_complainadvice GetModel(int comd_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select comd_date,comd_ID,comd_u_id,comd_staff_id,comd_content,comd_valid from t_complainadvice ");
			strSql.Append(" where comd_ID=@comd_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@comd_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = comd_ID;

			WalleProject.Model.t_complainadvice model=new WalleProject.Model.t_complainadvice();
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
		public WalleProject.Model.t_complainadvice DataRowToModel(DataRow row)
		{
			WalleProject.Model.t_complainadvice model=new WalleProject.Model.t_complainadvice();
			if (row != null)
			{
				if(row["comd_date"]!=null && row["comd_date"].ToString()!="")
				{
					model.comd_date=DateTime.Parse(row["comd_date"].ToString());
				}
				if(row["comd_ID"]!=null && row["comd_ID"].ToString()!="")
				{
					model.comd_ID=int.Parse(row["comd_ID"].ToString());
				}
				if(row["comd_u_id"]!=null && row["comd_u_id"].ToString()!="")
				{
					model.comd_u_id=int.Parse(row["comd_u_id"].ToString());
				}
				if(row["comd_staff_id"]!=null && row["comd_staff_id"].ToString()!="")
				{
					model.comd_staff_id=int.Parse(row["comd_staff_id"].ToString());
				}
				if(row["comd_content"]!=null)
				{
					model.comd_content=row["comd_content"].ToString();
				}
				if(row["comd_valid"]!=null)
				{
					model.comd_valid=row["comd_valid"].ToString();
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
			strSql.Append("select comd_date,comd_ID,comd_u_id,comd_staff_id,comd_content,comd_valid ");
			strSql.Append(" FROM t_complainadvice ");
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
			strSql.Append("select count(1) FROM t_complainadvice ");
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
				strSql.Append("order by T.comd_ID desc");
			}
			strSql.Append(")AS Row, T.*  from t_complainadvice T ");
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
			parameters[0].Value = "t_complainadvice";
			parameters[1].Value = "comd_ID";
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

