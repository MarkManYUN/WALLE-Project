using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_filecategory:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_filecategory
	{
		public t_filecategory()
		{}
		#region Model
		private int _filec_id;
		private string _filec_name;
		private string _filec_path;
		private string _file_ext;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int filec_ID
		{
			set{ _filec_id=value;}
			get{return _filec_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string filec_name
		{
			set{ _filec_name=value;}
			get{return _filec_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string filec_path
		{
			set{ _filec_path=value;}
			get{return _filec_path;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string file_ext
		{
			set{ _file_ext=value;}
			get{return _file_ext;}
		}
		#endregion Model

	}
}

