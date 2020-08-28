using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WalleProject.DAL
{
	/// <summary>
	/// 数据访问类:t_systeminterchange
	/// </summary>
	public partial class t_systeminterchange
	{
		public t_systeminterchange()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("si_id", "t_systeminterchange"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int si_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_systeminterchange");
			strSql.Append(" where si_id=@si_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@si_id", MySqlDbType.Int32)
			};
			parameters[0].Value = si_id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WalleProject.Model.t_systeminterchange model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_systeminterchange(");
			strSql.Append("si_sort,si_vaild,si_date,si_content,si_per_type,si_pic_id,si_per_id,si_sl_id)");
			strSql.Append(" values (");
			strSql.Append("@si_sort,@si_vaild,@si_date,@si_content,@si_per_type,@si_pic_id,@si_per_id,@si_sl_id)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@si_sort", MySqlDbType.Int32,10),
					new MySqlParameter("@si_vaild", MySqlDbType.VarChar,20),
					new MySqlParameter("@si_date", MySqlDbType.DateTime),
					new MySqlParameter("@si_content", MySqlDbType.Text),
					new MySqlParameter("@si_per_type", MySqlDbType.VarChar,20),
					new MySqlParameter("@si_pic_id", MySqlDbType.Int32,10),
					new MySqlParameter("@si_per_id", MySqlDbType.Int32,10),
					new MySqlParameter("@si_sl_id", MySqlDbType.Int32,10)};
			parameters[0].Value = model.si_sort;
			parameters[1].Value = model.si_vaild;
			parameters[2].Value = model.si_date;
			parameters[3].Value = model.si_content;
			parameters[4].Value = model.si_per_type;
			parameters[5].Value = model.si_pic_id;
			parameters[6].Value = model.si_per_id;
			parameters[7].Value = model.si_sl_id;

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
		public bool Update(WalleProject.Model.t_systeminterchange model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_systeminterchange set ");
			strSql.Append("si_sort=@si_sort,");
			strSql.Append("si_vaild=@si_vaild,");
			strSql.Append("si_date=@si_date,");
			strSql.Append("si_content=@si_content,");
			strSql.Append("si_per_type=@si_per_type,");
			strSql.Append("si_pic_id=@si_pic_id,");
			strSql.Append("si_per_id=@si_per_id,");
			strSql.Append("si_sl_id=@si_sl_id");
			strSql.Append(" where si_id=@si_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@si_sort", MySqlDbType.Int32,10),
					new MySqlParameter("@si_vaild", MySqlDbType.VarChar,20),
					new MySqlParameter("@si_date", MySqlDbType.DateTime),
					new MySqlParameter("@si_content", MySqlDbType.Text),
					new MySqlParameter("@si_per_type", MySqlDbType.VarChar,20),
					new MySqlParameter("@si_pic_id", MySqlDbType.Int32,10),
					new MySqlParameter("@si_per_id", MySqlDbType.Int32,10),
					new MySqlParameter("@si_sl_id", MySqlDbType.Int32,10),
					new MySqlParameter("@si_id", MySqlDbType.Int32,10)};
			parameters[0].Value = model.si_sort;
			parameters[1].Value = model.si_vaild;
			parameters[2].Value = model.si_date;
			parameters[3].Value = model.si_content;
			parameters[4].Value = model.si_per_type;
			parameters[5].Value = model.si_pic_id;
			parameters[6].Value = model.si_per_id;
			parameters[7].Value = model.si_sl_id;
			parameters[8].Value = model.si_id;

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
		public bool Delete(int si_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_systeminterchange ");
			strSql.Append(" where si_id=@si_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@si_id", MySqlDbType.Int32)
			};
			parameters[0].Value = si_id;

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
		public bool DeleteList(string si_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_systeminterchange ");
			strSql.Append(" where si_id in ("+si_idlist + ")  ");
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
		public WalleProject.Model.t_systeminterchange GetModel(int si_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select si_sort,si_vaild,si_date,si_content,si_per_type,si_pic_id,si_per_id,si_sl_id,si_id from t_systeminterchange ");
			strSql.Append(" where si_id=@si_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@si_id", MySqlDbType.Int32)
			};
			parameters[0].Value = si_id;

			WalleProject.Model.t_systeminterchange model=new WalleProject.Model.t_systeminterchange();
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
		public WalleProject.Model.t_systeminterchange DataRowToModel(DataRow row)
		{
			WalleProject.Model.t_systeminterchange model=new WalleProject.Model.t_systeminterchange();
			if (row != null)
			{
				if(row["si_sort"]!=null && row["si_sort"].ToString()!="")
				{
					model.si_sort=int.Parse(row["si_sort"].ToString());
				}
				if(row["si_vaild"]!=null)
				{
					model.si_vaild=row["si_vaild"].ToString();
				}
				if(row["si_date"]!=null && row["si_date"].ToString()!="")
				{
					model.si_date=DateTime.Parse(row["si_date"].ToString());
				}
				if(row["si_content"]!=null)
				{
					model.si_content=row["si_content"].ToString();
				}
				if(row["si_per_type"]!=null)
				{
					model.si_per_type=row["si_per_type"].ToString();
				}
				if(row["si_pic_id"]!=null && row["si_pic_id"].ToString()!="")
				{
					model.si_pic_id=int.Parse(row["si_pic_id"].ToString());
				}
				if(row["si_per_id"]!=null && row["si_per_id"].ToString()!="")
				{
					model.si_per_id=int.Parse(row["si_per_id"].ToString());
				}
				if(row["si_sl_id"]!=null && row["si_sl_id"].ToString()!="")
				{
					model.si_sl_id=int.Parse(row["si_sl_id"].ToString());
				}
				if(row["si_id"]!=null && row["si_id"].ToString()!="")
				{
					model.si_id=int.Parse(row["si_id"].ToString());
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
			strSql.Append("select si_sort,si_vaild,si_date,si_content,si_per_type,si_pic_id,si_per_id,si_sl_id,si_id ");
			strSql.Append(" FROM t_systeminterchange ");
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
			strSql.Append("select count(1) FROM t_systeminterchange ");
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
				strSql.Append("order by T.si_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_systeminterchange T ");
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
			parameters[0].Value = "t_systeminterchange";
			parameters[1].Value = "si_id";
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

