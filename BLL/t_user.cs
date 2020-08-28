using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using WalleProject.Model;
namespace WalleProject.BLL
{
	/// <summary>
	/// t_user
	/// </summary>
	public partial class t_user
	{
		private readonly WalleProject.DAL.t_user dal=new WalleProject.DAL.t_user();
		public t_user()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}
        /// <summary>
        /// 通过电话号码查找是否存在该记录
        /// </summary>
        public bool Exists(string phone) {
            return dal.Exists(phone);
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int u_ID)
		{
			return dal.Exists(u_ID);
		}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="u_id"></param>
        /// <param name="u_passWord"></param>
        /// <returns></returns>
        public bool IsLogin(long u_id, string u_passWord) {
            return dal.IsLogin(u_id, u_passWord);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WalleProject.Model.t_user model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(WalleProject.Model.t_user model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int u_ID)
		{
			
			return dal.Delete(u_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string u_IDlist )
		{
			return dal.DeleteList(u_IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public WalleProject.Model.t_user GetModel(int u_ID)
		{
			
			return dal.GetModel(u_ID);
		}
        /// <summary>
        /// 通过电话号码得到一个对象实体
        /// </summary>
        public WalleProject.Model.t_user GetModel(String phone) {
            return dal.GetModel(phone);
        }
        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public WalleProject.Model.t_user GetModelByCache(int u_ID)
		{
			
			string CacheKey = "t_userModel-" + u_ID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(u_ID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (WalleProject.Model.t_user)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<WalleProject.Model.t_user> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<WalleProject.Model.t_user> DataTableToList(DataTable dt)
		{
			List<WalleProject.Model.t_user> modelList = new List<WalleProject.Model.t_user>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				WalleProject.Model.t_user model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

