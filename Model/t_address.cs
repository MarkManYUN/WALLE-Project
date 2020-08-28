using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_address:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_address
	{
		public t_address()
		{}
		#region Model
		private int _add_u_id;
		private string _add_contactname;
		private string _add_contactphone;
		private DateTime? _add_date;
		private int? _add_postcode;
		private string _add_default;
		private string _add_address;
		private string _add_counties;
		private string _add_city;
		private string _add_province;
		private int _add_id;
		/// <summary>
		/// 
		/// </summary>
		public int add_u_ID
		{
			set{ _add_u_id=value;}
			get{return _add_u_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string add_contactName
		{
			set{ _add_contactname=value;}
			get{return _add_contactname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string add_contactPhone
		{
			set{ _add_contactphone=value;}
			get{return _add_contactphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? add_date
		{
			set{ _add_date=value;}
			get{return _add_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? add_postcode
		{
			set{ _add_postcode=value;}
			get{return _add_postcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string add_default
		{
			set{ _add_default=value;}
			get{return _add_default;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string add_address
		{
			set{ _add_address=value;}
			get{return _add_address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string add_counties
		{
			set{ _add_counties=value;}
			get{return _add_counties;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string add_city
		{
			set{ _add_city=value;}
			get{return _add_city;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string add_province
		{
			set{ _add_province=value;}
			get{return _add_province;}
		}
		/// <summary>
		/// auto_increment
		/// </summary>
		public int add_ID
		{
			set{ _add_id=value;}
			get{return _add_id;}
		}
		#endregion Model

	}
}

