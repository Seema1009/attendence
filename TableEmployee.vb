Public Class TableEmployee

    Public EmpID As Integer

    Private Sub TableEmployee_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Standardization
        Call Std_Colors(cmdEdit, cmdDelete, cmdAdd, cmdLoad)
        Call Init_Form(lblHeading)
        Call Init_Content(cmdAdd)
        Call Init_Content(cmdDelete)
        Call Init_Content(cmdEdit)
        Call Init_Content(cmdLoad)
        Call Init_Content(GroupBox1)
        Call Init_Content(GroupBox2)
    End Sub

    Public Sub Refresh_grid()
        'Code to refresh the datagrid
        Call GetEmp(cbxEmp)
        dbgEmp.DataSource = mytable
        If cbxEmp.Items.Count > 0 Then
            cbxEmp.SelectedIndex = 0
        End If
    End Sub

    Public Sub DeleteDept(EmpID As String)
        ' Delete record after confirmation from the user. The EmpID is passed as input parameter
        Dim tempstr As String
        If MsgBox("Are you sure you want to Delete the Employee with EmpID " & EmpID & " ?", MsgBoxStyle.OkCancel, "Delete Confirmation") = vbOK Then
            OpenConnection() 'open connection
            tempstr = "Delete from Employees where EmpID = " & EmpID
            Call ExecQuery(tempstr)
            If Exception Is "" Then
                'MsgBox("Record Deleteted successfully")
                Form1.SSTStatus.Text = "Record Deleteted successfully"
            Else
                MsgBox(Exception)
            End If
        End If
        CloseConnection() ' close connection
    End Sub

    Private Sub selectRecord(ID As Integer)
        'Select the Record in datagrid of Selected Employee ID
        Dim tempstr As String
        OpenConnection()
        tempstr = "select * from Employees where EmpID = " & ID
        Call ExecQuery(tempstr)
        If Exception Is "" And Recordcount > 0 Then
            Dim r As DataRow = mytable.Rows(0)
        Else
            MsgBox(Exception)
        End If
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        'Code to Delete a record in the database permanently
        If dbgEmp.CurrentRow Is Nothing Then
            MsgBox("Please select an Employee")
            Exit Sub
        End If
        EmpID = dbgEmp.Item(0, dbgEmp.CurrentRow.Index).Value
        Call DeleteDept(EmpID)
        Call Refresh_grid()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        'code to update/edit a record in database
        If dbgEmp.CurrentRow Is Nothing Then
            MsgBox("Please Select an Employee")
            Exit Sub
        End If
        EmpID = dbgEmp.Item(0, dbgEmp.CurrentRow.Index).Value
        Call selectRecord(EmpID)
        FORM_MODE = "EDIT"
        Call addformEmp.Show()
        CloseConnection()
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        'code to add new record in database
        FORM_MODE = "ADD"
        If dbgEmp.DataSource Is Nothing Then
            MsgBox("Please load the Employees Database")
            Exit Sub
        End If
        Call addformEmp.show()
    End Sub

    Private Sub cmdLoad_Click(sender As Object, e As EventArgs) Handles cmdLoad.Click
        Call Refresh_grid()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        'filter/Search Code
        If dbgEmp.DataSource Is Nothing Then
            MsgBox("Please load the Employees Database")
            Exit Sub
        End If
        Dim tempstr As String

        tempstr = "select * from Employees where EmpName LIKE '" & "%" & cbxEmp.Text & "%'"
        If chkActive.Checked = True And chkInactive.Checked = False Then
            tempstr = tempstr & " and EmpActive = True "
        ElseIf chkActive.Checked = False And chkInactive.Checked = True Then
            tempstr = tempstr & " and EmpActive = False "
        End If
        OpenConnection()
        Call ExecQuery(tempstr)
        If Exception Is "" Then
            dbgEmp.DataSource = mytable
            dbgEmp.Columns(0).Visible = False
        Else
            MsgBox(Exception)
        End If
        CloseConnection()
    End Sub

    Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
        'export to excel
        Dim fname As String = lblHeading.Text
        If dbgEmp.DataSource IsNot Nothing Then
            Call export_excel(dbgEmp, fname)
        Else
            MsgBox("Please load the Employee Database")
        End If
    End Sub
End Class