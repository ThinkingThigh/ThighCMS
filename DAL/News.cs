using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Maticsoft.DBUtility;//Please add references
namespace Thigh.DAL
{
	/// <summary>
	/// 数据访问类:News
	/// </summary>
	public partial class News
	{
		public News()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("NewsID", "tb_News"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int NewsID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_News");
			strSql.Append(" where NewsID=@NewsID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@NewsID", OleDbType.Integer,4)
			};
			parameters[0].Value = NewsID;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Thigh.Model.News model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_News(");
			strSql.Append("NewsTitle,NewsContent,Keywords,Description,PicUrl,PubTime,Source,ClickTime,State,NewsTypeID,NewsTypeName,AdminID,AdminName)");
			strSql.Append(" values (");
			strSql.Append("@NewsTitle,@NewsContent,@Keywords,@Description,@PicUrl,@PubTime,@Source,@ClickTime,@State,@NewsTypeID,@NewsTypeName,@AdminID,@AdminName)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@NewsTitle", OleDbType.VarChar,50),
					new OleDbParameter("@NewsContent", OleDbType.VarChar,0),
					new OleDbParameter("@Keywords", OleDbType.VarChar,50),
					new OleDbParameter("@Description", OleDbType.VarChar,50),
					new OleDbParameter("@PicUrl", OleDbType.VarChar,50),
					new OleDbParameter("@PubTime", OleDbType.VarChar,50),
					new OleDbParameter("@Source", OleDbType.VarChar,50),
					new OleDbParameter("@ClickTime", OleDbType.VarChar,50),
					new OleDbParameter("@State", OleDbType.VarChar,50),
					new OleDbParameter("@NewsTypeID", OleDbType.VarChar,50),
					new OleDbParameter("@NewsTypeName", OleDbType.VarChar,50),
					new OleDbParameter("@AdminID", OleDbType.VarChar,50),
					new OleDbParameter("@AdminName", OleDbType.VarChar,50)};
			parameters[0].Value = model.NewsTitle;
			parameters[1].Value = model.NewsContent;
			parameters[2].Value = model.Keywords;
			parameters[3].Value = model.Description;
			parameters[4].Value = model.PicUrl;
			parameters[5].Value = model.PubTime;
			parameters[6].Value = model.Source;
			parameters[7].Value = model.ClickTime;
			parameters[8].Value = model.State;
			parameters[9].Value = model.NewsTypeID;
			parameters[10].Value = model.NewsTypeName;
			parameters[11].Value = model.AdminID;
			parameters[12].Value = model.AdminName;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Thigh.Model.News model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_News set ");
			strSql.Append("NewsTitle=@NewsTitle,");
			strSql.Append("NewsContent=@NewsContent,");
			strSql.Append("Keywords=@Keywords,");
			strSql.Append("Description=@Description,");
			strSql.Append("PicUrl=@PicUrl,");
			strSql.Append("PubTime=@PubTime,");
			strSql.Append("Source=@Source,");
			strSql.Append("ClickTime=@ClickTime,");
			strSql.Append("State=@State,");
			strSql.Append("NewsTypeID=@NewsTypeID,");
			strSql.Append("NewsTypeName=@NewsTypeName,");
			strSql.Append("AdminID=@AdminID,");
			strSql.Append("AdminName=@AdminName");
			strSql.Append(" where NewsID=@NewsID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@NewsTitle", OleDbType.VarChar,50),
					new OleDbParameter("@NewsContent", OleDbType.VarChar,0),
					new OleDbParameter("@Keywords", OleDbType.VarChar,50),
					new OleDbParameter("@Description", OleDbType.VarChar,50),
					new OleDbParameter("@PicUrl", OleDbType.VarChar,50),
					new OleDbParameter("@PubTime", OleDbType.VarChar,50),
					new OleDbParameter("@Source", OleDbType.VarChar,50),
					new OleDbParameter("@ClickTime", OleDbType.VarChar,50),
					new OleDbParameter("@State", OleDbType.VarChar,50),
					new OleDbParameter("@NewsTypeID", OleDbType.VarChar,50),
					new OleDbParameter("@NewsTypeName", OleDbType.VarChar,50),
					new OleDbParameter("@AdminID", OleDbType.VarChar,50),
					new OleDbParameter("@AdminName", OleDbType.VarChar,50),
					new OleDbParameter("@NewsID", OleDbType.Integer,4)};
			parameters[0].Value = model.NewsTitle;
			parameters[1].Value = model.NewsContent;
			parameters[2].Value = model.Keywords;
			parameters[3].Value = model.Description;
			parameters[4].Value = model.PicUrl;
			parameters[5].Value = model.PubTime;
			parameters[6].Value = model.Source;
			parameters[7].Value = model.ClickTime;
			parameters[8].Value = model.State;
			parameters[9].Value = model.NewsTypeID;
			parameters[10].Value = model.NewsTypeName;
			parameters[11].Value = model.AdminID;
			parameters[12].Value = model.AdminName;
			parameters[13].Value = model.NewsID;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int NewsID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_News ");
			strSql.Append(" where NewsID=@NewsID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@NewsID", OleDbType.Integer,4)
			};
			parameters[0].Value = NewsID;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string NewsIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_News ");
			strSql.Append(" where NewsID in ("+NewsIDlist + ")  ");
			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Thigh.Model.News GetModel(int NewsID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select NewsID,NewsTitle,NewsContent,Keywords,Description,PicUrl,PubTime,Source,ClickTime,State,NewsTypeID,NewsTypeName,AdminID,AdminName from tb_News ");
			strSql.Append(" where NewsID=@NewsID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@NewsID", OleDbType.Integer,4)
			};
			parameters[0].Value = NewsID;

			Thigh.Model.News model=new Thigh.Model.News();
			DataSet ds=DbHelperOleDb.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Thigh.Model.News DataRowToModel(DataRow row)
		{
			Thigh.Model.News model=new Thigh.Model.News();
			if (row != null)
			{
				if(row["NewsID"]!=null && row["NewsID"].ToString()!="")
				{
					model.NewsID=int.Parse(row["NewsID"].ToString());
				}
				if(row["NewsTitle"]!=null)
				{
					model.NewsTitle=row["NewsTitle"].ToString();
				}
				if(row["NewsContent"]!=null)
				{
					model.NewsContent=row["NewsContent"].ToString();
				}
				if(row["Keywords"]!=null)
				{
					model.Keywords=row["Keywords"].ToString();
				}
				if(row["Description"]!=null)
				{
					model.Description=row["Description"].ToString();
				}
				if(row["PicUrl"]!=null)
				{
					model.PicUrl=row["PicUrl"].ToString();
				}
				if(row["PubTime"]!=null)
				{
					model.PubTime=row["PubTime"].ToString();
				}
				if(row["Source"]!=null)
				{
					model.Source=row["Source"].ToString();
				}
				if(row["ClickTime"]!=null)
				{
					model.ClickTime=row["ClickTime"].ToString();
				}
				if(row["State"]!=null)
				{
					model.State=row["State"].ToString();
				}
				if(row["NewsTypeID"]!=null)
				{
					model.NewsTypeID=row["NewsTypeID"].ToString();
				}
				if(row["NewsTypeName"]!=null)
				{
					model.NewsTypeName=row["NewsTypeName"].ToString();
				}
				if(row["AdminID"]!=null)
				{
					model.AdminID=row["AdminID"].ToString();
				}
				if(row["AdminName"]!=null)
				{
					model.AdminName=row["AdminName"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select NewsID,NewsTitle,NewsContent,Keywords,Description,PicUrl,PubTime,Source,ClickTime,State,NewsTypeID,NewsTypeName,AdminID,AdminName ");
			strSql.Append(" FROM tb_News ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperOleDb.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM tb_News ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.NewsID desc");
			}
			strSql.Append(")AS Row, T.*  from tb_News T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperOleDb.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			OleDbParameter[] parameters = {
					new OleDbParameter("@tblName", OleDbType.VarChar, 255),
					new OleDbParameter("@fldName", OleDbType.VarChar, 255),
					new OleDbParameter("@PageSize", OleDbType.Integer),
					new OleDbParameter("@PageIndex", OleDbType.Integer),
					new OleDbParameter("@IsReCount", OleDbType.Boolean),
					new OleDbParameter("@OrderType", OleDbType.Boolean),
					new OleDbParameter("@strWhere", OleDbType.VarChar,1000),
					};
			parameters[0].Value = "tb_News";
			parameters[1].Value = "NewsID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOleDb.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

