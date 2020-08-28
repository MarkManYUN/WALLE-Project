using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_staffcategory:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_staffcategory
	{
		public t_staffcategory()
		{}
		#region Model
		private string _stac_name;
		private int _stac_id;
		/// <summary>
		/// 
		/// </summary>
		public string stac_name
		{
			set{ _stac_name=value;}
			get{return _stac_name;}
		}
		/// <summary>
		/// auto_increment
		/// </summary>
		public int stac_ID
		{
			set{ _stac_id=value;}
			get{return _stac_id;}
		}
		#endregion Model

	}
}

