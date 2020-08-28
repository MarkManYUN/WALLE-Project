using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WalleProject.DAL
{
	/// <summary>
	/// 数据访问类:t_waste
	/// </summary>
	public partial class t_waste
	{
		public t_waste()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("was_ID", "t_waste"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int was_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_waste");
			strSql.Append(" where was_ID=@was_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@was_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = was_ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WalleProject.Model.t_waste model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_waste(");
			strSql.Append("was_pic_ID,was_name,was_price,was_recoverable,was_number,was_cate_ID,was_valid)");
			strSql.Append(" values (");
			strSql.Append("@was_pic_ID,@was_name,@was_price,@was_recoverable,@was_number,@was_cate_ID,@was_valid)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@was_pic_ID", MySqlDbType.Int32,10),
					new MySqlParameter("@was_name", MySqlDbType.VarChar,10),
					new MySqlParameter("@was_price", MySqlDbType.Decimal,10),
					new MySqlParameter("@was_recoverable", MySqlDbType.Int32,10),
					new MySqlParameter("@was_number", MySqlDbType.Int32,10),
					new MySqlParameter("@was_cate_ID", MySqlDbType.Int32,10),
					new MySqlParameter("@was_valid", MySqlDbType.VarChar,2)};
			parameters[0].Value = model.was_pic_ID;
			parameters[1].Value = model.was_name;
			parameters[2].Value = model.was_price;
			parameters[3].Value = model.was_recoverable;
			parameters[4].Value = model.was_number;
			parameters[5].Value = model.was_cate_ID;
			parameters[6].Value = model.was_valid;

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
		public bool Update(WalleProject.Model.t_waste model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_waste set ");
			strSql.Append("was_pic_ID=@was_pic_ID,");
			strSql.Append("was_name=@was_name,");
			strSql.Append("was_price=@was_price,");
			strSql.Append("was_recoverable=@was_recoverable,");
			strSql.Append("was_number=@was_number,");
			strSql.Append("was_cate_ID=@was_cate_ID,");
			strSql.Append("was_valid=@was_valid");
			strSql.Append(" where was_ID=@was_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@was_pic_ID", MySqlDbType.Int32,10),
					new MySqlParameter("@was_name", MySqlDbType.VarChar,10),
					new MySqlParameter("@was_price", MySqlDbType.Decimal,10),
					new MySqlParameter("@was_recoverable", MySqlDbType.Int32,10),
					new MySqlParameter("@was_number", MySqlDbType.Int32,10),
					new MySqlParameter("@was_cate_ID", MySqlDbType.Int32,10),
					new MySqlParameter("@was_valid", MySqlDbType.VarChar,2),
					new MySqlParameter("@was_ID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.was_pic_ID;
			parameters[1].Value = model.was_name;
			parameters[2].Value = model.was_price;
			parameters[3].Value = model.was_recoverable;
			parameters[4].Value = model.was_number;
			parameters[5].Value = model.was_cate_ID;
			parameters[6].Value = model.was_valid;
			parameters[7].Value = model.was_ID;

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
		public bool Delete(int was_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_waste ");
			strSql.Append(" where was_ID=@was_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@was_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = was_ID;

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
		public bool DeleteList(string was_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_waste ");
			strSql.Append(" where was_ID in ("+was_IDlist + ")  ");
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
        /// 得到一个对象实体(两个表连接)
        /// </summary>
        public WalleProject.Model.t_waste GetWasteModel(int was_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * from t_waste inner join t_wastecategory on t_waste.was_cate_ID=t_wastecategory.wasc_ID  ");
            strSql.Append(" where was_ID=@was_ID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@was_ID", MySqlDbType.Int32)
            };
            parameters[0].Value = was_ID;

            WalleProject.Model.t_waste model = new WalleProject.Model.t_waste();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row= ds.Tables[0].Rows[0];
                if (row != null)
                {
                    if (row["was_pic_ID"] != null && row["was_pic_ID"].ToString() != "")
                    {
                        model.was_pic_ID = int.Parse(row["was_pic_ID"].ToString());
                    }
                    if (row["was_ID"] != null && row["was_ID"].ToString() != "")
                    {
                        model.was_ID = int.Parse(row["was_ID"].ToString());
                    }
                    if (row["was_name"] != null)
                    {
                        model.was_name = row["was_name"].ToString();
                    }
                    if (row["was_price"] != null && row["was_price"].ToString() != "")
                    {
                        model.was_price = decimal.Parse(row["was_price"].ToString());
                    }
                    if (row["was_recoverable"] != null)
                    {
                        model.was_recoverable = int.Parse(row["was_recoverable"].ToString());
                    }
                    if (row["was_number"] != null && row["was_number"].ToString() != "")
                    {
                        model.was_number = int.Parse(row["was_number"].ToString());
                    }
                    if (row["was_cate_ID"] != null && row["was_cate_ID"].ToString() != "")
                    {
                        model.was_cate_ID = int.Parse(row["was_cate_ID"].ToString());
                    }
                    if (row["was_valid"] != null)
                    {
                        model.was_valid = row["was_valid"].ToString();
                    }
                    if (row["wasc_name"] != null)
                    {
                        model.wastecategory.wasc_name = row["wasc_name"].ToString();
                    }
                   
                }
                return model;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WalleProject.Model.t_waste GetModel(int was_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select was_pic_ID,was_ID,was_name,was_price,was_recoverable,was_number,was_cate_ID,was_valid from t_waste ");
			strSql.Append(" where was_ID=@was_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@was_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = was_ID;

			WalleProject.Model.t_waste model=new WalleProject.Model.t_waste();
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
		public WalleProject.Model.t_waste DataRowToModel(DataRow row)
		{
			WalleProject.Model.t_waste model=new WalleProject.Model.t_waste();
			if (row != null)
			{
				if(row["was_pic_ID"]!=null && row["was_pic_ID"].ToString()!="")
				{
					model.was_pic_ID=int.Parse(row["was_pic_ID"].ToString());
				}
				if(row["was_ID"]!=null && row["was_ID"].ToString()!="")
				{
					model.was_ID=int.Parse(row["was_ID"].ToString());
				}
				if(row["was_name"]!=null)
				{
					model.was_name=row["was_name"].ToString();
				}
				if(row["was_price"]!=null && row["was_price"].ToString()!="")
				{
					model.was_price=decimal.Parse(row["was_price"].ToString());
				}
				if(row["was_recoverable"]!=null)
				{
					model.was_recoverable= int.Parse( row["was_recoverable"].ToString());
				}
				if(row["was_number"]!=null && row["was_number"].ToString()!="")
				{
					model.was_number=int.Parse(row["was_number"].ToString());
				}
				if(row["was_cate_ID"]!=null && row["was_cate_ID"].ToString()!="")
				{
					model.was_cate_ID=int.Parse(row["was_cate_ID"].ToString());
				}
				if(row["was_valid"]!=null)
				{
					model.was_valid=row["was_valid"].ToString();
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
			strSql.Append("select was_pic_ID,was_ID,was_name,was_price,was_recoverable,was_number,was_cate_ID,was_valid ");
			strSql.Append(" FROM t_waste ");
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
			strSql.Append("select count(1) FROM t_waste ");
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
				strSql.Append("order by T.was_ID desc");
			}
			strSql.Append(")AS Row, T.*  from t_waste T ");
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
			parameters[0].Value = "t_waste";
			parameters[1].Value = "was_ID";
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

