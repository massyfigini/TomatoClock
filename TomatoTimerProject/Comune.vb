Public Class Comune

    Public Shared Sub DGVtoEXCEL(ByVal DGV As DataGridView, ByVal FLE As String)
        Try
            Dim DTB = New DataTable, RWS As Integer, CLS As Integer

            For CLS = 0 To DGV.ColumnCount - 1 ' COLUMNS OF DTB
                DTB.Columns.Add(DGV.Columns(CLS).Name.ToString)
            Next

            Dim DRW As DataRow

            For RWS = 0 To DGV.Rows.Count - 1 ' FILL DTB WITH DATAGRIDVIEW
                DRW = DTB.NewRow

                For CLS = 0 To DGV.ColumnCount - 1
                    Try
                        DRW(DTB.Columns(CLS).ColumnName.ToString) = DGV.Rows(RWS).Cells(CLS).Value.ToString
                    Catch ex As Exception

                    End Try
                Next

                DTB.Rows.Add(DRW)
            Next

            DTB.AcceptChanges()

            Dim DST As New DataSet
            DST.Tables.Add(DTB)
            DTB.WriteXml(FLE)
            Dim EXL As String = "C:\Program Files (x86)\Microsoft Office\Office15\EXCEL.EXE" ' PATH OF/ EXCEL.EXE IN YOUR MICROSOFT OFFICE
            Shell(Chr(34) & EXL & Chr(34) & " " & Chr(34) & FLE & Chr(34), vbNormalFocus) ' OPEN XML WITH EXCEL

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

End Class
