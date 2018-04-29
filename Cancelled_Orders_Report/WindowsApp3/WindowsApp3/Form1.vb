Imports Microsoft.Reporting.WinForms

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.cancel_orders' table. You can move, or remove it, as needed.
        Dim parameters(2) As ReportParameter
        If CheckBox1.Checked = False Then

            parameters(0) = New ReportParameter("column_visible", "False")

        Else

            parameters(0) = New ReportParameter("column_visible", "True")

        End If

        parameters(1) = New ReportParameter("FromDate", FromDate.Value.ToString("MM/dd/yyyy"))
        parameters(2) = New ReportParameter("ToDate", ToDate.Value.ToString("MM/dd/yyyy"))
        Me.cancel_ordersTableAdapter.Fill(Me.DataSet1.cancel_orders, FromDate.Value)
        Me.ReportViewer1.LocalReport.SetParameters(parameters)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Me.cancel_ordersTableAdapter.FillBy(Me.DataSet1.cancel_orders, FromDate.Value, ToDate.Value)
        Dim parameters(2) As ReportParameter
        If CheckBox1.Checked = False Then

            parameters(0) = New ReportParameter("column_visible", "False")

        Else

            parameters(0) = New ReportParameter("column_visible", "True")

        End If
        parameters(1) = New ReportParameter("FromDate", FromDate.Value.ToString("MM/dd/yyyy"))
        parameters(2) = New ReportParameter("ToDate", ToDate.Value.ToString("MM/dd/yyyy"))
        Me.cancel_ordersTableAdapter.FillBy(Me.DataSet1.cancel_orders, FromDate.Value, ToDate.Value)
        Me.ReportViewer1.LocalReport.SetParameters(parameters)
        Me.ReportViewer1.RefreshReport()


    End Sub

    Private Sub FromDate_ValueChanged(sender As Object, e As EventArgs) Handles FromDate.ValueChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Public Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CheckBox1.Dispose()
        Label1.Dispose()
        Label2.Dispose()
        Label3.Dispose()
        Button3.Dispose()
        Panel1.Dispose()
        Button1.Dispose()
        Button2.Dispose()
        FromDate.Dispose()
        ToDate.Dispose()
        Label4.Dispose()
        ReportViewer1.Dock = DockStyle.Fill

    End Sub
End Class
