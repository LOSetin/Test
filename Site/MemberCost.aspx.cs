﻿using Arrow.Framework;
using Arrow.Framework.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Arrow.Framework.Extensions;

public partial class MemberCost : MemberBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Response.Redirect("MemberCost.aspx?k="+Server.UrlEncode(tbKeyword.Text.Trim())+"&bt="+Server.UrlEncode(tbBegin.Text.Trim())+"&et="+Server.UrlEncode(tbEnd.Text.Trim()));
    }
}