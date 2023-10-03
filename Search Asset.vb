Imports System.Data.SqlClient
Public Class SearchAsset
    Dim Con = New SqlConnection("Persist Security Info=False;User ID=sa;pwd=Lokee2,,,9;Initial Catalog=AssetManagementSystem;Data Source=LOKEELEGEND\ASSETSQL")

    Dim da As New SqlDataAdapter
    Dim cmd As New SqlCommand
    'Dim dr As New SqlDataReader
    Dim dt1 As DataTable
    Dim ds As New DataSet

Private Sub search_Backbtn_Click(sender As Object, e As EventArgs)
        Me.Close()
End Sub

Private Sub Searchasset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AssetManagementSystemSearchasset1.Managetable' table. You can move, or remove it, as needed.
        Me.ManagetableTableAdapter3.Fill(Me.AssetManagementSystemSearchasset1.Managetable)

        dtgsearchtable.Columns(0).Width = 70
        dtgsearchtable.Columns(1).Width = 110
        dtgsearchtable.Columns(2).Width = 100
        dtgsearchtable.Columns(3).Width = 190
        dtgsearchtable.Columns(4).Width = 100
        dtgsearchtable.Columns(5).Width = 100
        dtgsearchtable.Columns(6).Width = 100
        dtgsearchtable.Columns(7).Width = 180
        dtgsearchtable.Columns(8).Width = 220
        dtgsearchtable.Columns(9).Width = 280

        dtgsearchtable.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
        dtgsearchtable.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
        dtgsearchtable.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
        dtgsearchtable.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
        dtgsearchtable.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
        dtgsearchtable.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
        dtgsearchtable.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
        dtgsearchtable.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
        dtgsearchtable.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
        dtgsearchtable.Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter


        dtgsearchtable.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
        dtgsearchtable.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
        dtgsearchtable.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
        dtgsearchtable.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
        dtgsearchtable.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
        dtgsearchtable.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
        dtgsearchtable.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
        dtgsearchtable.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
        dtgsearchtable.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
        dtgsearchtable.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter

End Sub
Private Sub search()
        Dim Con = New SqlConnection("Persist Security Info=False;User ID=sa;pwd=Lokee2,,,9;Initial Catalog=AssetManagementSystem;Data Source=LOKEELEGEND\ASSETSQL")
        If Dept_cbox.SelectedIndex = 0 Then
            Dim searchtext As String = Search_txtbox.Text
            Dim cmd As New SqlCommand("select * from Managetable where DeviceID like '%" & searchtext & "%'", Con)
            Dim da As New SqlDataAdapter(cmd)

            Dim ds As New DataSet()

            If (da.Fill(ds, "Managetable")) Then

                dtgsearchtable.DataSource = ds.Tables(0)
            Else

                MsgBox("Match not found", MsgBoxStyle.Exclamation)

            End If
        ElseIf Dept_cbox.SelectedIndex = 1 Then
            Dim searchtext As String = Search_txtbox.Text
            Dim cmd As New SqlCommand("select  * from Managetable where DeptName like '%" & searchtext & "%' order by DeviceID", Con)
            Dim da As New SqlDataAdapter(cmd)

            Dim ds As New DataSet()

            If (da.Fill(ds, "Managetable")) Then

                dtgsearchtable.DataSource = ds.Tables(0)
            Else
                MsgBox("Match not found", MsgBoxStyle.Exclamation)
            End If
        ElseIf Dept_cbox.SelectedIndex = 2 Then
            Dim searchtext As String = Search_txtbox.Text
            Dim cmd As New SqlCommand("select  * from Managetable where DevName like '%" & searchtext & "%'order by DeviceID", Con)
            Dim da As New SqlDataAdapter(cmd)

            Dim ds As New DataSet()

            If (da.Fill(ds, "Managetable")) Then

                dtgsearchtable.DataSource = ds.Tables(0)
            Else
                MsgBox("Match not found", MsgBoxStyle.Exclamation)
            End If
        ElseIf Dept_cbox.SelectedIndex = 3 Then
            Dim searchtext As String = Search_txtbox.Text
            Dim cmd As New SqlCommand("select  * from Managetable where LabName like '%" & searchtext & "%' order by DeviceID", Con)
            Dim da As New SqlDataAdapter(cmd)

            Dim ds As New DataSet()

            If (da.Fill(ds, "Managetable")) Then

                dtgsearchtable.DataSource = ds.Tables(0)
            Else
                MsgBox("Match not found", MsgBoxStyle.Exclamation)
            End If
        End If

End Sub

Private Sub dtgsearchtable_CellMouseClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgsearchtable.CellContentClick
        dtgsearchtable.EditMode = DataGridViewEditMode.EditProgrammatically

        dtgsearchtable.SelectionMode = DataGridViewSelectionMode.FullRowSelect
End Sub

Private Sub SearchID_btn_Click(sender As Object, e As EventArgs) Handles SearchID_btn.Click
        search()
End Sub

Private Sub Search_Backbtn_Click_1(sender As Object, e As EventArgs) Handles Search_Backbtn.Click
        Me.Close()
End Sub
End Class

