using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WalleProject.DAL
{
	/// <summary>
	/// 数据访问类:t_menu
	/// </summary>
	public partial class t_menu
	{
		public t_menu()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("menu_ID", "t_menu"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int menu_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_menu");
			strSql.Append(" where menu_ID=@menu_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@menu_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = menu_ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WalleProject.Model.t_menu model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_menu(");
			strSql.Append("menu_Cate_ID,menu_name,menu_sort,menu_path,menu_valid)");
			strSql.Append(" values (");
			strSql.Append("@menu_Cate_ID,@menu_name,@menu_sort,@menu_path,@menu_valid)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@menu_Cate_ID", MySqlDbType.Int32,10),
					new MySqlParameter("@menu_name", MySqlDbType.VarChar,10),
					new MySqlParameter("@menu_sort", MySqlDbType.Int32,10),
					new MySqlParameter("@menu_path", MySqlDbType.VarChar,50),
					new MySqlParameter("@menu_valid", MySqlDbType.VarChar,2)};
			parameters[0].Value = model.menu_Cate_ID;
			parameters[1].Value = model.menu_name;
			parameters[2].Value = model.menu_sort;
			parameters[3].Value = model.menu_path;
			parameters[4].Value = model.menu_valid;

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
		public bool Update(WalleProject.Model.t_menu model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_menu set ");
			strSql.Append("menu_Cate_ID=@menu_Cate_ID,");
			strSql.Append("menu_name=@menu_name,");
			strSql.Append("menu_sort=@menu_sort,");
			strSql.Append("menu_path=@menu_path,");
			strSql.Append("menu_valid=@menu_valid");
			strSql.Append(" where menu_ID=@menu_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@menu_Cate_ID", MySqlDbType.Int32,10),
					new MySqlParameter("@menu_name", MySqlDbType.VarChar,10),
					new MySqlParameter("@menu_sort", MySqlDbType.Int32,10),
					new MySqlParameter("@menu_path", MySqlDbType.VarChar,50),
					new MySqlParameter("@menu_valid", MySqlDbType.VarChar,2),
					new MySqlParameter("@menu_ID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.menu_Cate_ID;
			parameters[1].Value = model.menu_name;
			parameters[2].Value = model.menu_sort;
			parameters[3].Value = model.menu_path;
			parameters[4].Value = model.menu_valid;
			parameters[5].Value = model.menu_ID;

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
		public bool Delete(int menu_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_menu ");
			strSql.Append(" where menu_ID=@menu_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@menu_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = menu_ID;

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
		public bool DeleteList(string menu_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_menu ");
			strSql.Append(" where menu_ID in ("+menu_IDlist + ")  ");
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
		public WalleProject.Model.t_menu GetModel(int menu_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select menu_ID,menu_Cate_ID,menu_name,menu_sort,menu_path,menu_valid from t_menu ");
			strSql.Append(" where menu_ID=@menu_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@menu_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = menu_ID;

			WalleProject.Model.t_menu model=new WalleProject.Model.t_menu();
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
		public WalleProject.Model.t_menu DataRowToModel(DataRow row)
		{
			WalleProject.Model.t_menu model=new WalleProject.Model.t_menu();
			if (row != null)
			{
				if(row["menu_ID"]!=null && row["menu_ID"].ToString()!="")
				{
					model.menu_ID=int.Parse(row["menu_ID"].ToString());
				}
				if(row["menu_Cate_ID"]!=null && row["menu_Cate_ID"].ToString()!="")
				{
					model.menu_Cate_ID=int.Parse(row["menu_Cate_ID"].ToString());
				}
				if(row["menu_name"]!=null)
				{
					model.menu_name=row["menu_name"].ToString();
				}
				if(row["menu_sort"]!=null && row["menu_sort"].ToString()!="")
				{
					model.menu_sort=int.Parse(row["menu_sort"].ToString());
				}
				if(row["menu_path"]!=null)
				{
					model.menu_path=row["menu_path"].ToString();
				}
				if(row["menu_valid"]!=null)
				{
					model.menu_valid=row["menu_valid"].ToString();
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
			strSql.Append("select menu_ID,menu_Cate_ID,menu_name,menu_sort,menu_path,menu_valid ");
			strSql.Append(" FROM t_menu ");
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
			strSql.Append("select count(1) FROM t_menu ");
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
				strSql.Append("order by T.menu_ID desc");
			}
			strSql.Append(")AS Row, T.*  from t_menu T ");
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
			parameters[0].Value = "t_menu";
			parameters[1].Value = "menu_ID";
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

