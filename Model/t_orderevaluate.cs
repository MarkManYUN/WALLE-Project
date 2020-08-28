using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_orderevaluate:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_orderevaluate
	{
		public t_orderevaluate()
		{}
		#region Model
		private int? _oe_sort;
		private string _oe_vaild;
		private int? _oe_grade;
		private string _oe_isread= "否";
		private string _oe_per_type;
		private string _oe_content;
		private int? _oe_tra_id;
		private int? _oe_per_id;
		private int? _oe_pic_id;
		private int _oe_id;
		private DateTime? _oe_date;
		/// <summary>
		/// 
		/// </summary>
		public int? oe_sort
		{
			set{ _oe_sort=value;}
			get{return _oe_sort;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string oe_vaild
		{
			set{ _oe_vaild=value;}
			get{return _oe_vaild;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? oe_grade
		{
			set{ _oe_grade=value;}
			get{return _oe_grade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string oe_isread
		{
			set{ _oe_isread=value;}
			get{return _oe_isread;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string oe_per_type
		{
			set{ _oe_per_type=value;}
			get{return _oe_per_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string oe_content
		{
			set{ _oe_content=value;}
			get{return _oe_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? oe_tra_id
		{
			set{ _oe_tra_id=value;}
			get{return _oe_tra_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? oe_per_id
		{
			set{ _oe_per_id=value;}
			get{return _oe_per_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? oe_pic_id
		{
			set{ _oe_pic_id=value;}
			get{return _oe_pic_id;}
		}
		/// <summary>
		/// auto_increment
		/// </summary>
		public int oe_id
		{
			set{ _oe_id=value;}
			get{return _oe_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? oe_date
		{
			set{ _oe_date=value;}
			get{return _oe_date;}
		}
		#endregion Model

	}
}

