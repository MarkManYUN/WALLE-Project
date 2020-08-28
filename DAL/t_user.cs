using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WalleProject.DAL
{
    /// <summary>
    /// 数据访问类:t_user
    /// </summary>
    public partial class t_user
    {
        public t_user()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("u_ID", "t_user");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int u_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from t_user");
            strSql.Append(" where u_ID=@u_ID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@u_ID", MySqlDbType.Int32)
            };
            parameters[0].Value = u_ID;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 通过电话号码查找是否存在该记录
        /// </summary>
        public bool Exists(string phone)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from t_user");
            strSql.Append(" where u_phone=@u_phone");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@u_phone", MySqlDbType.String)
            };
            parameters[0].Value = phone;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sta_id"></param>
        /// <param name="sta_passWord"></param>
        /// <returns></returns>
        public bool IsLogin(long u_id, string u_passWord)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from t_user");
            strSql.Append(" where u_ID=@u_id and u_passWord=@u_passWord");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@u_ID", MySqlDbType.Int32),
                    new MySqlParameter("@u_passWord", MySqlDbType.String)

            };
            parameters[0].Value = u_id;
            parameters[1].Value = u_passWord;
            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WalleProject.Model.t_user model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into t_user(");
            strSql.Append("u_address,u_lastLoginDate,u_creaditsLogID,u_registrationDate,u_nickName,u_category,u_birthDate,u_state,u_passWord,u_integral,u_creditGrade,u_name,u_pic_ID,u_phone)");
            strSql.Append(" values (");
            strSql.Append("@u_address,@u_lastLoginDate,@u_creaditsLogID,@u_registrationDate,@u_nickName,@u_category,@u_birthDate,@u_state,@u_passWord,@u_integral,@u_creditGrade,@u_name,@u_pic_ID,@u_phone)");
            MySqlParameter[] parameters = {

                    new MySqlParameter("@u_address", MySqlDbType.VarChar,50),
                    new MySqlParameter("@u_lastLoginDate", MySqlDbType.DateTime),
                    new MySqlParameter("@u_creaditsLogID", MySqlDbType.Int32,10),
                    new MySqlParameter("@u_registrationDate", MySqlDbType.Date),
                    new MySqlParameter("@u_nickName", MySqlDbType.VarChar,10),
                    new MySqlParameter("@u_category", MySqlDbType.VarChar,10),
                    new MySqlParameter("@u_birthDate", MySqlDbType.Date),
                    new MySqlParameter("@u_state", MySqlDbType.VarChar,10),
                    new MySqlParameter("@u_passWord", MySqlDbType.VarChar,10),
                    new MySqlParameter("@u_integral", MySqlDbType.Int32,10),
                    new MySqlParameter("@u_creditGrade", MySqlDbType.VarChar,10),
                    new MySqlParameter("@u_name", MySqlDbType.VarChar,10),
                    new MySqlParameter("@u_pic_ID", MySqlDbType.Int32,10),
                new MySqlParameter("@u_phone", MySqlDbType.VarChar,20)};
            parameters[0].Value = model.u_address;
            parameters[1].Value = model.u_lastLoginDate;
            parameters[2].Value = model.u_creaditsLogID;
            parameters[3].Value = model.u_registrationDate;
            parameters[4].Value = model.u_nickName;
            parameters[5].Value = model.u_category;
            parameters[6].Value = model.u_birthDate;
            parameters[7].Value = model.u_state;
            parameters[8].Value = model.u_passWord;
            parameters[9].Value = model.u_integral;
            parameters[10].Value = model.u_creditGrade;
            parameters[11].Value = model.u_name;
            parameters[12].Value = model.u_pic_ID;
            parameters[13].Value = model.u_phone;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(WalleProject.Model.t_user model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update t_user set ");


            strSql.Append("u_address=@u_address,");
            strSql.Append("u_lastLoginDate=@u_lastLoginDate,");
            strSql.Append("u_creaditsLogID=@u_creaditsLogID,");
            strSql.Append("u_registrationDate=@u_registrationDate,");
            strSql.Append("u_nickName=@u_nickName,");
            strSql.Append("u_category=@u_category,");
            strSql.Append("u_birthDate=@u_birthDate,");
            strSql.Append("u_state=@u_state,");
            strSql.Append("u_passWord=@u_passWord,");
            strSql.Append("u_integral=@u_integral,");
            strSql.Append("u_creditGrade=@u_creditGrade,");
            strSql.Append("u_name=@u_name,");
            strSql.Append("u_pic_ID=@u_pic_ID,");
            strSql.Append("u_phone=@u_phone ");
            strSql.Append(" where u_ID=@u_ID");
            MySqlParameter[] parameters = {

   new MySqlParameter("@u_address", MySqlDbType.VarChar,50),
                    new MySqlParameter("@u_lastLoginDate", MySqlDbType.DateTime),
                    new MySqlParameter("@u_creaditsLogID", MySqlDbType.Int32,10),
                    new MySqlParameter("@u_registrationDate", MySqlDbType.Date),
                    new MySqlParameter("@u_nickName", MySqlDbType.VarChar,10),
                    new MySqlParameter("@u_category", MySqlDbType.VarChar,10),
                    new MySqlParameter("@u_birthDate", MySqlDbType.Date),
                    new MySqlParameter("@u_state", MySqlDbType.VarChar,10),
                    new MySqlParameter("@u_passWord", MySqlDbType.VarChar,10),
                    new MySqlParameter("@u_integral", MySqlDbType.Int32,10),
                    new MySqlParameter("@u_creditGrade", MySqlDbType.VarChar,10),
                    new MySqlParameter("@u_name", MySqlDbType.VarChar,10),
                    new MySqlParameter("@u_pic_ID", MySqlDbType.Int32,10),
                new MySqlParameter("@u_phone", MySqlDbType.VarChar,20),
                    new MySqlParameter("@u_ID", MySqlDbType.Int32,10)};

            parameters[0].Value = model.u_address;
            parameters[1].Value = model.u_lastLoginDate;
            parameters[2].Value = model.u_creaditsLogID;
            parameters[3].Value = model.u_registrationDate;
            parameters[4].Value = model.u_nickName;
            parameters[5].Value = model.u_category;
            parameters[6].Value = model.u_birthDate;
            parameters[7].Value = model.u_state;
            parameters[8].Value = model.u_passWord;
            parameters[9].Value = model.u_integral;
            parameters[10].Value = model.u_creditGrade;
            parameters[11].Value = model.u_name;
            parameters[12].Value = model.u_pic_ID;
            parameters[13].Value = model.u_phone;
            parameters[14].Value = model.u_ID;

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
        public bool Delete(int u_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from t_user ");
            strSql.Append(" where u_ID=@u_ID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@u_ID", MySqlDbType.Int32)
            };
            parameters[0].Value = u_ID;

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string u_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from t_user ");
            strSql.Append(" where u_ID in (" + u_IDlist + ")  ");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        public WalleProject.Model.t_user GetModel(int u_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  u_phone,u_address,u_lastLoginDate,u_creaditsLogID,u_registrationDate,u_ID,u_nickName,u_category,u_birthDate,u_state,u_passWord,u_integral,u_creditGrade,u_name,u_pic_ID from t_user ");
            strSql.Append(" where u_ID=@u_ID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@u_ID", MySqlDbType.Int32)
            };
            parameters[0].Value = u_ID;

            WalleProject.Model.t_user model = new WalleProject.Model.t_user();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 通过电话号码得到一个对象实体
        /// </summary>
        public WalleProject.Model.t_user GetModel(String phone)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  u_phone,u_address,u_lastLoginDate,u_creaditsLogID,u_registrationDate,u_ID,u_nickName,u_category,u_birthDate,u_state,u_passWord,u_integral,u_creditGrade,u_name,u_pic_ID from t_user ");
            strSql.Append(" where u_phone=@u_phone");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@u_phone", MySqlDbType.String)
            };
            parameters[0].Value = phone;

            WalleProject.Model.t_user model = new WalleProject.Model.t_user();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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
        public WalleProject.Model.t_user DataRowToModel(DataRow row)
        {
            WalleProject.Model.t_user model = new WalleProject.Model.t_user();
            if (row != null)
            {
                if (row["u_address"] != null)
                {
                    model.u_address = row["u_address"].ToString();
                }
                if (row["u_phone"] != null)
                {
                    model.u_phone = row["u_phone"].ToString();
                }
                if (row["u_lastLoginDate"] != null && row["u_lastLoginDate"].ToString() != "")
                {
                    model.u_lastLoginDate = DateTime.Parse(row["u_lastLoginDate"].ToString());
                }
                if (row["u_creaditsLogID"] != null && row["u_creaditsLogID"].ToString() != "")
                {
                    model.u_creaditsLogID = int.Parse(row["u_creaditsLogID"].ToString());
                }
                if (row["u_registrationDate"] != null && row["u_registrationDate"].ToString() != "")
                {
                    model.u_registrationDate = DateTime.Parse(row["u_registrationDate"].ToString());
                }
                if (row["u_ID"] != null && row["u_ID"].ToString() != "")
                {
                    model.u_ID = int.Parse(row["u_ID"].ToString());
                }
                if (row["u_nickName"] != null)
                {
                    model.u_nickName = row["u_nickName"].ToString();
                }
                if (row["u_category"] != null)
                {
                    model.u_category = row["u_category"].ToString();
                }
                if (row["u_birthDate"] != null && row["u_birthDate"].ToString() != "")
                {
                    model.u_birthDate = DateTime.Parse(row["u_birthDate"].ToString());
                }
                if (row["u_state"] != null)
                {
                    model.u_state = row["u_state"].ToString();
                }
                if (row["u_passWord"] != null)
                {
                    model.u_passWord = row["u_passWord"].ToString();
                }
                if (row["u_integral"] != null && row["u_integral"].ToString() != "")
                {
                    model.u_integral = int.Parse(row["u_integral"].ToString());
                }
                if (row["u_creditGrade"] != null)
                {
                    model.u_creditGrade = row["u_creditGrade"].ToString();
                }
                if (row["u_name"] != null)
                {
                    model.u_name = row["u_name"].ToString();
                }
                if (row["u_pic_ID"] != null && row["u_pic_ID"].ToString() != "")
                {
                    model.u_pic_ID = int.Parse(row["u_pic_ID"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select u_phone,u_address,u_lastLoginDate,u_creaditsLogID,u_registrationDate,u_ID,u_nickName,u_category,u_birthDate,u_state,u_passWord,u_integral,u_creditGrade,u_name,u_pic_ID ");
            strSql.Append(" FROM t_user ");
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM t_user ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.u_ID desc");
            }
            strSql.Append(")AS Row, T.*  from t_user T ");
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
			parameters[0].Value = "t_user";
			parameters[1].Value = "u_ID";
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

