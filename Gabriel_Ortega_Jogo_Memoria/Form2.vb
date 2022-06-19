Public Class Form2

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'img luigi par
        If clique = False Then
            clique = True
            PictureBox2.Image = My.Resources.Luigi
            PictureBox2.Enabled = False
            par1 = 2
        Else
            clique = False
            PictureBox2.Image = My.Resources.Luigi
            PictureBox2.Enabled = False
            par2 = 2
            verificar()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'Img mario (par)
        If clique = False Then
            clique = True
            PictureBox1.Image = My.Resources.mario
            PictureBox1.Enabled = False
            par1 = 1
        Else
            clique = False
            PictureBox1.Image = My.Resources.mario
            PictureBox1.Enabled = False
            par2 = 1
            verificar()

        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Start()

        PictureBox1.Image = My.Resources.mario
        PictureBox2.Image = My.Resources.Luigi
        PictureBox3.Image = My.Resources.yoshi
        PictureBox4.Image = My.Resources.bowser
        PictureBox5.Image = My.Resources.Luigi
        PictureBox6.Image = My.Resources.yoshi
        PictureBox7.Image = My.Resources.mario
        PictureBox8.Image = My.Resources.bowser
        PictureBox9.Image = My.Resources.Peach_Princess
        PictureBox10.Image = My.Resources.Wario
        PictureBox11.Image = My.Resources.Toad
        PictureBox12.Image = My.Resources.Wario
        PictureBox13.Image = My.Resources.Peach_Princess
        PictureBox14.Image = My.Resources.Waluigi
        PictureBox15.Image = My.Resources.Toad
        PictureBox16.Image = My.Resources.Waluigi

        PictureBox1.Enabled = False
        PictureBox2.Enabled = False
        PictureBox3.Enabled = False
        PictureBox4.Enabled = False
        PictureBox5.Enabled = False
        PictureBox6.Enabled = False
        PictureBox7.Enabled = False
        PictureBox8.Enabled = False
        PictureBox9.Enabled = False
        PictureBox10.Enabled = False
        PictureBox11.Enabled = False
        PictureBox12.Enabled = False
        PictureBox13.Enabled = False
        PictureBox14.Enabled = False
        PictureBox15.Enabled = False
        PictureBox16.Enabled = False

        If Label2.Text = 4 Then
            Timer3.Start()
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        'Img mario (par)
        If clique = False Then
            clique = True
            PictureBox7.Image = My.Resources.mario
            PictureBox7.Enabled = False
            par1 = 1

        Else
            clique = False
            PictureBox7.Image = My.Resources.mario
            PictureBox7.Enabled = False
            par2 = 1
            verificar()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        'img luigi par
        If clique = False Then
            clique = True
            PictureBox5.Image = My.Resources.Luigi
            PictureBox5.Enabled = False
            par1 = 2
        Else
            clique = False
            PictureBox5.Image = My.Resources.Luigi
            PictureBox5.Enabled = False
            par2 = 2
            verificar()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        'img yoshi par
        If clique = False Then
            clique = True
            PictureBox3.Image = My.Resources.yoshi
            PictureBox3.Enabled = False
            par1 = 3
        Else
            clique = False
            PictureBox3.Image = My.Resources.yoshi
            PictureBox3.Enabled = False
            par2 = 3
            verificar()
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        'img yoshi par
        If clique = False Then
            clique = True
            PictureBox6.Image = My.Resources.yoshi
            PictureBox6.Enabled = False
            par1 = 3

        Else
            clique = False
            PictureBox6.Image = My.Resources.yoshi
            PictureBox6.Enabled = False
            par2 = 3
            verificar()

        End If

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        'img bowser par
        If clique = False Then
            clique = True
            PictureBox4.Image = My.Resources.bowser
            PictureBox4.Enabled = False
            par1 = 4
        Else
            clique = False
            PictureBox4.Image = My.Resources.bowser
            PictureBox4.Enabled = False
            par2 = 4
            verificar()
        End If
    End Sub

    Private Sub PictureBox8_Click_1(sender As Object, e As EventArgs) Handles PictureBox8.Click
        'img bowser par
        If clique = False Then
            clique = True
            PictureBox8.Image = My.Resources.bowser
            PictureBox8.Enabled = False
            par1 = 4

        Else
            clique = False
            PictureBox8.Image = My.Resources.bowser
            PictureBox8.Enabled = False
            par2 = 4
            verificar()
        End If

    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        'Peach princess
        If clique = False Then
            clique = True
            PictureBox13.Image = My.Resources.Peach_Princess
            PictureBox13.Enabled = False
            par1 = 5
        Else
            clique = False
            PictureBox13.Image = My.Resources.Peach_Princess
            PictureBox13.Enabled = False
            par2 = 5
            verificar()


        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        'Peach Princess
        If clique = False Then
            clique = True
            PictureBox9.Image = My.Resources.Peach_Princess
            PictureBox9.Enabled = False
            par1 = 5
        Else
            clique = False
            PictureBox9.Image = My.Resources.Peach_Princess
            PictureBox9.Enabled = False
            par2 = 5
            verificar()


        End If

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        'Wario
        If clique = False Then
            clique = True
            PictureBox10.Image = My.Resources.Wario
            PictureBox10.Enabled = False
            par1 = 6
        Else
            clique = False
            PictureBox10.Image = My.Resources.Wario
            PictureBox10.Enabled = False
            par2 = 6
            verificar()
        End If
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        'Wario
        If clique = False Then
            clique = True
            PictureBox12.Image = My.Resources.Wario
            PictureBox12.Enabled = False
            par1 = 6
        Else
            clique = False
            PictureBox12.Image = My.Resources.Wario
            PictureBox12.Enabled = False
            par2 = 6
            verificar()
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        'Toad
        If clique = False Then
            clique = True
            PictureBox11.Image = My.Resources.Toad
            PictureBox11.Enabled = False
            par1 = 7
        Else
            clique = False
            PictureBox11.Image = My.Resources.Toad
            PictureBox11.Enabled = False
            par2 = 7
            verificar()
        End If
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        'Toad
        If clique = False Then
            clique = True
            PictureBox15.Image = My.Resources.Toad
            PictureBox15.Enabled = False
            par1 = 7
        Else
            clique = False
            PictureBox15.Image = My.Resources.Toad
            PictureBox15.Enabled = False
            par2 = 7
            verificar()
        End If
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        'Waluigi
        If clique = False Then
            clique = True
            PictureBox14.Image = My.Resources.Waluigi
            PictureBox14.Enabled = False
            par1 = 8
        Else
            clique = False
            PictureBox14.Image = My.Resources.Waluigi
            PictureBox14.Enabled = False
            par2 = 8
            verificar()
        End If
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        'Waluigi
        If clique = False Then
            clique = True
            PictureBox16.Image = My.Resources.Waluigi
            PictureBox16.Enabled = False
            par1 = 8
        Else
            clique = False
            PictureBox16.Image = My.Resources.Waluigi
            PictureBox16.Enabled = False
            par2 = 8
            verificar()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text += 1

        If par1 = 1 Then
            Timer1.Stop()
            PictureBox1.Enabled = True
            PictureBox2.Enabled = True
            PictureBox3.Enabled = True
            PictureBox4.Enabled = True
            PictureBox5.Enabled = True
            PictureBox6.Enabled = True
            PictureBox7.Enabled = True
            PictureBox8.Enabled = True
            PictureBox9.Enabled = True
            PictureBox10.Enabled = True
            PictureBox11.Enabled = True
            PictureBox12.Enabled = True
            PictureBox13.Enabled = True
            PictureBox14.Enabled = True
            PictureBox15.Enabled = True
            PictureBox16.Enabled = True

            PictureBox1.Visible = False
            PictureBox7.Visible = False
            Label1.Text = 0
        ElseIf par1 = 2 Then
            Timer1.Stop()
            PictureBox1.Enabled = True
            PictureBox2.Enabled = True
            PictureBox3.Enabled = True
            PictureBox4.Enabled = True
            PictureBox5.Enabled = True
            PictureBox6.Enabled = True
            PictureBox7.Enabled = True
            PictureBox8.Enabled = True
            PictureBox9.Enabled = True
            PictureBox10.Enabled = True
            PictureBox11.Enabled = True
            PictureBox12.Enabled = True
            PictureBox13.Enabled = True
            PictureBox14.Enabled = True
            PictureBox15.Enabled = True
            PictureBox16.Enabled = True

            PictureBox5.Visible = False
            PictureBox2.Visible = False
            Label1.Text = 0
        ElseIf par1 = 3 Then
            Timer1.Stop()
            PictureBox1.Enabled = True
            PictureBox2.Enabled = True
            PictureBox3.Enabled = True
            PictureBox4.Enabled = True
            PictureBox5.Enabled = True
            PictureBox6.Enabled = True
            PictureBox7.Enabled = True
            PictureBox8.Enabled = True
            PictureBox9.Enabled = True
            PictureBox10.Enabled = True
            PictureBox11.Enabled = True
            PictureBox12.Enabled = True
            PictureBox13.Enabled = True
            PictureBox14.Enabled = True
            PictureBox15.Enabled = True
            PictureBox16.Enabled = True

            PictureBox3.Visible = False
            PictureBox6.Visible = False
            Label1.Text = 0
        ElseIf par1 = 4 Then
            Timer1.Stop()
            PictureBox1.Enabled = True
            PictureBox2.Enabled = True
            PictureBox3.Enabled = True
            PictureBox4.Enabled = True
            PictureBox5.Enabled = True
            PictureBox6.Enabled = True
            PictureBox7.Enabled = True
            PictureBox8.Enabled = True
            PictureBox9.Enabled = True
            PictureBox10.Enabled = True
            PictureBox11.Enabled = True
            PictureBox12.Enabled = True
            PictureBox13.Enabled = True
            PictureBox14.Enabled = True
            PictureBox15.Enabled = True
            PictureBox16.Enabled = True

            PictureBox4.Visible = False
            PictureBox8.Visible = False
            Label1.Text = 0
        ElseIf par1 = 5 Then
            Timer1.Stop()
            PictureBox1.Enabled = True
            PictureBox2.Enabled = True
            PictureBox3.Enabled = True
            PictureBox4.Enabled = True
            PictureBox5.Enabled = True
            PictureBox6.Enabled = True
            PictureBox7.Enabled = True
            PictureBox8.Enabled = True
            PictureBox9.Enabled = True
            PictureBox10.Enabled = True
            PictureBox11.Enabled = True
            PictureBox12.Enabled = True
            PictureBox13.Enabled = True
            PictureBox14.Enabled = True
            PictureBox15.Enabled = True
            PictureBox16.Enabled = True

            PictureBox13.Visible = False
            PictureBox9.Visible = False
            Label1.Text = 0
        ElseIf par1 = 6 Then
            Timer1.Stop()

            PictureBox1.Enabled = True
            PictureBox2.Enabled = True
            PictureBox3.Enabled = True
            PictureBox4.Enabled = True
            PictureBox5.Enabled = True
            PictureBox6.Enabled = True
            PictureBox7.Enabled = True
            PictureBox8.Enabled = True
            PictureBox9.Enabled = True
            PictureBox10.Enabled = True
            PictureBox11.Enabled = True
            PictureBox12.Enabled = True
            PictureBox13.Enabled = True
            PictureBox14.Enabled = True
            PictureBox15.Enabled = True
            PictureBox16.Enabled = True

            PictureBox10.Visible = False
            PictureBox12.Visible = False
            Label1.Text = 0
        ElseIf par1 = 7 Then
            Timer1.Stop()
            PictureBox1.Enabled = True
            PictureBox2.Enabled = True
            PictureBox3.Enabled = True
            PictureBox4.Enabled = True
            PictureBox5.Enabled = True
            PictureBox6.Enabled = True
            PictureBox7.Enabled = True
            PictureBox8.Enabled = True
            PictureBox9.Enabled = True
            PictureBox10.Enabled = True
            PictureBox11.Enabled = True
            PictureBox12.Enabled = True
            PictureBox13.Enabled = True
            PictureBox14.Enabled = True
            PictureBox15.Enabled = True
            PictureBox16.Enabled = True

            PictureBox11.Visible = False
            PictureBox15.Visible = False
            Label1.Text = 0
        ElseIf par1 = 8 Then
            Timer1.Stop()
            PictureBox1.Enabled = True
            PictureBox2.Enabled = True
            PictureBox3.Enabled = True
            PictureBox4.Enabled = True
            PictureBox5.Enabled = True
            PictureBox6.Enabled = True
            PictureBox7.Enabled = True
            PictureBox8.Enabled = True
            PictureBox9.Enabled = True
            PictureBox10.Enabled = True
            PictureBox11.Enabled = True
            PictureBox12.Enabled = True
            PictureBox13.Enabled = True
            PictureBox14.Enabled = True
            PictureBox15.Enabled = True
            PictureBox16.Enabled = True

            PictureBox14.Visible = False
            PictureBox16.Visible = False
            Label1.Text = 0
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label2.Text += 1
        PictureBox1.Enabled = False
        PictureBox2.Enabled = False
        PictureBox3.Enabled = False
        PictureBox4.Enabled = False
        PictureBox5.Enabled = False
        PictureBox6.Enabled = False
        PictureBox7.Enabled = False
        PictureBox8.Enabled = False
        PictureBox9.Enabled = False
        PictureBox10.Enabled = False
        PictureBox11.Enabled = False
        PictureBox12.Enabled = False
        PictureBox13.Enabled = False
        PictureBox14.Enabled = False
        PictureBox15.Enabled = False
        PictureBox16.Enabled = False

        

        If Label2.Text = 4 Then
            Timer2.Stop()
            PictureBox1.Image = My.Resources.logo_mario
            PictureBox2.Image = My.Resources.logo_mario
            PictureBox3.Image = My.Resources.logo_mario
            PictureBox4.Image = My.Resources.logo_mario
            PictureBox5.Image = My.Resources.logo_mario
            PictureBox6.Image = My.Resources.logo_mario
            PictureBox7.Image = My.Resources.logo_mario
            PictureBox8.Image = My.Resources.logo_mario
            PictureBox9.Image = My.Resources.logo_mario
            PictureBox10.Image = My.Resources.logo_mario
            PictureBox11.Image = My.Resources.logo_mario
            PictureBox12.Image = My.Resources.logo_mario
            PictureBox13.Image = My.Resources.logo_mario
            PictureBox14.Image = My.Resources.logo_mario
            PictureBox15.Image = My.Resources.logo_mario
            PictureBox16.Image = My.Resources.logo_mario

            PictureBox1.Enabled = True
            PictureBox2.Enabled = True
            PictureBox3.Enabled = True
            PictureBox4.Enabled = True
            PictureBox5.Enabled = True
            PictureBox6.Enabled = True
            PictureBox7.Enabled = True
            PictureBox8.Enabled = True
            PictureBox9.Enabled = True
            PictureBox10.Enabled = True
            PictureBox11.Enabled = True
            PictureBox12.Enabled = True
            PictureBox13.Enabled = True
            PictureBox14.Enabled = True
            PictureBox15.Enabled = True
            PictureBox16.Enabled = True

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TentarNovamenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TentarNovamenteToolStripMenuItem.Click
        Timer1.Stop()
        PictureBox1.Image = My.Resources.logo_mario
        PictureBox2.Image = My.Resources.logo_mario
        PictureBox3.Image = My.Resources.logo_mario
        PictureBox4.Image = My.Resources.logo_mario
        PictureBox5.Image = My.Resources.logo_mario
        PictureBox6.Image = My.Resources.logo_mario
        PictureBox7.Image = My.Resources.logo_mario
        PictureBox8.Image = My.Resources.logo_mario
        PictureBox9.Image = My.Resources.logo_mario
        PictureBox10.Image = My.Resources.logo_mario
        PictureBox11.Image = My.Resources.logo_mario
        PictureBox12.Image = My.Resources.logo_mario
        PictureBox13.Image = My.Resources.logo_mario
        PictureBox14.Image = My.Resources.logo_mario
        PictureBox15.Image = My.Resources.logo_mario
        PictureBox16.Image = My.Resources.logo_mario


        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        PictureBox5.Visible = True
        PictureBox6.Visible = True
        PictureBox7.Visible = True
        PictureBox8.Visible = True
        PictureBox9.Visible = True
        PictureBox10.Visible = True
        PictureBox11.Visible = True
        PictureBox12.Visible = True
        PictureBox13.Visible = True
        PictureBox14.Visible = True
        PictureBox15.Visible = True
        PictureBox16.Visible = True

        PictureBox1.Enabled = True
        PictureBox2.Enabled = True
        PictureBox3.Enabled = True
        PictureBox4.Enabled = True
        PictureBox5.Enabled = True
        PictureBox6.Enabled = True
        PictureBox7.Enabled = True
        PictureBox8.Enabled = True
        PictureBox9.Enabled = True
        PictureBox10.Enabled = True
        PictureBox11.Enabled = True
        PictureBox12.Enabled = True
        PictureBox13.Enabled = True
        PictureBox14.Enabled = True
        PictureBox15.Enabled = True
        PictureBox16.Enabled = True

        pontos = 0
        clique = False

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VoltarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoltarToolStripMenuItem.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        End
    End Sub
End Class