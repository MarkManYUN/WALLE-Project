using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_newscategory:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_newscategory
	{
		public t_newscategory()
		{}
		#region Model
		private string _newc_name;
		private int _newc_id;
		/// <summary>
		/// 
		/// </summary>
		public string newc_name
		{
			set{ _newc_name=value;}
			get{return _newc_name;}
		}
		/// <summary>
		/// auto_increment
		/// </summary>
		public int newc_ID
		{
			set{ _newc_id=value;}
			get{return _newc_id;}
		}
		#endregion Model

	}
}

