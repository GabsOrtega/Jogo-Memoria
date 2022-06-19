Public Class Form3

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'Rouge 
        If clique = False Then
            clique = True
            PictureBox1.Image = My.Resources.Rouge
            PictureBox1.Enabled = False
            par1 = 1
        Else
            clique = False
            PictureBox1.Image = My.Resources.Rouge
            PictureBox1.Enabled = False
            par2 = 1
            verificar2()
        End If
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        'Rouge
        If clique = False Then
            clique = True
            PictureBox22.Image = My.Resources.Rouge
            PictureBox22.Enabled = False
            par1 = 1
        Else
            clique = False
            PictureBox22.Image = My.Resources.Rouge
            PictureBox22.Enabled = False
            par2 = 1
            verificar2()
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'Tails
        If clique = False Then
            clique = True
            PictureBox2.Image = My.Resources.Tails
            PictureBox2.Enabled = False
            par1 = 2
        Else
            clique = False
            PictureBox2.Image = My.Resources.Tails
            PictureBox2.Enabled = False
            par2 = 2
            verificar2()
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        'Tails
        If clique = False Then
            clique = True
            PictureBox4.Image = My.Resources.Tails
            PictureBox4.Enabled = False
            par1 = 2
        Else
            clique = False
            PictureBox4.Image = My.Resources.Tails
            PictureBox4.Enabled = False
            par2 = 2
            verificar2()
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        'Sonic
        If clique = False Then
            clique = True
            PictureBox9.Image = My.Resources.Sonic
            PictureBox9.Enabled = False
            par1 = 3
        Else
            clique = False
            PictureBox9.Image = My.Resources.Sonic
            PictureBox9.Enabled = False
            par2 = 3
            verificar2()
        End If
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        'Sonic
        If clique = False Then
            clique = True
            PictureBox24.Image = My.Resources.Sonic
            PictureBox24.Enabled = False
            par1 = 3
        Else
            clique = False
            PictureBox24.Image = My.Resources.Sonic
            PictureBox24.Enabled = False
            par2 = 3
            verificar2()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        'Charmy Bee
        If clique = False Then
            clique = True
            PictureBox3.Image = My.Resources.Charmy_Bee
            PictureBox3.Enabled = False
            par1 = 4
        Else
            clique = False
            PictureBox3.Image = My.Resources.Charmy_Bee
            PictureBox3.Enabled = False
            par2 = 4
            verificar2()
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        'Charmy Bee
        If clique = False Then
            clique = True
            PictureBox11.Image = My.Resources.Charmy_Bee
            PictureBox11.Enabled = False
            par1 = 4
        Else
            clique = False
            PictureBox11.Image = My.Resources.Charmy_Bee
            PictureBox11.Enabled = False
            par2 = 4
            verificar2()
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        'Vector
        If clique = False Then
            clique = True
            PictureBox6.Image = My.Resources.Vector
            PictureBox6.Enabled = False
            par1 = 5
        Else
            clique = False
            PictureBox6.Image = My.Resources.Vector
            PictureBox6.Enabled = False
            par2 = 5
            verificar2()
        End If
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        'Vector
        If clique = False Then
            clique = True
            PictureBox23.Image = My.Resources.Vector
            PictureBox23.Enabled = False
            par1 = 5
        Else
            clique = False
            PictureBox23.Image = My.Resources.Vector
            PictureBox23.Enabled = False
            par2 = 5
            verificar2()
        End If
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        'Silver
        If clique = False Then
            clique = True
            PictureBox14.Image = My.Resources.Silver
            PictureBox14.Enabled = False
            par1 = 6
        Else
            clique = False
            PictureBox14.Image = My.Resources.Silver
            PictureBox14.Enabled = False
            par2 = 6
            verificar2()
        End If
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        'Silver
        If clique = False Then
            clique = True
            PictureBox21.Image = My.Resources.Silver
            PictureBox21.Enabled = False
            par1 = 6
        Else
            clique = False
            PictureBox21.Image = My.Resources.Silver
            PictureBox21.Enabled = False
            par2 = 6
            verificar2()
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        'Eggman
        If clique = False Then
            clique = True
            PictureBox8.Image = My.Resources.Eggman
            PictureBox8.Enabled = False
            par1 = 7
        Else
            clique = False
            PictureBox8.Image = My.Resources.Eggman
            PictureBox8.Enabled = False
            par2 = 7
            verificar2()
        End If
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        'Eggman
        If clique = False Then
            clique = True
            PictureBox18.Image = My.Resources.Eggman
            PictureBox18.Enabled = False
            par1 = 7
        Else
            clique = False
            PictureBox18.Image = My.Resources.Eggman
            PictureBox18.Enabled = False
            par2 = 7
            verificar2()
        End If
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        'Big the cat
        If clique = False Then
            clique = True
            PictureBox13.Image = My.Resources.Big
            PictureBox13.Enabled = False
            par1 = 8
        Else
            clique = False
            PictureBox13.Image = My.Resources.Big
            PictureBox13.Enabled = False
            par2 = 8
            verificar2()
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        'Big The cat
        If clique = False Then
            clique = True
            PictureBox10.Image = My.Resources.Big
            PictureBox10.Enabled = False
            par1 = 8
        Else
            clique = False
            PictureBox10.Image = My.Resources.Big
            PictureBox10.Enabled = False
            par2 = 8
            verificar2()
        End If
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        'Shadow
        If clique = False Then
            clique = True
            PictureBox17.Image = My.Resources.Shadow
            PictureBox17.Enabled = False
            par1 = 9
        Else
            clique = False
            PictureBox17.Image = My.Resources.Shadow
            PictureBox17.Enabled = False
            par2 = 9
            verificar2()
        End If
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        'Shadow
        If clique = False Then
            clique = True
            PictureBox12.Image = My.Resources.Shadow
            PictureBox12.Enabled = False
            par1 = 9
        Else
            clique = False
            PictureBox12.Image = My.Resources.Shadow
            PictureBox12.Enabled = False
            par2 = 9
            verificar2()
        End If
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        'Amy
        If clique = False Then
            clique = True
            PictureBox15.Image = My.Resources.Amy
            PictureBox15.Enabled = False
            par1 = 10
        Else
            clique = False
            PictureBox15.Image = My.Resources.Amy
            PictureBox15.Enabled = False
            par2 = 10
            verificar2()
        End If
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        'Amy
        If clique = False Then
            clique = True
            PictureBox19.Image = My.Resources.Amy
            PictureBox19.Enabled = False
            par1 = 10
        Else
            clique = False
            PictureBox19.Image = My.Resources.Amy
            PictureBox19.Enabled = False
            par2 = 10
            verificar2()
        End If
    End Sub


    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        'Knuckles
        If clique = False Then
            clique = True
            PictureBox16.Image = My.Resources.Knuckles
            PictureBox16.Enabled = False
            par1 = 11
        Else
            clique = False
            PictureBox16.Image = My.Resources.Knuckles
            PictureBox16.Enabled = False
            par2 = 11
            verificar2()
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        'Knuckles
        If clique = False Then
            clique = True
            PictureBox7.Image = My.Resources.Knuckles
            PictureBox7.Enabled = False
            par1 = 11
        Else
            clique = False
            PictureBox7.Image = My.Resources.Knuckles
            PictureBox7.Enabled = False
            par2 = 11
            verificar2()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        'Cream
        If clique = False Then
            clique = True
            PictureBox5.Image = My.Resources.Cream
            PictureBox5.Enabled = False
            par1 = 12
        Else
            clique = False
            PictureBox5.Image = My.Resources.Cream
            PictureBox5.Enabled = False
            par2 = 12
            verificar2()
        End If

    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        'Cream
        If clique = False Then
            clique = True
            PictureBox20.Image = My.Resources.Cream
            PictureBox20.Enabled = False
            par1 = 12
        Else
            clique = False
            PictureBox20.Image = My.Resources.Cream
            PictureBox20.Enabled = False
            par2 = 12
            verificar2()
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Start()
        PictureBox1.Image = My.Resources.Rouge
        PictureBox2.Image = My.Resources.Tails
        PictureBox3.Image = My.Resources.Charmy_Bee
        PictureBox4.Image = My.Resources.Tails
        PictureBox5.Image = My.Resources.Cream
        PictureBox6.Image = My.Resources.Vector
        PictureBox7.Image = My.Resources.Knuckles
        PictureBox8.Image = My.Resources.Eggman
        PictureBox9.Image = My.Resources.Sonic
        PictureBox10.Image = My.Resources.Big
        PictureBox11.Image = My.Resources.Charmy_Bee
        PictureBox12.Image = My.Resources.Shadow
        PictureBox13.Image = My.Resources.Big
        PictureBox14.Image = My.Resources.Silver
        PictureBox15.Image = My.Resources.Amy
        PictureBox16.Image = My.Resources.Knuckles
        PictureBox17.Image = My.Resources.Shadow
        PictureBox18.Image = My.Resources.Eggman
        PictureBox19.Image = My.Resources.Amy
        PictureBox20.Image = My.Resources.Cream
        PictureBox21.Image = My.Resources.Silver
        PictureBox22.Image = My.Resources.Rouge
        PictureBox23.Image = My.Resources.Vector
        PictureBox24.Image = My.Resources.Sonic


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
        PictureBox17.Enabled = False
        PictureBox18.Enabled = False
        PictureBox19.Enabled = False
        PictureBox20.Enabled = False
        PictureBox21.Enabled = False
        PictureBox22.Enabled = False
        PictureBox23.Enabled = False
        PictureBox24.Enabled = False

    End Sub

    Private Sub TentarNovamenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TentarNovamenteToolStripMenuItem.Click
        Timer1.Stop()
        PictureBox1.Image = My.Resources.capa_sonicc
        PictureBox2.Image = My.Resources.capa_sonicc
        PictureBox3.Image = My.Resources.capa_sonicc
        PictureBox4.Image = My.Resources.capa_sonicc
        PictureBox5.Image = My.Resources.capa_sonicc
        PictureBox6.Image = My.Resources.capa_sonicc
        PictureBox7.Image = My.Resources.capa_sonicc
        PictureBox8.Image = My.Resources.capa_sonicc
        PictureBox9.Image = My.Resources.capa_sonicc
        PictureBox10.Image = My.Resources.capa_sonicc
        PictureBox11.Image = My.Resources.capa_sonicc
        PictureBox12.Image = My.Resources.capa_sonicc
        PictureBox13.Image = My.Resources.capa_sonicc
        PictureBox14.Image = My.Resources.capa_sonicc
        PictureBox15.Image = My.Resources.capa_sonicc
        PictureBox16.Image = My.Resources.capa_sonicc
        PictureBox17.Image = My.Resources.capa_sonicc
        PictureBox18.Image = My.Resources.capa_sonicc
        PictureBox19.Image = My.Resources.capa_sonicc
        PictureBox20.Image = My.Resources.capa_sonicc
        PictureBox21.Image = My.Resources.capa_sonicc
        PictureBox22.Image = My.Resources.capa_sonicc
        PictureBox23.Image = My.Resources.capa_sonicc
        PictureBox24.Image = My.Resources.capa_sonicc

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
        PictureBox17.Visible = True
        PictureBox18.Visible = True
        PictureBox19.Visible = True
        PictureBox20.Visible = True
        PictureBox21.Visible = True
        PictureBox22.Visible = True
        PictureBox23.Visible = True
        PictureBox24.Visible = True


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
        PictureBox17.Enabled = True
        PictureBox18.Enabled = True
        PictureBox19.Enabled = True
        PictureBox20.Enabled = True
        PictureBox21.Enabled = True
        PictureBox22.Enabled = True
        PictureBox23.Enabled = True
        PictureBox24.Enabled = True

        pontos = 0
        clique = False
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
            PictureBox17.Enabled = True
            PictureBox18.Enabled = True
            PictureBox19.Enabled = True
            PictureBox20.Enabled = True
            PictureBox21.Enabled = True
            PictureBox22.Enabled = True
            PictureBox23.Enabled = True
            PictureBox24.Enabled = True

            PictureBox1.Visible = False
            PictureBox22.Visible = False
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
            PictureBox17.Enabled = True
            PictureBox18.Enabled = True
            PictureBox19.Enabled = True
            PictureBox20.Enabled = True
            PictureBox21.Enabled = True
            PictureBox22.Enabled = True
            PictureBox23.Enabled = True
            PictureBox24.Enabled = True

            PictureBox2.Visible = False
            PictureBox4.Visible = False
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
            PictureBox17.Enabled = True
            PictureBox18.Enabled = True
            PictureBox19.Enabled = True
            PictureBox20.Enabled = True
            PictureBox21.Enabled = True
            PictureBox22.Enabled = True
            PictureBox23.Enabled = True
            PictureBox24.Enabled = True

            PictureBox9.Visible = False
            PictureBox24.Visible = False
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
            PictureBox17.Enabled = True
            PictureBox18.Enabled = True
            PictureBox19.Enabled = True
            PictureBox20.Enabled = True
            PictureBox21.Enabled = True
            PictureBox22.Enabled = True
            PictureBox23.Enabled = True
            PictureBox24.Enabled = True

            PictureBox3.Visible = False
            PictureBox11.Visible = False
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
            PictureBox17.Enabled = True
            PictureBox18.Enabled = True
            PictureBox19.Enabled = True
            PictureBox20.Enabled = True
            PictureBox21.Enabled = True
            PictureBox22.Enabled = True
            PictureBox23.Enabled = True
            PictureBox24.Enabled = True

            PictureBox6.Visible = False
            PictureBox23.Visible = False
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
            PictureBox17.Enabled = True
            PictureBox18.Enabled = True
            PictureBox19.Enabled = True
            PictureBox20.Enabled = True
            PictureBox21.Enabled = True
            PictureBox22.Enabled = True
            PictureBox23.Enabled = True
            PictureBox24.Enabled = True

            PictureBox14.Visible = False
            PictureBox21.Visible = False
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
            PictureBox17.Enabled = True
            PictureBox18.Enabled = True
            PictureBox19.Enabled = True
            PictureBox20.Enabled = True
            PictureBox21.Enabled = True
            PictureBox22.Enabled = True
            PictureBox23.Enabled = True
            PictureBox24.Enabled = True

            PictureBox8.Visible = False
            PictureBox18.Visible = False
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
            PictureBox17.Enabled = True
            PictureBox18.Enabled = True
            PictureBox19.Enabled = True
            PictureBox20.Enabled = True
            PictureBox21.Enabled = True
            PictureBox22.Enabled = True
            PictureBox23.Enabled = True
            PictureBox24.Enabled = True

            PictureBox13.Visible = False
            PictureBox10.Visible = False
            Label1.Text = 0

        ElseIf par1 = 9 Then
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
            PictureBox17.Enabled = True
            PictureBox18.Enabled = True
            PictureBox19.Enabled = True
            PictureBox20.Enabled = True
            PictureBox21.Enabled = True
            PictureBox22.Enabled = True
            PictureBox23.Enabled = True
            PictureBox24.Enabled = True

            PictureBox17.Visible = False
            PictureBox12.Visible = False
            Label1.Text = 0

        ElseIf par1 = 10 Then
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
            PictureBox17.Enabled = True
            PictureBox18.Enabled = True
            PictureBox19.Enabled = True
            PictureBox20.Enabled = True
            PictureBox21.Enabled = True
            PictureBox22.Enabled = True
            PictureBox23.Enabled = True
            PictureBox24.Enabled = True

            PictureBox15.Visible = False
            PictureBox19.Visible = False
            Label1.Text = 0

        ElseIf par1 = 11 Then
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
            PictureBox17.Enabled = True
            PictureBox18.Enabled = True
            PictureBox19.Enabled = True
            PictureBox20.Enabled = True
            PictureBox21.Enabled = True
            PictureBox22.Enabled = True
            PictureBox23.Enabled = True
            PictureBox24.Enabled = True

            PictureBox16.Visible = False
            PictureBox7.Visible = False
            Label1.Text = 0

        ElseIf par1 = 12 Then
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
            PictureBox17.Enabled = True
            PictureBox18.Enabled = True
            PictureBox19.Enabled = True
            PictureBox20.Enabled = True
            PictureBox21.Enabled = True
            PictureBox22.Enabled = True
            PictureBox23.Enabled = True
            PictureBox24.Enabled = True

            PictureBox5.Visible = False
            PictureBox20.Visible = False
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
        PictureBox17.Enabled = False
        PictureBox18.Enabled = False
        PictureBox19.Enabled = False
        PictureBox20.Enabled = False
        PictureBox21.Enabled = False
        PictureBox22.Enabled = False
        PictureBox23.Enabled = False
        PictureBox24.Enabled = False

        If Label2.Text = 4 Then
            Timer2.Stop()
            PictureBox1.Image = My.Resources.capa_sonicc
            PictureBox2.Image = My.Resources.capa_sonicc
            PictureBox3.Image = My.Resources.capa_sonicc
            PictureBox4.Image = My.Resources.capa_sonicc
            PictureBox5.Image = My.Resources.capa_sonicc
            PictureBox6.Image = My.Resources.capa_sonicc
            PictureBox7.Image = My.Resources.capa_sonicc
            PictureBox8.Image = My.Resources.capa_sonicc
            PictureBox9.Image = My.Resources.capa_sonicc
            PictureBox10.Image = My.Resources.capa_sonicc
            PictureBox11.Image = My.Resources.capa_sonicc
            PictureBox12.Image = My.Resources.capa_sonicc
            PictureBox13.Image = My.Resources.capa_sonicc
            PictureBox14.Image = My.Resources.capa_sonicc
            PictureBox15.Image = My.Resources.capa_sonicc
            PictureBox16.Image = My.Resources.capa_sonicc
            PictureBox17.Image = My.Resources.capa_sonicc
            PictureBox18.Image = My.Resources.capa_sonicc
            PictureBox19.Image = My.Resources.capa_sonicc
            PictureBox20.Image = My.Resources.capa_sonicc
            PictureBox21.Image = My.Resources.capa_sonicc
            PictureBox22.Image = My.Resources.capa_sonicc
            PictureBox23.Image = My.Resources.capa_sonicc
            PictureBox24.Image = My.Resources.capa_sonicc


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
            PictureBox17.Enabled = True
            PictureBox18.Enabled = True
            PictureBox19.Enabled = True
            PictureBox20.Enabled = True
            PictureBox21.Enabled = True
            PictureBox22.Enabled = True
            PictureBox23.Enabled = True
            PictureBox24.Enabled = True

        End If
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        End
    End Sub

    Private Sub VoltarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoltarToolStripMenuItem.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class