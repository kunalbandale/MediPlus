Public Class Software

    Private Sub Table1BindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BillDataDataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.vendorPayment' table. You can move, or remove it, as needed.
        Me.VendorPaymentTableAdapter.Fill(Me.DatabaseDataSet.vendorPayment)
        'TODO: This line of code loads data into the 'DatabaseDataSet.purchaseMaster' table. You can move, or remove it, as needed.
        Timer1.Start()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Table1BindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            Table1BindingSource.EndEdit()
            Table1TableAdapter.Update(BillDataDataSet.Table1)
            MessageBox.Show("Saved Successfully!!")
        Catch ex As Exception
            MessageBox.Show("Error Ocurred!!")
        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Table1BindingSource.RemoveCurrent()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim count As Integer
        count = Table1BindingSource.Count
        Label1.Text = count.ToString
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        login.Show()
        Me.Dispose()
    End Sub

    'vendor payment Master

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        VendorPaymentBindingSource.AddNew()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Try
            VendorPaymentBindingSource.EndEdit()
            VendorPaymentTableAdapter.Update(DatabaseDataSet.vendorPayment)
            MessageBox.Show("data Saved!!!")
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try

    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        VendorPaymentBindingSource.RemoveCurrent()
    End Sub
End Class