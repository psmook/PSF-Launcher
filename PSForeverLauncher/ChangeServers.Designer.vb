<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeServers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangeServers))
        Me.Save = New System.Windows.Forms.Button
        Me.Cancel = New System.Windows.Forms.Button
        Me.ManifestLabel = New System.Windows.Forms.Label
        Me.ManifestFile = New System.Windows.Forms.TextBox
        Me.ManifestDesc = New System.Windows.Forms.TextBox
        Me.Reset = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(136, 98)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 23)
        Me.Save.TabIndex = 0
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(217, 98)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 1
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'ManifestLabel
        '
        Me.ManifestLabel.AutoSize = True
        Me.ManifestLabel.Location = New System.Drawing.Point(13, 13)
        Me.ManifestLabel.Name = "ManifestLabel"
        Me.ManifestLabel.Size = New System.Drawing.Size(66, 13)
        Me.ManifestLabel.TabIndex = 2
        Me.ManifestLabel.Text = "Manifest File"
        '
        'ManifestFile
        '
        Me.ManifestFile.Location = New System.Drawing.Point(16, 33)
        Me.ManifestFile.Name = "ManifestFile"
        Me.ManifestFile.Size = New System.Drawing.Size(276, 20)
        Me.ManifestFile.TabIndex = 3
        '
        'ManifestDesc
        '
        Me.ManifestDesc.BackColor = System.Drawing.SystemColors.Control
        Me.ManifestDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ManifestDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ManifestDesc.Location = New System.Drawing.Point(16, 59)
        Me.ManifestDesc.Multiline = True
        Me.ManifestDesc.Name = "ManifestDesc"
        Me.ManifestDesc.Size = New System.Drawing.Size(276, 33)
        Me.ManifestDesc.TabIndex = 4
        Me.ManifestDesc.Text = "The manifest file provides this launcher all of the information it needs to conne" & _
            "ct you to the custom server."
        '
        'Reset
        '
        Me.Reset.Location = New System.Drawing.Point(16, 97)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(75, 23)
        Me.Reset.TabIndex = 5
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'ChangeServers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(304, 132)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.ManifestDesc)
        Me.Controls.Add(Me.ManifestFile)
        Me.Controls.Add(Me.ManifestLabel)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Save)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangeServers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose Server"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents ManifestLabel As System.Windows.Forms.Label
    Friend WithEvents ManifestFile As System.Windows.Forms.TextBox
    Friend WithEvents ManifestDesc As System.Windows.Forms.TextBox
    Friend WithEvents Reset As System.Windows.Forms.Button
End Class
