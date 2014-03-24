using System;
namespace Thigh.Model
{
	/// <summary>
	/// Admin:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Admin
	{
		public Admin()
		{}
		#region Model
		private int _adminid;
		private string _adminaccount;
		private string _adminpassword;
		private string _adminname;
		private string _admintype;
		/// <summary>
		/// 
		/// </summary>
		public int AdminID
		{
			set{ _adminid=value;}
			get{return _adminid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AdminAccount
		{
			set{ _adminaccount=value;}
			get{return _adminaccount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AdminPassword
		{
			set{ _adminpassword=value;}
			get{return _adminpassword;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AdminName
		{
			set{ _adminname=value;}
			get{return _adminname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AdminType
		{
			set{ _admintype=value;}
			get{return _admintype;}
		}
		#endregion Model

	}
}

