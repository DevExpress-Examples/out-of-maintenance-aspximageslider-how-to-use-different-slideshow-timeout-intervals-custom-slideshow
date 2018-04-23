Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxHiddenField

Namespace E4913
	Partial Public Class [Default]
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub hfCustomIntervals_Init(ByVal sender As Object, ByVal e As EventArgs)
			Dim hiddenField As ASPxHiddenField = TryCast(sender, ASPxHiddenField)

			hiddenField("Cherries") = 2000
			hiddenField("Raspberry") = 5000
			hiddenField("Strawberry") = 1000
			hiddenField("Tomatoes") = 4000
		End Sub
	End Class
End Namespace