Imports System.Data.SqlClient
Public Class Exchangeasset
    Dim Con = New SqlConnection("Persist Security Info=False;User ID=sa;pwd=Lokee2,,,9;Initial Catalog=AssetManagementSystem;Data Source=LOKEELEGEND\ASSETSQL")

Private Sub populate()

        Dim query As String = "Select * from Exchangetable"
        Using cmd As SqlCommand = New SqlCommand(query, Con)
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable()
                    da.Fill(dt)
                    dtgExchangetable.DataSource = dt
                End Using
            End Using
        End Using
End Sub
Private Sub Reset()
        DeviceID_txtbox.Text = ""
        DeviceName_txtbox.Text = ""
        Fromlab_cbox.Text = ""
        DeviceName_txtbox.Text = ""
        Tolab_cbox.Text = ""
        Exdate_cbox.Text = ""
        rdb_Working.Text = "Working"
        rdb_Notworking.Text = "Not Working"
        Dim key = 0
End Sub

Private Sub Exchangeasset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AssetManagementSystemExg_AssetDataSet.Exchangetable' table. You can move, or remove it, as needed.
        Me.ExchangetableTableAdapter3.Fill(Me.AssetManagementSystemExg_AssetDataSet.Exchangetable)
        dtgExchangetable.Columns(0).Width = 70
        dtgExchangetable.Columns(1).Width = 110
        dtgExchangetable.Columns(2).Width = 100
        dtgExchangetable.Columns(3).Width = 190
        dtgExchangetable.Columns(4).Width = 100
        dtgExchangetable.Columns(5).Width = 100


        dtgExchangetable.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
        dtgExchangetable.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
        dtgExchangetable.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
        dtgExchangetable.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
        dtgExchangetable.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
        dtgExchangetable.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter

        dtgExchangetable.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
        dtgExchangetable.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
        dtgExchangetable.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
        dtgExchangetable.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
        dtgExchangetable.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
        dtgExchangetable.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
    End Sub

Private Sub Exc_Addbtn_Click(sender As Object, e As EventArgs) Handles Exc_Addbtn.Click
        If DeviceID_txtbox.Text = "" Or DeviceName_txtbox.Text = "" Or Fromlab_cbox.Text = "" Or Tolab_cbox.Text = "" Or Exdate_cbox.Text = "" Or rdb_Working.Text = "" Or rdb_Notworking.Text = "" Then
            MsgBox("Missing Informations")
        End If
        Try
            Dim DeviceID As Integer = DeviceID_txtbox.Text
            Dim DeviceName As String = DeviceName_txtbox.Text
            Dim Fromlab As String = Fromlab_cbox.Text
            Dim Tolab As String = Tolab_cbox.Text
            Dim ExchangeDate As String = Exdate_cbox.Text
            Dim Condition As String = ""
            If rdb_Working.Checked = True Then
                Condition = "Working"
            Else
                Condition = "Not Working"
            End If

            Con.Open()
            Dim command As New SqlCommand("Insert into Exchangetable values('" & DeviceID & "','" & DeviceName & "','" & Fromlab & "','" & Tolab & "','" & ExchangeDate & "','" & Condition & "')", Con)
            command.ExecuteNonQuery()
            Con.close()
            populate()
            Reset()
        Catch ex As SqlException
            If ex.Number = 2627 Then
                MsgBox("The given DeviceID has already imported", MsgBoxStyle.Critical, "Warning")
                Con.Close()
            End If
        End Try
End Sub

Private Sub Exc_Editbtn_Click(sender As Object, e As EventArgs) Handles Exc_Editbtn.Click
        Dim DeviceID As Integer = DeviceID_txtbox.Text
        Dim DeviceName As String = DeviceName_txtbox.Text
        Dim Fromlab As String = Fromlab_cbox.Text
        Dim Tolab As String = Tolab_cbox.Text
        Dim ExchangeDate As String = Exdate_cbox.Text
        Dim Condition As String = ""
        If rdb_Working.Checked = True Then
            Condition = "Working"
        Else
            Condition = "Not Working"
        End If

        Con.Open()
        Dim command As New SqlCommand("Update Exchangetable set DeviceName='" & DeviceName_txtbox.Text & "',Fromlab='" & Fromlab_cbox.Text & "',Tolab='" & Tolab_cbox.Text & "',ExchangeDate='" & Exdate_cbox.Text & "',Condition ='" & Condition & "' where DeviceID ='" & DeviceID_txtbox.Text & "'", Con)
        command.ExecuteNonQuery()
        Con.close()
        populate()
        Reset()
End Sub
    Dim key = 0

Private Sub Exc_Deletebtn_Click(sender As Object, e As EventArgs) Handles Exc_Deletebtn.Click
        Dim Cmd As SqlCommand = New SqlCommand("Delete from Exchangetable WHERE DeviceID = '" & DeviceID_txtbox.Text & "'", Con)
        Con.Open()
        Cmd.ExecuteNonQuery()
        MsgBox("User Details Deleted")
        Con.Close()
        populate()
End Sub

Private Sub Exc_Resetbtn_Click(sender As Object, e As EventArgs) Handles Exc_Resetbtn.Click
        Reset()
End Sub

Private Sub dtgExchangetable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgExchangetable.CellContentClick
        Dim row As DataGridViewRow = dtgExchangetable.Rows(e.RowIndex)

        DeviceID_txtbox.Text = row.Cells(0).Value.ToString
        DeviceName_txtbox.Text = row.Cells(1).Value.ToString
        Fromlab_cbox.Text = row.Cells(2).Value.ToString
        Tolab_cbox.Text = row.Cells(3).Value.ToString
        Exdate_cbox.Text = row.Cells(4).Value.ToString
        If row.Cells(5).Value.ToString() = "Working" Then
            rdb_Working.Checked = True
        Else
            rdb_Notworking.Checked = True
        End If

        If DeviceID_txtbox.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If

End Sub

Private Sub rdb_Working_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_Working.CheckedChanged
        'condition = "Working"
End Sub

Private Sub rdb_Notworking_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_Notworking.CheckedChanged
        'condition = "Not Working"

End Sub
Private Sub Exc_Backbtn_Click(sender As Object, e As EventArgs) Handles Exc_Backbtn.Click
        Me.Close()
End Sub

Private Sub Exdate_cbox_ValueChanged_1(sender As Object, e As EventArgs) Handles Exdate_cbox.ValueChanged
        Exdate_cbox.Text = Exdate_cbox.Value.Date.ToString("dd-MM-yyyy")
End Sub
End Class

