Public Class frmCheckStaff
    Private Sub frmCheckStaff_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        Me.TopMost = True

    End Sub

    Private Sub frmCheckStaff_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate

        Me.TopMost = False

    End Sub
End Class