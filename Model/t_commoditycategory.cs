using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_commoditycategory:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_commoditycategory
	{
		public t_commoditycategory()
		{}
		#region Model
		private string _comc_name;
		private int _comc_id;
		/// <summary>
		/// 
		/// </summary>
		public string comc_name
		{
			set{ _comc_name=value;}
			get{return _comc_name;}
		}
		/// <summary>
		/// auto_increment
		/// </summary>
		public int comc_ID
		{
			set{ _comc_id=value;}
			get{return _comc_id;}
		}
		#endregion Model

	}
}

