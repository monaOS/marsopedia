Public Class Main
    Public Function EnableDarkMode()
        Me.BackColor = Color.FromArgb(30, 30, 30)
        Title.ForeColor = Color.FromArgb(255, 255, 255)
        Description.ForeColor = Color.FromArgb(255, 255, 255)
        My.Settings.Theme = "Dark"
        My.Settings.Save()
    End Function
    Public Function EnableLightMode()
        Me.BackColor = Color.FromArgb(255, 255, 255)
        Title.ForeColor = Color.FromArgb(30, 30, 30)
        Description.ForeColor = Color.FromArgb(30, 30, 30)
        My.Settings.Theme = "Light"
        My.Settings.Save()
    End Function
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Theme = "Dark" Then
            EnableDarkMode()
        ElseIf My.Settings.Theme = "Light" Then
            EnableLightMode()
        Else
            EnableLightMode()
        End If
        Info.Text = "[i] Sto controllando la connessione ad intenet..."
        If Not My.Computer.Network.IsAvailable Then
            SearchBox.Enabled = False
            InfoButton.Enabled = False
            Title.Text = "Oh no!"
            Description.Text = "Marsopedia richiede una connessione a intenet per funzionare."
        End If
        Info.Text = "[i] Benvenut* su Marsopedia."
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Info.Text = "[i] Chiusura di Marsopedia in corso..."
        End
    End Sub

    Private Sub ChangeThemeButton_Click(sender As Object, e As EventArgs) Handles ChangeThemeButton.Click
        If My.Settings.Theme = "Dark" Then
            Info.Text = "[i] Sto impostando il tema chiaro..."
            EnableLightMode()
            Info.Text = "[i] Benvenut* su Marsopedia."
        ElseIf My.Settings.Theme = "Light" Then
            Info.Text = "[i] Sto impostando il tema scuro..."
            EnableDarkMode()
            Info.Text = "[i] Benvenut* su Marsopedia."
        Else
            Info.Text = "[i] Sto impostando il tema chiaro..."
            EnableLightMode()
            Info.Text = "[i] Benvenut* su Marsopedia."
        End If
    End Sub

    Private Sub SearchBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchBox.KeyDown
        Info.Text = "[i] Premi Invio per cercare la parola."
        If e.KeyCode = Keys.Enter Then
            If Not SearchBox.Text.Trim = "" Then
                Try
                    Info.Text = "[i] Sto creando una connessione al server..."
                    Dim Web As New System.Net.WebClient
                    Web.Encoding = System.Text.Encoding.UTF8
                    Info.Text = "[i] Sto scaricando la definizione dai server..."
                    Dim DescriptionText As String = Web.DownloadString("https://marsopedia-contents.parliamodipc.repl.co/descriptions/" + SearchBox.Text.ToLower)
                        Info.Text = "[i] Sto modificando il titolo..."
                        Title.Text = "Significato di " + SearchBox.Text.ToLower
                        Info.Text = "[i] Sto modificando la descrizione..."
                        Description.Text = DescriptionText
                        Info.Text = "[i] Benvenut* su Marsopedia."
                    Catch ex As Exception
                    Info.Text = "[i] Sto modificando il titolo..."
                    Title.Text = "Oh no!"
                    Info.Text = "[i] Sto modificando la descrizione..."
                    Description.Text = "La parola non è inclusa in Marsopedia."
                    Info.Text = "[i] Benvenut* su Marsopedia."
                End Try
            Else
                Info.Text = "[i] Sto modificando il titolo..."
                Title.Text = "Benvenut*!"
                Info.Text = "[i] Sto modificando la descrizione..."
                Description.Text = "Scrivi un'espressione nella barra qui sopra."
                Info.Text = "[i] Benvenut* su Marsopedia."
            End If
        End If
    End Sub

    Private Sub AppName_MouseDown(sender As Object, e As MouseEventArgs) Handles AppName.MouseDown
        Info.Text = "[i] MODALITÀ MONA SUPREMO ATTIVATA!"
        AppName.Text = "MONA"
        SearchBox.Enabled = False
        Title.Text = "MONA"
        Description.Text = "MONA"
        ChangeThemeButton.Text = "MONA"
        ExitButton.Text = "MONA"
        InfoButton.Text = "MONA"
        SearchBox.Text = "MONA"
        Me.Text = "MONA"
    End Sub

    Private Sub InfoButton_Click(sender As Object, e As EventArgs) Handles InfoButton.Click
        SearchBox.Text = "Marsopedia"
        Try
            Info.Text = "[i] Sto creando una connessione al server..."
            Dim Web As New System.Net.WebClient
            Web.Encoding = System.Text.Encoding.UTF8
            Info.Text = "[i] Sto scaricando la definizione dai server..."
            Dim DescriptionText As String = Web.DownloadString("https://marsopedia-contents.parliamodipc.repl.co/descriptions/marsopedia")
            Info.Text = "[i] Sto modificando il titolo..."
            Title.Text = "Significato di " + SearchBox.Text.ToLower
            Info.Text = "[i] Sto modificando la descrizione..."
            Description.Text = DescriptionText
            Info.Text = "[i] Benvenut* su Marsopedia."
        Catch ex As Exception
            Info.Text = "[i] Sto modificando il titolo..."
            Title.Text = "Lei è sfigato!"
            Info.Text = "[i] Sto modificando la descrizione..."
            Description.Text = "I nostri server sono offline."

            Info.Text = "[i] Benvenut* su Marsopedia."
        End Try
    End Sub
End Class
