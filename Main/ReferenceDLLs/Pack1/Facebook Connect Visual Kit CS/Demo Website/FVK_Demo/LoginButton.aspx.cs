﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Facebook;
using Facebook.Web;
using FVK;

namespace FVK_Demo
{
    public partial class LoginButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var fbWebContext = FacebookWebContext.Current;
            if (!fbWebContext.IsAuthorized())
            {
                ErrorLabel.Visible = true;
            }
            else
            {
                ErrorLabel.Visible = false;
            }
        }

        protected void OnConnected(object sender, EventArgs e)
        {
            ConnectLabel.Visible = true;
        }
    }
}
