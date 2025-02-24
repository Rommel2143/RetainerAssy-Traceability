Module Containers




    Public Sub display_form(newForm As Form)

        ' Add the new form to Panel1
        With newForm

            .TopLevel = False
            Mainframe.Panel1.Controls.Add(newForm)
            .BringToFront()
            .Show()
        End With

    End Sub

    Public Sub display_formsub(newForm As Form)

        ' Add the new form to Panel1
        With newForm
            .TopLevel = False
            sub_frame.Panel1.Controls.Add(newForm)
            .BringToFront()
            .Show()
        End With

    End Sub

End Module
