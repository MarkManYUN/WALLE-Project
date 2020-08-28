using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_user:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_user
	{
		public t_user()
		{}
		#region Model
		private string _u_address;
		private DateTime? _u_lastlogindate;
		private int? _u_creaditslogid;
		private DateTime? _u_registrationdate;
		private int _u_id;
		private string _u_nickname;
		private string _u_category="普通";
		private DateTime? _u_birthdate;
		private string _u_state= "正常";
		private string _u_password= "123456";
		private int _u_integral=10;
		private string _u_creditgrade= "良好";
		private string _u_name;
		private int _u_pic_id=5;
        private string _u_phone;
        /// <summary>
		/// 
		/// </summary>
		public string u_phone
        {
            set { _u_phone = value; }
            get { return _u_phone; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string u_address
		{
			set{ _u_address=value;}
			get{return _u_address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? u_lastLoginDate
		{
			set{ _u_lastlogindate=value;}
			get{return _u_lastlogindate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? u_creaditsLogID
		{
			set{ _u_creaditslogid=value;}
			get{return _u_creaditslogid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? u_registrationDate
		{
			set{ _u_registrationdate=value;}
			get{return _u_registrationdate;}
		}
		/// <summary>
		/// auto_increment
		/// </summary>
		public int u_ID
		{
			set{ _u_id=value;}
			get{return _u_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string u_nickName
		{
			set{ _u_nickname=value;}
			get{return _u_nickname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string u_category
		{
			set{ _u_category=value;}
			get{return _u_category;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? u_birthDate
		{
			set{ _u_birthdate=value;}
			get{return _u_birthdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string u_state
		{
			set{ _u_state=value;}
			get{return _u_state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string u_passWord
		{
			set{ _u_password=value;}
			get{return _u_password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int u_integral
		{
			set{ _u_integral=value;}
			get{return _u_integral;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string u_creditGrade
		{
			set{ _u_creditgrade=value;}
			get{return _u_creditgrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string u_name
		{
			set{ _u_name=value;}
			get{return _u_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int u_pic_ID
		{
			set{ _u_pic_id=value;}
			get{return _u_pic_id;}
		}
		#endregion Model

	}
}

