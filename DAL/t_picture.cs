using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WalleProject.DAL
{
	/// <summary>
	/// 数据访问类:t_picture
	/// </summary>
	public partial class t_picture
	{
		public t_picture()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("pic_ID", "t_picture"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int pic_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_picture");
			strSql.Append(" where pic_ID=@pic_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@pic_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = pic_ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WalleProject.Model.t_picture model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_picture(");
			strSql.Append("pic_cate_ID,pic_date,pic_name,pic_valid)");
			strSql.Append(" values (");
			strSql.Append("@pic_cate_ID,@pic_date,@pic_name,@pic_valid)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@pic_cate_ID", MySqlDbType.Int32,10),
					new MySqlParameter("@pic_date", MySqlDbType.DateTime),
					new MySqlParameter("@pic_name", MySqlDbType.VarChar,10),
					new MySqlParameter("@pic_valid", MySqlDbType.VarChar,2)};
			parameters[0].Value = model.pic_cate_ID;
			parameters[1].Value = model.pic_date;
			parameters[2].Value = model.pic_name;
			parameters[3].Value = model.pic_valid;

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
		public bool Update(WalleProject.Model.t_picture model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_picture set ");
			strSql.Append("pic_cate_ID=@pic_cate_ID,");
			strSql.Append("pic_date=@pic_date,");
			strSql.Append("pic_name=@pic_name,");
			strSql.Append("pic_valid=@pic_valid");
			strSql.Append(" where pic_ID=@pic_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@pic_cate_ID", MySqlDbType.Int32,10),
					new MySqlParameter("@pic_date", MySqlDbType.DateTime),
					new MySqlParameter("@pic_name", MySqlDbType.VarChar,10),
					new MySqlParameter("@pic_valid", MySqlDbType.VarChar,2),
					new MySqlParameter("@pic_ID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.pic_cate_ID;
			parameters[1].Value = model.pic_date;
			parameters[2].Value = model.pic_name;
			parameters[3].Value = model.pic_valid;
			parameters[4].Value = model.pic_ID;

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
		public bool Delete(int pic_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_picture ");
			strSql.Append(" where pic_ID=@pic_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@pic_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = pic_ID;

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
		public bool DeleteList(string pic_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_picture ");
			strSql.Append(" where pic_ID in ("+pic_IDlist + ")  ");
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
		public WalleProject.Model.t_picture GetModel(int pic_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select pic_cate_ID,pic_ID,pic_date,pic_name,pic_valid from t_picture ");
			strSql.Append(" where pic_ID=@pic_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@pic_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = pic_ID;

			WalleProject.Model.t_picture model=new WalleProject.Model.t_picture();
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
        /// 得到一个对象实体(连接两个表）
        /// </summary>
        public WalleProject.Model.t_picture GetPicturModel(int pic_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT * from t_picture inner join t_picturecategory 
on t_picture.pic_cate_ID=t_picturecategory.picca_ID");
            strSql.Append(" where pic_ID=@pic_ID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@pic_ID", MySqlDbType.Int32)
            };
            parameters[0].Value = pic_ID;

            WalleProject.Model.t_picture model = new WalleProject.Model.t_picture();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                if (row != null)
                {
                    if (row["pic_cate_ID"] != null && row["pic_cate_ID"].ToString() != "")
                    {
                        model.pic_cate_ID = int.Parse(row["pic_cate_ID"].ToString());
                    }
                    if (row["pic_ID"] != null && row["pic_ID"].ToString() != "")
                    {
                        model.pic_ID = int.Parse(row["pic_ID"].ToString());
                    }
                    if (row["pic_date"] != null && row["pic_date"].ToString() != "")
                    {
                        model.pic_date = DateTime.Parse(row["pic_date"].ToString());
                    }
                    if (row["pic_name"] != null)
                    {
                        model.pic_name = row["pic_name"].ToString();
                    }
                    if (row["pic_valid"] != null)
                    {
                        model.pic_valid = row["pic_valid"].ToString();
                    }
                    if (row["picca_name"] != null)
                    {
                        model.picturecategory.picca_name = row["picca_name"].ToString();
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
        public WalleProject.Model.t_picture DataRowToModel(DataRow row)
		{
			WalleProject.Model.t_picture model=new WalleProject.Model.t_picture();
			if (row != null)
			{
				if(row["pic_cate_ID"]!=null && row["pic_cate_ID"].ToString()!="")
				{
					model.pic_cate_ID=int.Parse(row["pic_cate_ID"].ToString());
				}
				if(row["pic_ID"]!=null && row["pic_ID"].ToString()!="")
				{
					model.pic_ID=int.Parse(row["pic_ID"].ToString());
				}
				if(row["pic_date"]!=null && row["pic_date"].ToString()!="")
				{
					model.pic_date=DateTime.Parse(row["pic_date"].ToString());
				}
				if(row["pic_name"]!=null)
				{
					model.pic_name=row["pic_name"].ToString();
				}
				if(row["pic_valid"]!=null)
				{
					model.pic_valid=row["pic_valid"].ToString();
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
			strSql.Append("select pic_cate_ID,pic_ID,pic_date,pic_name,pic_valid ");
			strSql.Append(" FROM t_picture ");
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
			strSql.Append("select count(1) FROM t_picture ");
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
				strSql.Append("order by T.pic_ID desc");
			}
			strSql.Append(")AS Row, T.*  from t_picture T ");
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
			parameters[0].Value = "t_picture";
			parameters[1].Value = "pic_ID";
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

