Module Module1
    Public clique As Boolean = False
    Public par1, par2, pontos As Integer
    Dim tentarnovamente As Integer
    Dim parabens As Integer
    Sub verificar()
        If par1 = par2 Then
            pontos = pontos + 1
            If par1 = 1 Then
                Form2.Timer1.Start()
                Form2.PictureBox1.Enabled = False
                Form2.PictureBox2.Enabled = False
                Form2.PictureBox3.Enabled = False
                Form2.PictureBox4.Enabled = False
                Form2.PictureBox5.Enabled = False
                Form2.PictureBox6.Enabled = False
                Form2.PictureBox7.Enabled = False
                Form2.PictureBox8.Enabled = False
                Form2.PictureBox9.Enabled = False
                Form2.PictureBox10.Enabled = False
                Form2.PictureBox11.Enabled = False
                Form2.PictureBox12.Enabled = False
                Form2.PictureBox13.Enabled = False
                Form2.PictureBox14.Enabled = False
                Form2.PictureBox15.Enabled = False
                Form2.PictureBox16.Enabled = False
                Form2.PictureBox1.Visible = True
                Form2.PictureBox7.Visible = True
            ElseIf par1 = 2 Then
                Form2.Timer1.Start()
                Form2.PictureBox1.Enabled = False
                Form2.PictureBox2.Enabled = False
                Form2.PictureBox3.Enabled = False
                Form2.PictureBox4.Enabled = False
                Form2.PictureBox5.Enabled = False
                Form2.PictureBox6.Enabled = False
                Form2.PictureBox7.Enabled = False
                Form2.PictureBox8.Enabled = False
                Form2.PictureBox9.Enabled = False
                Form2.PictureBox10.Enabled = False
                Form2.PictureBox11.Enabled = False
                Form2.PictureBox12.Enabled = False
                Form2.PictureBox13.Enabled = False
                Form2.PictureBox14.Enabled = False
                Form2.PictureBox15.Enabled = False
                Form2.PictureBox16.Enabled = False
                Form2.PictureBox5.Visible = True
                Form2.PictureBox2.Visible = True
            ElseIf par1 = 3 Then
                Form2.Timer1.Start()
                Form2.PictureBox1.Enabled = False
                Form2.PictureBox2.Enabled = False
                Form2.PictureBox3.Enabled = False
                Form2.PictureBox4.Enabled = False
                Form2.PictureBox5.Enabled = False
                Form2.PictureBox6.Enabled = False
                Form2.PictureBox7.Enabled = False
                Form2.PictureBox8.Enabled = False
                Form2.PictureBox9.Enabled = False
                Form2.PictureBox10.Enabled = False
                Form2.PictureBox11.Enabled = False
                Form2.PictureBox12.Enabled = False
                Form2.PictureBox13.Enabled = False
                Form2.PictureBox14.Enabled = False
                Form2.PictureBox15.Enabled = False
                Form2.PictureBox16.Enabled = False

                Form2.PictureBox3.Visible = True
                Form2.PictureBox6.Visible = True
            ElseIf par1 = 4 Then
                Form2.Timer1.Start()
                Form2.PictureBox1.Enabled = False
                Form2.PictureBox2.Enabled = False
                Form2.PictureBox3.Enabled = False
                Form2.PictureBox4.Enabled = False
                Form2.PictureBox5.Enabled = False
                Form2.PictureBox6.Enabled = False
                Form2.PictureBox7.Enabled = False
                Form2.PictureBox8.Enabled = False
                Form2.PictureBox9.Enabled = False
                Form2.PictureBox10.Enabled = False
                Form2.PictureBox11.Enabled = False
                Form2.PictureBox12.Enabled = False
                Form2.PictureBox13.Enabled = False
                Form2.PictureBox14.Enabled = False
                Form2.PictureBox15.Enabled = False
                Form2.PictureBox16.Enabled = False

                Form2.PictureBox4.Visible = True
                Form2.PictureBox8.Visible = True
            ElseIf par1 = 5 Then
                Form2.Timer1.Start()
                Form2.PictureBox1.Enabled = False
                Form2.PictureBox2.Enabled = False
                Form2.PictureBox3.Enabled = False
                Form2.PictureBox4.Enabled = False
                Form2.PictureBox5.Enabled = False
                Form2.PictureBox6.Enabled = False
                Form2.PictureBox7.Enabled = False
                Form2.PictureBox8.Enabled = False
                Form2.PictureBox9.Enabled = False
                Form2.PictureBox10.Enabled = False
                Form2.PictureBox11.Enabled = False
                Form2.PictureBox12.Enabled = False
                Form2.PictureBox13.Enabled = False
                Form2.PictureBox14.Enabled = False
                Form2.PictureBox15.Enabled = False
                Form2.PictureBox16.Enabled = False

                Form2.PictureBox13.Visible = True
                Form2.PictureBox9.Visible = True
            ElseIf par1 = 6 Then
                Form2.Timer1.Start()
                Form2.PictureBox1.Enabled = False
                Form2.PictureBox2.Enabled = False
                Form2.PictureBox3.Enabled = False
                Form2.PictureBox4.Enabled = False
                Form2.PictureBox5.Enabled = False
                Form2.PictureBox6.Enabled = False
                Form2.PictureBox7.Enabled = False
                Form2.PictureBox8.Enabled = False
                Form2.PictureBox9.Enabled = False
                Form2.PictureBox10.Enabled = False
                Form2.PictureBox11.Enabled = False
                Form2.PictureBox12.Enabled = False
                Form2.PictureBox13.Enabled = False
                Form2.PictureBox14.Enabled = False
                Form2.PictureBox15.Enabled = False
                Form2.PictureBox16.Enabled = False

                Form2.PictureBox10.Visible = True
                Form2.PictureBox12.Visible = True
            ElseIf par1 = 7 Then
                Form2.PictureBox1.Enabled = False
                Form2.PictureBox2.Enabled = False
                Form2.PictureBox3.Enabled = False
                Form2.PictureBox4.Enabled = False
                Form2.PictureBox5.Enabled = False
                Form2.PictureBox6.Enabled = False
                Form2.PictureBox7.Enabled = False
                Form2.PictureBox8.Enabled = False
                Form2.PictureBox9.Enabled = False
                Form2.PictureBox10.Enabled = False
                Form2.PictureBox11.Enabled = False
                Form2.PictureBox12.Enabled = False
                Form2.PictureBox13.Enabled = False
                Form2.PictureBox14.Enabled = False
                Form2.PictureBox15.Enabled = False
                Form2.PictureBox16.Enabled = False

                Form2.Timer1.Start()
                Form2.PictureBox11.Visible = True
                Form2.PictureBox15.Visible = True
            ElseIf par1 = 8 Then
                Form2.Timer1.Start()
                Form2.PictureBox1.Enabled = False
                Form2.PictureBox2.Enabled = False
                Form2.PictureBox3.Enabled = False
                Form2.PictureBox4.Enabled = False
                Form2.PictureBox5.Enabled = False
                Form2.PictureBox6.Enabled = False
                Form2.PictureBox7.Enabled = False
                Form2.PictureBox8.Enabled = False
                Form2.PictureBox9.Enabled = False
                Form2.PictureBox10.Enabled = False
                Form2.PictureBox11.Enabled = False
                Form2.PictureBox12.Enabled = False
                Form2.PictureBox13.Enabled = False
                Form2.PictureBox14.Enabled = False
                Form2.PictureBox15.Enabled = False
                Form2.PictureBox16.Enabled = False

                Form2.PictureBox14.Visible = True
                Form2.PictureBox16.Visible = True
            End If
        Else
            tentarnovamente = MessageBox.Show("Tente Novamente!", "Você errou!", MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            If tentarnovamente = vbYes Then

            ElseIf tentarnovamente = vbNo Then
                Form1.Show()
                Form2.Close()
            End If
            Form2.PictureBox1.Image = My.Resources.logo_mario
            Form2.PictureBox2.Image = My.Resources.logo_mario
            Form2.PictureBox3.Image = My.Resources.logo_mario
            Form2.PictureBox4.Image = My.Resources.logo_mario
            Form2.PictureBox5.Image = My.Resources.logo_mario
            Form2.PictureBox6.Image = My.Resources.logo_mario
            Form2.PictureBox7.Image = My.Resources.logo_mario
            Form2.PictureBox8.Image = My.Resources.logo_mario
            Form2.PictureBox9.Image = My.Resources.logo_mario
            Form2.PictureBox10.Image = My.Resources.logo_mario
            Form2.PictureBox11.Image = My.Resources.logo_mario
            Form2.PictureBox12.Image = My.Resources.logo_mario
            Form2.PictureBox13.Image = My.Resources.logo_mario
            Form2.PictureBox14.Image = My.Resources.logo_mario
            Form2.PictureBox15.Image = My.Resources.logo_mario
            Form2.PictureBox16.Image = My.Resources.logo_mario

            Form2.PictureBox1.Enabled = True
            Form2.PictureBox2.Enabled = True
            Form2.PictureBox3.Enabled = True
            Form2.PictureBox4.Enabled = True
            Form2.PictureBox5.Enabled = True
            Form2.PictureBox6.Enabled = True
            Form2.PictureBox7.Enabled = True
            Form2.PictureBox8.Enabled = True
            Form2.PictureBox9.Enabled = True
            Form2.PictureBox10.Enabled = True
            Form2.PictureBox11.Enabled = True
            Form2.PictureBox12.Enabled = True
            Form2.PictureBox13.Enabled = True
            Form2.PictureBox14.Enabled = True
            Form2.PictureBox15.Enabled = True
            Form2.PictureBox16.Enabled = True
        End If

        If pontos = 8 Then
            parabens = MessageBox.Show("Parábens!!! Você ganhou!!! e fez " & pontos & " pontos" & vbCrLf & "Deseja tentar novamente?", "Você Ganhou!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If parabens = vbYes Then

            ElseIf parabens = vbNo Then
                Form1.Show()
                Form2.Close()
            End If
            Form2.PictureBox1.Image = My.Resources.logo_mario
            Form2.PictureBox2.Image = My.Resources.logo_mario
            Form2.PictureBox3.Image = My.Resources.logo_mario
            Form2.PictureBox4.Image = My.Resources.logo_mario
            Form2.PictureBox5.Image = My.Resources.logo_mario
            Form2.PictureBox6.Image = My.Resources.logo_mario
            Form2.PictureBox7.Image = My.Resources.logo_mario
            Form2.PictureBox8.Image = My.Resources.logo_mario
            Form2.PictureBox9.Image = My.Resources.logo_mario
            Form2.PictureBox10.Image = My.Resources.logo_mario
            Form2.PictureBox11.Image = My.Resources.logo_mario
            Form2.PictureBox12.Image = My.Resources.logo_mario
            Form2.PictureBox13.Image = My.Resources.logo_mario
            Form2.PictureBox14.Image = My.Resources.logo_mario
            Form2.PictureBox15.Image = My.Resources.logo_mario
            Form2.PictureBox16.Image = My.Resources.logo_mario


            Form2.PictureBox1.Visible = True
            Form2.PictureBox2.Visible = True
            Form2.PictureBox3.Visible = True
            Form2.PictureBox4.Visible = True
            Form2.PictureBox5.Visible = True
            Form2.PictureBox6.Visible = True
            Form2.PictureBox7.Visible = True
            Form2.PictureBox8.Visible = True
            Form2.PictureBox9.Visible = True
            Form2.PictureBox10.Visible = True
            Form2.PictureBox11.Visible = True
            Form2.PictureBox12.Visible = True
            Form2.PictureBox13.Visible = True
            Form2.PictureBox14.Visible = True
            Form2.PictureBox15.Visible = True
            Form2.PictureBox16.Visible = True

            pontos = 0
            clique = False
        End If
    End Sub
End Module
