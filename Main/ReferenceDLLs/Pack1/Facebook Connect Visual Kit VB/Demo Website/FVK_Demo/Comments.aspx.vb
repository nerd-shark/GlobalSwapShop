﻿Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports Facebook
Imports Facebook.Web
Imports FVK

Namespace FVK_Demo
    Partial Public Class Comments
        Inherits System.Web.UI.Page
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            Dim fbWebContext = FacebookWebContext.Current
            If Not fbWebContext.IsAuthorized() Then
                ErrorLabel.Visible = True
                loginbutton1.Visible = True
            Else
                ErrorLabel.Visible = False
                loginbutton1.Visible = False
            End If
        End Sub
    End Class
End Namespace