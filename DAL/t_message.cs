using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WalleProject.DAL
{
	/// <summary>
	/// 数据访问类:t_message
	/// </summary>
	public partial class t_message
	{
		public t_message()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("mess_ID", "t_message"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int mess_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_message");
			strSql.Append(" where mess_ID=@mess_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@mess_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = mess_ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WalleProject.Model.t_message model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_message(");
			strSql.Append("mess_content,mess_date,mess_inpotance,mess_valid,mess_type)");
			strSql.Append(" values (");
			strSql.Append("@mess_content,@mess_date,@mess_inpotance,@mess_valid,@mess_type)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@mess_content", MySqlDbType.Text),
					new MySqlParameter("@mess_date", MySqlDbType.DateTime),
					new MySqlParameter("@mess_inpotance", MySqlDbType.Int32,10),
					new MySqlParameter("@mess_valid", MySqlDbType.VarChar,2),
					new MySqlParameter("@mess_type", MySqlDbType.VarChar,20)};
			parameters[0].Value = model.mess_content;
			parameters[1].Value = model.mess_date;
			parameters[2].Value = model.mess_inpotance;
			parameters[3].Value = model.mess_valid;
			parameters[4].Value = model.mess_type;

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
		public bool Update(WalleProject.Model.t_message model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_message set ");
			strSql.Append("mess_content=@mess_content,");
			strSql.Append("mess_date=@mess_date,");
			strSql.Append("mess_inpotance=@mess_inpotance,");
			strSql.Append("mess_valid=@mess_valid,");
			strSql.Append("mess_type=@mess_type");
			strSql.Append(" where mess_ID=@mess_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@mess_content", MySqlDbType.Text),
					new MySqlParameter("@mess_date", MySqlDbType.DateTime),
					new MySqlParameter("@mess_inpotance", MySqlDbType.Int32,10),
					new MySqlParameter("@mess_valid", MySqlDbType.VarChar,2),
					new MySqlParameter("@mess_type", MySqlDbType.VarChar,20),
					new MySqlParameter("@mess_ID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.mess_content;
			parameters[1].Value = model.mess_date;
			parameters[2].Value = model.mess_inpotance;
			parameters[3].Value = model.mess_valid;
			parameters[4].Value = model.mess_type;
			parameters[5].Value = model.mess_ID;

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
		public bool Delete(int mess_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_message ");
			strSql.Append(" where mess_ID=@mess_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@mess_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = mess_ID;

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
		public bool DeleteList(string mess_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_message ");
			strSql.Append(" where mess_ID in ("+mess_IDlist + ")  ");
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
		public WalleProject.Model.t_message GetModel(int mess_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select mess_ID,mess_content,mess_date,mess_inpotance,mess_valid,mess_type from t_message ");
			strSql.Append(" where mess_ID=@mess_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@mess_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = mess_ID;

			WalleProject.Model.t_message model=new WalleProject.Model.t_message();
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
		public WalleProject.Model.t_message DataRowToModel(DataRow row)
		{
			WalleProject.Model.t_message model=new WalleProject.Model.t_message();
			if (row != null)
			{
				if(row["mess_ID"]!=null && row["mess_ID"].ToString()!="")
				{
					model.mess_ID=int.Parse(row["mess_ID"].ToString());
				}
				if(row["mess_content"]!=null)
				{
					model.mess_content=row["mess_content"].ToString();
				}
				if(row["mess_date"]!=null && row["mess_date"].ToString()!="")
				{
					model.mess_date=DateTime.Parse(row["mess_date"].ToString());
				}
				if(row["mess_inpotance"]!=null && row["mess_inpotance"].ToString()!="")
				{
					model.mess_inpotance=int.Parse(row["mess_inpotance"].ToString());
				}
				if(row["mess_valid"]!=null)
				{
					model.mess_valid=row["mess_valid"].ToString();
				}
				if(row["mess_type"]!=null)
				{
					model.mess_type=row["mess_type"].ToString();
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
			strSql.Append("select mess_ID,mess_content,mess_date,mess_inpotance,mess_valid,mess_type ");
			strSql.Append(" FROM t_message ");
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
			strSql.Append("select count(1) FROM t_message ");
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
				strSql.Append("order by T.mess_ID desc");
			}
			strSql.Append(")AS Row, T.*  from t_message T ");
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
			parameters[0].Value = "t_message";
			parameters[1].Value = "mess_ID";
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

