Module GetData

    Public Sub GetVisitorTot(ByRef entrydate As String, ByRef VTotCount() As Integer, ByRef Gpentrydate() As String)
        Dim Tempstr As String
        Dim Lci As Integer
        Tempstr = "Select count(gpentrydate) as Expr1, format([gpentrydate],'00-00-0000') as Expr2 from tGatePass where gpentrydate > '" & entrydate & "' group by gpentrydate order by gpentrydate"

        OpenConnection()
        Call ExecQuery(Tempstr)
        If Exception = "" Then
            If Recordcount > 0 Then
                Lci = 0
                For Each r As DataRow In mytable.Rows
                    VTotCount(Lci) = r("Expr1")
                    Gpentrydate(Lci) = r("Expr2")
                    Lci = Lci + 1
                Next
            End If
        Else
            MsgBox(Exception) ' display the exception
        End If
        CloseConnection()
    End Sub

    Public Sub GetVisitorOut(ByRef entrydate As String, ByRef VOutCount As Integer)
        ' get the number of counts of visitors checked-Out
        Dim Tempstr As String

        Tempstr = "Select count(GpExitTime) as Expr1 from tGatePass where GpEntryDate = '" & entrydate & "' "
        OpenConnection()
        Call ExecQuery(Tempstr)
        If Exception = "" Then
            If Recordcount > 0 Then

                Dim r As DataRow = mytable.Rows(0)
                VOutCount = r("Expr1")
            Else
                ' no record found
                VOutCount = 0
            End If
        Else
            MsgBox(Exception) ' display the exception
        End If
        CloseConnection()
    End Sub
    Public Sub GetVisitorIn(ByRef entrydate As String, ByRef VinCount As Integer)
        ' get the number of counts of visitors checked-In
        Dim Tempstr As String

        Tempstr = "Select count(GpEntryDate) as Expr1 from tGatePass where GpEntryDate = '" & entrydate & "' And GpExitTime is Null"
        OpenConnection()
        Call ExecQuery(Tempstr)
        If Exception = "" Then
            If Recordcount > 0 Then

                Dim r As DataRow = mytable.Rows(0)
                VinCount = r("Expr1")
            Else
                ' no record found
                VinCount = 0
            End If
        Else
            MsgBox(Exception) ' display the exception
        End If
        CloseConnection()
    End Sub

    Public Sub GetUser(cbxUser As ComboBox)
        'This routines gets all the User Names  from the table and populates the combobox for all the records whose
        ' Status is active .
        Dim Tempstr As String
        cbxUser.Items.Clear() ' clear the combo Box
        OpenConnection() ' open connection
        Tempstr = "select * from Users" ' get all the fields from User Table
        Call ExecQuery(Tempstr)
        If Exception = "" Then
            For Each r As DataRow In mytable.Rows
                Tempstr = r("UserActive") ' Get the status 
                If r("UserActive") Then ' if active then value is true 
                    cbxUser.Items.Add(r("Username")) ' Add to the combobox
                End If

            Next
        Else
            MsgBox(Exception) ' display the exception
        End If
        CloseConnection() ' Close connection
    End Sub
    Public Sub GetEmp(cbxEmp As ComboBox)
        'This routines gets all the Employee Names  from the table and populates the combobox for all the records whose
        ' Status is active .
        Dim Tempstr As String
        cbxEmp.Items.Clear() ' clear the combo Box
        OpenConnection() ' open connection
        Tempstr = "select * from Employees order by EmpID asc" ' get all the fields from Employees Table
        Call ExecQuery(Tempstr)
        If Exception = "" Then
            For Each r As DataRow In mytable.Rows
                Tempstr = r("EmpActive") ' Get the status 
                If r("EmpActive") Then ' if active then value is true 
                    cbxEmp.Items.Add(r("EmpName")) ' Add to the combobox
                End If

            Next
        Else
            MsgBox(Exception) ' display the exception
        End If
        CloseConnection() ' Close connection
    End Sub

End Module
