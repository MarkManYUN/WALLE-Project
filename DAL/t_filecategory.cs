using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WalleProject.DAL
{
	/// <summary>
	/// 数据访问类:t_filecategory
	/// </summary>
	public partial class t_filecategory
	{
		public t_filecategory()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("filec_ID", "t_filecategory"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int filec_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_filecategory");
			strSql.Append(" where filec_ID=@filec_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@filec_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = filec_ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WalleProject.Model.t_filecategory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_filecategory(");
			strSql.Append("filec_name,filec_path,file_ext)");
			strSql.Append(" values (");
			strSql.Append("@filec_name,@filec_path,@file_ext)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@filec_name", MySqlDbType.VarChar,10),
					new MySqlParameter("@filec_path", MySqlDbType.VarChar,50),
					new MySqlParameter("@file_ext", MySqlDbType.VarChar,50)};
			parameters[0].Value = model.filec_name;
			parameters[1].Value = model.filec_path;
			parameters[2].Value = model.file_ext;

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
		public bool Update(WalleProject.Model.t_filecategory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_filecategory set ");
			strSql.Append("filec_name=@filec_name,");
			strSql.Append("filec_path=@filec_path,");
			strSql.Append("file_ext=@file_ext");
			strSql.Append(" where filec_ID=@filec_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@filec_name", MySqlDbType.VarChar,10),
					new MySqlParameter("@filec_path", MySqlDbType.VarChar,50),
					new MySqlParameter("@file_ext", MySqlDbType.VarChar,50),
					new MySqlParameter("@filec_ID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.filec_name;
			parameters[1].Value = model.filec_path;
			parameters[2].Value = model.file_ext;
			parameters[3].Value = model.filec_ID;

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
		public bool Delete(int filec_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_filecategory ");
			strSql.Append(" where filec_ID=@filec_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@filec_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = filec_ID;

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
		public bool DeleteList(string filec_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_filecategory ");
			strSql.Append(" where filec_ID in ("+filec_IDlist + ")  ");
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
		public WalleProject.Model.t_filecategory GetModel(int filec_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select filec_ID,filec_name,filec_path,file_ext from t_filecategory ");
			strSql.Append(" where filec_ID=@filec_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@filec_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = filec_ID;

			WalleProject.Model.t_filecategory model=new WalleProject.Model.t_filecategory();
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
		public WalleProject.Model.t_filecategory DataRowToModel(DataRow row)
		{
			WalleProject.Model.t_filecategory model=new WalleProject.Model.t_filecategory();
			if (row != null)
			{
				if(row["filec_ID"]!=null && row["filec_ID"].ToString()!="")
				{
					model.filec_ID=int.Parse(row["filec_ID"].ToString());
				}
				if(row["filec_name"]!=null)
				{
					model.filec_name=row["filec_name"].ToString();
				}
				if(row["filec_path"]!=null)
				{
					model.filec_path=row["filec_path"].ToString();
				}
				if(row["file_ext"]!=null)
				{
					model.file_ext=row["file_ext"].ToString();
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
			strSql.Append("select filec_ID,filec_name,filec_path,file_ext ");
			strSql.Append(" FROM t_filecategory ");
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
			strSql.Append("select count(1) FROM t_filecategory ");
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
				strSql.Append("order by T.filec_ID desc");
			}
			strSql.Append(")AS Row, T.*  from t_filecategory T ");
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
			parameters[0].Value = "t_filecategory";
			parameters[1].Value = "filec_ID";
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

