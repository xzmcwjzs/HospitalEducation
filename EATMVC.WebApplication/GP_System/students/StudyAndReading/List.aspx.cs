﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Common;
using EATMVC.Model;

public partial class students_StudyAndReading_List : System.Web.UI.Page
{
    GP_Login loginModel = null;
    protected string StudentsName = string.Empty;
    protected string TrainingBaseCode = string.Empty;
    protected string DeptName = string.Empty;
    protected string ActivityForm = string.Empty;
    protected string ActivityDate = string.Empty;
    protected string LanguageType = string.Empty;
    protected string SuperiorDoctor = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["loginModel"] == null)
        {
            ShowMessageBox.Showmessagebox(this, "请重新登录", "/Home/Index");
            return;
        }

        if (!IsPostBack)
        {
            loginModel = new GP_Login();
            loginModel = (GP_Login)Session["loginModel"];
            StudentsName = loginModel.name;
            TrainingBaseCode = loginModel.training_base_code;

        }
        DeptName = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["DeptName"]));
        ActivityForm = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["ActivityForm"]));
        ActivityDate = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["ActivityDate"]));
        LanguageType = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["LanguageType"]));
        SuperiorDoctor = CommonFunc.FilterSpecialString(CommonFunc.SafeGetStringFromObj(Request.Form["SuperiorDoctor"]));

    }
}