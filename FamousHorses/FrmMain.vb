'Project            Chapter 10 part 1
'Programmer         Theodore Feldman
'Date               11/30/2023
'Description        Uses an Access database to Add, Delete, Edit, Print, Save, and Search the database 
'


Public Class FrmMain

    'Variables
    Dim blnAdd As Boolean = False

    Private Sub TblHorsesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblHorsesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HorsesDataSet)

    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HorsesDataSet.tblHorses' table. You can move, or remove it, as needed.
        Me.TblHorsesTableAdapter.Fill(Me.HorsesDataSet.tblHorses)

    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click

        With TblHorsesBindingSource
            If .Position = .Count - 1 Then
                .MoveFirst()
            Else
                .MoveNext()
            End If
        End With
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click

        With TblHorsesBindingSource
            If .Position = 0 Then
                .MoveLast()
            Else
                .MovePrevious()
            End If
        End With
    End Sub

    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles BtnFirst.Click
        TblHorsesBindingSource.MoveFirst()
    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles BtnLast.Click
        TblHorsesBindingSource.MoveLast()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        'Adds new record or cancels the add

        If BtnAdd.Text = "Add" Then
            BtnAdd.Text = "Cancel"
            BtnSave.Enabled = True
            DisableButtons()
            UnlockTextBoxes()
            BtnEdit.Enabled = False
            ClearTextBoxes()
            blnAdd = True

            TblHorsesBindingSource.EndEdit()
            TblHorsesBindingSource.AddNew()
        Else
            BtnAdd.Text = "Add"
            BtnSave.Enabled = False
            EnableButtons()
            LockTextBoxes()
            BtnEdit.Enabled = True
            blnAdd = False

            TblHorsesTableAdapter.Fill(HorsesDataSet.tblHorses)
        End If
    End Sub

    Private Sub DisableButtons()
        BtnDelete.Enabled = False
        BtnPrint.Enabled = False
        BtnFirst.Enabled = False
        BtnLast.Enabled = False
        BtnPrevious.Enabled = False
        BtnNext.Enabled = False
    End Sub
    Private Sub EnableButtons()
        BtnDelete.Enabled = True
        BtnPrint.Enabled = True
        BtnSave.Enabled = False
        BtnLast.Enabled = True
        BtnPrevious.Enabled = True
        BtnNext.Enabled = True
        BtnFirst.Enabled = True
    End Sub

    Private Sub UnlockTextBoxes()
        HorseTextBox.ReadOnly = False
        RiderTextBox.ReadOnly = False
        SeriesTextBox.ReadOnly = False
    End Sub

    Private Sub LockTextBoxes()
        HorseTextBox.ReadOnly = True
        RiderTextBox.ReadOnly = True
        SeriesTextBox.ReadOnly = True
    End Sub

    Private Sub ClearTextBoxes()
        HorseTextBox.Text = ""
        HorseTextBox.Focus()
        RiderTextBox.Text = ""
        SeriesTextBox.Text = ""
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If blnAdd = True Then
            Try
                HorsesDataSet.AcceptChanges()
                TblHorsesBindingSource.EndEdit()

                TblHorsesTableAdapter.Update(HorsesDataSet)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Else
            MessageBox.Show("Not available for adding.", "Add Error", MessageBoxButtons.OK)
        End If

        blnAdd = False
        LockTextBoxes()
        EnableButtons()

        BtnAdd.Text = "&Add"
        BtnEdit.Enabled = True
        BtnSave.Enabled = False

        'Refresh the database
        TblHorsesTableAdapter.Fill(HorsesDataSet.tblHorses)
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        'Edits the existing records
        If BtnEdit.Text = "Edit" Then
            BtnEdit.Text = "Update"
            DisableButtons()
            UnlockTextBoxes()
            BtnAdd.Enabled = False
            HorseTextBox.Focus()
        Else
            BtnEdit.Text = "Edit"
            EnableButtons()
            LockTextBoxes()
            BtnAdd.Enabled = True

            TblHorsesBindingSource.EndEdit()
            TblHorsesTableAdapter.Update(HorsesDataSet.tblHorses)

            TblHorsesTableAdapter.Fill(HorsesDataSet.tblHorses)
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        'Removes the Current active record
        Dim intReply As Integer
        intReply = MessageBox.Show("Delete the horse " & HorseTextBox.Text & "?", "Deletion Request", MessageBoxButtons.YesNo)
        Try
            If intReply = vbYes Then
                TblHorsesBindingSource.RemoveCurrent()
                TblHorsesTableAdapter.Update(HorsesDataSet.tblHorses)
            Else
                TblHorsesBindingSource.CancelEdit()
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting record")
        End Try
    End Sub

    Private Sub PpdPreview_Load(sender As Object, e As EventArgs) Handles PpdPreview.Load
        'handels the preview of the document
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        'Prints the preview of the document
        PpdPreview.Document = PrtDocument
        PpdPreview.ShowDialog()
    End Sub

    Private Sub PrtDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrtDocument.PrintPage
        'Sets up the printout

        Dim fntPrint As New Font("Arial", 12)
        Dim fntHeading As New Font("Arial", 16, FontStyle.Bold)
        Dim sngLineHeight As Single = fntPrint.GetHeight + 2
        Dim sngPrintX As Single = e.MarginBounds.Left
        Dim sngPrintY As Single = e.MarginBounds.Top
        Dim strPrintLine As String
        Dim intCount As Integer

        strPrintLine = "Famous Horses"
        e.Graphics.DrawString(strPrintLine, fntHeading, Brushes.DarkRed, sngPrintX, sngPrintY)

        sngPrintY += sngLineHeight
        strPrintLine = "by Theodore Feldman"
        e.Graphics.DrawString(strPrintLine, fntHeading, Brushes.DarkRed, sngPrintX, sngPrintY)

        sngPrintY += sngLineHeight * 2

        TblHorsesBindingSource.MoveFirst()

        For intCount = 0 To TblHorsesBindingSource.Count - 1
            strPrintLine = HorseTextBox.Text.ToString()
            e.Graphics.DrawString(strPrintLine, fntPrint, Brushes.Red, sngPrintX, sngPrintY)

            sngPrintX += 200
            strPrintLine = RiderTextBox.Text.ToString()
            e.Graphics.DrawString(strPrintLine, fntPrint, Brushes.OrangeRed, sngPrintX, sngPrintY)

            sngPrintX += 200
            strPrintLine = SeriesTextBox.Text.ToString()
            e.Graphics.DrawString(strPrintLine, fntPrint, Brushes.DarkMagenta, sngPrintX, sngPrintY)

            sngPrintX = e.MarginBounds.Left
            sngPrintY += sngLineHeight
            TblHorsesBindingSource.MoveNext()

        Next

        sngPrintY += sngLineHeight * 3
        strPrintLine = "*** End Of Report ***"
        e.Graphics.DrawString(strPrintLine, fntPrint, Brushes.DarkRed, sngPrintX, sngPrintY)
    End Sub

    Private Sub BtnDeleteAll_Click(sender As Object, e As EventArgs) Handles BtnDeleteAll.Click
        'Deletes all of the records in the database table

        Dim intReply As Integer
        Dim intCount As Integer
        Dim intDeleteAll As Integer

        intCount = TblHorsesBindingSource.Count - 1

        intReply = MessageBox.Show("Delete All Records?", "Delete All", MessageBoxButtons.YesNo)
        If intReply = vbYes Then
            Try
                Do While intDeleteAll <= intCount
                    HorsesDataSet.tblHorses.Rows(0).Delete()
                    TblHorsesTableAdapter.Update(HorsesDataSet.tblHorses)
                    intDeleteAll += 1
                Loop
                TblHorsesTableAdapter.Fill(HorsesDataSet.tblHorses)
            Catch ex As Exception
                MessageBox.Show("Unable to delete the records.", "Horses", MessageBoxButtons.OK)
            End Try

        Else
            MessageBox.Show("Deleteion Canceled", "Horses")
        End If
    End Sub

    Private Sub BtnLookup_Click(sender As Object, e As EventArgs) Handles BtnLookup.Click
        'Searches the database table for a specific horse name

        Dim strHorse As String
        Dim intCount As Integer
        Dim blnFound As Boolean = False
        Dim intPosition As Integer

        strHorse = CStr(TxtLookup.Text)
        intCount = TblHorsesBindingSource.Count

        TblHorsesBindingSource.MoveFirst()

        Do Until blnFound = True Or intPosition >= intCount
            If UCase(strHorse) = UCase(HorseTextBox.Text) Then
                blnFound = True
            Else
                TblHorsesBindingSource.MoveNext()
            End If
            intPosition += 1
        Loop

        If blnFound = False Then
            TblHorsesBindingSource.MoveFirst()
            TxtLookup.Text = "Not Found"
        Else
            TxtLookup.Text = ""
        End If

    End Sub
End Class
