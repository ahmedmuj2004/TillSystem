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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnPay = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.GrpFood = New System.Windows.Forms.GroupBox()
        Me.BtnVeggieWrap = New System.Windows.Forms.Button()
        Me.BtnChickenWrap = New System.Windows.Forms.Button()
        Me.BtnBeefBurger = New System.Windows.Forms.Button()
        Me.BtnChickenBurger = New System.Windows.Forms.Button()
        Me.BtnVeggiePizza = New System.Windows.Forms.Button()
        Me.BtnPepperoniPizza = New System.Windows.Forms.Button()
        Me.GrpDrinks = New System.Windows.Forms.GroupBox()
        Me.BtnJuice = New System.Windows.Forms.Button()
        Me.BtnWater = New System.Windows.Forms.Button()
        Me.BtnCoffee = New System.Windows.Forms.Button()
        Me.BtnChai = New System.Windows.Forms.Button()
        Me.BtnFanta = New System.Windows.Forms.Button()
        Me.BtnPepsi = New System.Windows.Forms.Button()
        Me.GrpDesserts = New System.Windows.Forms.GroupBox()
        Me.BtnMixfruitCustard = New System.Windows.Forms.Button()
        Me.BtnMangoCustard = New System.Windows.Forms.Button()
        Me.BtnVanillaIcecream = New System.Windows.Forms.Button()
        Me.BtnChoclateIcecream = New System.Windows.Forms.Button()
        Me.BtnButterCake = New System.Windows.Forms.Button()
        Me.BtnLavaCake = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpFood.SuspendLayout()
        Me.GrpDrinks.SuspendLayout()
        Me.GrpDesserts.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colName, Me.colQty, Me.colPrice})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(303, 376)
        Me.DataGridView1.TabIndex = 0
        '
        'colName
        '
        Me.colName.HeaderText = "Name"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        '
        'colQty
        '
        Me.colQty.HeaderText = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.ReadOnly = True
        '
        'colPrice
        '
        Me.colPrice.HeaderText = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.ReadOnly = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(12, 422)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(93, 23)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnPay
        '
        Me.BtnPay.Location = New System.Drawing.Point(123, 422)
        Me.BtnPay.Name = "BtnPay"
        Me.BtnPay.Size = New System.Drawing.Size(108, 23)
        Me.BtnPay.TabIndex = 2
        Me.BtnPay.Text = "Pay"
        Me.BtnPay.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 396)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total "
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(215, 393)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 23)
        Me.txtTotal.TabIndex = 4
        '
        'GrpFood
        '
        Me.GrpFood.Controls.Add(Me.BtnVeggieWrap)
        Me.GrpFood.Controls.Add(Me.BtnChickenWrap)
        Me.GrpFood.Controls.Add(Me.BtnBeefBurger)
        Me.GrpFood.Controls.Add(Me.BtnChickenBurger)
        Me.GrpFood.Controls.Add(Me.BtnVeggiePizza)
        Me.GrpFood.Controls.Add(Me.BtnPepperoniPizza)
        Me.GrpFood.Location = New System.Drawing.Point(361, 12)
        Me.GrpFood.Name = "GrpFood"
        Me.GrpFood.Size = New System.Drawing.Size(393, 141)
        Me.GrpFood.TabIndex = 5
        Me.GrpFood.TabStop = False
        Me.GrpFood.Text = "Food"
        '
        'BtnVeggieWrap
        '
        Me.BtnVeggieWrap.Location = New System.Drawing.Point(261, 78)
        Me.BtnVeggieWrap.Name = "BtnVeggieWrap"
        Me.BtnVeggieWrap.Size = New System.Drawing.Size(75, 50)
        Me.BtnVeggieWrap.TabIndex = 16
        Me.BtnVeggieWrap.Text = "Veggie Wrap"
        Me.BtnVeggieWrap.UseVisualStyleBackColor = True
        '
        'BtnChickenWrap
        '
        Me.BtnChickenWrap.Location = New System.Drawing.Point(261, 22)
        Me.BtnChickenWrap.Name = "BtnChickenWrap"
        Me.BtnChickenWrap.Size = New System.Drawing.Size(75, 50)
        Me.BtnChickenWrap.TabIndex = 15
        Me.BtnChickenWrap.Text = "Chicken Wrap"
        Me.BtnChickenWrap.UseVisualStyleBackColor = True
        '
        'BtnBeefBurger
        '
        Me.BtnBeefBurger.Location = New System.Drawing.Point(133, 78)
        Me.BtnBeefBurger.Name = "BtnBeefBurger"
        Me.BtnBeefBurger.Size = New System.Drawing.Size(75, 50)
        Me.BtnBeefBurger.TabIndex = 14
        Me.BtnBeefBurger.Text = "Beef Burger"
        Me.BtnBeefBurger.UseVisualStyleBackColor = True
        '
        'BtnChickenBurger
        '
        Me.BtnChickenBurger.Location = New System.Drawing.Point(133, 22)
        Me.BtnChickenBurger.Name = "BtnChickenBurger"
        Me.BtnChickenBurger.Size = New System.Drawing.Size(75, 50)
        Me.BtnChickenBurger.TabIndex = 8
        Me.BtnChickenBurger.Text = "Chicken Burger"
        Me.BtnChickenBurger.UseVisualStyleBackColor = True
        '
        'BtnVeggiePizza
        '
        Me.BtnVeggiePizza.Location = New System.Drawing.Point(6, 78)
        Me.BtnVeggiePizza.Name = "BtnVeggiePizza"
        Me.BtnVeggiePizza.Size = New System.Drawing.Size(75, 50)
        Me.BtnVeggiePizza.TabIndex = 13
        Me.BtnVeggiePizza.Text = "Veggie Pizza"
        Me.BtnVeggiePizza.UseVisualStyleBackColor = True
        '
        'BtnPepperoniPizza
        '
        Me.BtnPepperoniPizza.Location = New System.Drawing.Point(6, 22)
        Me.BtnPepperoniPizza.Name = "BtnPepperoniPizza"
        Me.BtnPepperoniPizza.Size = New System.Drawing.Size(75, 50)
        Me.BtnPepperoniPizza.TabIndex = 0
        Me.BtnPepperoniPizza.Text = "Pepperoni Pizza"
        Me.BtnPepperoniPizza.UseVisualStyleBackColor = True
        '
        'GrpDrinks
        '
        Me.GrpDrinks.Controls.Add(Me.BtnJuice)
        Me.GrpDrinks.Controls.Add(Me.BtnWater)
        Me.GrpDrinks.Controls.Add(Me.BtnCoffee)
        Me.GrpDrinks.Controls.Add(Me.BtnChai)
        Me.GrpDrinks.Controls.Add(Me.BtnFanta)
        Me.GrpDrinks.Controls.Add(Me.BtnPepsi)
        Me.GrpDrinks.Location = New System.Drawing.Point(361, 159)
        Me.GrpDrinks.Name = "GrpDrinks"
        Me.GrpDrinks.Size = New System.Drawing.Size(393, 133)
        Me.GrpDrinks.TabIndex = 6
        Me.GrpDrinks.TabStop = False
        Me.GrpDrinks.Text = "Drinks"
        '
        'BtnJuice
        '
        Me.BtnJuice.Location = New System.Drawing.Point(261, 76)
        Me.BtnJuice.Name = "BtnJuice"
        Me.BtnJuice.Size = New System.Drawing.Size(75, 50)
        Me.BtnJuice.TabIndex = 19
        Me.BtnJuice.Text = "Juice"
        Me.BtnJuice.UseVisualStyleBackColor = True
        '
        'BtnWater
        '
        Me.BtnWater.Location = New System.Drawing.Point(261, 22)
        Me.BtnWater.Name = "BtnWater"
        Me.BtnWater.Size = New System.Drawing.Size(75, 50)
        Me.BtnWater.TabIndex = 18
        Me.BtnWater.Text = "Water"
        Me.BtnWater.UseVisualStyleBackColor = True
        '
        'BtnCoffee
        '
        Me.BtnCoffee.Location = New System.Drawing.Point(133, 77)
        Me.BtnCoffee.Name = "BtnCoffee"
        Me.BtnCoffee.Size = New System.Drawing.Size(75, 50)
        Me.BtnCoffee.TabIndex = 17
        Me.BtnCoffee.Text = "Coffee"
        Me.BtnCoffee.UseVisualStyleBackColor = True
        '
        'BtnChai
        '
        Me.BtnChai.Location = New System.Drawing.Point(133, 22)
        Me.BtnChai.Name = "BtnChai"
        Me.BtnChai.Size = New System.Drawing.Size(75, 50)
        Me.BtnChai.TabIndex = 16
        Me.BtnChai.Text = "Chai"
        Me.BtnChai.UseVisualStyleBackColor = True
        '
        'BtnFanta
        '
        Me.BtnFanta.Location = New System.Drawing.Point(6, 75)
        Me.BtnFanta.Name = "BtnFanta"
        Me.BtnFanta.Size = New System.Drawing.Size(75, 50)
        Me.BtnFanta.TabIndex = 15
        Me.BtnFanta.Text = "Fanta"
        Me.BtnFanta.UseVisualStyleBackColor = True
        '
        'BtnPepsi
        '
        Me.BtnPepsi.Location = New System.Drawing.Point(6, 22)
        Me.BtnPepsi.Name = "BtnPepsi"
        Me.BtnPepsi.Size = New System.Drawing.Size(75, 50)
        Me.BtnPepsi.TabIndex = 14
        Me.BtnPepsi.Text = "Pepsi"
        Me.BtnPepsi.UseVisualStyleBackColor = True
        '
        'GrpDesserts
        '
        Me.GrpDesserts.Controls.Add(Me.BtnMixfruitCustard)
        Me.GrpDesserts.Controls.Add(Me.BtnMangoCustard)
        Me.GrpDesserts.Controls.Add(Me.BtnVanillaIcecream)
        Me.GrpDesserts.Controls.Add(Me.BtnChoclateIcecream)
        Me.GrpDesserts.Controls.Add(Me.BtnButterCake)
        Me.GrpDesserts.Controls.Add(Me.BtnLavaCake)
        Me.GrpDesserts.Location = New System.Drawing.Point(361, 310)
        Me.GrpDesserts.Name = "GrpDesserts"
        Me.GrpDesserts.Size = New System.Drawing.Size(393, 135)
        Me.GrpDesserts.TabIndex = 7
        Me.GrpDesserts.TabStop = False
        Me.GrpDesserts.Text = "Desserts"
        '
        'BtnMixfruitCustard
        '
        Me.BtnMixfruitCustard.Location = New System.Drawing.Point(261, 78)
        Me.BtnMixfruitCustard.Name = "BtnMixfruitCustard"
        Me.BtnMixfruitCustard.Size = New System.Drawing.Size(75, 50)
        Me.BtnMixfruitCustard.TabIndex = 6
        Me.BtnMixfruitCustard.Text = "FixFruit Custard"
        Me.BtnMixfruitCustard.UseVisualStyleBackColor = True
        '
        'BtnMangoCustard
        '
        Me.BtnMangoCustard.Location = New System.Drawing.Point(261, 22)
        Me.BtnMangoCustard.Name = "BtnMangoCustard"
        Me.BtnMangoCustard.Size = New System.Drawing.Size(75, 50)
        Me.BtnMangoCustard.TabIndex = 5
        Me.BtnMangoCustard.Text = "Mango Custard"
        Me.BtnMangoCustard.UseVisualStyleBackColor = True
        '
        'BtnVanillaIcecream
        '
        Me.BtnVanillaIcecream.Location = New System.Drawing.Point(133, 79)
        Me.BtnVanillaIcecream.Name = "BtnVanillaIcecream"
        Me.BtnVanillaIcecream.Size = New System.Drawing.Size(75, 50)
        Me.BtnVanillaIcecream.TabIndex = 4
        Me.BtnVanillaIcecream.Text = "Vanilla Icecream"
        Me.BtnVanillaIcecream.UseVisualStyleBackColor = True
        '
        'BtnChoclateIcecream
        '
        Me.BtnChoclateIcecream.Location = New System.Drawing.Point(133, 22)
        Me.BtnChoclateIcecream.Name = "BtnChoclateIcecream"
        Me.BtnChoclateIcecream.Size = New System.Drawing.Size(75, 50)
        Me.BtnChoclateIcecream.TabIndex = 3
        Me.BtnChoclateIcecream.Text = "Choclate Icecream"
        Me.BtnChoclateIcecream.UseVisualStyleBackColor = True
        '
        'BtnButterCake
        '
        Me.BtnButterCake.Location = New System.Drawing.Point(6, 78)
        Me.BtnButterCake.Name = "BtnButterCake"
        Me.BtnButterCake.Size = New System.Drawing.Size(75, 50)
        Me.BtnButterCake.TabIndex = 2
        Me.BtnButterCake.Text = "Butter Cake"
        Me.BtnButterCake.UseVisualStyleBackColor = True
        '
        'BtnLavaCake
        '
        Me.BtnLavaCake.Location = New System.Drawing.Point(6, 22)
        Me.BtnLavaCake.Name = "BtnLavaCake"
        Me.BtnLavaCake.Size = New System.Drawing.Size(75, 50)
        Me.BtnLavaCake.TabIndex = 1
        Me.BtnLavaCake.Text = "Lava Cake"
        Me.BtnLavaCake.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(12, 393)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(93, 23)
        Me.BtnDelete.TabIndex = 8
        Me.BtnDelete.Text = "-"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.GrpDesserts)
        Me.Controls.Add(Me.GrpDrinks)
        Me.Controls.Add(Me.GrpFood)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnPay)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpFood.ResumeLayout(False)
        Me.GrpDrinks.ResumeLayout(False)
        Me.GrpDesserts.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnPay As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents GrpFood As GroupBox
    Friend WithEvents BtnPepperoniPizza As Button
    Friend WithEvents GrpDrinks As GroupBox
    Friend WithEvents GrpDesserts As GroupBox
    Friend WithEvents BtnVeggiePizza As Button
    Friend WithEvents BtnFanta As Button
    Friend WithEvents BtnPepsi As Button
    Friend WithEvents BtnVeggieWrap As Button
    Friend WithEvents BtnChickenWrap As Button
    Friend WithEvents BtnBeefBurger As Button
    Friend WithEvents BtnChickenBurger As Button
    Friend WithEvents BtnJuice As Button
    Friend WithEvents BtnWater As Button
    Friend WithEvents BtnCoffee As Button
    Friend WithEvents BtnChai As Button
    Friend WithEvents BtnMixfruitCustard As Button
    Friend WithEvents BtnMangoCustard As Button
    Friend WithEvents BtnVanillaIcecream As Button
    Friend WithEvents BtnChoclateIcecream As Button
    Friend WithEvents BtnButterCake As Button
    Friend WithEvents BtnLavaCake As Button
    Friend WithEvents BtnDelete As Button
End Class
