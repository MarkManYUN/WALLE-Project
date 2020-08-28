using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_waste:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_waste
	{
		public t_waste()
		{}
		#region Model
		private int? _was_pic_id;
		private int _was_id;
		private string _was_name;
		private decimal? _was_price;
		private Int32 _was_recoverable = 1;
		private int? _was_number=0;
		private int? _was_cate_id;
		private string _was_valid;
        public Model.t_wastecategory wastecategory = new t_wastecategory();
		/// <summary>
		/// 
		/// </summary>
		public int? was_pic_ID
		{
			set{ _was_pic_id=value;}
			get{return _was_pic_id;}
		}
		/// <summary>
		/// auto_increment
		/// </summary>
		public int was_ID
		{
			set{ _was_id=value;}
			get{return _was_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string was_name
		{
			set{ _was_name=value;}
			get{return _was_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? was_price
		{
			set{ _was_price=value;}
			get{return _was_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Int32 was_recoverable
		{
			set{ _was_recoverable=value;}
			get{return _was_recoverable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? was_number
		{
			set{ _was_number=value;}
			get{return _was_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? was_cate_ID
		{
			set{ _was_cate_id=value;}
			get{return _was_cate_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string was_valid
		{
			set{ _was_valid=value;}
			get{return _was_valid;}
		}
		#endregion Model

	}
}

