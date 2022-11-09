<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.num1 = New System.Windows.Forms.Label()
        Me.num2 = New System.Windows.Forms.Label()
        Me.num3 = New System.Windows.Forms.Label()
        Me.btnjogar = New System.Windows.Forms.Button()
        Me.btnsair = New System.Windows.Forms.Button()
        Me.imagemresultado = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.imagemresultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(278, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jogo Sete Da Sorte"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.num1)
        Me.Panel1.Location = New System.Drawing.Point(172, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(100, 100)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.num2)
        Me.Panel2.Location = New System.Drawing.Point(343, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(100, 100)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.num3)
        Me.Panel3.Location = New System.Drawing.Point(511, 80)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(100, 100)
        Me.Panel3.TabIndex = 3
        '
        'num1
        '
        Me.num1.AutoSize = True
        Me.num1.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num1.Location = New System.Drawing.Point(25, 24)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(46, 54)
        Me.num1.TabIndex = 0
        Me.num1.Text = "0"
        '
        'num2
        '
        Me.num2.AutoSize = True
        Me.num2.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num2.Location = New System.Drawing.Point(26, 24)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(46, 54)
        Me.num2.TabIndex = 0
        Me.num2.Text = "0"
        '
        'num3
        '
        Me.num3.AutoSize = True
        Me.num3.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num3.Location = New System.Drawing.Point(25, 24)
        Me.num3.Name = "num3"
        Me.num3.Size = New System.Drawing.Size(46, 54)
        Me.num3.TabIndex = 0
        Me.num3.Text = "0"
        '
        'btnjogar
        '
        Me.btnjogar.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnjogar.ForeColor = System.Drawing.Color.Teal
        Me.btnjogar.Location = New System.Drawing.Point(24, 329)
        Me.btnjogar.Name = "btnjogar"
        Me.btnjogar.Size = New System.Drawing.Size(141, 46)
        Me.btnjogar.TabIndex = 4
        Me.btnjogar.Text = "Jogar"
        Me.btnjogar.UseVisualStyleBackColor = True
        '
        'btnsair
        '
        Me.btnsair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsair.Location = New System.Drawing.Point(675, 408)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(104, 30)
        Me.btnsair.TabIndex = 5
        Me.btnsair.Text = "Sair"
        Me.btnsair.UseVisualStyleBackColor = True
        '
        'imagemresultado
        '
        Me.imagemresultado.Location = New System.Drawing.Point(232, 234)
        Me.imagemresultado.Name = "imagemresultado"
        Me.imagemresultado.Size = New System.Drawing.Size(329, 141)
        Me.imagemresultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagemresultado.TabIndex = 6
        Me.imagemresultado.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.imagemresultado)
        Me.Controls.Add(Me.btnsair)
        Me.Controls.Add(Me.btnjogar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Jogo Sete da Sorte"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.imagemresultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents num1 As Label
    Friend WithEvents num2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents num3 As Label
    Friend WithEvents btnjogar As Button
    Friend WithEvents btnsair As Button
    Friend WithEvents imagemresultado As PictureBox
End Class
