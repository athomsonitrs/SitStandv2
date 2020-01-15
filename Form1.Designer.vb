Imports System.Configuration

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
        Dim minutesPerHour As Integer = ConfigurationManager.AppSettings("minutesPerHour")
        Dim sitHeight As Integer = ConfigurationManager.AppSettings("sitHeight")
        Dim standHeight As Integer = ConfigurationManager.AppSettings("standHeight")

        Me.CurrentConfig = New System.Windows.Forms.Label()
        Me.AppTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CurrentConfig
        '
        Me.CurrentConfig.AutoSize = True
        Me.CurrentConfig.Location = New System.Drawing.Point(151, 161)
        Me.CurrentConfig.Name = "CurrentConfig"
        Me.CurrentConfig.Size = New System.Drawing.Size(165, 80)
        Me.CurrentConfig.TabIndex = 0
        Me.CurrentConfig.Text = "Current Configuration:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & minutesPerHour & " minutes per hour" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & sitHeight & " Sit Height" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & standHeight & " Stand Height" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'AppTitle
        '
        Me.AppTitle.AutoSize = True
        Me.AppTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppTitle.Location = New System.Drawing.Point(104, 18)
        Me.AppTitle.Name = "AppTitle"
        Me.AppTitle.Size = New System.Drawing.Size(555, 52)
        Me.AppTitle.TabIndex = 1
        Me.AppTitle.Text = "Welcome to SitStand (ajmt)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AppTitle)
        Me.Controls.Add(Me.CurrentConfig)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CurrentConfig As Label
    Friend WithEvents AppTitle As Label
End Class
