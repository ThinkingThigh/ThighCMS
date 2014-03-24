using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Maticsoft.DBUtility;//Please add references
namespace Thigh.DAL
{
	/// <summary>
	/// 数据访问类:Admin
	/// </summary>
	public partial class Admin
	{
		public Admin()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("AdminID", "tb_Admin"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AdminID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_Admin");
			strSql.Append(" where AdminID=@AdminID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@AdminID", OleDbType.Integer,4)
			};
			parameters[0].Value = AdminID;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Thigh.Model.Admin model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_Admin(");
			strSql.Append("AdminAccount,AdminPassword,AdminName,AdminType)");
			strSql.Append(" values (");
			strSql.Append("@AdminAccount,@AdminPassword,@AdminName,@AdminType)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@AdminAccount", OleDbType.VarChar,50),
					new OleDbParameter("@AdminPassword", OleDbType.VarChar,50),
					new OleDbParameter("@AdminName", OleDbType.VarChar,50),
					new OleDbParameter("@AdminType", OleDbType.VarChar,50)};
			parameters[0].Value = model.AdminAccount;
			parameters[1].Value = model.AdminPassword;
			parameters[2].Value = model.AdminName;
			parameters[3].Value = model.AdminType;

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
		public bool Update(Thigh.Model.Admin model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_Admin set ");
			strSql.Append("AdminAccount=@AdminAccount,");
			strSql.Append("AdminPassword=@AdminPassword,");
			strSql.Append("AdminName=@AdminName,");
			strSql.Append("AdminType=@AdminType");
			strSql.Append(" where AdminID=@AdminID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@AdminAccount", OleDbType.VarChar,50),
					new OleDbParameter("@AdminPassword", OleDbType.VarChar,50),
					new OleDbParameter("@AdminName", OleDbType.VarChar,50),
					new OleDbParameter("@AdminType", OleDbType.VarChar,50),
					new OleDbParameter("@AdminID", OleDbType.Integer,4)};
			parameters[0].Value = model.AdminAccount;
			parameters[1].Value = model.AdminPassword;
			parameters[2].Value = model.AdminName;
			parameters[3].Value = model.AdminType;
			parameters[4].Value = model.AdminID;

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
		public bool Delete(int AdminID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_Admin ");
			strSql.Append(" where AdminID=@AdminID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@AdminID", OleDbType.Integer,4)
			};
			parameters[0].Value = AdminID;

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
		public bool DeleteList(string AdminIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_Admin ");
			strSql.Append(" where AdminID in ("+AdminIDlist + ")  ");
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
		public Thigh.Model.Admin GetModel(int AdminID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select AdminID,AdminAccount,AdminPassword,AdminName,AdminType from tb_Admin ");
			strSql.Append(" where AdminID=@AdminID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@AdminID", OleDbType.Integer,4)
			};
			parameters[0].Value = AdminID;

			Thigh.Model.Admin model=new Thigh.Model.Admin();
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
		public Thigh.Model.Admin DataRowToModel(DataRow row)
		{
			Thigh.Model.Admin model=new Thigh.Model.Admin();
			if (row != null)
			{
				if(row["AdminID"]!=null && row["AdminID"].ToString()!="")
				{
					model.AdminID=int.Parse(row["AdminID"].ToString());
				}
				if(row["AdminAccount"]!=null)
				{
					model.AdminAccount=row["AdminAccount"].ToString();
				}
				if(row["AdminPassword"]!=null)
				{
					model.AdminPassword=row["AdminPassword"].ToString();
				}
				if(row["AdminName"]!=null)
				{
					model.AdminName=row["AdminName"].ToString();
				}
				if(row["AdminType"]!=null)
				{
					model.AdminType=row["AdminType"].ToString();
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
			strSql.Append("select AdminID,AdminAccount,AdminPassword,AdminName,AdminType ");
			strSql.Append(" FROM tb_Admin ");
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
			strSql.Append("select count(1) FROM tb_Admin ");
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
				strSql.Append("order by T.AdminID desc");
			}
			strSql.Append(")AS Row, T.*  from tb_Admin T ");
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
			parameters[0].Value = "tb_Admin";
			parameters[1].Value = "AdminID";
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

