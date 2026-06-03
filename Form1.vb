Public Class Form1

    Dim state As Integer = 0

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Interval = 3000 '3 seconds
        Timer1.Start()
    End Sub

    Private Sub ResetLights()

        NR.BackColor = Color.Gray
        NY.BackColor = Color.Gray
        NG.BackColor = Color.Gray

        SR.BackColor = Color.Gray
        SY.BackColor = Color.Gray
        SG.BackColor = Color.Gray

        ER.BackColor = Color.Gray
        EY.BackColor = Color.Gray
        EG.BackColor = Color.Gray

        WR.BackColor = Color.Gray
        WY.BackColor = Color.Gray
        WG.BackColor = Color.Gray

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ResetLights()

        Select Case state

            ' North-South Green
            Case 0
                NG.BackColor = Color.Lime
                SG.BackColor = Color.Lime

                ER.BackColor = Color.Red
                WR.BackColor = Color.Red

            ' North-South Yellow
            Case 1
                NY.BackColor = Color.Yellow
                SY.BackColor = Color.Yellow

                ER.BackColor = Color.Red
                WR.BackColor = Color.Red

            ' East-West Green
            Case 2
                NR.BackColor = Color.Red
                SR.BackColor = Color.Red

                EG.BackColor = Color.Lime
                WG.BackColor = Color.Lime

            ' East-West Yellow
            Case 3
                NR.BackColor = Color.Red
                SR.BackColor = Color.Red

                EY.BackColor = Color.Yellow
                WY.BackColor = Color.Yellow

        End Select

        state += 1

        If state > 3 Then
            state = 0
        End If

    End Sub

    Private Sub EY_Paint(sender As Object, e As PaintEventArgs) Handles EY.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class