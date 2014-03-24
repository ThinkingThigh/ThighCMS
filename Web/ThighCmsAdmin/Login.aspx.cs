using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Thigh.Web.ThighCmsAdmin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                CheckLogin();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        protected void CheckLogin()
        {
            Thigh.BLL.Admin adminbll = new Thigh.BLL.Admin();
            DataSet ds = adminbll.GetList(string.Format("AdminAccount='{0}' and AdminPassword='{1}'", txtAccount.Text, txtPassword.Text));
            if (ds.Tables[0].Rows.Count > 0)
            {
                Thigh.Model.Admin CurrentAdmin = new Thigh.Model.Admin();
                CurrentAdmin = adminbll.GetModel(Convert.ToInt32(ds.Tables[0].Rows[0]["AdminID"].ToString()));
                //初始化一个用户凭证的实例
                //提供对票证的属性和值的访问，这些票证用于 Forms 身份验证对用户进行标识
                //Forms 身份验证使用这些票证来标识已经过身份验证的用户
                FormsAuthenticationTicket myTicket;

                //根据不同的用户名分配不同的role(这部分可以通过数据库role读取来替代)

                //版本号，用户名，票证发出时的本地日期和时间，票证过期时的本地日期和时间， 
                //如果票证将存储在持久性 Cookie（跨浏览器会话保存），则为 true；否则为 false。如果该票证存储在 URL 中
                //存储在票证中的用户特定的数据
                myTicket = new FormsAuthenticationTicket(1, "AdminID", DateTime.Now, DateTime.Now.AddMinutes(480), false, ds.Tables[0].Rows[0]["AdminID"].ToString());


                string encryptedTicket = FormsAuthentication.Encrypt(myTicket); //加密用户凭证

                //把用户凭证存入Cookie 
                HttpCookie authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);

                //添加Cookie
                Response.Cookies.Add(authCookie);
                //Session["CurrentAdmin"] = CurrentAdmin;
                // 跳转默认重定向的默认 URL具体见Web.Config的配置
                //Response.Redirect(FormsAuthentication.GetRedirectUrl(ds.Tables[0].Rows[0]["AdminID"].ToString(), false));
                Response.Redirect("Index.aspx");
            }
            else
            {
                Maticsoft.Common.MessageBox.Show(this, "登录失败！");
            }
        }
    }
}
