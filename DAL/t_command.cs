using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WalleProject.DAL
{
	/// <summary>
	/// 数据访问类:t_command
	/// </summary>
	public partial class t_command
	{
		public t_command()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("command_ID", "t_command"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int command_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_command");
			strSql.Append(" where command_ID=@command_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@command_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = command_ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WalleProject.Model.t_command model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_command(");
			strSql.Append("command_user_ID,command_staff_ID,command_content,command_Delete,command_Valid,command_Date)");
			strSql.Append(" values (");
			strSql.Append("@command_user_ID,@command_staff_ID,@command_content,@command_Delete,@command_Valid,@command_Date)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@command_user_ID", MySqlDbType.Int32,10),
					new MySqlParameter("@command_staff_ID", MySqlDbType.Int32,10),
					new MySqlParameter("@command_content", MySqlDbType.VarChar,200),
					new MySqlParameter("@command_Delete", MySqlDbType.Int32,1),
					new MySqlParameter("@command_Valid", MySqlDbType.Int32,1),
					new MySqlParameter("@command_Date", MySqlDbType.DateTime)};
			parameters[0].Value = model.command_user_ID;
			parameters[1].Value = model.command_staff_ID;
			parameters[2].Value = model.command_content;
			parameters[3].Value = model.command_Delete;
			parameters[4].Value = model.command_Valid;
			parameters[5].Value = model.command_Date;

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
		public bool Update(WalleProject.Model.t_command model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_command set ");
			strSql.Append("command_user_ID=@command_user_ID,");
			strSql.Append("command_staff_ID=@command_staff_ID,");
			strSql.Append("command_content=@command_content,");
			strSql.Append("command_Delete=@command_Delete,");
			strSql.Append("command_Valid=@command_Valid,");
			strSql.Append("command_Date=@command_Date");
			strSql.Append(" where command_ID=@command_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@command_user_ID", MySqlDbType.Int32,10),
					new MySqlParameter("@command_staff_ID", MySqlDbType.Int32,10),
					new MySqlParameter("@command_content", MySqlDbType.VarChar,200),
					new MySqlParameter("@command_Delete", MySqlDbType.Int32,1),
					new MySqlParameter("@command_Valid", MySqlDbType.Int32,1),
					new MySqlParameter("@command_Date", MySqlDbType.DateTime),
					new MySqlParameter("@command_ID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.command_user_ID;
			parameters[1].Value = model.command_staff_ID;
			parameters[2].Value = model.command_content;
			parameters[3].Value = model.command_Delete;
			parameters[4].Value = model.command_Valid;
			parameters[5].Value = model.command_Date;
			parameters[6].Value = model.command_ID;

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
		public bool Delete(int command_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_command ");
			strSql.Append(" where command_ID=@command_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@command_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = command_ID;

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
		public bool DeleteList(string command_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_command ");
			strSql.Append(" where command_ID in ("+command_IDlist + ")  ");
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
		public WalleProject.Model.t_command GetModel(int command_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select command_user_ID,command_staff_ID,command_content,command_ID,command_Delete,command_Valid,command_Date from t_command ");
			strSql.Append(" where command_ID=@command_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@command_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = command_ID;

			WalleProject.Model.t_command model=new WalleProject.Model.t_command();
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
		public WalleProject.Model.t_command DataRowToModel(DataRow row)
		{
			WalleProject.Model.t_command model=new WalleProject.Model.t_command();
			if (row != null)
			{
				if(row["command_user_ID"]!=null && row["command_user_ID"].ToString()!="")
				{
					model.command_user_ID=int.Parse(row["command_user_ID"].ToString());
				}
				if(row["command_staff_ID"]!=null && row["command_staff_ID"].ToString()!="")
				{
					model.command_staff_ID=int.Parse(row["command_staff_ID"].ToString());
				}
				if(row["command_content"]!=null)
				{
					model.command_content=row["command_content"].ToString();
				}
				if(row["command_ID"]!=null && row["command_ID"].ToString()!="")
				{
					model.command_ID=int.Parse(row["command_ID"].ToString());
				}
				if(row["command_Delete"]!=null && row["command_Delete"].ToString()!="")
				{
					model.command_Delete=int.Parse(row["command_Delete"].ToString());
				}
				if(row["command_Valid"]!=null && row["command_Valid"].ToString()!="")
				{
					model.command_Valid=int.Parse(row["command_Valid"].ToString());
				}
				if(row["command_Date"]!=null && row["command_Date"].ToString()!="")
				{
					model.command_Date=DateTime.Parse(row["command_Date"].ToString());
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
			strSql.Append("select command_user_ID,command_staff_ID,command_content,command_ID,command_Delete,command_Valid,command_Date ");
			strSql.Append(" FROM t_command ");
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
			strSql.Append("select count(1) FROM t_command ");
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
				strSql.Append("order by T.command_ID desc");
			}
			strSql.Append(")AS Row, T.*  from t_command T ");
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
			parameters[0].Value = "t_command";
			parameters[1].Value = "command_ID";
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

