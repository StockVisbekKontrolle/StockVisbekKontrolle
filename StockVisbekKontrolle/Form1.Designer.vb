<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtBoxDatum = New System.Windows.Forms.TextBox()
        Me.lblDatum = New System.Windows.Forms.Label()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.txtBoxContainerNummer = New System.Windows.Forms.TextBox()
        Me.txtBoxReederei = New System.Windows.Forms.TextBox()
        Me.txtBoxFuß = New System.Windows.Forms.TextBox()
        Me.txtBoxGestellung = New System.Windows.Forms.TextBox()
        Me.txtBoxGestellungOrt = New System.Windows.Forms.TextBox()
        Me.txtBoxGeprüft = New System.Windows.Forms.TextBox()
        Me.txtBoxDepot = New System.Windows.Forms.TextBox()
        Me.btnAlle = New System.Windows.Forms.Button()
        Me.btnUngeprueft = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btnDepotsPruefen = New System.Windows.Forms.Button()
        Me.txtBoxChassis = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(30, 178)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(1239, 493)
        Me.DataGridView1.TabIndex = 0
        '
        'txtBoxDatum
        '
        Me.txtBoxDatum.Location = New System.Drawing.Point(335, 58)
        Me.txtBoxDatum.Name = "txtBoxDatum"
        Me.txtBoxDatum.Size = New System.Drawing.Size(82, 23)
        Me.txtBoxDatum.TabIndex = 1
        '
        'lblDatum
        '
        Me.lblDatum.AutoSize = True
        Me.lblDatum.Location = New System.Drawing.Point(335, 35)
        Me.lblDatum.Name = "lblDatum"
        Me.lblDatum.Size = New System.Drawing.Size(43, 15)
        Me.lblDatum.TabIndex = 2
        Me.lblDatum.Text = "Datum"
        '
        'btnMinus
        '
        Me.btnMinus.Location = New System.Drawing.Point(303, 58)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(18, 20)
        Me.btnMinus.TabIndex = 3
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(430, 59)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(17, 21)
        Me.btnPlus.TabIndex = 4
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'txtBoxContainerNummer
        '
        Me.txtBoxContainerNummer.Location = New System.Drawing.Point(271, 149)
        Me.txtBoxContainerNummer.Name = "txtBoxContainerNummer"
        Me.txtBoxContainerNummer.Size = New System.Drawing.Size(100, 23)
        Me.txtBoxContainerNummer.TabIndex = 5
        '
        'txtBoxReederei
        '
        Me.txtBoxReederei.Location = New System.Drawing.Point(473, 149)
        Me.txtBoxReederei.Name = "txtBoxReederei"
        Me.txtBoxReederei.Size = New System.Drawing.Size(91, 23)
        Me.txtBoxReederei.TabIndex = 6
        '
        'txtBoxFuß
        '
        Me.txtBoxFuß.Location = New System.Drawing.Point(673, 149)
        Me.txtBoxFuß.Name = "txtBoxFuß"
        Me.txtBoxFuß.Size = New System.Drawing.Size(35, 23)
        Me.txtBoxFuß.TabIndex = 7
        '
        'txtBoxGestellung
        '
        Me.txtBoxGestellung.Location = New System.Drawing.Point(717, 149)
        Me.txtBoxGestellung.Name = "txtBoxGestellung"
        Me.txtBoxGestellung.Size = New System.Drawing.Size(114, 23)
        Me.txtBoxGestellung.TabIndex = 8
        '
        'txtBoxGestellungOrt
        '
        Me.txtBoxGestellungOrt.Location = New System.Drawing.Point(865, 149)
        Me.txtBoxGestellungOrt.Name = "txtBoxGestellungOrt"
        Me.txtBoxGestellungOrt.Size = New System.Drawing.Size(94, 23)
        Me.txtBoxGestellungOrt.TabIndex = 9
        '
        'txtBoxGeprüft
        '
        Me.txtBoxGeprüft.Location = New System.Drawing.Point(411, 148)
        Me.txtBoxGeprüft.Name = "txtBoxGeprüft"
        Me.txtBoxGeprüft.Size = New System.Drawing.Size(21, 23)
        Me.txtBoxGeprüft.TabIndex = 11
        '
        'txtBoxDepot
        '
        Me.txtBoxDepot.Location = New System.Drawing.Point(612, 149)
        Me.txtBoxDepot.Name = "txtBoxDepot"
        Me.txtBoxDepot.Size = New System.Drawing.Size(21, 23)
        Me.txtBoxDepot.TabIndex = 12
        '
        'btnAlle
        '
        Me.btnAlle.Location = New System.Drawing.Point(79, 146)
        Me.btnAlle.Name = "btnAlle"
        Me.btnAlle.Size = New System.Drawing.Size(62, 24)
        Me.btnAlle.TabIndex = 13
        Me.btnAlle.Text = "alle"
        Me.btnAlle.UseVisualStyleBackColor = True
        '
        'btnUngeprueft
        '
        Me.btnUngeprueft.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUngeprueft.Location = New System.Drawing.Point(393, 123)
        Me.btnUngeprueft.Name = "btnUngeprueft"
        Me.btnUngeprueft.Size = New System.Drawing.Size(54, 19)
        Me.btnUngeprueft.TabIndex = 14
        Me.btnUngeprueft.Text = "ungeprüft"
        Me.btnUngeprueft.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 696)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "1.1"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(1336, 178)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(220, 493)
        Me.DataGridView2.TabIndex = 16
        '
        'btnDepotsPruefen
        '
        Me.btnDepotsPruefen.Location = New System.Drawing.Point(912, 693)
        Me.btnDepotsPruefen.Name = "btnDepotsPruefen"
        Me.btnDepotsPruefen.Size = New System.Drawing.Size(74, 39)
        Me.btnDepotsPruefen.TabIndex = 17
        Me.btnDepotsPruefen.Text = "Depots prüfen"
        Me.btnDepotsPruefen.UseVisualStyleBackColor = True
        '
        'txtBoxChassis
        '
        Me.txtBoxChassis.Location = New System.Drawing.Point(178, 148)
        Me.txtBoxChassis.Name = "txtBoxChassis"
        Me.txtBoxChassis.Size = New System.Drawing.Size(69, 23)
        Me.txtBoxChassis.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1722, 788)
        Me.Controls.Add(Me.txtBoxChassis)
        Me.Controls.Add(Me.btnDepotsPruefen)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUngeprueft)
        Me.Controls.Add(Me.btnAlle)
        Me.Controls.Add(Me.txtBoxDepot)
        Me.Controls.Add(Me.txtBoxGeprüft)
        Me.Controls.Add(Me.txtBoxGestellungOrt)
        Me.Controls.Add(Me.txtBoxGestellung)
        Me.Controls.Add(Me.txtBoxFuß)
        Me.Controls.Add(Me.txtBoxReederei)
        Me.Controls.Add(Me.txtBoxContainerNummer)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.lblDatum)
        Me.Controls.Add(Me.txtBoxDatum)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtBoxDatum As TextBox
    Friend WithEvents lblDatum As Label
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents txtBoxContainerNummer As TextBox
    Friend WithEvents txtBoxReederei As TextBox
    Friend WithEvents txtBoxFuß As TextBox
    Friend WithEvents txtBoxGestellung As TextBox
    Friend WithEvents txtBoxGestellungOrt As TextBox
    Friend WithEvents txtBoxGeprüft As TextBox
    Friend WithEvents txtBoxDepot As TextBox
    Friend WithEvents btnAlle As Button
    Friend WithEvents btnUngeprueft As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnDepotsPruefen As Button
    Friend WithEvents txtBoxChassis As TextBox
End Class
