using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        const string channelAccessToken = "FmX/9hPepdS/qpxRJdqIcIujyLV7lbIUlimQlwlQd77GVSoEZH3LfCWKYCg99FdSPjqpIZ7wUWBY9iBf5kaDZROvA28JR6+I8zFqX6M6Ja6/TKCwJjtt0ak/bJDR639GoADVkl5OZzhwCpwbnbwcpgdB04t89/1O/w1cDnyilFU=";  //!!!!! 改成自己的ChannelAccessToken !!!!!
        const string AdminUserId= "U847104d40f901f3c14a5902ffc8b174b";  //!!!改成你的AdminUserId!!!

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, $"測試 {DateTime.Now.ToString()} ! ");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, 1,2);
        }
    }
}