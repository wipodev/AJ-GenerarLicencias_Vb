<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.LabelKey = New System.Windows.Forms.Label()
        Me.LabelLocation = New System.Windows.Forms.Label()
        Me.UbicacionClaves = New System.Windows.Forms.TextBox()
        Me.BuscarUbicacion = New System.Windows.Forms.Button()
        Me.DividerKey = New System.Windows.Forms.Label()
        Me.DividerLicense = New System.Windows.Forms.Label()
        Me.LabelLicenseDate = New System.Windows.Forms.Label()
        Me.LabelLicense = New System.Windows.Forms.Label()
        Me.FechaLicencia = New System.Windows.Forms.DateTimePicker()
        Me.FechaExpiracion = New System.Windows.Forms.DateTimePicker()
        Me.LabelExpiration = New System.Windows.Forms.Label()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.VersionCubierta = New System.Windows.Forms.TextBox()
        Me.LabelVersionSample = New System.Windows.Forms.Label()
        Me.NombreLicenciatario = New System.Windows.Forms.TextBox()
        Me.LabelLicensee = New System.Windows.Forms.Label()
        Me.SerialDiscoDuro = New System.Windows.Forms.TextBox()
        Me.LabelSerial = New System.Windows.Forms.Label()
        Me.GenerarLicencia = New System.Windows.Forms.Button()
        Me.EstatusUbicacion = New System.Windows.Forms.Label()
        Me.EstatusUbicacionColor = New System.Windows.Forms.Label()
        Me.GuardarUbicacionLicencia = New System.Windows.Forms.SaveFileDialog()
        Me.GenerarClaves = New System.Windows.Forms.Button()
        Me.NombreProducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BuscarDlic = New System.Windows.Forms.Button()
        Me.DialogoBuscar = New System.Windows.Forms.FolderBrowserDialog()
        Me.AbrirUbicacionDlic = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'LabelKey
        '
        Me.LabelKey.AutoSize = True
        Me.LabelKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelKey.Location = New System.Drawing.Point(8, 8)
        Me.LabelKey.Name = "LabelKey"
        Me.LabelKey.Size = New System.Drawing.Size(132, 13)
        Me.LabelKey.TabIndex = 0
        Me.LabelKey.Text = "Clave Publica-Pribada"
        '
        'LabelLocation
        '
        Me.LabelLocation.AutoSize = True
        Me.LabelLocation.Location = New System.Drawing.Point(5, 34)
        Me.LabelLocation.Name = "LabelLocation"
        Me.LabelLocation.Size = New System.Drawing.Size(58, 13)
        Me.LabelLocation.TabIndex = 2
        Me.LabelLocation.Text = "Ubicacion:"
        '
        'UbicacionClaves
        '
        Me.UbicacionClaves.Location = New System.Drawing.Point(64, 32)
        Me.UbicacionClaves.Name = "UbicacionClaves"
        Me.UbicacionClaves.ReadOnly = True
        Me.UbicacionClaves.Size = New System.Drawing.Size(376, 20)
        Me.UbicacionClaves.TabIndex = 3
        '
        'BuscarUbicacion
        '
        Me.BuscarUbicacion.Location = New System.Drawing.Point(368, 56)
        Me.BuscarUbicacion.Name = "BuscarUbicacion"
        Me.BuscarUbicacion.Size = New System.Drawing.Size(75, 23)
        Me.BuscarUbicacion.TabIndex = 6
        Me.BuscarUbicacion.Text = "Buscar"
        Me.BuscarUbicacion.UseVisualStyleBackColor = True
        '
        'DividerKey
        '
        Me.DividerKey.BackColor = System.Drawing.SystemColors.ControlText
        Me.DividerKey.Location = New System.Drawing.Point(8, 24)
        Me.DividerKey.Name = "DividerKey"
        Me.DividerKey.Size = New System.Drawing.Size(432, 1)
        Me.DividerKey.TabIndex = 1
        '
        'DividerLicense
        '
        Me.DividerLicense.BackColor = System.Drawing.SystemColors.ControlText
        Me.DividerLicense.Location = New System.Drawing.Point(12, 107)
        Me.DividerLicense.Name = "DividerLicense"
        Me.DividerLicense.Size = New System.Drawing.Size(432, 1)
        Me.DividerLicense.TabIndex = 8
        '
        'LabelLicenseDate
        '
        Me.LabelLicenseDate.AutoSize = True
        Me.LabelLicenseDate.Location = New System.Drawing.Point(21, 222)
        Me.LabelLicenseDate.Name = "LabelLicenseDate"
        Me.LabelLicenseDate.Size = New System.Drawing.Size(94, 13)
        Me.LabelLicenseDate.TabIndex = 9
        Me.LabelLicenseDate.Text = "Fecha de licencia:"
        '
        'LabelLicense
        '
        Me.LabelLicense.AutoSize = True
        Me.LabelLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLicense.Location = New System.Drawing.Point(12, 91)
        Me.LabelLicense.Name = "LabelLicense"
        Me.LabelLicense.Size = New System.Drawing.Size(142, 13)
        Me.LabelLicense.TabIndex = 7
        Me.LabelLicense.Text = "Generacion de Licencia"
        '
        'FechaLicencia
        '
        Me.FechaLicencia.Location = New System.Drawing.Point(127, 220)
        Me.FechaLicencia.MaxDate = New Date(2999, 12, 31, 0, 0, 0, 0)
        Me.FechaLicencia.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.FechaLicencia.Name = "FechaLicencia"
        Me.FechaLicencia.Size = New System.Drawing.Size(313, 20)
        Me.FechaLicencia.TabIndex = 10
        '
        'FechaExpiracion
        '
        Me.FechaExpiracion.Location = New System.Drawing.Point(127, 244)
        Me.FechaExpiracion.MaxDate = New Date(2999, 12, 31, 0, 0, 0, 0)
        Me.FechaExpiracion.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.FechaExpiracion.Name = "FechaExpiracion"
        Me.FechaExpiracion.Size = New System.Drawing.Size(313, 20)
        Me.FechaExpiracion.TabIndex = 12
        Me.FechaExpiracion.Value = New Date(2999, 12, 31, 0, 0, 0, 0)
        '
        'LabelExpiration
        '
        Me.LabelExpiration.AutoSize = True
        Me.LabelExpiration.Location = New System.Drawing.Point(8, 246)
        Me.LabelExpiration.Name = "LabelExpiration"
        Me.LabelExpiration.Size = New System.Drawing.Size(107, 13)
        Me.LabelExpiration.TabIndex = 11
        Me.LabelExpiration.Text = "Fecha de Expiracion:"
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Location = New System.Drawing.Point(29, 144)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(86, 13)
        Me.LabelVersion.TabIndex = 13
        Me.LabelVersion.Text = "Versión cubierta:"
        '
        'VersionCubierta
        '
        Me.VersionCubierta.Location = New System.Drawing.Point(127, 142)
        Me.VersionCubierta.Name = "VersionCubierta"
        Me.VersionCubierta.Size = New System.Drawing.Size(217, 20)
        Me.VersionCubierta.TabIndex = 14
        '
        'LabelVersionSample
        '
        Me.LabelVersionSample.AutoSize = True
        Me.LabelVersionSample.Location = New System.Drawing.Point(352, 144)
        Me.LabelVersionSample.Name = "LabelVersionSample"
        Me.LabelVersionSample.Size = New System.Drawing.Size(86, 13)
        Me.LabelVersionSample.TabIndex = 15
        Me.LabelVersionSample.Text = "Ej: 1.2.3.4, or 1.*"
        '
        'NombreLicenciatario
        '
        Me.NombreLicenciatario.Location = New System.Drawing.Point(127, 194)
        Me.NombreLicenciatario.Name = "NombreLicenciatario"
        Me.NombreLicenciatario.Size = New System.Drawing.Size(313, 20)
        Me.NombreLicenciatario.TabIndex = 17
        '
        'LabelLicensee
        '
        Me.LabelLicensee.AutoSize = True
        Me.LabelLicensee.Location = New System.Drawing.Point(5, 196)
        Me.LabelLicensee.Name = "LabelLicensee"
        Me.LabelLicensee.Size = New System.Drawing.Size(110, 13)
        Me.LabelLicensee.TabIndex = 16
        Me.LabelLicensee.Text = "Nombre Licenciatario:"
        '
        'SerialDiscoDuro
        '
        Me.SerialDiscoDuro.Location = New System.Drawing.Point(127, 168)
        Me.SerialDiscoDuro.Name = "SerialDiscoDuro"
        Me.SerialDiscoDuro.Size = New System.Drawing.Size(313, 20)
        Me.SerialDiscoDuro.TabIndex = 19
        '
        'LabelSerial
        '
        Me.LabelSerial.AutoSize = True
        Me.LabelSerial.Location = New System.Drawing.Point(23, 170)
        Me.LabelSerial.Name = "LabelSerial"
        Me.LabelSerial.Size = New System.Drawing.Size(92, 13)
        Me.LabelSerial.TabIndex = 18
        Me.LabelSerial.Text = "Serial Disco Duro:"
        '
        'GenerarLicencia
        '
        Me.GenerarLicencia.Location = New System.Drawing.Point(259, 270)
        Me.GenerarLicencia.Name = "GenerarLicencia"
        Me.GenerarLicencia.Size = New System.Drawing.Size(103, 23)
        Me.GenerarLicencia.TabIndex = 20
        Me.GenerarLicencia.Text = "Generar Licencia"
        Me.GenerarLicencia.UseVisualStyleBackColor = True
        '
        'EstatusUbicacion
        '
        Me.EstatusUbicacion.AutoSize = True
        Me.EstatusUbicacion.Location = New System.Drawing.Point(80, 56)
        Me.EstatusUbicacion.Name = "EstatusUbicacion"
        Me.EstatusUbicacion.Size = New System.Drawing.Size(132, 13)
        Me.EstatusUbicacion.TabIndex = 5
        Me.EstatusUbicacion.Text = "Directorio No especificado"
        Me.EstatusUbicacion.UseMnemonic = False
        '
        'EstatusUbicacionColor
        '
        Me.EstatusUbicacionColor.BackColor = System.Drawing.Color.Red
        Me.EstatusUbicacionColor.Location = New System.Drawing.Point(64, 56)
        Me.EstatusUbicacionColor.Name = "EstatusUbicacionColor"
        Me.EstatusUbicacionColor.Size = New System.Drawing.Size(13, 13)
        Me.EstatusUbicacionColor.TabIndex = 4
        '
        'GuardarUbicacionLicencia
        '
        Me.GuardarUbicacionLicencia.FileName = "LicenciaCVCELL.lic"
        Me.GuardarUbicacionLicencia.Filter = "Archivo de Licencia |*.lic|Archivo XML|*.xml|Todos los Archivos|*.*"
        Me.GuardarUbicacionLicencia.Title = "Guardar Archivo de Licencia"
        '
        'GenerarClaves
        '
        Me.GenerarClaves.Enabled = False
        Me.GenerarClaves.Location = New System.Drawing.Point(259, 56)
        Me.GenerarClaves.Name = "GenerarClaves"
        Me.GenerarClaves.Size = New System.Drawing.Size(103, 23)
        Me.GenerarClaves.TabIndex = 21
        Me.GenerarClaves.Text = "Generar Claves"
        Me.GenerarClaves.UseVisualStyleBackColor = True
        '
        'NombreProducto
        '
        Me.NombreProducto.Location = New System.Drawing.Point(127, 116)
        Me.NombreProducto.Name = "NombreProducto"
        Me.NombreProducto.Size = New System.Drawing.Size(313, 20)
        Me.NombreProducto.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Nombre Producto:"
        '
        'BuscarDlic
        '
        Me.BuscarDlic.Location = New System.Drawing.Point(368, 270)
        Me.BuscarDlic.Name = "BuscarDlic"
        Me.BuscarDlic.Size = New System.Drawing.Size(75, 23)
        Me.BuscarDlic.TabIndex = 24
        Me.BuscarDlic.Text = "Buscar"
        Me.BuscarDlic.UseVisualStyleBackColor = True
        '
        'AbrirUbicacionDlic
        '
        Me.AbrirUbicacionDlic.FileName = "*.dlic"
        Me.AbrirUbicacionDlic.Filter = "Archivo de Licencia |*.dlic|Todos los Archivos|*.*"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 302)
        Me.Controls.Add(Me.BuscarDlic)
        Me.Controls.Add(Me.NombreProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GenerarClaves)
        Me.Controls.Add(Me.EstatusUbicacion)
        Me.Controls.Add(Me.EstatusUbicacionColor)
        Me.Controls.Add(Me.GenerarLicencia)
        Me.Controls.Add(Me.SerialDiscoDuro)
        Me.Controls.Add(Me.LabelSerial)
        Me.Controls.Add(Me.NombreLicenciatario)
        Me.Controls.Add(Me.LabelLicensee)
        Me.Controls.Add(Me.LabelVersionSample)
        Me.Controls.Add(Me.VersionCubierta)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.FechaExpiracion)
        Me.Controls.Add(Me.LabelExpiration)
        Me.Controls.Add(Me.FechaLicencia)
        Me.Controls.Add(Me.DividerLicense)
        Me.Controls.Add(Me.LabelLicenseDate)
        Me.Controls.Add(Me.LabelLicense)
        Me.Controls.Add(Me.DividerKey)
        Me.Controls.Add(Me.BuscarUbicacion)
        Me.Controls.Add(Me.UbicacionClaves)
        Me.Controls.Add(Me.LabelLocation)
        Me.Controls.Add(Me.LabelKey)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generador de Licencias CVCELL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelKey As System.Windows.Forms.Label
    Friend WithEvents LabelLocation As System.Windows.Forms.Label
    Friend WithEvents UbicacionClaves As System.Windows.Forms.TextBox
    Friend WithEvents BuscarUbicacion As System.Windows.Forms.Button
    Friend WithEvents DividerKey As System.Windows.Forms.Label
    Friend WithEvents DividerLicense As System.Windows.Forms.Label
    Friend WithEvents LabelLicenseDate As System.Windows.Forms.Label
    Friend WithEvents LabelLicense As System.Windows.Forms.Label
    Friend WithEvents FechaLicencia As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaExpiracion As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelExpiration As System.Windows.Forms.Label
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents VersionCubierta As System.Windows.Forms.TextBox
    Friend WithEvents LabelVersionSample As System.Windows.Forms.Label
    Friend WithEvents NombreLicenciatario As System.Windows.Forms.TextBox
    Friend WithEvents LabelLicensee As System.Windows.Forms.Label
    Friend WithEvents SerialDiscoDuro As System.Windows.Forms.TextBox
    Friend WithEvents LabelSerial As System.Windows.Forms.Label
    Friend WithEvents GenerarLicencia As System.Windows.Forms.Button
    Friend WithEvents EstatusUbicacion As System.Windows.Forms.Label
    Friend WithEvents EstatusUbicacionColor As System.Windows.Forms.Label
    Friend WithEvents GuardarUbicacionLicencia As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GenerarClaves As System.Windows.Forms.Button
    Friend WithEvents NombreProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BuscarDlic As System.Windows.Forms.Button
    Friend WithEvents DialogoBuscar As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents AbrirUbicacionDlic As System.Windows.Forms.OpenFileDialog

End Class
