using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WalleProject.DAL
{
	/// <summary>
	/// 数据访问类:t_pricerecord
	/// </summary>
	public partial class t_pricerecord
	{
		public t_pricerecord()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("pri_ID", "t_pricerecord"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int pri_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_pricerecord");
			strSql.Append(" where pri_ID=@pri_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@pri_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = pri_ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WalleProject.Model.t_pricerecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_pricerecord(");
			strSql.Append("pri_date,pri_price,pri_com_ID)");
			strSql.Append(" values (");
			strSql.Append("@pri_date,@pri_price,@pri_com_ID)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@pri_date", MySqlDbType.Date),
					new MySqlParameter("@pri_price", MySqlDbType.Decimal,10),
					new MySqlParameter("@pri_com_ID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.pri_date;
			parameters[1].Value = model.pri_price;
			parameters[2].Value = model.pri_com_ID;

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
		public bool Update(WalleProject.Model.t_pricerecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_pricerecord set ");
			strSql.Append("pri_date=@pri_date,");
			strSql.Append("pri_price=@pri_price,");
			strSql.Append("pri_com_ID=@pri_com_ID");
			strSql.Append(" where pri_ID=@pri_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@pri_date", MySqlDbType.Date),
					new MySqlParameter("@pri_price", MySqlDbType.Decimal,10),
					new MySqlParameter("@pri_com_ID", MySqlDbType.Int32,10),
					new MySqlParameter("@pri_ID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.pri_date;
			parameters[1].Value = model.pri_price;
			parameters[2].Value = model.pri_com_ID;
			parameters[3].Value = model.pri_ID;

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
		public bool Delete(int pri_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_pricerecord ");
			strSql.Append(" where pri_ID=@pri_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@pri_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = pri_ID;

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
		public bool DeleteList(string pri_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_pricerecord ");
			strSql.Append(" where pri_ID in ("+pri_IDlist + ")  ");
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
		public WalleProject.Model.t_pricerecord GetModel(int pri_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select pri_date,pri_price,pri_com_ID,pri_ID from t_pricerecord ");
			strSql.Append(" where pri_ID=@pri_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@pri_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = pri_ID;

			WalleProject.Model.t_pricerecord model=new WalleProject.Model.t_pricerecord();
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
		public WalleProject.Model.t_pricerecord DataRowToModel(DataRow row)
		{
			WalleProject.Model.t_pricerecord model=new WalleProject.Model.t_pricerecord();
			if (row != null)
			{
				if(row["pri_date"]!=null && row["pri_date"].ToString()!="")
				{
					model.pri_date=DateTime.Parse(row["pri_date"].ToString());
				}
				if(row["pri_price"]!=null && row["pri_price"].ToString()!="")
				{
					model.pri_price=decimal.Parse(row["pri_price"].ToString());
				}
				if(row["pri_com_ID"]!=null && row["pri_com_ID"].ToString()!="")
				{
					model.pri_com_ID=int.Parse(row["pri_com_ID"].ToString());
				}
				if(row["pri_ID"]!=null && row["pri_ID"].ToString()!="")
				{
					model.pri_ID=int.Parse(row["pri_ID"].ToString());
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
			strSql.Append("select pri_date,pri_price,pri_com_ID,pri_ID ");
			strSql.Append(" FROM t_pricerecord ");
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
			strSql.Append("select count(1) FROM t_pricerecord ");
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
				strSql.Append("order by T.pri_ID desc");
			}
			strSql.Append(")AS Row, T.*  from t_pricerecord T ");
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
			parameters[0].Value = "t_pricerecord";
			parameters[1].Value = "pri_ID";
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

