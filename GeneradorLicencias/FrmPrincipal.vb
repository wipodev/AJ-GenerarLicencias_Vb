Imports System.Xml
Imports System.Security.Cryptography
Imports System.Security.Cryptography.Xml

Public Class FrmPrincipal
    Public Const NombreClavePribada As String = "ClavePribadaCVCELL.xml"
    Public Const NombreClavePublica As String = "ClavePublicaCVCELL.xml"

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.UbicacionClaves.Text = My.Settings.DireccionParClaves
        EstatusDirectorioClaves()
    End Sub

    Private Sub EstatusDirectorioClaves()
        Dim RutaClaves As String = Me.UbicacionClaves.Text

        Me.FechaLicencia.Value = Today
        If RutaClaves <> Nothing Then
            If My.Computer.FileSystem.DirectoryExists(RutaClaves) Then
                If My.Computer.FileSystem.FileExists(RutaClaves & "\" & NombreClavePribada) = False And My.Computer.FileSystem.FileExists(RutaClaves & "\" & NombreClavePublica) = False Then
                    Mensajes(3)
                ElseIf My.Computer.FileSystem.FileExists(RutaClaves & "\" & NombreClavePribada) = False Then
                    Mensajes(4)
                ElseIf My.Computer.FileSystem.FileExists(RutaClaves & "\" & NombreClavePublica) = False Then
                    Mensajes(5)
                Else
                    Mensajes(6)
                End If
            Else
                Mensajes(2)
            End If
        Else
            Mensajes(1)
        End If

        If Me.EstatusUbicacion.Text = "Las claves estan listas para usarse." Then
            Me.EstatusUbicacionColor.BackColor = Color.Green
            Me.GenerarLicencia.Enabled = True
            Me.BuscarDlic.Enabled = True
            Me.NombreProducto.Enabled = True
            Me.VersionCubierta.Enabled = True
            Me.SerialDiscoDuro.Enabled = True
            Me.NombreLicenciatario.Enabled = True
            Me.FechaLicencia.Enabled = True
            Me.FechaExpiracion.Enabled = True
        Else
            Me.EstatusUbicacionColor.BackColor = Color.Red
            Me.GenerarLicencia.Enabled = False
            Me.BuscarDlic.Enabled = False
            Me.NombreProducto.Enabled = False
            Me.VersionCubierta.Enabled = False
            Me.SerialDiscoDuro.Enabled = False
            Me.NombreLicenciatario.Enabled = False
            Me.FechaLicencia.Enabled = False
            Me.FechaExpiracion.Enabled = False
        End If
    End Sub

    Private Sub Mensajes(ByVal ID As Integer)
        Select Case ID
            Case 1
                Me.EstatusUbicacion.Text = "Directorio no Especificado."
            Case 2
                Me.EstatusUbicacion.Text = "Directorio especificado invalido."
            Case 3
                Me.EstatusUbicacion.Text = "El directorio no tiene los archivos de clave."
            Case 4
                Me.EstatusUbicacion.Text = "El directorio no tiene un archivo de clave pribada."
            Case 5
                Me.EstatusUbicacion.Text = "El directorio no tiene un archivo de clave pública."
            Case 6
                Me.EstatusUbicacion.Text = "Las claves estan listas para usarse."
            Case Else
                Me.EstatusUbicacion.Text = "Desconocido."
        End Select

    End Sub

    Private Sub BuscarUbicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarUbicacion.Click
        If (DialogoBuscar.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Me.UbicacionClaves.Text = DialogoBuscar.SelectedPath
            My.Settings.DireccionParClaves = Me.UbicacionClaves.Text
            EstatusDirectorioClaves()
        End If
    End Sub

    Private Sub GenerarClaves_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarClaves.Click
        Dim ParClaves As RSA

        Try

            If Me.EstatusUbicacion.Text = "Las claves estan listas para usarse." Then
                If MsgBox("Uno o ambos de los archivos clave ya existe. " & vbCrLf & _
                          "¿Realmente desea sobrescribir el archivo (s) existente? " & vbCrLf & _
                           "Esta acción no se puede deshacerse.", MsgBoxStyle.YesNo Or MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton2, "Advertencia.") = MsgBoxResult.Yes Then
                    My.Computer.FileSystem.DeleteFile(Me.UbicacionClaves.Text & "\" & NombreClavePribada)
                    My.Computer.FileSystem.DeleteFile(Me.UbicacionClaves.Text & "\" & NombreClavePublica)
                    Mensajes(3)
                    ParClaves = New RSACryptoServiceProvider
                    ParClaves = RSA.Create()
                    My.Computer.FileSystem.WriteAllText(Me.UbicacionClaves.Text & "\" & NombreClavePribada, ParClaves.ToXmlString(False), False)
                    Mensajes(4)
                    My.Computer.FileSystem.WriteAllText(Me.UbicacionClaves.Text & "\" & NombreClavePublica, ParClaves.ToXmlString(True), False)
                    Mensajes(6)
                    MsgBox("Archivos de claves generados con éxito.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Aviso")
                End If
            End If

        Catch Falla As Exception
            MsgBox("Error al generar archivos:" & vbCrLf & vbCrLf & Falla.Message, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Error")
        End Try

    End Sub

    Private Sub GenerarLicencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarLicencia.Click
        Dim licenciaXML As XmlDocument

        If VerificarDatosLicencia() = True Then
            licenciaXML = ConstruirContenidoXmlLicencia()
            If (licenciaXML Is Nothing) = False Then
                If FirmarContenidoLicenciaXml(licenciaXML) = True Then
                    If GuardarUbicacionLicencia.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Try
                            If My.Computer.FileSystem.FileExists(GuardarUbicacionLicencia.FileName) = True Then
                                My.Computer.FileSystem.DeleteFile(GuardarUbicacionLicencia.FileName)
                                licenciaXML.Save(GuardarUbicacionLicencia.FileName)
                                MsgBox("Archivo de licencia guardado correctamente.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Aviso")
                            Else
                                licenciaXML.Save(GuardarUbicacionLicencia.FileName)
                                MsgBox("Archivo de licencia guardado correctamente.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Aviso")
                            End If
                        Catch ex As Exception
                            MsgBox("La licencia no se pudo guardar debido al siguiente error:" & vbCrLf & vbCrLf & ex.Message, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Error")
                            Return
                        End Try
                    End If
                End If
            End If
        End If

    End Sub

    Private Function VerificarDatosLicencia() As Boolean
        Dim PartesVersion() As String = Split(Trim(VersionCubierta.Text), ".")
        Dim scanVersion As String
        Const MensajeVersion As String = "La versión cubierta debe contener entre dos y cuatro " & vbCrLf & _
                                         "componentes delimitado por punto, y cada componente debe ser un " & vbCrLf & _
                                         "número entre 0 y 9999, o el carácter '*'"


        Return True

        If (PartesVersion.Length < 2) Or (PartesVersion.Length > 4) Then
            MsgBox(MensajeVersion, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
            VersionCubierta.Focus()
            Return False
        End If

        For Each scanVersion In PartesVersion
            If (IsNumeric(scanVersion) = True) Then
                If (Val(scanVersion) < 0) Or (Val(scanVersion) > 9999) Then
                    MsgBox(MensajeVersion, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
                    VersionCubierta.Focus()
                    Return False
                End If
            ElseIf (scanVersion <> "*") Then
                MsgBox(MensajeVersion, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
                VersionCubierta.Focus()
                Return False
            End If
        Next scanVersion

        If NombreLicenciatario.Text = "" Then
            MsgBox("El nombre de Licenciatario es necesario.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
            NombreLicenciatario.Focus()
            Return False
        End If

        If (Trim(SerialDiscoDuro.Text) = "") Then
            MsgBox("Se requiere el Número de Serie.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
            SerialDiscoDuro.Focus()
            Return False
        End If

        If (Trim(NombreProducto.Text) = "") Then
            MsgBox("Se requiere el Nombre de Producto.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
            NombreProducto.Focus()
            Return False
        End If

    End Function

    Private Function ConstruirContenidoXmlLicencia() As XmlDocument
        Dim Resultado As XmlDocument
        Dim ContenidoCabecera As XmlDeclaration
        Dim ElementoRaiz As XmlElement
        Dim DatoElemento As XmlElement

        Resultado = New XmlDocument
        ContenidoCabecera = Resultado.CreateXmlDeclaration("1.0", Nothing, String.Empty)
        Resultado.InsertBefore(ContenidoCabecera, Resultado.DocumentElement)

        ElementoRaiz = Resultado.CreateElement("Licencia")
        Resultado.InsertAfter(ElementoRaiz, ContenidoCabecera)

        DatoElemento = Resultado.CreateElement("Producto")
        DatoElemento.InnerText = Trim(NombreProducto.Text)
        ElementoRaiz.AppendChild(DatoElemento)

        DatoElemento = Resultado.CreateElement("FechaLicencia")
        DatoElemento.InnerText = Format(FechaLicencia.Value, "dd/MM/yyyy")
        ElementoRaiz.AppendChild(DatoElemento)

        DatoElemento = Resultado.CreateElement("FechaExpiracion")
        DatoElemento.InnerText = Format(FechaExpiracion.Value, "dd/MM/yyyy")
        ElementoRaiz.AppendChild(DatoElemento)

        DatoElemento = Resultado.CreateElement("VersionCubierta")
        DatoElemento.InnerText = Trim(VersionCubierta.Text)
        ElementoRaiz.AppendChild(DatoElemento)

        DatoElemento = Resultado.CreateElement("Licenciatario")
        DatoElemento.InnerText = Trim(NombreLicenciatario.Text)
        ElementoRaiz.AppendChild(DatoElemento)

        DatoElemento = Resultado.CreateElement("SerialDisco")
        DatoElemento.InnerText = Trim(SerialDiscoDuro.Text)
        ElementoRaiz.AppendChild(DatoElemento)

        Return Resultado
    End Function

    Private Function FirmarContenidoLicenciaXml(ByVal FuenteXML As XmlDocument) As Boolean
        Dim ArchivoClavePribada As String
        Dim ClavePribada As RSA
        Dim Firma As SignedXml
        Dim MetodoReferencia As Reference

        Try

            ArchivoClavePribada = UbicacionClaves.Text & "\" & NombreClavePribada

            If (My.Computer.FileSystem.FileExists(ArchivoClavePribada) = False) Then
                MsgBox("No se pudo encontrar el archivo de clave privada.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
            ClavePribada = RSA.Create()
            ClavePribada.FromXmlString(My.Computer.FileSystem.ReadAllText(ArchivoClavePribada))

            Firma = New SignedXml(FuenteXML)
            Firma.SignedInfo.CanonicalizationMethod = SignedXml.XmlDsigCanonicalizationUrl
            Firma.SigningKey = ClavePribada

            MetodoReferencia = New Reference("")
            MetodoReferencia.AddTransform(New XmlDsigEnvelopedSignatureTransform(False))
            Firma.AddReference(MetodoReferencia)

            Firma.ComputeSignature()
            FuenteXML.DocumentElement.AppendChild(Firma.GetXml())
            Return True

        Catch ex As Exception
            MsgBox("La licencia no puede ser firmada digitalmente por el siguiente error:" & vbCrLf & vbCrLf & ex.Message, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Error")
            Return False
        End Try

    End Function

    Private Sub BuscarDlic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarDlic.Click
        If (AbrirUbicacionDlic.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Dim Datos(1) As String
            Datos = Split(My.Computer.FileSystem.ReadAllText(AbrirUbicacionDlic.FileName), vbCrLf)
            Me.NombreProducto.Text = Datos(0)
            Me.SerialDiscoDuro.Text = Datos(1)
        End If
    End Sub

End Class
