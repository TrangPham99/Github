﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class khachhang : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Control hienthihome = new Control();
        string page = Request.QueryString.Get("page");
        switch (page)
        {
            case "xem":
                hienthihome = LoadControl("UC_Home/XemSanPham.ascx");
                break;
            case "gh":
                hienthihome = LoadControl("UC_Home/GioHang.ascx");
                break;
            case "lienhe":
                hienthihome = LoadControl("UC_Home/lienhe.ascx");
                break;
            case "thanhtoan":
                hienthihome = LoadControl("UC_Home/Thanhtoan.ascx");
                break;
            default:
                hienthihome = LoadControl("UC_Home/TrangChu.ascx");
                break;
        }
        this.Panel1.Controls.Add(hienthihome);
    }
}