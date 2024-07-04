Public Class Form1

    Dim x As String
    Dim filename As String
    Dim c As Integer = 0
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        x = MsgBox("Are you sure to exit?", vbYesNo, "NOTICE")
        If x = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        op.ShowDialog()
        If op.FileName <> "" Then
            filename = op.FileName
            ListBox1.Items.Add(filename)
        End If
        'Update variable to count
        c = c + 1
    End Sub

    Private Sub selectbtn_Click(sender As Object, e As EventArgs) Handles selectbtn.Click
        If c > 0 Then
            ListBox1.SelectedIndex = 0
        End If

    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        c = c - 1
        If c > 0 Then
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub

    Private Sub playbtn_Click(sender As Object, e As EventArgs) Handles playbtn.Click
        If c > 0 Then
            Player1.URL = ListBox1.SelectedItem
        End If
    End Sub

    Private Sub stopbtn_Click(sender As Object, e As EventArgs) Handles stopbtn.Click

    End Sub

    Private Sub VersionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersionToolStripMenuItem.Click
        MsgBox("This is 0.1.1 Version", vbOKOnly, "NOTICE")
    End Sub
End Class
