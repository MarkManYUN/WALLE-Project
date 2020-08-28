using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_staff:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_staff
	{
		public t_staff()
		{}
		#region Model
		private long _sta_id;
		private string _sta_username;
		private DateTime? _sta_entrydate;
		private string _sta_password= "123456";
		private string _sta_maritalstatus;
		private string _sta_idnumber;
		private string _sta_homeaddress;
		private string _sta_phone;
		private string _sta_name;
		private int? _sta__pic_id;
		private int? _sta_tra_id;
		private DateTime? _sta_lastlogindate;
		private decimal? _sta_salary=4000M;
        public Model.t_staffcategory staffcategory = new t_staffcategory();
        public Model.t_picture staffPicture = new t_picture();
		/// <summary>
		/// auto_increment
		/// </summary>
		public long sta_id
		{
			set{ _sta_id=value;}
			get{return _sta_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sta_userName
		{
			set{ _sta_username=value;}
			get{return _sta_username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? sta_entryDate
		{
			set{ _sta_entrydate=value;}
			get{return _sta_entrydate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sta_passWord
		{
			set{ _sta_password=value;}
			get{return _sta_password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sta_maritalStatus
		{
			set{ _sta_maritalstatus=value;}
			get{return _sta_maritalstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sta_IDNumber
		{
			set{ _sta_idnumber=value;}
			get{return _sta_idnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sta_homeAddress
		{
			set{ _sta_homeaddress=value;}
			get{return _sta_homeaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sta_phone
		{
			set{ _sta_phone=value;}
			get{return _sta_phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sta_name
		{
			set{ _sta_name=value;}
			get{return _sta_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sta__pic_id
		{
			set{ _sta__pic_id=value;}
			get{return _sta__pic_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sta_tra_id
		{
			set{ _sta_tra_id=value;}
			get{return _sta_tra_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? sta_lastLogindate
		{
			set{ _sta_lastlogindate=value;}
			get{return _sta_lastlogindate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? sta_salary
		{
			set{ _sta_salary=value;}
			get{return _sta_salary;}
		}
		#endregion Model

	}
}

