using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WalleProject.DAL
{
	/// <summary>
	/// 数据访问类:t_integratingrecord
	/// </summary>
	public partial class t_integratingrecord
	{
		public t_integratingrecord()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("int_ID", "t_integratingrecord"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int int_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_integratingrecord");
			strSql.Append(" where int_ID=@int_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@int_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = int_ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WalleProject.Model.t_integratingrecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_integratingrecord(");
			strSql.Append("int_date,int_integral,int_way,int_u_ID)");
			strSql.Append(" values (");
			strSql.Append("@int_date,@int_integral,@int_way,@int_u_ID)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@int_date", MySqlDbType.DateTime),
					new MySqlParameter("@int_integral", MySqlDbType.Int32,10),
					new MySqlParameter("@int_way", MySqlDbType.VarChar,10),
					new MySqlParameter("@int_u_ID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.int_date;
			parameters[1].Value = model.int_integral;
			parameters[2].Value = model.int_way;
			parameters[3].Value = model.int_u_ID;

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
		public bool Update(WalleProject.Model.t_integratingrecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_integratingrecord set ");
			strSql.Append("int_date=@int_date,");
			strSql.Append("int_integral=@int_integral,");
			strSql.Append("int_way=@int_way,");
			strSql.Append("int_u_ID=@int_u_ID");
			strSql.Append(" where int_ID=@int_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@int_date", MySqlDbType.DateTime),
					new MySqlParameter("@int_integral", MySqlDbType.Int32,10),
					new MySqlParameter("@int_way", MySqlDbType.VarChar,10),
					new MySqlParameter("@int_u_ID", MySqlDbType.Int32,10),
					new MySqlParameter("@int_ID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.int_date;
			parameters[1].Value = model.int_integral;
			parameters[2].Value = model.int_way;
			parameters[3].Value = model.int_u_ID;
			parameters[4].Value = model.int_ID;

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
		public bool Delete(int int_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_integratingrecord ");
			strSql.Append(" where int_ID=@int_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@int_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = int_ID;

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
		public bool DeleteList(string int_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_integratingrecord ");
			strSql.Append(" where int_ID in ("+int_IDlist + ")  ");
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
		public WalleProject.Model.t_integratingrecord GetModel(int int_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select int_ID,int_date,int_integral,int_way,int_u_ID from t_integratingrecord ");
			strSql.Append(" where int_ID=@int_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@int_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = int_ID;

			WalleProject.Model.t_integratingrecord model=new WalleProject.Model.t_integratingrecord();
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
		public WalleProject.Model.t_integratingrecord DataRowToModel(DataRow row)
		{
			WalleProject.Model.t_integratingrecord model=new WalleProject.Model.t_integratingrecord();
			if (row != null)
			{
				if(row["int_ID"]!=null && row["int_ID"].ToString()!="")
				{
					model.int_ID=int.Parse(row["int_ID"].ToString());
				}
				if(row["int_date"]!=null && row["int_date"].ToString()!="")
				{
					model.int_date=DateTime.Parse(row["int_date"].ToString());
				}
				if(row["int_integral"]!=null && row["int_integral"].ToString()!="")
				{
					model.int_integral=int.Parse(row["int_integral"].ToString());
				}
				if(row["int_way"]!=null)
				{
					model.int_way=row["int_way"].ToString();
				}
				if(row["int_u_ID"]!=null && row["int_u_ID"].ToString()!="")
				{
					model.int_u_ID=int.Parse(row["int_u_ID"].ToString());
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
			strSql.Append("select int_ID,int_date,int_integral,int_way,int_u_ID ");
			strSql.Append(" FROM t_integratingrecord ");
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
			strSql.Append("select count(1) FROM t_integratingrecord ");
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
				strSql.Append("order by T.int_ID desc");
			}
			strSql.Append(")AS Row, T.*  from t_integratingrecord T ");
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
			parameters[0].Value = "t_integratingrecord";
			parameters[1].Value = "int_ID";
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

