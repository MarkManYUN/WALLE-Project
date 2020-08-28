using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_picture:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_picture
	{
		public t_picture()
		{}
		#region Model
		private int? _pic_cate_id;
		private int _pic_id;
		private DateTime? _pic_date;
		private string _pic_name;
		private string _pic_valid;
        public Model.t_picturecategory picturecategory = new t_picturecategory();
		/// <summary>
		/// 
		/// </summary>
		public int? pic_cate_ID
		{
			set{ _pic_cate_id=value;}
			get{return _pic_cate_id;}
		}
		/// <summary>
		/// auto_increment
		/// </summary>
		public int pic_ID
		{
			set{ _pic_id=value;}
			get{return _pic_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? pic_date
		{
			set{ _pic_date=value;}
			get{return _pic_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pic_name
		{
			set{ _pic_name=value;}
			get{return _pic_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pic_valid
		{
			set{ _pic_valid=value;}
			get{return _pic_valid;}
		}
		#endregion Model

	}
}

