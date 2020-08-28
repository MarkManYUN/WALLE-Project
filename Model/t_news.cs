using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_news:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_news
	{
		public t_news()
		{}
		#region Model
		private string _new_title;
		private DateTime? _new_creatdate;
		private int? _new_cate_id;
		private int? _new_pic_id;
		private string _new_content;
		private string _new_valid;
		private int _new_id;
        public Model.t_picture picture = new t_picture();
        public Model.t_newscategory newscategory = new t_newscategory();
		/// <summary>
		/// 
		/// </summary>
		public string new_title
		{
			set{ _new_title=value;}
			get{return _new_title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? new_creatDate
		{
			set{ _new_creatdate=value;}
			get{return _new_creatdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? new_cate_id
		{
			set{ _new_cate_id=value;}
			get{return _new_cate_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? new_pic_id
		{
			set{ _new_pic_id=value;}
			get{return _new_pic_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string new_content
		{
			set{ _new_content=value;}
			get{return _new_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string new_valid
		{
			set{ _new_valid=value;}
			get{return _new_valid;}
		}
		/// <summary>
		/// auto_increment
		/// </summary>
		public int new_ID
		{
			set{ _new_id=value;}
			get{return _new_id;}
		}
		#endregion Model

	}
}

