﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.pnl2 = New System.Windows.Forms.Panel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.rctEntrar = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rctPass = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rctUtl = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblEntrar = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.pctPass = New System.Windows.Forms.PictureBox()
        Me.pctUtl = New System.Windows.Forms.PictureBox()
        Me.lblErroUtl = New System.Windows.Forms.Label()
        Me.lblErroPass = New System.Windows.Forms.Label()
        Me.pnl1.SuspendLayout()
        CType(Me.pctPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctUtl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnl1.Controls.Add(Me.lbl1)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl1.Location = New System.Drawing.Point(0, 0)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(295, 78)
        Me.pnl1.TabIndex = 0
        '
        'lbl1
        '
        Me.lbl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl1.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(0, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(295, 74)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Iniciar Sessão"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl2
        '
        Me.pnl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl2.Location = New System.Drawing.Point(0, 343)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(295, 26)
        Me.pnl2.TabIndex = 1
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.rctEntrar, Me.rctPass, Me.rctUtl})
        Me.ShapeContainer1.Size = New System.Drawing.Size(295, 369)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'rctEntrar
        '
        Me.rctEntrar.BackColor = System.Drawing.Color.Yellow
        Me.rctEntrar.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctEntrar.BorderColor = System.Drawing.Color.Yellow
        Me.rctEntrar.CornerRadius = 5
        Me.rctEntrar.Location = New System.Drawing.Point(21, 276)
        Me.rctEntrar.Name = "rctEntrar"
        Me.rctEntrar.Size = New System.Drawing.Size(249, 36)
        '
        'rctPass
        '
        Me.rctPass.BackColor = System.Drawing.Color.White
        Me.rctPass.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctPass.BorderColor = System.Drawing.Color.White
        Me.rctPass.CornerRadius = 3
        Me.rctPass.Location = New System.Drawing.Point(22, 206)
        Me.rctPass.Name = "rctPass"
        Me.rctPass.Size = New System.Drawing.Size(249, 36)
        '
        'rctUtl
        '
        Me.rctUtl.BackColor = System.Drawing.Color.White
        Me.rctUtl.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctUtl.BorderColor = System.Drawing.Color.White
        Me.rctUtl.CornerRadius = 3
        Me.rctUtl.Location = New System.Drawing.Point(22, 120)
        Me.rctUtl.Name = "rctUtl"
        Me.rctUtl.Size = New System.Drawing.Size(249, 36)
        '
        'txtNome
        '
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNome.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.ForeColor = System.Drawing.Color.Black
        Me.txtNome.Location = New System.Drawing.Point(64, 128)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(198, 22)
        Me.txtNome.TabIndex = 3
        Me.txtNome.Tag = ""
        '
        'txtPass
        '
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.Black
        Me.txtPass.Location = New System.Drawing.Point(64, 214)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPass.Size = New System.Drawing.Size(197, 22)
        Me.txtPass.TabIndex = 4
        '
        'lblEntrar
        '
        Me.lblEntrar.BackColor = System.Drawing.Color.Yellow
        Me.lblEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblEntrar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntrar.ForeColor = System.Drawing.Color.Black
        Me.lblEntrar.Location = New System.Drawing.Point(24, 282)
        Me.lblEntrar.Name = "lblEntrar"
        Me.lblEntrar.Size = New System.Drawing.Size(246, 26)
        Me.lblEntrar.TabIndex = 7
        Me.lblEntrar.Text = "Entrar"
        Me.lblEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(20, 99)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(133, 16)
        Me.lbl2.TabIndex = 8
        Me.lbl2.Text = "Nome de utilizador:"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.White
        Me.lbl5.Location = New System.Drawing.Point(20, 185)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(101, 16)
        Me.lbl5.TabIndex = 9
        Me.lbl5.Text = "Palavra-passe:"
        '
        'pctPass
        '
        Me.pctPass.BackColor = System.Drawing.Color.White
        Me.pctPass.BackgroundImage = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.locked_1
        Me.pctPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctPass.Location = New System.Drawing.Point(25, 209)
        Me.pctPass.Name = "pctPass"
        Me.pctPass.Size = New System.Drawing.Size(34, 32)
        Me.pctPass.TabIndex = 11
        Me.pctPass.TabStop = False
        '
        'pctUtl
        '
        Me.pctUtl.BackColor = System.Drawing.Color.White
        Me.pctUtl.BackgroundImage = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.user1
        Me.pctUtl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctUtl.Location = New System.Drawing.Point(24, 123)
        Me.pctUtl.Name = "pctUtl"
        Me.pctUtl.Size = New System.Drawing.Size(34, 32)
        Me.pctUtl.TabIndex = 10
        Me.pctUtl.TabStop = False
        '
        'lblErroUtl
        '
        Me.lblErroUtl.AutoSize = True
        Me.lblErroUtl.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErroUtl.ForeColor = System.Drawing.Color.Salmon
        Me.lblErroUtl.Location = New System.Drawing.Point(20, 158)
        Me.lblErroUtl.Name = "lblErroUtl"
        Me.lblErroUtl.Size = New System.Drawing.Size(0, 15)
        Me.lblErroUtl.TabIndex = 12
        '
        'lblErroPass
        '
        Me.lblErroPass.AutoSize = True
        Me.lblErroPass.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErroPass.ForeColor = System.Drawing.Color.Salmon
        Me.lblErroPass.Location = New System.Drawing.Point(18, 244)
        Me.lblErroPass.Name = "lblErroPass"
        Me.lblErroPass.Size = New System.Drawing.Size(0, 15)
        Me.lblErroPass.TabIndex = 13
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(295, 369)
        Me.Controls.Add(Me.lblErroPass)
        Me.Controls.Add(Me.lblErroUtl)
        Me.Controls.Add(Me.pctPass)
        Me.Controls.Add(Me.pctUtl)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lblEntrar)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.pnl2)
        Me.Controls.Add(Me.pnl1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnl1.ResumeLayout(False)
        CType(Me.pctPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctUtl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents pnl2 As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents rctPass As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rctUtl As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents rctEntrar As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblEntrar As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents pctUtl As System.Windows.Forms.PictureBox
    Friend WithEvents pctPass As System.Windows.Forms.PictureBox
    Friend WithEvents lblErroUtl As System.Windows.Forms.Label
    Friend WithEvents lblErroPass As System.Windows.Forms.Label

End Class
