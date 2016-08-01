<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Launcher
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Launcher))
        Me.PNLabel = New System.Windows.Forms.Label
        Me.PatchNotes = New System.Windows.Forms.TextBox
        Me.FileCheckProgress = New System.Windows.Forms.ProgressBar
        Me.PlayButton = New System.Windows.Forms.Button
        Me.RefreshServerButton = New System.Windows.Forms.Button
        Me.ChangeServerButton = New System.Windows.Forms.Button
        Me.UpdateClientButton = New System.Windows.Forms.Button
        Me.AccountButton = New System.Windows.Forms.Button
        Me.PSForeverLauncherNotification = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.CVLabel = New System.Windows.Forms.Label
        Me.SVLabel = New System.Windows.Forms.Label
        Me.CSLabel = New System.Windows.Forms.Label
        Me.ConnectedServerLabel = New System.Windows.Forms.Label
        Me.ClientVersionLabel = New System.Windows.Forms.Label
        Me.ServerVersionLabel = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Logo = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNLabel
        '
        Me.PNLabel.AutoSize = True
        Me.PNLabel.Location = New System.Drawing.Point(8, 10)
        Me.PNLabel.Name = "PNLabel"
        Me.PNLabel.Size = New System.Drawing.Size(69, 13)
        Me.PNLabel.TabIndex = 0
        Me.PNLabel.Text = "Patch Notes:"
        '
        'PatchNotes
        '
        Me.PatchNotes.BackColor = System.Drawing.SystemColors.Window
        Me.PatchNotes.CausesValidation = False
        Me.PatchNotes.Cursor = System.Windows.Forms.Cursors.No
        Me.PatchNotes.Location = New System.Drawing.Point(10, 28)
        Me.PatchNotes.Multiline = True
        Me.PatchNotes.Name = "PatchNotes"
        Me.PatchNotes.ReadOnly = True
        Me.PatchNotes.Size = New System.Drawing.Size(320, 404)
        Me.PatchNotes.TabIndex = 1
        '
        'FileCheckProgress
        '
        Me.FileCheckProgress.Location = New System.Drawing.Point(340, 206)
        Me.FileCheckProgress.Name = "FileCheckProgress"
        Me.FileCheckProgress.Size = New System.Drawing.Size(275, 25)
        Me.FileCheckProgress.TabIndex = 2
        '
        'PlayButton
        '
        Me.PlayButton.Enabled = False
        Me.PlayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!)
        Me.PlayButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PlayButton.Location = New System.Drawing.Point(340, 237)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(275, 70)
        Me.PlayButton.TabIndex = 3
        Me.PlayButton.Text = "Play"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'RefreshServerButton
        '
        Me.RefreshServerButton.Location = New System.Drawing.Point(340, 367)
        Me.RefreshServerButton.Name = "RefreshServerButton"
        Me.RefreshServerButton.Size = New System.Drawing.Size(135, 25)
        Me.RefreshServerButton.TabIndex = 4
        Me.RefreshServerButton.Text = "Refresh Connection"
        Me.RefreshServerButton.UseVisualStyleBackColor = True
        '
        'ChangeServerButton
        '
        Me.ChangeServerButton.Location = New System.Drawing.Point(480, 367)
        Me.ChangeServerButton.Name = "ChangeServerButton"
        Me.ChangeServerButton.Size = New System.Drawing.Size(135, 25)
        Me.ChangeServerButton.TabIndex = 7
        Me.ChangeServerButton.Text = "Change Servers"
        Me.ChangeServerButton.UseVisualStyleBackColor = True
        '
        'UpdateClientButton
        '
        Me.UpdateClientButton.Enabled = False
        Me.UpdateClientButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.UpdateClientButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UpdateClientButton.Location = New System.Drawing.Point(340, 312)
        Me.UpdateClientButton.Name = "UpdateClientButton"
        Me.UpdateClientButton.Size = New System.Drawing.Size(275, 50)
        Me.UpdateClientButton.TabIndex = 8
        Me.UpdateClientButton.Text = "Update Client"
        Me.UpdateClientButton.UseVisualStyleBackColor = True
        '
        'AccountButton
        '
        Me.AccountButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.AccountButton.Location = New System.Drawing.Point(340, 397)
        Me.AccountButton.Name = "AccountButton"
        Me.AccountButton.Size = New System.Drawing.Size(275, 35)
        Me.AccountButton.TabIndex = 9
        Me.AccountButton.Text = "My Account"
        Me.AccountButton.UseVisualStyleBackColor = True
        '
        'PSForeverLauncherNotification
        '
        Me.PSForeverLauncherNotification.Visible = True
        '
        'CVLabel
        '
        Me.CVLabel.AutoSize = True
        Me.CVLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CVLabel.Location = New System.Drawing.Point(3, 23)
        Me.CVLabel.Name = "CVLabel"
        Me.CVLabel.Size = New System.Drawing.Size(74, 13)
        Me.CVLabel.TabIndex = 10
        Me.CVLabel.Text = "Client Version:"
        '
        'SVLabel
        '
        Me.SVLabel.AutoSize = True
        Me.SVLabel.Location = New System.Drawing.Point(137, 23)
        Me.SVLabel.Name = "SVLabel"
        Me.SVLabel.Size = New System.Drawing.Size(79, 13)
        Me.SVLabel.TabIndex = 11
        Me.SVLabel.Text = "Server Version:"
        '
        'CSLabel
        '
        Me.CSLabel.AutoSize = True
        Me.CSLabel.Location = New System.Drawing.Point(3, 4)
        Me.CSLabel.Name = "CSLabel"
        Me.CSLabel.Size = New System.Drawing.Size(108, 13)
        Me.CSLabel.TabIndex = 12
        Me.CSLabel.Text = "Connected to Server:"
        '
        'ConnectedServerLabel
        '
        Me.ConnectedServerLabel.AutoSize = True
        Me.ConnectedServerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConnectedServerLabel.Location = New System.Drawing.Point(117, 4)
        Me.ConnectedServerLabel.Name = "ConnectedServerLabel"
        Me.ConnectedServerLabel.Size = New System.Drawing.Size(37, 13)
        Me.ConnectedServerLabel.TabIndex = 13
        Me.ConnectedServerLabel.Text = "None"
        '
        'ClientVersionLabel
        '
        Me.ClientVersionLabel.AutoSize = True
        Me.ClientVersionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientVersionLabel.Location = New System.Drawing.Point(83, 23)
        Me.ClientVersionLabel.Name = "ClientVersionLabel"
        Me.ClientVersionLabel.Size = New System.Drawing.Size(47, 13)
        Me.ClientVersionLabel.TabIndex = 14
        Me.ClientVersionLabel.Text = "1.0.0.0"
        '
        'ServerVersionLabel
        '
        Me.ServerVersionLabel.AutoSize = True
        Me.ServerVersionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServerVersionLabel.Location = New System.Drawing.Point(222, 23)
        Me.ServerVersionLabel.Name = "ServerVersionLabel"
        Me.ServerVersionLabel.Size = New System.Drawing.Size(47, 13)
        Me.ServerVersionLabel.TabIndex = 15
        Me.ServerVersionLabel.Text = "1.0.0.0"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.Controls.Add(Me.CSLabel)
        Me.Panel1.Controls.Add(Me.ServerVersionLabel)
        Me.Panel1.Controls.Add(Me.ConnectedServerLabel)
        Me.Panel1.Controls.Add(Me.SVLabel)
        Me.Panel1.Controls.Add(Me.ClientVersionLabel)
        Me.Panel1.Controls.Add(Me.CVLabel)
        Me.Panel1.Location = New System.Drawing.Point(340, 160)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(275, 40)
        Me.Panel1.TabIndex = 16
        '
        'Logo
        '
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.InitialImage = CType(resources.GetObject("Logo.InitialImage"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(340, 28)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(275, 125)
        Me.Logo.TabIndex = 17
        Me.Logo.TabStop = False
        '
        'Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AccountButton)
        Me.Controls.Add(Me.UpdateClientButton)
        Me.Controls.Add(Me.ChangeServerButton)
        Me.Controls.Add(Me.RefreshServerButton)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.FileCheckProgress)
        Me.Controls.Add(Me.PatchNotes)
        Me.Controls.Add(Me.PNLabel)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Launcher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to PSForever!"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PNLabel As System.Windows.Forms.Label
    Friend WithEvents PatchNotes As System.Windows.Forms.TextBox
    Friend WithEvents FileCheckProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents PlayButton As System.Windows.Forms.Button
    Friend WithEvents RefreshServerButton As System.Windows.Forms.Button
    Friend WithEvents ChangeServerButton As System.Windows.Forms.Button
    Friend WithEvents UpdateClientButton As System.Windows.Forms.Button
    Friend WithEvents AccountButton As System.Windows.Forms.Button
    Friend WithEvents PSForeverLauncherNotification As System.Windows.Forms.NotifyIcon
    Friend WithEvents CVLabel As System.Windows.Forms.Label
    Friend WithEvents SVLabel As System.Windows.Forms.Label
    Friend WithEvents CSLabel As System.Windows.Forms.Label
    Friend WithEvents ConnectedServerLabel As System.Windows.Forms.Label
    Friend WithEvents ClientVersionLabel As System.Windows.Forms.Label
    Friend WithEvents ServerVersionLabel As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Logo As System.Windows.Forms.PictureBox

End Class
