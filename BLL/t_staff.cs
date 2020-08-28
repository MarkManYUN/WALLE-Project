using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using WalleProject.Model;
namespace WalleProject.BLL
{
	/// <summary>
	/// t_staff
	/// </summary>
	public partial class t_staff
	{
		private readonly WalleProject.DAL.t_staff dal=new WalleProject.DAL.t_staff();
		public t_staff()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long sta_id)
		{
			return dal.Exists(sta_id);
		}
        public bool IsLogin(long sta_id, string pwd) {
            return dal.IsLogin(sta_id, pwd);
        }
        /// <summary>
        /// 更新员工工资
        /// </summary>
        public bool UpdateSalary(WalleProject.Model.t_staff model) {
            return dal.UpdateSalary(model);
        }
        
            /// <summary>
            /// 增加一条数据
            /// </summary>
            public bool Add(WalleProject.Model.t_staff model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(WalleProject.Model.t_staff model)
		{
			return dal.Update(model);
		}
      
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(long sta_id)
		{
			
			return dal.Delete(sta_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string sta_idlist )
		{
			return dal.DeleteList(sta_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public WalleProject.Model.t_staff GetModel(long sta_id)
		{
			
			return dal.GetModel(sta_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public WalleProject.Model.t_staff GetModelByCache(long sta_id)
		{
			
			string CacheKey = "t_staffModel-" + sta_id;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(sta_id);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (WalleProject.Model.t_staff)objModel;
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
		public DataSet GetSalaryList(string strWhere) {
            return dal.GetSalaryList(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<WalleProject.Model.t_staff> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<WalleProject.Model.t_staff> DataTableToList(DataTable dt)
		{
			List<WalleProject.Model.t_staff> modelList = new List<WalleProject.Model.t_staff>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				WalleProject.Model.t_staff model;
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

