using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WalleProject.DAL
{
	/// <summary>
	/// 数据访问类:t_staff
	/// </summary>
	public partial class t_staff
	{
		public t_staff()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long sta_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_staff");
			strSql.Append(" where sta_id=@sta_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@sta_id", MySqlDbType.Int32)
			};
			parameters[0].Value = sta_id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}
        public bool IsLogin(long sta_id, string sta_passWord) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from t_staff");
            strSql.Append(" where sta_id=@sta_id and sta_passWord=@sta_passWord");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@sta_id", MySqlDbType.Int32),
                    new MySqlParameter("@sta_passWord", MySqlDbType.String)

            };
            parameters[0].Value = sta_id;
            parameters[1].Value = sta_passWord;
            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WalleProject.Model.t_staff model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_staff(");
			strSql.Append("sta_userName,sta_entryDate,sta_passWord,sta_maritalStatus,sta_IDNumber,sta_homeAddress,sta_phone,sta_name,sta__pic_id,sta_tra_id,sta_lastLogindate,sta_salary)");
			strSql.Append(" values (");
			strSql.Append("@sta_userName,@sta_entryDate,@sta_passWord,@sta_maritalStatus,@sta_IDNumber,@sta_homeAddress,@sta_phone,@sta_name,@sta__pic_id,@sta_tra_id,@sta_lastLogindate,@sta_salary)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@sta_userName", MySqlDbType.VarChar,20),
					new MySqlParameter("@sta_entryDate", MySqlDbType.Int32),
					new MySqlParameter("@sta_passWord", MySqlDbType.VarChar,20),
					new MySqlParameter("@sta_maritalStatus", MySqlDbType.VarChar,2),
					new MySqlParameter("@sta_IDNumber", MySqlDbType.VarChar,20),
					new MySqlParameter("@sta_homeAddress", MySqlDbType.VarChar,50),
					new MySqlParameter("@sta_phone", MySqlDbType.VarChar,20),
					new MySqlParameter("@sta_name", MySqlDbType.VarChar,10),
					new MySqlParameter("@sta__pic_id", MySqlDbType.Int32,10),
					new MySqlParameter("@sta_tra_id", MySqlDbType.Int32,10),
					new MySqlParameter("@sta_lastLogindate", MySqlDbType.DateTime),
					new MySqlParameter("@sta_salary", MySqlDbType.Decimal,10)};
			parameters[0].Value = model.sta_userName;
			parameters[1].Value = model.sta_entryDate;
			parameters[2].Value = model.sta_passWord;
			parameters[3].Value = model.sta_maritalStatus;
			parameters[4].Value = model.sta_IDNumber;
			parameters[5].Value = model.sta_homeAddress;
			parameters[6].Value = model.sta_phone;
			parameters[7].Value = model.sta_name;
			parameters[8].Value = model.sta__pic_id;
			parameters[9].Value = model.sta_tra_id;
			parameters[10].Value = model.sta_lastLogindate;
			parameters[11].Value = model.sta_salary;

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
		public bool Update(WalleProject.Model.t_staff model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_staff set ");
			strSql.Append("sta_userName=@sta_userName,");
			strSql.Append("sta_entryDate=@sta_entryDate,");
			strSql.Append("sta_passWord=@sta_passWord,");
			strSql.Append("sta_maritalStatus=@sta_maritalStatus,");
			strSql.Append("sta_IDNumber=@sta_IDNumber,");
			strSql.Append("sta_homeAddress=@sta_homeAddress,");
			strSql.Append("sta_phone=@sta_phone,");
			strSql.Append("sta_name=@sta_name,");
			strSql.Append("sta__pic_id=@sta__pic_id,");
			strSql.Append("sta_tra_id=@sta_tra_id,");
			strSql.Append("sta_lastLogindate=@sta_lastLogindate,");
			strSql.Append("sta_salary=@sta_salary");
			strSql.Append(" where sta_id=@sta_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@sta_userName", MySqlDbType.VarChar,20),
					new MySqlParameter("@sta_entryDate", MySqlDbType.DateTime),
					new MySqlParameter("@sta_passWord", MySqlDbType.VarChar,20),
					new MySqlParameter("@sta_maritalStatus", MySqlDbType.VarChar,2),
					new MySqlParameter("@sta_IDNumber", MySqlDbType.VarChar,20),
					new MySqlParameter("@sta_homeAddress", MySqlDbType.VarChar,50),
					new MySqlParameter("@sta_phone", MySqlDbType.VarChar,20),
					new MySqlParameter("@sta_name", MySqlDbType.VarChar,10),
					new MySqlParameter("@sta__pic_id", MySqlDbType.Int32,10),
					new MySqlParameter("@sta_tra_id", MySqlDbType.Int32,10),
					new MySqlParameter("@sta_lastLogindate", MySqlDbType.DateTime),
					new MySqlParameter("@sta_salary", MySqlDbType.Decimal,10),
					new MySqlParameter("@sta_id", MySqlDbType.Int32,10)};
			parameters[0].Value = model.sta_userName;
			parameters[1].Value = model.sta_entryDate;
			parameters[2].Value = model.sta_passWord;
			parameters[3].Value = model.sta_maritalStatus;
			parameters[4].Value = model.sta_IDNumber;
			parameters[5].Value = model.sta_homeAddress;
			parameters[6].Value = model.sta_phone;
			parameters[7].Value = model.sta_name;
			parameters[8].Value = model.sta__pic_id;
			parameters[9].Value = model.sta_tra_id;
			parameters[10].Value = model.sta_lastLogindate;
			parameters[11].Value = model.sta_salary;
			parameters[12].Value = model.sta_id;

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
		/// 更新员工工资
		/// </summary>
		public bool UpdateSalary(WalleProject.Model.t_staff model) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update t_staff set ");
           
            strSql.Append("sta_salary=@sta_salary");
            strSql.Append(" where sta_id=@sta_id");
            MySqlParameter[] parameters = {
                    
                    new MySqlParameter("@sta_salary", MySqlDbType.Decimal,10),
                    new MySqlParameter("@sta_id", MySqlDbType.Int32,10)};
          
            parameters[0].Value = model.sta_salary;
            parameters[1].Value = model.sta_id;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Delete(long sta_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_staff ");
			strSql.Append(" where sta_id=@sta_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@sta_id", MySqlDbType.Int32)
			};
			parameters[0].Value = sta_id;

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
		public bool DeleteList(string sta_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_staff ");
			strSql.Append(" where sta_id in ("+sta_idlist + ")  ");
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
		public WalleProject.Model.t_staff GetModel(long sta_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append(@"SELECT * from t_staff inner join t_staffcategory on t_staff.sta_tra_id=t_staffcategory.stac_ID
 inner join t_picture on t_picture.pic_ID = t_staff.sta__pic_id ");
			strSql.Append(" where sta_id=@sta_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@sta_id", MySqlDbType.Int32)
			};
			parameters[0].Value = sta_id;

			WalleProject.Model.t_staff model=new WalleProject.Model.t_staff();
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
        public WalleProject.Model.t_staff DataRowToModel(DataRow row)
		{
			WalleProject.Model.t_staff model=new WalleProject.Model.t_staff();
			if (row != null)
			{
				if(row["sta_id"]!=null && row["sta_id"].ToString()!="")
				{
					model.sta_id=long.Parse(row["sta_id"].ToString());
				}
				if(row["sta_userName"]!=null)
				{
					model.sta_userName=row["sta_userName"].ToString();
				}
				if(row["sta_entryDate"]!=null && row["sta_entryDate"].ToString()!="")
				{
					model.sta_entryDate=DateTime.Parse(row["sta_entryDate"].ToString());
				}
				if(row["sta_passWord"]!=null)
				{
					model.sta_passWord=row["sta_passWord"].ToString();
				}
				if(row["sta_maritalStatus"]!=null)
				{
					model.sta_maritalStatus=row["sta_maritalStatus"].ToString();
				}
				if(row["sta_IDNumber"]!=null)
				{
					model.sta_IDNumber=row["sta_IDNumber"].ToString();
				}
				if(row["sta_homeAddress"]!=null)
				{
					model.sta_homeAddress=row["sta_homeAddress"].ToString();
				}
				if(row["sta_phone"]!=null)
				{
					model.sta_phone=row["sta_phone"].ToString();
				}
				if(row["sta_name"]!=null)
				{
					model.sta_name=row["sta_name"].ToString();
				}
				if(row["sta__pic_id"]!=null && row["sta__pic_id"].ToString()!="")
				{
					model.sta__pic_id=int.Parse(row["sta__pic_id"].ToString());
				}
				if(row["sta_tra_id"]!=null && row["sta_tra_id"].ToString()!="")
				{
					model.sta_tra_id=int.Parse(row["sta_tra_id"].ToString());
				}
				if(row["sta_lastLogindate"]!=null && row["sta_lastLogindate"].ToString()!="")
				{
					model.sta_lastLogindate=DateTime.Parse(row["sta_lastLogindate"].ToString());
				}
				if(row["sta_salary"]!=null && row["sta_salary"].ToString()!="")
				{
					model.sta_salary=decimal.Parse(row["sta_salary"].ToString());
				}
                if (row["pic_valid"] != null && row["pic_valid"].ToString() != "")
                {
                    model.staffPicture.pic_valid = row["pic_valid"].ToString();
                }
                if (row["stac_name"] != null && row["stac_name"].ToString() != "")
                {
                    model.staffcategory.stac_name = row["stac_name"].ToString();
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
			strSql.Append("select sta_id,sta_userName,sta_entryDate,sta_passWord,sta_maritalStatus,sta_IDNumber,sta_homeAddress,sta_phone,sta_name,sta__pic_id,sta_tra_id,sta_lastLogindate,sta_salary ");
			strSql.Append(" FROM t_staff ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}
        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetSalaryList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM t_staff left join t_staffsalary on t_staff.sta_id=t_staffsalary.sal_sta_id");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM t_staff ");
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
				strSql.Append("order by T.sta_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_staff T ");
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
			parameters[0].Value = "t_staff";
			parameters[1].Value = "sta_id";
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

