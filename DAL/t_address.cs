using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WalleProject.DAL
{
	/// <summary>
	/// 数据访问类:t_address
	/// </summary>
	public partial class t_address
	{
		public t_address()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("add_ID", "t_address"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int add_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_address");
			strSql.Append(" where add_ID=@add_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@add_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = add_ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WalleProject.Model.t_address model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_address(");
			strSql.Append("add_u_ID,add_contactName,add_contactPhone,add_date,add_postcode,add_default,add_address,add_counties,add_city,add_province)");
			strSql.Append(" values (");
			strSql.Append("@add_u_ID,@add_contactName,@add_contactPhone,@add_date,@add_postcode,@add_default,@add_address,@add_counties,@add_city,@add_province)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@add_u_ID", MySqlDbType.Int32,10),
					new MySqlParameter("@add_contactName", MySqlDbType.VarChar,10),
					new MySqlParameter("@add_contactPhone", MySqlDbType.VarChar,20),
					new MySqlParameter("@add_date", MySqlDbType.DateTime),
					new MySqlParameter("@add_postcode", MySqlDbType.Int32,10),
					new MySqlParameter("@add_default", MySqlDbType.VarChar,2),
					new MySqlParameter("@add_address", MySqlDbType.VarChar,20),
					new MySqlParameter("@add_counties", MySqlDbType.VarChar,10),
					new MySqlParameter("@add_city", MySqlDbType.VarChar,10),
					new MySqlParameter("@add_province", MySqlDbType.VarChar,10)};
			parameters[0].Value = model.add_u_ID;
			parameters[1].Value = model.add_contactName;
			parameters[2].Value = model.add_contactPhone;
			parameters[3].Value = model.add_date;
			parameters[4].Value = model.add_postcode;
			parameters[5].Value = model.add_default;
			parameters[6].Value = model.add_address;
			parameters[7].Value = model.add_counties;
			parameters[8].Value = model.add_city;
			parameters[9].Value = model.add_province;

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
		public bool Update(WalleProject.Model.t_address model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_address set ");
			strSql.Append("add_u_ID=@add_u_ID,");
			strSql.Append("add_contactName=@add_contactName,");
			strSql.Append("add_contactPhone=@add_contactPhone,");
			strSql.Append("add_date=@add_date,");
			strSql.Append("add_postcode=@add_postcode,");
			strSql.Append("add_default=@add_default,");
			strSql.Append("add_address=@add_address,");
			strSql.Append("add_counties=@add_counties,");
			strSql.Append("add_city=@add_city,");
			strSql.Append("add_province=@add_province");
			strSql.Append(" where add_ID=@add_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@add_u_ID", MySqlDbType.Int32,10),
					new MySqlParameter("@add_contactName", MySqlDbType.VarChar,10),
					new MySqlParameter("@add_contactPhone", MySqlDbType.VarChar,20),
					new MySqlParameter("@add_date", MySqlDbType.DateTime),
					new MySqlParameter("@add_postcode", MySqlDbType.Int32,10),
					new MySqlParameter("@add_default", MySqlDbType.VarChar,2),
					new MySqlParameter("@add_address", MySqlDbType.VarChar,20),
					new MySqlParameter("@add_counties", MySqlDbType.VarChar,10),
					new MySqlParameter("@add_city", MySqlDbType.VarChar,10),
					new MySqlParameter("@add_province", MySqlDbType.VarChar,10),
					new MySqlParameter("@add_ID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.add_u_ID;
			parameters[1].Value = model.add_contactName;
			parameters[2].Value = model.add_contactPhone;
			parameters[3].Value = model.add_date;
			parameters[4].Value = model.add_postcode;
			parameters[5].Value = model.add_default;
			parameters[6].Value = model.add_address;
			parameters[7].Value = model.add_counties;
			parameters[8].Value = model.add_city;
			parameters[9].Value = model.add_province;
			parameters[10].Value = model.add_ID;

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
		public bool Delete(int add_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_address ");
			strSql.Append(" where add_ID=@add_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@add_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = add_ID;

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
		public bool DeleteList(string add_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_address ");
			strSql.Append(" where add_ID in ("+add_IDlist + ")  ");
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
		public WalleProject.Model.t_address GetModel(int add_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select add_u_ID,add_contactName,add_contactPhone,add_date,add_postcode,add_default,add_address,add_counties,add_city,add_province,add_ID from t_address ");
			strSql.Append(" where add_ID=@add_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@add_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = add_ID;

			WalleProject.Model.t_address model=new WalleProject.Model.t_address();
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
		public WalleProject.Model.t_address DataRowToModel(DataRow row)
		{
			WalleProject.Model.t_address model=new WalleProject.Model.t_address();
			if (row != null)
			{
				if(row["add_u_ID"]!=null && row["add_u_ID"].ToString()!="")
				{
					model.add_u_ID=int.Parse(row["add_u_ID"].ToString());
				}
				if(row["add_contactName"]!=null)
				{
					model.add_contactName=row["add_contactName"].ToString();
				}
				if(row["add_contactPhone"]!=null)
				{
					model.add_contactPhone=row["add_contactPhone"].ToString();
				}
				if(row["add_date"]!=null && row["add_date"].ToString()!="")
				{
					model.add_date=DateTime.Parse(row["add_date"].ToString());
				}
				if(row["add_postcode"]!=null && row["add_postcode"].ToString()!="")
				{
					model.add_postcode=int.Parse(row["add_postcode"].ToString());
				}
				if(row["add_default"]!=null)
				{
					model.add_default=row["add_default"].ToString();
				}
				if(row["add_address"]!=null)
				{
					model.add_address=row["add_address"].ToString();
				}
				if(row["add_counties"]!=null)
				{
					model.add_counties=row["add_counties"].ToString();
				}
				if(row["add_city"]!=null)
				{
					model.add_city=row["add_city"].ToString();
				}
				if(row["add_province"]!=null)
				{
					model.add_province=row["add_province"].ToString();
				}
				if(row["add_ID"]!=null && row["add_ID"].ToString()!="")
				{
					model.add_ID=int.Parse(row["add_ID"].ToString());
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
			strSql.Append("select add_u_ID,add_contactName,add_contactPhone,add_date,add_postcode,add_default,add_address,add_counties,add_city,add_province,add_ID ");
			strSql.Append(" FROM t_address ");
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
			strSql.Append("select count(1) FROM t_address ");
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
				strSql.Append("order by T.add_ID desc");
			}
			strSql.Append(")AS Row, T.*  from t_address T ");
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
			parameters[0].Value = "t_address";
			parameters[1].Value = "add_ID";
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

