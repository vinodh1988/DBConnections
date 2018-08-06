<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CityBox
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SnoBox = New System.Windows.Forms.TextBox()
        Me.PersonBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TvsDataSet1 = New DesktopLINQ.tvsDataSet1()
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TvsDataSet = New DesktopLINQ.tvsDataSet()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.CityTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PersonTableAdapter = New DesktopLINQ.tvsDataSetTableAdapters.PersonTableAdapter()
        Me.PersonTableAdapter1 = New DesktopLINQ.tvsDataSet1TableAdapters.PersonTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TvsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TvsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Get People"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(257, 89)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(645, 295)
        Me.DataGridView1.TabIndex = 1
        '
        'SnoBox
        '
        Me.SnoBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource1, "Sno", True))
        Me.SnoBox.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.PersonBindingSource1, "Sno", True))
        Me.SnoBox.Location = New System.Drawing.Point(109, 127)
        Me.SnoBox.Name = "SnoBox"
        Me.SnoBox.Size = New System.Drawing.Size(100, 20)
        Me.SnoBox.TabIndex = 2
        '
        'PersonBindingSource1
        '
        Me.PersonBindingSource1.DataMember = "Person"
        Me.PersonBindingSource1.DataSource = Me.TvsDataSet1
        '
        'TvsDataSet1
        '
        Me.TvsDataSet1.DataSetName = "tvsDataSet1"
        Me.TvsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonBindingSource
        '
        Me.PersonBindingSource.DataMember = "Person"
        Me.PersonBindingSource.DataSource = Me.TvsDataSet
        '
        'TvsDataSet
        '
        Me.TvsDataSet.DataSetName = "tvsDataSet"
        Me.TvsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NameBox
        '
        Me.NameBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource1, "Name", True))
        Me.NameBox.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.PersonBindingSource1, "Name", True))
        Me.NameBox.Location = New System.Drawing.Point(109, 153)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(100, 20)
        Me.NameBox.TabIndex = 3
        '
        'CityTxt
        '
        Me.CityTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource1, "City", True))
        Me.CityTxt.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.PersonBindingSource1, "City", True))
        Me.CityTxt.Location = New System.Drawing.Point(109, 179)
        Me.CityTxt.Name = "CityTxt"
        Me.CityTxt.Size = New System.Drawing.Size(100, 20)
        Me.CityTxt.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "City"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(65, 219)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Store Person"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PersonTableAdapter
        '
        Me.PersonTableAdapter.ClearBeforeFill = True
        '
        'PersonTableAdapter1
        '
        Me.PersonTableAdapter1.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(65, 248)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Update Person"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(65, 277)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Delete Person"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(120, 34)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(115, 23)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Get Employees"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("NewsGoth Cn BT", 16.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label4.Location = New System.Drawing.Point(390, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 26)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "LINQ Demonstration"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(417, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Developed in LUCAS TVS"
        '
        'CityBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CityTxt)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.SnoBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "CityBox"
        Me.Text = "LINQ Demonstration"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TvsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TvsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SnoBox As TextBox
    Friend WithEvents NameBox As TextBox
    Friend WithEvents CityTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TvsDataSet As tvsDataSet
    Friend WithEvents PersonBindingSource As BindingSource
    Friend WithEvents PersonTableAdapter As tvsDataSetTableAdapters.PersonTableAdapter
    Friend WithEvents TvsDataSet1 As tvsDataSet1
    Friend WithEvents PersonBindingSource1 As BindingSource
    Friend WithEvents PersonTableAdapter1 As tvsDataSet1TableAdapters.PersonTableAdapter
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
