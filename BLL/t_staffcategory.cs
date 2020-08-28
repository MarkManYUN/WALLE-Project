﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using WalleProject.Model;
namespace WalleProject.BLL
{
	/// <summary>
	/// t_staffcategory
	/// </summary>
	public partial class t_staffcategory
	{
		private readonly WalleProject.DAL.t_staffcategory dal=new WalleProject.DAL.t_staffcategory();
		public t_staffcategory()
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
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int stac_ID)
		{
			return dal.Exists(stac_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WalleProject.Model.t_staffcategory model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(WalleProject.Model.t_staffcategory model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int stac_ID)
		{
			
			return dal.Delete(stac_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string stac_IDlist )
		{
			return dal.DeleteList(stac_IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public WalleProject.Model.t_staffcategory GetModel(int stac_ID)
		{
			
			return dal.GetModel(stac_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public WalleProject.Model.t_staffcategory GetModelByCache(int stac_ID)
		{
			
			string CacheKey = "t_staffcategoryModel-" + stac_ID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(stac_ID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (WalleProject.Model.t_staffcategory)objModel;
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
		public List<WalleProject.Model.t_staffcategory> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<WalleProject.Model.t_staffcategory> DataTableToList(DataTable dt)
		{
			List<WalleProject.Model.t_staffcategory> modelList = new List<WalleProject.Model.t_staffcategory>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				WalleProject.Model.t_staffcategory model;
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

