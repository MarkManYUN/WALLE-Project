using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_systemleave:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_systemleave
	{
		public t_systemleave()
		{}
		#region Model
		private int? _sl_sort;
		private string _sl_valid;
		private string _sl_content;
		private int? _sl_pic_id;
		private int? _sl_per_id;
		private int _sl_id;
		private int? _sl_per_type;
		private DateTime? _sl_date;
		/// <summary>
		/// 
		/// </summary>
		public int? sl_sort
		{
			set{ _sl_sort=value;}
			get{return _sl_sort;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sl_valid
		{
			set{ _sl_valid=value;}
			get{return _sl_valid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sl_content
		{
			set{ _sl_content=value;}
			get{return _sl_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sl_pic_id
		{
			set{ _sl_pic_id=value;}
			get{return _sl_pic_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sl_per_id
		{
			set{ _sl_per_id=value;}
			get{return _sl_per_id;}
		}
		/// <summary>
		/// auto_increment
		/// </summary>
		public int sl_id
		{
			set{ _sl_id=value;}
			get{return _sl_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sl_per_type
		{
			set{ _sl_per_type=value;}
			get{return _sl_per_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? sl_date
		{
			set{ _sl_date=value;}
			get{return _sl_date;}
		}
		#endregion Model

	}
}

