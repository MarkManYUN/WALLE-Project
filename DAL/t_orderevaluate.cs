using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WalleProject.DAL
{
	/// <summary>
	/// 数据访问类:t_orderevaluate
	/// </summary>
	public partial class t_orderevaluate
	{
		public t_orderevaluate()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("oe_id", "t_orderevaluate"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int oe_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_orderevaluate");
			strSql.Append(" where oe_id=@oe_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@oe_id", MySqlDbType.Int32)
			};
			parameters[0].Value = oe_id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WalleProject.Model.t_orderevaluate model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_orderevaluate(");
			strSql.Append("oe_sort,oe_vaild,oe_grade,oe_isread,oe_per_type,oe_content,oe_tra_id,oe_per_id,oe_pic_id,oe_date)");
			strSql.Append(" values (");
			strSql.Append("@oe_sort,@oe_vaild,@oe_grade,@oe_isread,@oe_per_type,@oe_content,@oe_tra_id,@oe_per_id,@oe_pic_id,@oe_date)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@oe_sort", MySqlDbType.Int32,10),
					new MySqlParameter("@oe_vaild", MySqlDbType.VarChar,20),
					new MySqlParameter("@oe_grade", MySqlDbType.Int32,10),
					new MySqlParameter("@oe_isread", MySqlDbType.VarChar,10),
					new MySqlParameter("@oe_per_type", MySqlDbType.VarChar,20),
					new MySqlParameter("@oe_content", MySqlDbType.Text),
					new MySqlParameter("@oe_tra_id", MySqlDbType.Int32,10),
					new MySqlParameter("@oe_per_id", MySqlDbType.Int32,10),
					new MySqlParameter("@oe_pic_id", MySqlDbType.Int32,10),
					new MySqlParameter("@oe_date", MySqlDbType.DateTime)};
			parameters[0].Value = model.oe_sort;
			parameters[1].Value = model.oe_vaild;
			parameters[2].Value = model.oe_grade;
			parameters[3].Value = model.oe_isread;
			parameters[4].Value = model.oe_per_type;
			parameters[5].Value = model.oe_content;
			parameters[6].Value = model.oe_tra_id;
			parameters[7].Value = model.oe_per_id;
			parameters[8].Value = model.oe_pic_id;
			parameters[9].Value = model.oe_date;

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
		public bool Update(WalleProject.Model.t_orderevaluate model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_orderevaluate set ");
			strSql.Append("oe_sort=@oe_sort,");
			strSql.Append("oe_vaild=@oe_vaild,");
			strSql.Append("oe_grade=@oe_grade,");
			strSql.Append("oe_isread=@oe_isread,");
			strSql.Append("oe_per_type=@oe_per_type,");
			strSql.Append("oe_content=@oe_content,");
			strSql.Append("oe_tra_id=@oe_tra_id,");
			strSql.Append("oe_per_id=@oe_per_id,");
			strSql.Append("oe_pic_id=@oe_pic_id,");
			strSql.Append("oe_date=@oe_date");
			strSql.Append(" where oe_id=@oe_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@oe_sort", MySqlDbType.Int32,10),
					new MySqlParameter("@oe_vaild", MySqlDbType.VarChar,20),
					new MySqlParameter("@oe_grade", MySqlDbType.Int32,10),
					new MySqlParameter("@oe_isread", MySqlDbType.VarChar,10),
					new MySqlParameter("@oe_per_type", MySqlDbType.VarChar,20),
					new MySqlParameter("@oe_content", MySqlDbType.Text),
					new MySqlParameter("@oe_tra_id", MySqlDbType.Int32,10),
					new MySqlParameter("@oe_per_id", MySqlDbType.Int32,10),
					new MySqlParameter("@oe_pic_id", MySqlDbType.Int32,10),
					new MySqlParameter("@oe_date", MySqlDbType.DateTime),
					new MySqlParameter("@oe_id", MySqlDbType.Int32,10)};
			parameters[0].Value = model.oe_sort;
			parameters[1].Value = model.oe_vaild;
			parameters[2].Value = model.oe_grade;
			parameters[3].Value = model.oe_isread;
			parameters[4].Value = model.oe_per_type;
			parameters[5].Value = model.oe_content;
			parameters[6].Value = model.oe_tra_id;
			parameters[7].Value = model.oe_per_id;
			parameters[8].Value = model.oe_pic_id;
			parameters[9].Value = model.oe_date;
			parameters[10].Value = model.oe_id;

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
		public bool Delete(int oe_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_orderevaluate ");
			strSql.Append(" where oe_id=@oe_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@oe_id", MySqlDbType.Int32)
			};
			parameters[0].Value = oe_id;

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
		public bool DeleteList(string oe_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_orderevaluate ");
			strSql.Append(" where oe_id in ("+oe_idlist + ")  ");
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
		public WalleProject.Model.t_orderevaluate GetModel(int oe_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select oe_sort,oe_vaild,oe_grade,oe_isread,oe_per_type,oe_content,oe_tra_id,oe_per_id,oe_pic_id,oe_id,oe_date from t_orderevaluate ");
			strSql.Append(" where oe_id=@oe_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@oe_id", MySqlDbType.Int32)
			};
			parameters[0].Value = oe_id;

			WalleProject.Model.t_orderevaluate model=new WalleProject.Model.t_orderevaluate();
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
		public WalleProject.Model.t_orderevaluate DataRowToModel(DataRow row)
		{
			WalleProject.Model.t_orderevaluate model=new WalleProject.Model.t_orderevaluate();
			if (row != null)
			{
				if(row["oe_sort"]!=null && row["oe_sort"].ToString()!="")
				{
					model.oe_sort=int.Parse(row["oe_sort"].ToString());
				}
				if(row["oe_vaild"]!=null)
				{
					model.oe_vaild=row["oe_vaild"].ToString();
				}
				if(row["oe_grade"]!=null && row["oe_grade"].ToString()!="")
				{
					model.oe_grade=int.Parse(row["oe_grade"].ToString());
				}
				if(row["oe_isread"]!=null)
				{
					model.oe_isread=row["oe_isread"].ToString();
				}
				if(row["oe_per_type"]!=null)
				{
					model.oe_per_type=row["oe_per_type"].ToString();
				}
				if(row["oe_content"]!=null)
				{
					model.oe_content=row["oe_content"].ToString();
				}
				if(row["oe_tra_id"]!=null && row["oe_tra_id"].ToString()!="")
				{
					model.oe_tra_id=int.Parse(row["oe_tra_id"].ToString());
				}
				if(row["oe_per_id"]!=null && row["oe_per_id"].ToString()!="")
				{
					model.oe_per_id=int.Parse(row["oe_per_id"].ToString());
				}
				if(row["oe_pic_id"]!=null && row["oe_pic_id"].ToString()!="")
				{
					model.oe_pic_id=int.Parse(row["oe_pic_id"].ToString());
				}
				if(row["oe_id"]!=null && row["oe_id"].ToString()!="")
				{
					model.oe_id=int.Parse(row["oe_id"].ToString());
				}
				if(row["oe_date"]!=null && row["oe_date"].ToString()!="")
				{
					model.oe_date=DateTime.Parse(row["oe_date"].ToString());
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
			strSql.Append("select oe_sort,oe_vaild,oe_grade,oe_isread,oe_per_type,oe_content,oe_tra_id,oe_per_id,oe_pic_id,oe_id,oe_date ");
			strSql.Append(" FROM t_orderevaluate ");
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
			strSql.Append("select count(1) FROM t_orderevaluate ");
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
				strSql.Append("order by T.oe_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_orderevaluate T ");
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
			parameters[0].Value = "t_orderevaluate";
			parameters[1].Value = "oe_id";
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

