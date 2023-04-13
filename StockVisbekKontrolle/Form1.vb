Public Class Form1

    Dim dtStock As New DataTable("StockVisbek")

    Dim dtView As New DataView(dtStock)
    Dim strGeprüft As String = "FALSE"
    Dim strDepot As String = "FALSE"
    Dim strDatum = Strings.Left(Convert.ToString(Today), 10)
    Dim strPfad As String = "F:\StockVisbek\StockVisbek "
    Dim strPfadDatei As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtBoxDatum.Text = strDatum
        subDatenLaden(txtBoxDatum.Text)

    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        If txtBoxDatum.Text <> "" Then
            txtBoxDatum.Text = DateAdd("d", -1, txtBoxDatum.Text)
        Else
            txtBoxDatum.Text = Today.AddDays(-1)
        End If

        subDatenLaden(txtBoxDatum.Text)

    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click

        If txtBoxDatum.Text <> "" Then
            txtBoxDatum.Text = DateAdd("d", +1, txtBoxDatum.Text)
        Else
            txtBoxDatum.Text = Today.AddDays(+1)
        End If

        subDatenLaden(txtBoxDatum.Text)

    End Sub

    Private Sub subDatenLaden(strDatum As String)

        'lädt den erfassten Stock aus XML-Datei

        'Pfad bilden
        strPfadDatei = strPfad & strDatum & ".xml"

        'DataTable leeren
        dtStock.Clear()

        Try
            dtStock.ReadXml(strPfadDatei)
        Catch
            'MsgBox("Datei " & strPfadDatei & " fehlt")
            Exit Sub
        End Try

        subFilterAlleAnzeigen()

        DataGridView1.DataSource = dtView

        'Gridview einrichten

        Me.DataGridView1.Columns("Fuß").Width = 40
        Me.DataGridView1.Columns("Gestellung").Width = 150
        Me.DataGridView1.Columns("GestellungOrt").Width = 100
        Me.DataGridView1.Columns("ContainerNummerOhneFormat").Visible = False
        DataGridView1.Columns("erfasst").Visible = False

    End Sub

    Private Sub subFilterSetzen()

        'Sonderfall Containernummer
        'Ereignis KeyDown wird in TxtBoxContainernummer ausgelöst
        'Vergleich der Angabe soll aber in dem GridViewFeld ContainernummerOhneFormat
        'stattfinden
        Dim strbldContainer As New System.Text.StringBuilder
        strbldContainer.Clear()
        strbldContainer.Append(txtBoxContainerNummer.Text.ToString)
        strbldContainer.Replace(" ", "")
        strbldContainer.Replace(".", "")
        strbldContainer.Replace("-", "")

        dtView.RowFilter =
                "(([ContainerNummerOhneFormat] LIKE '*" & strbldContainer.ToString & "*') " &
                "OR ([ContainerNummer] LIKE '*" & txtBoxContainerNummer.Text & "*')) " &
                "And ([Reederei] Like '*" & txtBoxReederei.Text & "*') " &
                "And ([Chassis] Like '*" & txtBoxChassis.Text & "*') " &
                "AND ([Fuß] LIKE '*" & txtBoxFuß.Text & "*') " &
                "AND ([geprüft] = " & strGeprüft & ") " &
                "AND ([Depot] = " & strDepot & ") " &
                "AND ([Gestellung] LIKE '*" & txtBoxGestellung.Text & "*') " &
                "AND ([GestellungOrt] LIKE '*" & txtBoxGestellungOrt.Text & "*')"

        If (txtBoxGeprüft.Text = "") And (txtBoxDepot.Text = "") Then
            dtView.RowFilter =
                "([ContainerNummer] LIKE '*" & txtBoxContainerNummer.Text & "*') " &
                "AND ([Reederei] LIKE '*" & txtBoxReederei.Text & "*') " &
                "And ([Chassis] Like '*" & txtBoxChassis.Text & "*') " &
                "AND ([Fuß] LIKE '*" & txtBoxFuß.Text & "*') " &
                "AND (([geprüft] = FALSE) OR ([geprüft] = TRUE)) " &
                "AND (([Depot] = FALSE) OR ([Depot] = TRUE)) " &
                "AND ([Gestellung] LIKE '*" & txtBoxGestellung.Text & "*') " &
                "AND ([GestellungOrt] LIKE '*" & txtBoxGestellungOrt.Text & "*')"
        End If

        If (txtBoxGeprüft.Text = "X") And txtBoxDepot.Text = "" Then
            dtView.RowFilter =
                "([ContainerNummerOhneFormat] LIKE '*" & strbldContainer.ToString & "*') " &
                "AND ([Reederei] LIKE '*" & txtBoxReederei.Text & "*') " &
                "And ([Chassis] Like '*" & txtBoxChassis.Text & "*') " &
                "AND ([Fuß] LIKE '*" & txtBoxFuß.Text & "*') " &
                "AND ([geprüft] = TRUE) " &
                "AND (([Depot] = TRUE) OR ([Depot] = FALSE)) " &
                "AND ([Gestellung] LIKE '*" & txtBoxGestellung.Text & "*') " &
                "AND ([GestellungOrt] LIKE '*" & txtBoxGestellungOrt.Text & "*')"

        End If

    End Sub

    Private Sub subFilterAlleAnzeigen()
        'Sonderfall Containernummer
        'Ereignis KeyDown wird in TxtBoxContainernummer ausgelöst
        'Vergleich der Angabe soll aber in dem GridViewFeld ContainernummerOhneFormat
        'stattfinden
        Dim strbldContainer As New System.Text.StringBuilder
        strbldContainer.Clear()
        strbldContainer.Append(txtBoxContainerNummer.Text.ToString)
        strbldContainer.Replace(" ", "")
        strbldContainer.Replace(".", "")
        strbldContainer.Replace("-", "")

        If (txtBoxGeprüft.Text = "") And (txtBoxDepot.Text = "") Then
            dtView.RowFilter =
               "([ContainerNummerOhneFormat] LIKE '*" & strbldContainer.ToString & "*') " &
              "AND ([Reederei] LIKE '*" & txtBoxReederei.Text & "*') " &
              "And ([Chassis] Like '*" & txtBoxChassis.Text & "*') " &
             "AND ([Fuß] LIKE '*" & txtBoxFuß.Text & "*') " &
            "AND (([geprüft] = TRUE) OR ([geprüft] = FALSE)) " &
           "AND (([Depot] = TRUE) OR ([Depot] = FALSE)) " &
           "AND ([Gestellung] LIKE '*" & txtBoxGestellung.Text & "*') " &
          "AND ([GestellungOrt] LIKE '*" & txtBoxGestellungOrt.Text & "*')"
        End If


    End Sub


    Private Sub txtBoxContainerNummer_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBoxContainerNummer.KeyUp,
                                                                                            txtBoxReederei.KeyUp,
                                                                                            txtBoxChassis.KeyUp,
                                                                                            txtBoxFuß.KeyUp,
                                                                                            txtBoxGestellung.KeyUp,
                                                                                            txtBoxGestellungOrt.KeyUp

        subFilterSetzen()

    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        'Depot geklickt?
        If e.ColumnIndex = 6 Then
            If DataGridView1.CurrentCell.Value Then
                DataGridView1.CurrentRow.Cells("geprüft").Value = True
            End If
        End If

        If e.ColumnIndex = 6 Then
            If Not DataGridView1.CurrentCell.Value Then
                DataGridView1.CurrentRow.Cells("geprüft").Value = False
            End If
        End If


        'geprüft auf false, dann depot auch false
        If e.ColumnIndex = 4 Then
            If Not DataGridView1.CurrentCell.Value Then DataGridView1.CurrentRow.Cells("Depot").Value = False
        End If

        dtStock.WriteXml(strPfadDatei, XmlWriteMode.WriteSchema)


    End Sub



    Private Sub txtBoxGeprüft_Click(sender As Object, e As EventArgs) Handles txtBoxGeprüft.Click

        If txtBoxGeprüft.Text = "" Then
            txtBoxGeprüft.Text = "X"
            strGeprüft = "TRUE"
            subFilterSetzen()
            Exit Sub
        End If

        If txtBoxGeprüft.Text = "X" Then
            'ändern auf nur Ungeprüfte anzeigen
            txtBoxGeprüft.Text = ""
            strGeprüft = "FALSE"
            subFilterSetzen()
            Exit Sub
        End If


    End Sub

    Private Sub txtBoxDepot_Click(sender As Object, e As EventArgs) Handles txtBoxDepot.Click

        If txtBoxDepot.Text = "" Then
            txtBoxDepot.Text = "X"
            txtBoxGeprüft.Text = "X"
            strDepot = "TRUE"
            strGeprüft = "TRUE" 'wenn Depot angeklickt wird, wird geprüft auch auf geklickt gestellt
            subFilterSetzen()
            Exit Sub
        End If

        If txtBoxDepot.Text = "X" Then
            txtBoxDepot.Text = ""
            txtBoxGeprüft.Text = ""
            strDepot = "FALSE"
            strGeprüft = "FALSE"
            subFilterSetzen()
            Exit Sub
        End If

    End Sub

    Private Sub btnAlle_Click(sender As Object, e As EventArgs) Handles btnAlle.Click
        txtBoxContainerNummer.Text = ""
        txtBoxReederei.Text = ""
        txtBoxChassis.Text = ""
        txtBoxFuß.Text = ""
        txtBoxGestellung.Text = ""
        txtBoxGestellungOrt.Text = ""
        txtBoxGeprüft.Text = ""

        subFilterAlleAnzeigen()
    End Sub

    Private Sub btnUngeprueft_Click(sender As Object, e As EventArgs) Handles btnUngeprueft.Click

        txtBoxGeprüft.Text = ""

        dtView.RowFilter =
                "([ContainerNummer] LIKE '*" & txtBoxContainerNummer.Text & "*') " &
                "AND ([Reederei] LIKE '*" & txtBoxReederei.Text & "*') " &
                "And ([Chassis] Like '*" & txtBoxChassis.Text & "*') " &
                "AND ([Fuß] LIKE '*" & txtBoxFuß.Text & "*') " &
                "AND ([geprüft] = FALSE) " &
                "AND (([Depot] = FALSE) OR ([Depot] = TRUE)) " &
                "AND ([Gestellung] LIKE '*" & txtBoxGestellung.Text & "*') " &
                "AND ([GestellungOrt] LIKE '*" & txtBoxGestellungOrt.Text & "*')"
    End Sub

    Private Sub DataGridView1_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridView1.UserAddedRow
        'Datensatz anlegen.
        Dim row As DataRow = dtStock.NewRow

        row!Datum = ""
        row!erfasst = ""
        row!ContainerNummer = ""
        row!Reederei = ""
        row!Fuß = ""
        row!GestellungOrt = ""
        row!Gestellung = ""
        row!GestellungsDatum = ""
        row!Closing = ""
        row!Chassis = ""
        row!ContainerNummerOhneFormat = ""
        row!geprüft = False
        row!depot = False

        dtStock.Rows.Add(row)



    End Sub

    Private Sub btnDepotsPruefen_Click(sender As Object, e As EventArgs) Handles btnDepotsPruefen.Click
        Dim DepotPruefen As New clsDepotPruefen

        DepotPruefen.ClipBoardFuellen()
        DepotPruefen.ClipBoardAnDTUebergeben()
        DataGridView2.DataSource = DepotPruefen.dtDepotContainerNummern

        'DtStock sequentiell durchlaufen
        'wenn in DtDepot dann boolean = True
        'dann Depot auf True und Prüf auf True
        ' und evtl. Reederei nachtragen

        'Array Result füllen
        'dann Länge prüfen, wenn >0 dann gefudnen
        'String ContainerNummer auf gleiches Format bringen

        Dim sbContainerNummer As New System.Text.StringBuilder("")

        For Each row As DataRow In dtStock.Rows

            sbContainerNummer.Clear()
            sbContainerNummer.Append(row!ContainerNummer)
            sbContainerNummer.Replace(" ", "")
            sbContainerNummer.Replace(".", "")
            sbContainerNummer.Replace("-", "")

            'Ausstieg wenn ContainerNummer = ""
            If sbContainerNummer.ToString = "" Then Continue For

            If DepotPruefen.ContainerPruefObVorhanden(sbContainerNummer.ToString) Then
                'Depot auf True stellen
                'Pruef auf True stellen
                'evtl. Reederei nachtragen

                row!Depot = True
                row!geprüft = True

            End If

        Next

        'Daten speichern
        dtStock.WriteXml(strPfadDatei, XmlWriteMode.WriteSchema)

    End Sub
End Class
