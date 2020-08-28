using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WalleProject.DAL
{
	/// <summary>
	/// 数据访问类:t_file
	/// </summary>
	public partial class t_file
	{
		public t_file()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("file_ID", "t_file"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int file_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_file");
			strSql.Append(" where file_ID=@file_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@file_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = file_ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WalleProject.Model.t_file model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_file(");
			strSql.Append("file_date,file_title,file_catefory_ID,file_Name,file_valid)");
			strSql.Append(" values (");
			strSql.Append("@file_date,@file_title,@file_catefory_ID,@file_Name,@file_valid)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@file_date", MySqlDbType.DateTime),
					new MySqlParameter("@file_title", MySqlDbType.VarChar,20),
					new MySqlParameter("@file_catefory_ID", MySqlDbType.Int32,10),
					new MySqlParameter("@file_Name", MySqlDbType.VarChar,50),
					new MySqlParameter("@file_valid", MySqlDbType.VarChar,2)};
			parameters[0].Value = model.file_date;
			parameters[1].Value = model.file_title;
			parameters[2].Value = model.file_catefory_ID;
			parameters[3].Value = model.file_Name;
			parameters[4].Value = model.file_valid;

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
		public bool Update(WalleProject.Model.t_file model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_file set ");
			strSql.Append("file_date=@file_date,");
			strSql.Append("file_title=@file_title,");
			strSql.Append("file_catefory_ID=@file_catefory_ID,");
			strSql.Append("file_Name=@file_Name,");
			strSql.Append("file_valid=@file_valid");
			strSql.Append(" where file_ID=@file_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@file_date", MySqlDbType.DateTime),
					new MySqlParameter("@file_title", MySqlDbType.VarChar,20),
					new MySqlParameter("@file_catefory_ID", MySqlDbType.Int32,10),
					new MySqlParameter("@file_Name", MySqlDbType.VarChar,50),
					new MySqlParameter("@file_valid", MySqlDbType.VarChar,2),
					new MySqlParameter("@file_ID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.file_date;
			parameters[1].Value = model.file_title;
			parameters[2].Value = model.file_catefory_ID;
			parameters[3].Value = model.file_Name;
			parameters[4].Value = model.file_valid;
			parameters[5].Value = model.file_ID;

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
		public bool Delete(int file_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_file ");
			strSql.Append(" where file_ID=@file_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@file_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = file_ID;

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
		public bool DeleteList(string file_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_file ");
			strSql.Append(" where file_ID in ("+file_IDlist + ")  ");
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
		public WalleProject.Model.t_file GetModel(int file_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select file_ID,file_date,file_title,file_catefory_ID,file_Name,file_valid from t_file ");
			strSql.Append(" where file_ID=@file_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@file_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = file_ID;

			WalleProject.Model.t_file model=new WalleProject.Model.t_file();
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
		/// 得到一个对象实体(两个表连接)
		/// </summary>
		public WalleProject.Model.t_file GetFileModel(int file_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from t_file inner join t_filecategory on t_file.file_catefory_ID=t_filecategory.filec_ID ");
            strSql.Append(" where file_ID=@file_ID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@file_ID", MySqlDbType.Int32)
            };
            parameters[0].Value = file_ID;

          
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                WalleProject.Model.t_file model = new WalleProject.Model.t_file();
                if (row != null)
                {
                    if (row["file_ID"] != null && row["file_ID"].ToString() != "")
                    {
                        model.file_ID = int.Parse(row["file_ID"].ToString());
                    }
                    if (row["file_date"] != null && row["file_date"].ToString() != "")
                    {
                        model.file_date = DateTime.Parse(row["file_date"].ToString());
                    }
                    if (row["file_title"] != null)
                    {
                        model.file_title = row["file_title"].ToString();
                    }
                    if (row["file_catefory_ID"] != null && row["file_catefory_ID"].ToString() != "")
                    {
                        model.file_catefory_ID = int.Parse(row["file_catefory_ID"].ToString());
                    }
                    if (row["file_Name"] != null)
                    {
                        model.file_Name = row["file_Name"].ToString();
                    }
                    if (row["file_valid"] != null)
                    {
                        model.file_valid = row["file_valid"].ToString();
                    }
                    
                         if (row["filec_name"] != null)
                    {
                        model.file.filec_name = row["filec_name"].ToString();
                    }
                    if (row["filec_path"] != null)
                    {
                        model.file.filec_path = row["filec_path"].ToString();
                    }
                    if (row["file_ext"] != null)
                    {
                        model.file.file_ext = row["file_ext"].ToString();
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
        public WalleProject.Model.t_file DataRowToModel(DataRow row)
		{
			WalleProject.Model.t_file model=new WalleProject.Model.t_file();
			if (row != null)
			{
				if(row["file_ID"]!=null && row["file_ID"].ToString()!="")
				{
					model.file_ID=int.Parse(row["file_ID"].ToString());
				}
				if(row["file_date"]!=null && row["file_date"].ToString()!="")
				{
					model.file_date=DateTime.Parse(row["file_date"].ToString());
				}
				if(row["file_title"]!=null)
				{
					model.file_title=row["file_title"].ToString();
				}
				if(row["file_catefory_ID"]!=null && row["file_catefory_ID"].ToString()!="")
				{
					model.file_catefory_ID=int.Parse(row["file_catefory_ID"].ToString());
				}
				if(row["file_Name"]!=null)
				{
					model.file_Name=row["file_Name"].ToString();
				}
				if(row["file_valid"]!=null)
				{
					model.file_valid=row["file_valid"].ToString();
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
			strSql.Append("select file_ID,file_date,file_title,file_catefory_ID,file_Name,file_valid ");
			strSql.Append(" FROM t_file ");
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
			strSql.Append("select count(1) FROM t_file ");
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
				strSql.Append("order by T.file_ID desc");
			}
			strSql.Append(")AS Row, T.*  from t_file T ");
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
			parameters[0].Value = "t_file";
			parameters[1].Value = "file_ID";
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

