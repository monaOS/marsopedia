<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.AppName = New System.Windows.Forms.Label()
        Me.LeftPanel = New System.Windows.Forms.Panel()
        Me.ExitButton = New System.Windows.Forms.Label()
        Me.ChangeThemeButton = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InfoBar = New System.Windows.Forms.Panel()
        Me.Info = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.Description = New System.Windows.Forms.Label()
        Me.InfoButton = New System.Windows.Forms.Label()
        Me.LeftPanel.SuspendLayout()
        Me.InfoBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AppName
        '
        Me.AppName.AutoSize = True
        Me.AppName.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!)
        Me.AppName.ForeColor = System.Drawing.Color.White
        Me.AppName.Location = New System.Drawing.Point(19, 16)
        Me.AppName.Name = "AppName"
        Me.AppName.Size = New System.Drawing.Size(161, 37)
        Me.AppName.TabIndex = 0
        Me.AppName.Text = "Marsopedia"
        '
        'LeftPanel
        '
        Me.LeftPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LeftPanel.Controls.Add(Me.InfoButton)
        Me.LeftPanel.Controls.Add(Me.ExitButton)
        Me.LeftPanel.Controls.Add(Me.ChangeThemeButton)
        Me.LeftPanel.Controls.Add(Me.AppName)
        Me.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(200, 450)
        Me.LeftPanel.TabIndex = 1
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.AutoSize = True
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.ExitButton.ForeColor = System.Drawing.Color.White
        Me.ExitButton.Location = New System.Drawing.Point(12, 415)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(44, 25)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "esci"
        '
        'ChangeThemeButton
        '
        Me.ChangeThemeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChangeThemeButton.AutoSize = True
        Me.ChangeThemeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChangeThemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChangeThemeButton.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.ChangeThemeButton.ForeColor = System.Drawing.Color.White
        Me.ChangeThemeButton.Location = New System.Drawing.Point(12, 383)
        Me.ChangeThemeButton.Name = "ChangeThemeButton"
        Me.ChangeThemeButton.Size = New System.Drawing.Size(123, 25)
        Me.ChangeThemeButton.TabIndex = 1
        Me.ChangeThemeButton.Text = "cambia tema"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 37)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Marsopedia"
        '
        'InfoBar
        '
        Me.InfoBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.InfoBar.Controls.Add(Me.Info)
        Me.InfoBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.InfoBar.Location = New System.Drawing.Point(200, 422)
        Me.InfoBar.Name = "InfoBar"
        Me.InfoBar.Size = New System.Drawing.Size(600, 28)
        Me.InfoBar.TabIndex = 5
        '
        'Info
        '
        Me.Info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Info.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Info.ForeColor = System.Drawing.Color.White
        Me.Info.Location = New System.Drawing.Point(0, 0)
        Me.Info.Name = "Info"
        Me.Info.Size = New System.Drawing.Size(600, 28)
        Me.Info.TabIndex = 0
        Me.Info.Text = "[i] Benvenut* su Marsopedia."
        Me.Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.SearchBox)
        Me.Panel1.Location = New System.Drawing.Point(200, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 53)
        Me.Panel1.TabIndex = 6
        '
        'SearchBox
        '
        Me.SearchBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchBox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SearchBox.ForeColor = System.Drawing.Color.White
        Me.SearchBox.Location = New System.Drawing.Point(18, 12)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(570, 29)
        Me.SearchBox.TabIndex = 0
        Me.SearchBox.TabStop = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Font = New System.Drawing.Font("Segoe UI Semibold", 25.0!)
        Me.Title.ForeColor = System.Drawing.Color.Black
        Me.Title.Location = New System.Drawing.Point(206, 60)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(191, 46)
        Me.Title.TabIndex = 7
        Me.Title.Text = "Benvenut*!"
        '
        'Description
        '
        Me.Description.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Description.BackColor = System.Drawing.Color.Transparent
        Me.Description.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!)
        Me.Description.ForeColor = System.Drawing.Color.Black
        Me.Description.Location = New System.Drawing.Point(212, 110)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(576, 298)
        Me.Description.TabIndex = 8
        Me.Description.Text = "Scrivi un'espressione nella barra qui sopra."
        '
        'InfoButton
        '
        Me.InfoButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.InfoButton.AutoSize = True
        Me.InfoButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InfoButton.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.InfoButton.ForeColor = System.Drawing.Color.White
        Me.InfoButton.Location = New System.Drawing.Point(12, 351)
        Me.InfoButton.Name = "InfoButton"
        Me.InfoButton.Size = New System.Drawing.Size(46, 25)
        Me.InfoButton.TabIndex = 3
        Me.InfoButton.Text = "info"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.InfoBar)
        Me.Controls.Add(Me.LeftPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Marsopedia"
        Me.LeftPanel.ResumeLayout(False)
        Me.LeftPanel.PerformLayout()
        Me.InfoBar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AppName As Label
    Friend WithEvents LeftPanel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents ExitButton As Label
    Friend WithEvents ChangeThemeButton As Label
    Friend WithEvents InfoBar As Panel
    Friend WithEvents Info As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents Title As Label
    Friend WithEvents Description As Label
    Friend WithEvents InfoButton As Label
End Class
