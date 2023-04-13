Public Class clsDepotPruefen
    Public dtDepotContainerNummern As New DataTable
    Dim row As DataRow


    Public Sub ClipBoardFuellen()
        'Datei auswählen
        'markieren
        ' dann weiter
        'aber das Programm bleibt nicht stehen
        'msgBox, um das Programm anzuhalten!?

        MsgBox("Daten in Zwischenablage kopiert? ")



    End Sub


    Public Sub ClipBoardAnDTUebergeben()

        dtDepotContainerNummern.Columns.Add("Containernummer", GetType(String)) ' Containernummer

        Dim text As String = Clipboard.GetText
        Dim zeilen() As String = text.Split(vbCrLf)

        For x = 0 To zeilen.Length - 1
            row = dtDepotContainerNummern.NewRow
            row!ContainerNummer = zeilen(x).ToString
            dtDepotContainerNummern.Rows.Add(row)
        Next



    End Sub

    Public Function ContainerPruefObVorhanden(strContainer As String) As Boolean

        Dim result() As DataRow


        result = dtDepotContainerNummern.Select("[ContainerNummer] = '" & strContainer & "'")

        If result.Length > 0 Then
            ContainerPruefObVorhanden = True
        Else
            ContainerPruefObVorhanden = False
        End If

        Return ContainerPruefObVorhanden

    End Function

End Class
