using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WalleProject.DAL
{
	/// <summary>
	/// 数据访问类:t_commodity
	/// </summary>
	public partial class t_commodity
	{
		public t_commodity()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("com_ID", "t_commodity"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int com_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_commodity");
			strSql.Append(" where com_ID=@com_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@com_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = com_ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WalleProject.Model.t_commodity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_commodity(");
			strSql.Append("com_name,com_productDate,com_number,com_strageID,com_alertNumber,com_pic_ID,com_date,com_pri_ID,com_conversionInt,com_comc_ID,com_valid)");
			strSql.Append(" values (");
			strSql.Append("@com_name,@com_productDate,@com_number,@com_strageID,@com_alertNumber,@com_pic_ID,@com_date,@com_pri_ID,@com_conversionInt,@com_comc_ID,@com_valid)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@com_name", MySqlDbType.VarChar,20),
					new MySqlParameter("@com_productDate", MySqlDbType.Date),
					new MySqlParameter("@com_number", MySqlDbType.Int32,10),
					new MySqlParameter("@com_strageID", MySqlDbType.VarChar,10),
					new MySqlParameter("@com_alertNumber", MySqlDbType.Int32,10),
					new MySqlParameter("@com_pic_ID", MySqlDbType.Int32,10),
					new MySqlParameter("@com_date", MySqlDbType.Date),
					new MySqlParameter("@com_pri_ID", MySqlDbType.Decimal,10),
					new MySqlParameter("@com_conversionInt", MySqlDbType.Int32,10),
					new MySqlParameter("@com_comc_ID", MySqlDbType.Int32,10),
					new MySqlParameter("@com_valid", MySqlDbType.VarChar,2)};
			parameters[0].Value = model.com_name;
			parameters[1].Value = model.com_productDate;
			parameters[2].Value = model.com_number;
			parameters[3].Value = model.com_strageID;
			parameters[4].Value = model.com_alertNumber;
			parameters[5].Value = model.com_pic_ID;
			parameters[6].Value = model.com_date;
			parameters[7].Value = model.com_pri_ID;
			parameters[8].Value = model.com_conversionInt;
			parameters[9].Value = model.com_comc_ID;
			parameters[10].Value = model.com_valid;

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
		public bool Update(WalleProject.Model.t_commodity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_commodity set ");
			strSql.Append("com_name=@com_name,");
			strSql.Append("com_productDate=@com_productDate,");
			strSql.Append("com_number=@com_number,");
			strSql.Append("com_strageID=@com_strageID,");
			strSql.Append("com_alertNumber=@com_alertNumber,");
			strSql.Append("com_pic_ID=@com_pic_ID,");
			strSql.Append("com_date=@com_date,");
			strSql.Append("com_pri_ID=@com_pri_ID,");
			strSql.Append("com_conversionInt=@com_conversionInt,");
			strSql.Append("com_comc_ID=@com_comc_ID,");
			strSql.Append("com_valid=@com_valid");
			strSql.Append(" where com_ID=@com_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@com_name", MySqlDbType.VarChar,20),
					new MySqlParameter("@com_productDate", MySqlDbType.Date),
					new MySqlParameter("@com_number", MySqlDbType.Int32,10),
					new MySqlParameter("@com_strageID", MySqlDbType.VarChar,10),
					new MySqlParameter("@com_alertNumber", MySqlDbType.Int32,10),
					new MySqlParameter("@com_pic_ID", MySqlDbType.Int32,10),
					new MySqlParameter("@com_date", MySqlDbType.Date),
					new MySqlParameter("@com_pri_ID", MySqlDbType.Decimal,10),
					new MySqlParameter("@com_conversionInt", MySqlDbType.Int32,10),
					new MySqlParameter("@com_comc_ID", MySqlDbType.Int32,10),
					new MySqlParameter("@com_valid", MySqlDbType.VarChar,2),
					new MySqlParameter("@com_ID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.com_name;
			parameters[1].Value = model.com_productDate;
			parameters[2].Value = model.com_number;
			parameters[3].Value = model.com_strageID;
			parameters[4].Value = model.com_alertNumber;
			parameters[5].Value = model.com_pic_ID;
			parameters[6].Value = model.com_date;
			parameters[7].Value = model.com_pri_ID;
			parameters[8].Value = model.com_conversionInt;
			parameters[9].Value = model.com_comc_ID;
			parameters[10].Value = model.com_valid;
			parameters[11].Value = model.com_ID;

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
		public bool Delete(int com_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_commodity ");
			strSql.Append(" where com_ID=@com_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@com_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = com_ID;

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
		public bool DeleteList(string com_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_commodity ");
			strSql.Append(" where com_ID in ("+com_IDlist + ")  ");
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
		public WalleProject.Model.t_commodity GetModel(int com_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select com_ID,com_name,com_productDate,com_number,com_strageID,com_alertNumber,com_pic_ID,com_date,com_pri_ID,com_conversionInt,com_comc_ID,com_valid from t_commodity ");
			strSql.Append(" where com_ID=@com_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@com_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = com_ID;

			WalleProject.Model.t_commodity model=new WalleProject.Model.t_commodity();
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
		/// 得到一个对象实体(两个表）
		/// </summary>
		public WalleProject.Model.t_commodity GetCommodityModel(int com_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from t_commodity inner join t_commoditycategory on t_commodity.com_comc_ID=t_commoditycategory.comc_ID ");
            strSql.Append(" where com_ID=@com_ID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@com_ID", MySqlDbType.Int32)
            };
            parameters[0].Value = com_ID;

            WalleProject.Model.t_commodity model = new WalleProject.Model.t_commodity();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row= ds.Tables[0].Rows[0];
                if (row != null)
                {
                    if (row["com_ID"] != null && row["com_ID"].ToString() != "")
                    {
                        model.com_ID = int.Parse(row["com_ID"].ToString());
                    }
                    if (row["com_name"] != null)
                    {
                        model.com_name = row["com_name"].ToString();
                    }
                    if (row["com_productDate"] != null && row["com_productDate"].ToString() != "")
                    {
                        model.com_productDate = DateTime.Parse(row["com_productDate"].ToString());
                    }
                    if (row["com_number"] != null && row["com_number"].ToString() != "")
                    {
                        model.com_number = int.Parse(row["com_number"].ToString());
                    }
                    if (row["com_strageID"] != null)
                    {
                        model.com_strageID = row["com_strageID"].ToString();
                    }
                    if (row["com_alertNumber"] != null && row["com_alertNumber"].ToString() != "")
                    {
                        model.com_alertNumber = int.Parse(row["com_alertNumber"].ToString());
                    }
                    if (row["com_pic_ID"] != null && row["com_pic_ID"].ToString() != "")
                    {
                        model.com_pic_ID = int.Parse(row["com_pic_ID"].ToString());
                    }
                    if (row["com_date"] != null && row["com_date"].ToString() != "")
                    {
                        model.com_date = DateTime.Parse(row["com_date"].ToString());
                    }
                    if (row["com_pri_ID"] != null && row["com_pri_ID"].ToString() != "")
                    {
                        model.com_pri_ID = Decimal.Parse(row["com_pri_ID"].ToString());
                    }
                    if (row["com_conversionInt"] != null && row["com_conversionInt"].ToString() != "")
                    {
                        model.com_conversionInt = int.Parse(row["com_conversionInt"].ToString());
                    }
                    if (row["com_comc_ID"] != null && row["com_comc_ID"].ToString() != "")
                    {
                        model.com_comc_ID = int.Parse(row["com_comc_ID"].ToString());
                    }
                    if (row["com_valid"] != null)
                    {
                        model.com_valid = row["com_valid"].ToString();
                    }
                    if (row["comc_name"] != null)
                    {
                        model.commoditycategory.comc_name = row["comc_name"].ToString();
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
        public WalleProject.Model.t_commodity DataRowToModel(DataRow row)
		{
			WalleProject.Model.t_commodity model=new WalleProject.Model.t_commodity();
			if (row != null)
			{
				if(row["com_ID"]!=null && row["com_ID"].ToString()!="")
				{
					model.com_ID=int.Parse(row["com_ID"].ToString());
				}
				if(row["com_name"]!=null)
				{
					model.com_name=row["com_name"].ToString();
				}
				if(row["com_productDate"]!=null && row["com_productDate"].ToString()!="")
				{
					model.com_productDate=DateTime.Parse(row["com_productDate"].ToString());
				}
				if(row["com_number"]!=null && row["com_number"].ToString()!="")
				{
					model.com_number=int.Parse(row["com_number"].ToString());
				}
				if(row["com_strageID"]!=null)
				{
					model.com_strageID=row["com_strageID"].ToString();
				}
				if(row["com_alertNumber"]!=null && row["com_alertNumber"].ToString()!="")
				{
					model.com_alertNumber=int.Parse(row["com_alertNumber"].ToString());
				}
				if(row["com_pic_ID"]!=null && row["com_pic_ID"].ToString()!="")
				{
					model.com_pic_ID=int.Parse(row["com_pic_ID"].ToString());
				}
				if(row["com_date"]!=null && row["com_date"].ToString()!="")
				{
					model.com_date=DateTime.Parse(row["com_date"].ToString());
				}
				if(row["com_pri_ID"]!=null && row["com_pri_ID"].ToString()!="")
				{
					model.com_pri_ID= Decimal.Parse(row["com_pri_ID"].ToString());
				}
				if(row["com_conversionInt"]!=null && row["com_conversionInt"].ToString()!="")
				{
					model.com_conversionInt=int.Parse(row["com_conversionInt"].ToString());
				}
				if(row["com_comc_ID"]!=null && row["com_comc_ID"].ToString()!="")
				{
					model.com_comc_ID=int.Parse(row["com_comc_ID"].ToString());
				}
				if(row["com_valid"]!=null)
				{
					model.com_valid=row["com_valid"].ToString();
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
			strSql.Append("select com_ID,com_name,com_productDate,com_number,com_strageID,com_alertNumber,com_pic_ID,com_date,com_pri_ID,com_conversionInt,com_comc_ID,com_valid ");
			strSql.Append(" FROM t_commodity ");
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
			strSql.Append("select count(1) FROM t_commodity ");
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
				strSql.Append("order by T.com_ID desc");
			}
			strSql.Append(")AS Row, T.*  from t_commodity T ");
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
			parameters[0].Value = "t_commodity";
			parameters[1].Value = "com_ID";
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

