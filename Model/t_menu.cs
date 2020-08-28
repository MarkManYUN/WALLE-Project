using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_menu:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_menu
	{
		public t_menu()
		{}
		#region Model
		private int _menu_id;
		private int? _menu_cate_id;
		private string _menu_name;
		private int? _menu_sort;
		private string _menu_path;
		private string _menu_valid;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int menu_ID
		{
			set{ _menu_id=value;}
			get{return _menu_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? menu_Cate_ID
		{
			set{ _menu_cate_id=value;}
			get{return _menu_cate_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string menu_name
		{
			set{ _menu_name=value;}
			get{return _menu_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? menu_sort
		{
			set{ _menu_sort=value;}
			get{return _menu_sort;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string menu_path
		{
			set{ _menu_path=value;}
			get{return _menu_path;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string menu_valid
		{
			set{ _menu_valid=value;}
			get{return _menu_valid;}
		}
		#endregion Model

	}
}

