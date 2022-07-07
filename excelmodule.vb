Imports Microsoft.Office.Interop.Excel

Module excelmodule
    'Export to Excel
    Public Sub export_excel(dgv As DataGridView, fname As String)
        If dgv.DataSource Is Nothing Then
            MsgBox("Please load the Database")
            Exit Sub
        End If
        Using sfd As New SaveFileDialog() With {.Filter = "Excel Files (*.xlsx)|*.xlsx"}
            If sfd.ShowDialog() = DialogResult.OK Then
                'code to export datagrid data into                'excel format
                Try
                    Dim xlApp As Application
                    Dim xlWorkBook As Workbook
                    Dim xlWorkSheet As Worksheet
                    Dim misValue As Object = Reflection.Missing.Value
                    Dim i As Integer
                    Dim j As Integer

                    xlApp = New Application
                    xlWorkBook = xlApp.Workbooks.Add(misValue)
                    xlWorkSheet = xlWorkBook.Sheets("sheet1")

                    For i = 0 To dgv.RowCount - 1
                        For j = 0 To dgv.ColumnCount - 1
                            For k As Integer = 1 To dgv.Columns.Count
                                xlWorkSheet.Cells(1, k) = dgv.Columns(k - 1).HeaderText
                                xlWorkSheet.Cells(i + 2, j + 1) = dgv(j, i).Value.ToString()
                            Next
                        Next
                    Next

                    xlWorkSheet.SaveAs(sfd.FileName)
                    xlWorkBook.Close()
                    xlApp.Quit()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Form1.SSTStatus.Text = "Exported to Excel"
            Else
                Form1.SSTStatus.Text = "Export Cancelled"
            End If
        End Using
    End Sub

End Module
