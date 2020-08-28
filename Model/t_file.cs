using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_file:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_file
	{
		public t_file()
		{}
		#region Model
		private int _file_id;
		private DateTime? _file_date;
		private string _file_title;
		private int? _file_catefory_id;
		private string _file_name;
		private string _file_valid;
        public Model.t_filecategory file = new t_filecategory();
		/// <summary>
		/// auto_increment
		/// </summary>
		public int file_ID
		{
			set{ _file_id=value;}
			get{return _file_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? file_date
		{
			set{ _file_date=value;}
			get{return _file_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string file_title
		{
			set{ _file_title=value;}
			get{return _file_title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? file_catefory_ID
		{
			set{ _file_catefory_id=value;}
			get{return _file_catefory_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string file_Name
		{
			set{ _file_name=value;}
			get{return _file_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string file_valid
		{
			set{ _file_valid=value;}
			get{return _file_valid;}
		}
		#endregion Model

	}
}

