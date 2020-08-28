using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WalleProject.DAL
{
	/// <summary>
	/// 数据访问类:t_tradingrecord
	/// </summary>
	public partial class t_tradingrecord
	{
		public t_tradingrecord()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("tra_ID", "t_tradingrecord"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int tra_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_tradingrecord");
			strSql.Append(" where tra_ID=@tra_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@tra_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = tra_ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WalleProject.Model.t_tradingrecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_tradingrecord(");
			strSql.Append("tra_U_ID,tra_transactionAmount,tra_transactionDate,tra_accomplish,tra_staff_id,sta_comwas_id,tra_number,tra_addressID,tra_type,tra_vaild,tra_sort)");
			strSql.Append(" values (");
			strSql.Append("@tra_U_ID,@tra_transactionAmount,@tra_transactionDate,@tra_accomplish,@tra_staff_id,@sta_comwas_id,@tra_number,@tra_addressID,@tra_type,@tra_vaild,@tra_sort)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@tra_U_ID", MySqlDbType.Int32,10),
					new MySqlParameter("@tra_transactionAmount", MySqlDbType.Decimal,10),
					new MySqlParameter("@tra_transactionDate", MySqlDbType.DateTime),
					new MySqlParameter("@tra_accomplish", MySqlDbType.VarChar,10),
					new MySqlParameter("@tra_staff_id", MySqlDbType.Int32,10),
					new MySqlParameter("@sta_comwas_id", MySqlDbType.Int32,10),
					new MySqlParameter("@tra_number", MySqlDbType.Int32,10),
					new MySqlParameter("@tra_addressID", MySqlDbType.Int32,10),
					new MySqlParameter("@tra_type", MySqlDbType.VarChar,10),
					new MySqlParameter("@tra_vaild", MySqlDbType.VarChar,10),
					new MySqlParameter("@tra_sort", MySqlDbType.Int32,10)};
			parameters[0].Value = model.tra_U_ID;
			parameters[1].Value = model.tra_transactionAmount;
			parameters[2].Value = model.tra_transactionDate;
			parameters[3].Value = model.tra_accomplish;
			parameters[4].Value = model.tra_staff_id;
			parameters[5].Value = model.sta_comwas_id;
			parameters[6].Value = model.tra_number;
			parameters[7].Value = model.tra_addressID;
			parameters[8].Value = model.tra_type;
			parameters[9].Value = model.tra_vaild;
			parameters[10].Value = model.tra_sort;

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
		public bool Update(WalleProject.Model.t_tradingrecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_tradingrecord set ");
			strSql.Append("tra_U_ID=@tra_U_ID,");
			strSql.Append("tra_transactionAmount=@tra_transactionAmount,");
			strSql.Append("tra_transactionDate=@tra_transactionDate,");
			strSql.Append("tra_accomplish=@tra_accomplish,");
			strSql.Append("tra_staff_id=@tra_staff_id,");
			strSql.Append("sta_comwas_id=@sta_comwas_id,");
			strSql.Append("tra_number=@tra_number,");
			strSql.Append("tra_addressID=@tra_addressID,");
			strSql.Append("tra_type=@tra_type,");
			strSql.Append("tra_vaild=@tra_vaild,");
			strSql.Append("tra_sort=@tra_sort");
			strSql.Append(" where tra_ID=@tra_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@tra_U_ID", MySqlDbType.Int32,10),
					new MySqlParameter("@tra_transactionAmount", MySqlDbType.Decimal,10),
					new MySqlParameter("@tra_transactionDate", MySqlDbType.DateTime),
					new MySqlParameter("@tra_accomplish", MySqlDbType.VarChar,10),
					new MySqlParameter("@tra_staff_id", MySqlDbType.Int32,10),
					new MySqlParameter("@sta_comwas_id", MySqlDbType.Int32,10),
					new MySqlParameter("@tra_number", MySqlDbType.Int32,10),
					new MySqlParameter("@tra_addressID", MySqlDbType.Int32,10),
					new MySqlParameter("@tra_type", MySqlDbType.VarChar,10),
					new MySqlParameter("@tra_vaild", MySqlDbType.VarChar,10),
					new MySqlParameter("@tra_sort", MySqlDbType.Int32,10),
					new MySqlParameter("@tra_ID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.tra_U_ID;
			parameters[1].Value = model.tra_transactionAmount;
			parameters[2].Value = model.tra_transactionDate;
			parameters[3].Value = model.tra_accomplish;
			parameters[4].Value = model.tra_staff_id;
			parameters[5].Value = model.sta_comwas_id;
			parameters[6].Value = model.tra_number;
			parameters[7].Value = model.tra_addressID;
			parameters[8].Value = model.tra_type;
			parameters[9].Value = model.tra_vaild;
			parameters[10].Value = model.tra_sort;
			parameters[11].Value = model.tra_ID;

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
		public bool Delete(int tra_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_tradingrecord ");
			strSql.Append(" where tra_ID=@tra_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@tra_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = tra_ID;

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
		public bool DeleteList(string tra_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_tradingrecord ");
			strSql.Append(" where tra_ID in ("+tra_IDlist + ")  ");
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
		public WalleProject.Model.t_tradingrecord GetModel(int tra_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select tra_U_ID,tra_transactionAmount,tra_transactionDate,tra_accomplish,tra_staff_id,sta_comwas_id,tra_number,tra_ID,tra_addressID,tra_type,tra_vaild,tra_sort from t_tradingrecord ");
			strSql.Append(" where tra_ID=@tra_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@tra_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = tra_ID;

			WalleProject.Model.t_tradingrecord model=new WalleProject.Model.t_tradingrecord();
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
		public WalleProject.Model.t_tradingrecord DataRowToModel(DataRow row)
		{
			WalleProject.Model.t_tradingrecord model=new WalleProject.Model.t_tradingrecord();
			if (row != null)
			{
				if(row["tra_U_ID"]!=null && row["tra_U_ID"].ToString()!="")
				{
					model.tra_U_ID=int.Parse(row["tra_U_ID"].ToString());
				}
				if(row["tra_transactionAmount"]!=null && row["tra_transactionAmount"].ToString()!="")
				{
					model.tra_transactionAmount=decimal.Parse(row["tra_transactionAmount"].ToString());
				}
				if(row["tra_transactionDate"]!=null && row["tra_transactionDate"].ToString()!="")
				{
					model.tra_transactionDate=DateTime.Parse(row["tra_transactionDate"].ToString());
				}
				if(row["tra_accomplish"]!=null)
				{
					model.tra_accomplish=row["tra_accomplish"].ToString();
				}
				if(row["tra_staff_id"]!=null && row["tra_staff_id"].ToString()!="")
				{
					model.tra_staff_id=int.Parse(row["tra_staff_id"].ToString());
				}
				if(row["sta_comwas_id"]!=null && row["sta_comwas_id"].ToString()!="")
				{
					model.sta_comwas_id=int.Parse(row["sta_comwas_id"].ToString());
				}
				if(row["tra_number"]!=null && row["tra_number"].ToString()!="")
				{
					model.tra_number=int.Parse(row["tra_number"].ToString());
				}
				if(row["tra_ID"]!=null && row["tra_ID"].ToString()!="")
				{
					model.tra_ID=int.Parse(row["tra_ID"].ToString());
				}
				if(row["tra_addressID"]!=null && row["tra_addressID"].ToString()!="")
				{
					model.tra_addressID=int.Parse(row["tra_addressID"].ToString());
				}
				if(row["tra_type"]!=null)
				{
					model.tra_type=row["tra_type"].ToString();
				}
				if(row["tra_vaild"]!=null)
				{
					model.tra_vaild=row["tra_vaild"].ToString();
				}
				if(row["tra_sort"]!=null && row["tra_sort"].ToString()!="")
				{
					model.tra_sort=int.Parse(row["tra_sort"].ToString());
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
			strSql.Append("select tra_U_ID,tra_transactionAmount,tra_transactionDate,tra_accomplish,tra_staff_id,sta_comwas_id,tra_number,tra_ID,tra_addressID,tra_type,tra_vaild,tra_sort ");
			strSql.Append(" FROM t_tradingrecord ");
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
			strSql.Append("select count(1) FROM t_tradingrecord ");
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
				strSql.Append("order by T.tra_ID desc");
			}
			strSql.Append(")AS Row, T.*  from t_tradingrecord T ");
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
			parameters[0].Value = "t_tradingrecord";
			parameters[1].Value = "tra_ID";
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

