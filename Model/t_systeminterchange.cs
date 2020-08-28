using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_systeminterchange:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_systeminterchange
	{
		public t_systeminterchange()
		{}
		#region Model
		private int? _si_sort;
		private string _si_vaild;
		private DateTime? _si_date;
		private string _si_content;
		private string _si_per_type;
		private int? _si_pic_id;
		private int? _si_per_id;
		private int? _si_sl_id;
		private int _si_id;
		/// <summary>
		/// 
		/// </summary>
		public int? si_sort
		{
			set{ _si_sort=value;}
			get{return _si_sort;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string si_vaild
		{
			set{ _si_vaild=value;}
			get{return _si_vaild;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? si_date
		{
			set{ _si_date=value;}
			get{return _si_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string si_content
		{
			set{ _si_content=value;}
			get{return _si_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string si_per_type
		{
			set{ _si_per_type=value;}
			get{return _si_per_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? si_pic_id
		{
			set{ _si_pic_id=value;}
			get{return _si_pic_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? si_per_id
		{
			set{ _si_per_id=value;}
			get{return _si_per_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? si_sl_id
		{
			set{ _si_sl_id=value;}
			get{return _si_sl_id;}
		}
		/// <summary>
		/// auto_increment
		/// </summary>
		public int si_id
		{
			set{ _si_id=value;}
			get{return _si_id;}
		}
		#endregion Model

	}
}

