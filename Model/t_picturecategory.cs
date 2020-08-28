using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_picturecategory:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_picturecategory
	{
		public t_picturecategory()
		{}
		#region Model
		private int _picca_id;
		private string _picca_name;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int picca_ID
		{
			set{ _picca_id=value;}
			get{return _picca_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string picca_name
		{
			set{ _picca_name=value;}
			get{return _picca_name;}
		}
		#endregion Model

	}
}

