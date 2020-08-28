using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_commodity:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_commodity
	{
		public t_commodity()
		{}
		#region Model
		private int _com_id;
		private string _com_name;
		private DateTime? _com_productdate;
		private int? _com_number;
		private string _com_strageid;
		private int? _com_alertnumber;
		private int? _com_pic_id;
		private DateTime? _com_date;
		private decimal? _com_pri_id;
		private int? _com_conversionint;
		private int? _com_comc_id;
		private string _com_valid;
        public Model.t_commoditycategory commoditycategory = new t_commoditycategory();
		/// <summary>
		/// auto_increment
		/// </summary>
		public int com_ID
		{
			set{ _com_id=value;}
			get{return _com_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string com_name
		{
			set{ _com_name=value;}
			get{return _com_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? com_productDate
		{
			set{ _com_productdate=value;}
			get{return _com_productdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? com_number
		{
			set{ _com_number=value;}
			get{return _com_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string com_strageID
		{
			set{ _com_strageid=value;}
			get{return _com_strageid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? com_alertNumber
		{
			set{ _com_alertnumber=value;}
			get{return _com_alertnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? com_pic_ID
		{
			set{ _com_pic_id=value;}
			get{return _com_pic_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? com_date
		{
			set{ _com_date=value;}
			get{return _com_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? com_pri_ID
		{
			set{ _com_pri_id=value;}
			get{return _com_pri_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? com_conversionInt
		{
			set{ _com_conversionint=value;}
			get{return _com_conversionint;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? com_comc_ID
		{
			set{ _com_comc_id=value;}
			get{return _com_comc_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string com_valid
		{
			set{ _com_valid=value;}
			get{return _com_valid;}
		}
		#endregion Model

	}
}

