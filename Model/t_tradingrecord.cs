using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_tradingrecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_tradingrecord
	{
		public t_tradingrecord()
		{}
		#region Model
		private int? _tra_u_id;
		private decimal? _tra_transactionamount;
		private DateTime? _tra_transactiondate;
		private string _tra_accomplish;
		private int? _tra_staff_id;
		private int? _sta_comwas_id;
		private int? _tra_number;
		private int _tra_id;
		private int? _tra_addressid;
		private string _tra_type;
		private string _tra_vaild;
		private int? _tra_sort;
		/// <summary>
		/// 
		/// </summary>
		public int? tra_U_ID
		{
			set{ _tra_u_id=value;}
			get{return _tra_u_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? tra_transactionAmount
		{
			set{ _tra_transactionamount=value;}
			get{return _tra_transactionamount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? tra_transactionDate
		{
			set{ _tra_transactiondate=value;}
			get{return _tra_transactiondate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tra_accomplish
		{
			set{ _tra_accomplish=value;}
			get{return _tra_accomplish;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? tra_staff_id
		{
			set{ _tra_staff_id=value;}
			get{return _tra_staff_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sta_comwas_id
		{
			set{ _sta_comwas_id=value;}
			get{return _sta_comwas_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? tra_number
		{
			set{ _tra_number=value;}
			get{return _tra_number;}
		}
		/// <summary>
		/// auto_increment
		/// </summary>
		public int tra_ID
		{
			set{ _tra_id=value;}
			get{return _tra_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? tra_addressID
		{
			set{ _tra_addressid=value;}
			get{return _tra_addressid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tra_type
		{
			set{ _tra_type=value;}
			get{return _tra_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tra_vaild
		{
			set{ _tra_vaild=value;}
			get{return _tra_vaild;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? tra_sort
		{
			set{ _tra_sort=value;}
			get{return _tra_sort;}
		}
		#endregion Model

	}
}

