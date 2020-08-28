using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WalleProject.DAL
{
	/// <summary>
	/// 数据访问类:t_systemleave
	/// </summary>
	public partial class t_systemleave
	{
		public t_systemleave()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("sl_id", "t_systemleave"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int sl_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_systemleave");
			strSql.Append(" where sl_id=@sl_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@sl_id", MySqlDbType.Int32)
			};
			parameters[0].Value = sl_id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WalleProject.Model.t_systemleave model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_systemleave(");
			strSql.Append("sl_sort,sl_valid,sl_content,sl_pic_id,sl_per_id,sl_per_type,sl_date)");
			strSql.Append(" values (");
			strSql.Append("@sl_sort,@sl_valid,@sl_content,@sl_pic_id,@sl_per_id,@sl_per_type,@sl_date)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@sl_sort", MySqlDbType.Int32,10),
					new MySqlParameter("@sl_valid", MySqlDbType.VarChar,20),
					new MySqlParameter("@sl_content", MySqlDbType.Text),
					new MySqlParameter("@sl_pic_id", MySqlDbType.Int32,10),
					new MySqlParameter("@sl_per_id", MySqlDbType.Int32,10),
					new MySqlParameter("@sl_per_type", MySqlDbType.Int32,10),
					new MySqlParameter("@sl_date", MySqlDbType.DateTime)};
			parameters[0].Value = model.sl_sort;
			parameters[1].Value = model.sl_valid;
			parameters[2].Value = model.sl_content;
			parameters[3].Value = model.sl_pic_id;
			parameters[4].Value = model.sl_per_id;
			parameters[5].Value = model.sl_per_type;
			parameters[6].Value = model.sl_date;

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
		public bool Update(WalleProject.Model.t_systemleave model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_systemleave set ");
			strSql.Append("sl_sort=@sl_sort,");
			strSql.Append("sl_valid=@sl_valid,");
			strSql.Append("sl_content=@sl_content,");
			strSql.Append("sl_pic_id=@sl_pic_id,");
			strSql.Append("sl_per_id=@sl_per_id,");
			strSql.Append("sl_per_type=@sl_per_type,");
			strSql.Append("sl_date=@sl_date");
			strSql.Append(" where sl_id=@sl_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@sl_sort", MySqlDbType.Int32,10),
					new MySqlParameter("@sl_valid", MySqlDbType.VarChar,20),
					new MySqlParameter("@sl_content", MySqlDbType.Text),
					new MySqlParameter("@sl_pic_id", MySqlDbType.Int32,10),
					new MySqlParameter("@sl_per_id", MySqlDbType.Int32,10),
					new MySqlParameter("@sl_per_type", MySqlDbType.Int32,10),
					new MySqlParameter("@sl_date", MySqlDbType.DateTime),
					new MySqlParameter("@sl_id", MySqlDbType.Int32,10)};
			parameters[0].Value = model.sl_sort;
			parameters[1].Value = model.sl_valid;
			parameters[2].Value = model.sl_content;
			parameters[3].Value = model.sl_pic_id;
			parameters[4].Value = model.sl_per_id;
			parameters[5].Value = model.sl_per_type;
			parameters[6].Value = model.sl_date;
			parameters[7].Value = model.sl_id;

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
		public bool Delete(int sl_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_systemleave ");
			strSql.Append(" where sl_id=@sl_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@sl_id", MySqlDbType.Int32)
			};
			parameters[0].Value = sl_id;

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
		public bool DeleteList(string sl_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_systemleave ");
			strSql.Append(" where sl_id in ("+sl_idlist + ")  ");
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
		public WalleProject.Model.t_systemleave GetModel(int sl_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select sl_sort,sl_valid,sl_content,sl_pic_id,sl_per_id,sl_id,sl_per_type,sl_date from t_systemleave ");
			strSql.Append(" where sl_id=@sl_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@sl_id", MySqlDbType.Int32)
			};
			parameters[0].Value = sl_id;

			WalleProject.Model.t_systemleave model=new WalleProject.Model.t_systemleave();
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
		public WalleProject.Model.t_systemleave DataRowToModel(DataRow row)
		{
			WalleProject.Model.t_systemleave model=new WalleProject.Model.t_systemleave();
			if (row != null)
			{
				if(row["sl_sort"]!=null && row["sl_sort"].ToString()!="")
				{
					model.sl_sort=int.Parse(row["sl_sort"].ToString());
				}
				if(row["sl_valid"]!=null)
				{
					model.sl_valid=row["sl_valid"].ToString();
				}
				if(row["sl_content"]!=null)
				{
					model.sl_content=row["sl_content"].ToString();
				}
				if(row["sl_pic_id"]!=null && row["sl_pic_id"].ToString()!="")
				{
					model.sl_pic_id=int.Parse(row["sl_pic_id"].ToString());
				}
				if(row["sl_per_id"]!=null && row["sl_per_id"].ToString()!="")
				{
					model.sl_per_id=int.Parse(row["sl_per_id"].ToString());
				}
				if(row["sl_id"]!=null && row["sl_id"].ToString()!="")
				{
					model.sl_id=int.Parse(row["sl_id"].ToString());
				}
				if(row["sl_per_type"]!=null && row["sl_per_type"].ToString()!="")
				{
					model.sl_per_type=int.Parse(row["sl_per_type"].ToString());
				}
				if(row["sl_date"]!=null && row["sl_date"].ToString()!="")
				{
					model.sl_date=DateTime.Parse(row["sl_date"].ToString());
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
			strSql.Append("select sl_sort,sl_valid,sl_content,sl_pic_id,sl_per_id,sl_id,sl_per_type,sl_date ");
			strSql.Append(" FROM t_systemleave ");
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
			strSql.Append("select count(1) FROM t_systemleave ");
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
				strSql.Append("order by T.sl_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_systemleave T ");
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
			parameters[0].Value = "t_systemleave";
			parameters[1].Value = "sl_id";
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

