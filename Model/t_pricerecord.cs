using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_pricerecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_pricerecord
	{
		public t_pricerecord()
		{}
		#region Model
		private DateTime? _pri_date;
		private decimal? _pri_price;
		private int? _pri_com_id;
		private int _pri_id;
		/// <summary>
		/// 
		/// </summary>
		public DateTime? pri_date
		{
			set{ _pri_date=value;}
			get{return _pri_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? pri_price
		{
			set{ _pri_price=value;}
			get{return _pri_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? pri_com_ID
		{
			set{ _pri_com_id=value;}
			get{return _pri_com_id;}
		}
		/// <summary>
		/// auto_increment
		/// </summary>
		public int pri_ID
		{
			set{ _pri_id=value;}
			get{return _pri_id;}
		}
		#endregion Model

	}
}

