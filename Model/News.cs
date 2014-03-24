using System;
namespace Thigh.Model
{
	/// <summary>
	/// News:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class News
	{
		public News()
		{}
		#region Model
		private int _newsid;
		private string _newstitle;
		private string _newscontent;
		private string _keywords;
		private string _description;
		private string _picurl;
		private string _pubtime;
		private string _source;
		private string _clicktime;
		private string _state;
		private string _newstypeid;
		private string _newstypename;
		private string _adminid;
		private string _adminname;
		/// <summary>
		/// 新闻ID
		/// </summary>
		public int NewsID
		{
			set{ _newsid=value;}
			get{return _newsid;}
		}
		/// <summary>
		/// 新闻标题
		/// </summary>
		public string NewsTitle
		{
			set{ _newstitle=value;}
			get{return _newstitle;}
		}
		/// <summary>
		/// 新闻内容
		/// </summary>
		public string NewsContent
		{
			set{ _newscontent=value;}
			get{return _newscontent;}
		}
		/// <summary>
		/// 关键词
		/// </summary>
		public string Keywords
		{
			set{ _keywords=value;}
			get{return _keywords;}
		}
		/// <summary>
		/// 描述
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 封面图片路径
		/// </summary>
		public string PicUrl
		{
			set{ _picurl=value;}
			get{return _picurl;}
		}
		/// <summary>
		/// 发布时间
		/// </summary>
		public string PubTime
		{
			set{ _pubtime=value;}
			get{return _pubtime;}
		}
		/// <summary>
		/// 文章来源
		/// </summary>
		public string Source
		{
			set{ _source=value;}
			get{return _source;}
		}
		/// <summary>
		/// 点击次数
		/// </summary>
		public string ClickTime
		{
			set{ _clicktime=value;}
			get{return _clicktime;}
		}
		/// <summary>
		/// 启用状态
		/// </summary>
		public string State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 新闻分类ID
		/// </summary>
		public string NewsTypeID
		{
			set{ _newstypeid=value;}
			get{return _newstypeid;}
		}
		/// <summary>
		/// 新闻分类名称
		/// </summary>
		public string NewsTypeName
		{
			set{ _newstypename=value;}
			get{return _newstypename;}
		}
		/// <summary>
		/// 管理员编号
		/// </summary>
		public string AdminID
		{
			set{ _adminid=value;}
			get{return _adminid;}
		}
		/// <summary>
		/// 管理员名称
		/// </summary>
		public string AdminName
		{
			set{ _adminname=value;}
			get{return _adminname;}
		}
		#endregion Model

	}
}

