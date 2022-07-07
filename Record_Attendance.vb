Imports System.IO
Public Class Record_Attendance
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdLoad.Click

        Dim tempstr As String
        Dim fromDate As String
        Dim toDate As String
        Dim selectStr As String
        Dim Groupstr As String = "GROUP BY L_UID, C_NAME,C_DATE,C_Office,C_Card ORDER BY C_date , L_UID"
        Dim Wherestr As String
        Try
            selectStr = <![CDATA[

                SELECT L_UID,
                       C_NAME,
                       Min(CAST(Left([C_DATE], 4) + '-' + SUBSTRING([C_DATE],5,2) + '-' +  RIGHT([C_DATE],2)+ ' ' + LEFT([C_TIME],2)+ ':' + SUBSTRING([C_TIME],3,2) + ':' + RIGHT([C_TIME],2) as datetime)) AS InTime, 
                       Max(CAST(Left([C_DATE], 4) + '-' + SUBSTRING([C_DATE],5,2) + '-' +  RIGHT([C_DATE],2)+ ' ' + LEFT([C_TIME],2)+ ':' + SUBSTRING([C_TIME],3,2) + ':' + RIGHT([C_TIME],2) as datetime)) AS OutTime,
                       C_Office, 
                       C_Card 
                    FROM tEnter

            ]]>.Value

            'Set from and To dates. If today then from & to date is same 
            If rbToday.Checked = True Then
                fromDate = Format(Now(), "yyyyMMdd")
                toDate = fromDate
            Else
                fromDate = Format(dtpFrom.Value, "yyyyMMdd")
                toDate = Format(dtpTo.Value, "yyyyMMdd")
            End If

            ' Check for conditions of employee & visitor flags and make Wherestr accordingly
            Wherestr = " WHERE C_Date between'" & fromDate & "' AND '" & toDate & "'"
            If (chkEmployee.Checked = True And chkVisitor.Checked = False) Then
                Wherestr = Wherestr & " and L_UserType =0 "
            ElseIf (chkEmployee.Checked = False And chkVisitor.Checked = True) Then
                Wherestr = Wherestr & " and L_UserType =1 "

            End If
            tempstr = selectStr & Wherestr & Groupstr
            OpenConnection()
            Call ExecQuery(tempstr)
            dbgAttendance.DataSource = mytable
        Catch ex As Exception
            Console.WriteLine(ex)

        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub rbToday_CheckedChanged(sender As Object, e As EventArgs) Handles rbToday.CheckedChanged
        GroupBox2.Visible = False
    End Sub

    Private Sub rbOther_CheckedChanged(sender As Object, e As EventArgs) Handles rbOther.CheckedChanged
        GroupBox2.Visible = True
        dtpFrom.Value = Now()
        dtpTo.Value = Now()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'export to excel
        Dim fname As String = lblHeading.Text
        If dbgAttendance.DataSource IsNot Nothing Then
            Call export_excel(dbgAttendance, fname)
        Else
            MsgBox("Please load the Report Table")
        End If
    End Sub

    Private Sub cmdASCII_Click(sender As Object, e As EventArgs) Handles cmdASCII.Click
        Dim sfd As New SaveFileDialog() With {.Filter = "Text Files (*.txt)|*.txt"}
        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Using writer As TextWriter = New StreamWriter(sfd.FileName)
                    For i As Integer = 0 To dbgAttendance.Rows.Count - 1 Step +1
                        For j As Integer = 0 To dbgAttendance.Columns.Count - 1 Step +1
                            writer.Write(vbTab & dbgAttendance.Rows(i).Cells(j).Value.ToString() & vbTab & "|")
                        Next
                        writer.WriteLine("")
                        'writer.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------")
                    Next
                    writer.Close()

                    'MsgBox("Files exported")
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
        Else
            Exit Sub
        End If
        Form1.SSTStatus.Text = "Files Saved"
    End Sub
End Class