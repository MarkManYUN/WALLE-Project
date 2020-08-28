using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_menucategory:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_menucategory
	{
		public t_menucategory()
		{}
		#region Model
		private int _menuc_id;
		private string _menuc_name;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int menuc_ID
		{
			set{ _menuc_id=value;}
			get{return _menuc_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string menuc_name
		{
			set{ _menuc_name=value;}
			get{return _menuc_name;}
		}
		#endregion Model

	}
}

