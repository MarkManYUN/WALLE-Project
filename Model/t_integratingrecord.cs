using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_integratingrecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_integratingrecord
	{
		public t_integratingrecord()
		{}
		#region Model
		private int _int_id;
		private DateTime? _int_date;
		private int? _int_integral;
		private string _int_way;
		private int? _int_u_id;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int int_ID
		{
			set{ _int_id=value;}
			get{return _int_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? int_date
		{
			set{ _int_date=value;}
			get{return _int_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? int_integral
		{
			set{ _int_integral=value;}
			get{return _int_integral;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string int_way
		{
			set{ _int_way=value;}
			get{return _int_way;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? int_u_ID
		{
			set{ _int_u_id=value;}
			get{return _int_u_id;}
		}
		#endregion Model

	}
}

