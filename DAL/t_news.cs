using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WalleProject.DAL
{
	/// <summary>
	/// 数据访问类:t_news
	/// </summary>
	public partial class t_news
	{
		public t_news()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("new_ID", "t_news"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int new_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_news");
			strSql.Append(" where new_ID=@new_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@new_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = new_ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WalleProject.Model.t_news model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_news(");
			strSql.Append("new_title,new_creatDate,new_cate_id,new_pic_id,new_content,new_valid)");
			strSql.Append(" values (");
			strSql.Append("@new_title,@new_creatDate,@new_cate_id,@new_pic_id,@new_content,@new_valid)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@new_title", MySqlDbType.VarChar,20),
					new MySqlParameter("@new_creatDate", MySqlDbType.DateTime),
					new MySqlParameter("@new_cate_id", MySqlDbType.Int32,10),
					new MySqlParameter("@new_pic_id", MySqlDbType.Int32,10),
					new MySqlParameter("@new_content", MySqlDbType.Text),
					new MySqlParameter("@new_valid", MySqlDbType.VarChar,2)};
			parameters[0].Value = model.new_title;
			parameters[1].Value = model.new_creatDate;
			parameters[2].Value = model.new_cate_id;
			parameters[3].Value = model.new_pic_id;
			parameters[4].Value = model.new_content;
			parameters[5].Value = model.new_valid;

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
		public bool Update(WalleProject.Model.t_news model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_news set ");
			strSql.Append("new_title=@new_title,");
			strSql.Append("new_creatDate=@new_creatDate,");
			strSql.Append("new_cate_id=@new_cate_id,");
			strSql.Append("new_pic_id=@new_pic_id,");
			strSql.Append("new_content=@new_content,");
			strSql.Append("new_valid=@new_valid");
			strSql.Append(" where new_ID=@new_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@new_title", MySqlDbType.VarChar,20),
					new MySqlParameter("@new_creatDate", MySqlDbType.DateTime),
					new MySqlParameter("@new_cate_id", MySqlDbType.Int32,10),
					new MySqlParameter("@new_pic_id", MySqlDbType.Int32,10),
					new MySqlParameter("@new_content", MySqlDbType.Text),
					new MySqlParameter("@new_valid", MySqlDbType.VarChar,2),
					new MySqlParameter("@new_ID", MySqlDbType.Int32,10)};
			parameters[0].Value = model.new_title;
			parameters[1].Value = model.new_creatDate;
			parameters[2].Value = model.new_cate_id;
			parameters[3].Value = model.new_pic_id;
			parameters[4].Value = model.new_content;
			parameters[5].Value = model.new_valid;
			parameters[6].Value = model.new_ID;

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
		public bool Delete(int new_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_news ");
			strSql.Append(" where new_ID=@new_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@new_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = new_ID;

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
		public bool DeleteList(string new_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_news ");
			strSql.Append(" where new_ID in ("+new_IDlist + ")  ");
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
		public WalleProject.Model.t_news GetModel(int new_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select new_title,new_creatDate,new_cate_id,new_pic_id,new_content,new_valid,new_ID from t_news ");
			strSql.Append(" where new_ID=@new_ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@new_ID", MySqlDbType.Int32)
			};
			parameters[0].Value = new_ID;

			WalleProject.Model.t_news model=new WalleProject.Model.t_news();
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
		/// 得到一个对象实体(三个表连接)
		/// </summary>
		public WalleProject.Model.t_news GetNewsModel(int new_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"select * from t_news inner join t_newscategory on t_news.new_cate_id=t_newscategory.newc_ID 
inner join t_picture on t_news.new_pic_id=t_picture.pic_ID ");
            strSql.Append(" where new_ID=@new_ID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@new_ID", MySqlDbType.Int32)
            };
            parameters[0].Value = new_ID;

            WalleProject.Model.t_news model = new WalleProject.Model.t_news();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                if (row != null)
                {
                    if (row["new_title"] != null)
                    {
                        model.new_title = row["new_title"].ToString();
                    }
                    if (row["new_creatDate"] != null && row["new_creatDate"].ToString() != "")
                    {
                        model.new_creatDate = DateTime.Parse(row["new_creatDate"].ToString());
                    }
                    if (row["new_cate_id"] != null && row["new_cate_id"].ToString() != "")
                    {
                        model.new_cate_id = int.Parse(row["new_cate_id"].ToString());
                    }
                    if (row["new_pic_id"] != null && row["new_pic_id"].ToString() != "")
                    {
                        model.new_pic_id = int.Parse(row["new_pic_id"].ToString());
                    }
                    if (row["new_content"] != null)
                    {
                        model.new_content = row["new_content"].ToString();
                    }
                    if (row["new_valid"] != null)
                    {
                        model.new_valid = row["new_valid"].ToString();
                    }
                    if (row["new_ID"] != null && row["new_ID"].ToString() != "")
                    {
                        model.new_ID = int.Parse(row["new_ID"].ToString());
                    }
                    if (row["newc_name"] != null && row["new_ID"].ToString() != "")
                    {
                        model.newscategory.newc_name = row["newc_name"].ToString();
                    }
                    if (row["pic_valid"] != null && row["new_ID"].ToString() != "")
                    {
                        model.picture.pic_valid = row["pic_valid"].ToString();
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
        public WalleProject.Model.t_news DataRowToModel(DataRow row)
		{
			WalleProject.Model.t_news model=new WalleProject.Model.t_news();
			if (row != null)
			{
				if(row["new_title"]!=null)
				{
					model.new_title=row["new_title"].ToString();
				}
				if(row["new_creatDate"]!=null && row["new_creatDate"].ToString()!="")
				{
					model.new_creatDate=DateTime.Parse(row["new_creatDate"].ToString());
				}
				if(row["new_cate_id"]!=null && row["new_cate_id"].ToString()!="")
				{
					model.new_cate_id=int.Parse(row["new_cate_id"].ToString());
				}
				if(row["new_pic_id"]!=null && row["new_pic_id"].ToString()!="")
				{
					model.new_pic_id=int.Parse(row["new_pic_id"].ToString());
				}
				if(row["new_content"]!=null)
				{
					model.new_content=row["new_content"].ToString();
				}
				if(row["new_valid"]!=null)
				{
					model.new_valid=row["new_valid"].ToString();
				}
				if(row["new_ID"]!=null && row["new_ID"].ToString()!="")
				{
					model.new_ID=int.Parse(row["new_ID"].ToString());
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
			strSql.Append("select new_title,new_creatDate,new_cate_id,new_pic_id,new_content,new_valid,new_ID ");
			strSql.Append(" FROM t_news ");
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
			strSql.Append("select count(1) FROM t_news ");
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
				strSql.Append("order by T.new_ID desc");
			}
			strSql.Append(")AS Row, T.*  from t_news T ");
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
			parameters[0].Value = "t_news";
			parameters[1].Value = "new_ID";
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

