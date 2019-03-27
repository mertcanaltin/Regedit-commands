Imports Microsoft.Win32
Public Class Form1
    Private Sub AltAnahtarOlusturButton1_Click(sender As Object, e As EventArgs) Handles AltAnahtarOlusturButton1.Click
        Dim AltAnahtar As String = anahtarTextBox1.Text.Trim
        If AltAnahtar <> "" Then
            Registry.CurrentUser.CreateSubKey(AltAnahtar)
            My.Computer.Registry.CurrentUser.CreateSubKey("mert").CreateSubKey("BİP") 'ALT ANAHTAR ALTINDA ALT ANAHTAR OLUŞTURUR
            MsgBox("alt anahtar oluşturuldu")
            anahtarTextBox1.Clear()
        End If
    End Sub

    Private Sub AltAltaButton_Click(sender As Object, e As EventArgs) Handles AltAltaButton.Click
        Dim AltAnahtar As String = anahtarTextBox1.Text.Trim
        If AltAnahtar <> "" Then
            Registry.CurrentUser.CreateSubKey(AltAnahtar)
            My.Computer.Registry.CurrentUser.CreateSubKey("mert\bip\" & AltAnahtar)
            MsgBox("alt anahtar oluşturuldu")
            anahtarTextBox1.Clear()

        End If
    End Sub

    Private Sub DegerEkleButton_Click(sender As Object, e As EventArgs) Handles DegerEkleButton.Click
        Dim ad, veri As String
        ad = degerAdiTextBox.Text
        veri = DegerTextBox.Text
        Registry.CurrentUser.CreateSubKey("mert\bip\ayarlar").SetValue(ad, veri)
        MsgBox("veri kaydedildi")

    End Sub

    Private Sub DegerOkuButton_Click(sender As Object, e As EventArgs) Handles DegerOkuButton.Click
        Dim veri As String
        veri = Registry.CurrentUser.OpenSubKey("mert\bip\ayarlar").GetValue("yükseklik", 0)
        MsgBox("Okunan Değer :" & veri)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim veri As String
        veri = Registry.CurrentUser.OpenSubKey("mert\bip\ayarlar").GetValue("yükseklik", 0)
        Registry.CurrentUser.OpenSubKey("mert\bip\ayarlar", True).DeleteValue("yükseklik", False)
        MsgBox("Silinen Değer :" & veri)
    End Sub

    Private Sub AltAnahtarSilButton_Click(sender As Object, e As EventArgs) Handles AltAnahtarSilButton.Click
        Registry.CurrentUser.DeleteSubKey("mert\bip\ayarlar", False)
        MsgBox("AYARLAR Alt Anahtar Başarı ile silindi !")
    End Sub

    Private Sub TumAltAnahtarSilButton_Click(sender As Object, e As EventArgs) Handles TumAltAnahtarSilButton.Click
        Registry.CurrentUser.DeleteSubKeyTree("mert", False)
        MsgBox("Mert anahtarı silindi !")
    End Sub
End Class
