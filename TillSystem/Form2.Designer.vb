<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.BtnPayByCash = New System.Windows.Forms.Button()
        Me.BtnPayByCard = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnTakeAway = New System.Windows.Forms.Button()
        Me.BtnEatIn = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtReturn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtGivenAmount = New System.Windows.Forms.TextBox()
        Me.BtnPayPoint = New System.Windows.Forms.Button()
        Me.BtnPay0 = New System.Windows.Forms.Button()
        Me.BtnPay3 = New System.Windows.Forms.Button()
        Me.BtnPay7 = New System.Windows.Forms.Button()
        Me.BtnPay2 = New System.Windows.Forms.Button()
        Me.BtnPay6 = New System.Windows.Forms.Button()
        Me.BtnPay5 = New System.Windows.Forms.Button()
        Me.BtnPay4 = New System.Windows.Forms.Button()
        Me.BtnPay9 = New System.Windows.Forms.Button()
        Me.BtnPay8 = New System.Windows.Forms.Button()
        Me.BtnPay1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(186, 375)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Amount "
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(274, 372)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(162, 23)
        Me.txtTotal.TabIndex = 1
        '
        'BtnPayByCash
        '
        Me.BtnPayByCash.Location = New System.Drawing.Point(169, 218)
        Me.BtnPayByCash.Name = "BtnPayByCash"
        Me.BtnPayByCash.Size = New System.Drawing.Size(111, 43)
        Me.BtnPayByCash.TabIndex = 2
        Me.BtnPayByCash.Text = "Pay By Cash "
        Me.BtnPayByCash.UseVisualStyleBackColor = True
        '
        'BtnPayByCard
        '
        Me.BtnPayByCard.Location = New System.Drawing.Point(286, 218)
        Me.BtnPayByCard.Name = "BtnPayByCard"
        Me.BtnPayByCard.Size = New System.Drawing.Size(121, 43)
        Me.BtnPayByCard.TabIndex = 3
        Me.BtnPayByCard.Text = "Pay By Card"
        Me.BtnPayByCard.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnTakeAway)
        Me.GroupBox1.Controls.Add(Me.BtnEatIn)
        Me.GroupBox1.Controls.Add(Me.BtnQuit)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.txtReturn)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtGivenAmount)
        Me.GroupBox1.Controls.Add(Me.BtnPayPoint)
        Me.GroupBox1.Controls.Add(Me.BtnPayByCard)
        Me.GroupBox1.Controls.Add(Me.BtnPay0)
        Me.GroupBox1.Controls.Add(Me.BtnPayByCash)
        Me.GroupBox1.Controls.Add(Me.BtnPay3)
        Me.GroupBox1.Controls.Add(Me.BtnPay7)
        Me.GroupBox1.Controls.Add(Me.BtnPay2)
        Me.GroupBox1.Controls.Add(Me.BtnPay6)
        Me.GroupBox1.Controls.Add(Me.BtnPay5)
        Me.GroupBox1.Controls.Add(Me.BtnPay4)
        Me.GroupBox1.Controls.Add(Me.BtnPay9)
        Me.GroupBox1.Controls.Add(Me.BtnPay8)
        Me.GroupBox1.Controls.Add(Me.BtnPay1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(424, 334)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cash Box"
        '
        'BtnTakeAway
        '
        Me.BtnTakeAway.Location = New System.Drawing.Point(205, 274)
        Me.BtnTakeAway.Name = "BtnTakeAway"
        Me.BtnTakeAway.Size = New System.Drawing.Size(140, 49)
        Me.BtnTakeAway.TabIndex = 30
        Me.BtnTakeAway.Text = "Take Away"
        Me.BtnTakeAway.UseVisualStyleBackColor = True
        '
        'BtnEatIn
        '
        Me.BtnEatIn.Location = New System.Drawing.Point(10, 274)
        Me.BtnEatIn.Name = "BtnEatIn"
        Me.BtnEatIn.Size = New System.Drawing.Size(163, 49)
        Me.BtnEatIn.TabIndex = 17
        Me.BtnEatIn.Text = "Eat In"
        Me.BtnEatIn.UseVisualStyleBackColor = True
        '
        'BtnQuit
        '
        Me.BtnQuit.Location = New System.Drawing.Point(332, 158)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(75, 40)
        Me.BtnQuit.TabIndex = 29
        Me.BtnQuit.Text = "Quit"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(249, 158)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 40)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtReturn
        '
        Me.txtReturn.Location = New System.Drawing.Point(249, 92)
        Me.txtReturn.Name = "txtReturn"
        Me.txtReturn.Size = New System.Drawing.Size(158, 23)
        Me.txtReturn.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(249, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Return"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(249, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Given Amount"
        '
        'TxtGivenAmount
        '
        Me.TxtGivenAmount.Location = New System.Drawing.Point(249, 32)
        Me.TxtGivenAmount.Name = "TxtGivenAmount"
        Me.TxtGivenAmount.Size = New System.Drawing.Size(158, 23)
        Me.TxtGivenAmount.TabIndex = 17
        '
        'BtnPayPoint
        '
        Me.BtnPayPoint.Location = New System.Drawing.Point(90, 219)
        Me.BtnPayPoint.Name = "BtnPayPoint"
        Me.BtnPayPoint.Size = New System.Drawing.Size(60, 40)
        Me.BtnPayPoint.TabIndex = 26
        Me.BtnPayPoint.Text = "."
        Me.BtnPayPoint.UseVisualStyleBackColor = True
        '
        'BtnPay0
        '
        Me.BtnPay0.Location = New System.Drawing.Point(10, 219)
        Me.BtnPay0.Name = "BtnPay0"
        Me.BtnPay0.Size = New System.Drawing.Size(60, 40)
        Me.BtnPay0.TabIndex = 25
        Me.BtnPay0.Text = "0"
        Me.BtnPay0.UseVisualStyleBackColor = True
        '
        'BtnPay3
        '
        Me.BtnPay3.Location = New System.Drawing.Point(169, 158)
        Me.BtnPay3.Name = "BtnPay3"
        Me.BtnPay3.Size = New System.Drawing.Size(60, 40)
        Me.BtnPay3.TabIndex = 24
        Me.BtnPay3.Text = "3"
        Me.BtnPay3.UseVisualStyleBackColor = True
        '
        'BtnPay7
        '
        Me.BtnPay7.Location = New System.Drawing.Point(10, 22)
        Me.BtnPay7.Name = "BtnPay7"
        Me.BtnPay7.Size = New System.Drawing.Size(60, 40)
        Me.BtnPay7.TabIndex = 23
        Me.BtnPay7.Text = "7"
        Me.BtnPay7.UseVisualStyleBackColor = True
        '
        'BtnPay2
        '
        Me.BtnPay2.Location = New System.Drawing.Point(90, 158)
        Me.BtnPay2.Name = "BtnPay2"
        Me.BtnPay2.Size = New System.Drawing.Size(60, 40)
        Me.BtnPay2.TabIndex = 22
        Me.BtnPay2.Text = "2"
        Me.BtnPay2.UseVisualStyleBackColor = True
        '
        'BtnPay6
        '
        Me.BtnPay6.Location = New System.Drawing.Point(169, 91)
        Me.BtnPay6.Name = "BtnPay6"
        Me.BtnPay6.Size = New System.Drawing.Size(60, 40)
        Me.BtnPay6.TabIndex = 21
        Me.BtnPay6.Text = "6"
        Me.BtnPay6.UseVisualStyleBackColor = True
        '
        'BtnPay5
        '
        Me.BtnPay5.Location = New System.Drawing.Point(90, 91)
        Me.BtnPay5.Name = "BtnPay5"
        Me.BtnPay5.Size = New System.Drawing.Size(60, 40)
        Me.BtnPay5.TabIndex = 20
        Me.BtnPay5.Text = "5"
        Me.BtnPay5.UseVisualStyleBackColor = True
        '
        'BtnPay4
        '
        Me.BtnPay4.Location = New System.Drawing.Point(10, 91)
        Me.BtnPay4.Name = "BtnPay4"
        Me.BtnPay4.Size = New System.Drawing.Size(60, 40)
        Me.BtnPay4.TabIndex = 19
        Me.BtnPay4.Text = "4"
        Me.BtnPay4.UseVisualStyleBackColor = True
        '
        'BtnPay9
        '
        Me.BtnPay9.Location = New System.Drawing.Point(169, 22)
        Me.BtnPay9.Name = "BtnPay9"
        Me.BtnPay9.Size = New System.Drawing.Size(60, 40)
        Me.BtnPay9.TabIndex = 18
        Me.BtnPay9.Text = "9"
        Me.BtnPay9.UseVisualStyleBackColor = True
        '
        'BtnPay8
        '
        Me.BtnPay8.Location = New System.Drawing.Point(90, 22)
        Me.BtnPay8.Name = "BtnPay8"
        Me.BtnPay8.Size = New System.Drawing.Size(60, 40)
        Me.BtnPay8.TabIndex = 17
        Me.BtnPay8.Text = "8"
        Me.BtnPay8.UseVisualStyleBackColor = True
        '
        'BtnPay1
        '
        Me.BtnPay1.Location = New System.Drawing.Point(9, 158)
        Me.BtnPay1.Name = "BtnPay1"
        Me.BtnPay1.Size = New System.Drawing.Size(60, 40)
        Me.BtnPay1.TabIndex = 16
        Me.BtnPay1.Text = "1"
        Me.BtnPay1.UseVisualStyleBackColor = True
        '
        'PaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 437)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PaymentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Take Payment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents BtnPayByCash As Button
    Friend WithEvents BtnPayByCard As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnPayPoint As Button
    Friend WithEvents BtnPay0 As Button
    Friend WithEvents BtnPay3 As Button
    Friend WithEvents BtnPay7 As Button
    Friend WithEvents BtnPay2 As Button
    Friend WithEvents BtnPay6 As Button
    Friend WithEvents BtnPay5 As Button
    Friend WithEvents BtnPay4 As Button
    Friend WithEvents BtnPay9 As Button
    Friend WithEvents BtnPay8 As Button
    Friend WithEvents BtnPay1 As Button
    Friend WithEvents TxtGivenAmount As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnTakeAway As Button
    Friend WithEvents BtnEatIn As Button
    Friend WithEvents BtnQuit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtReturn As TextBox
    Friend WithEvents Label3 As Label
End Class
