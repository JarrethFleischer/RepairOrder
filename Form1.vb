Public Class Form1

    Dim tax As Double = 0.0775
    Dim tax2 As Double = 7.75
    Dim totaljp As Double
    Dim totalparts As Double
    Dim totalaftertax As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Controls.Clear()
        InitializeComponent()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub


    Private Sub TBtoolParts_Click(sender As Object, e As EventArgs) Handles TBtoolParts.Click
        'parts used
        Dim unitprice1 As Double = Val(tbUP1.Text)
        Dim unitprice2 As Double = Val(tbUP2.Text)
        Dim unitprice3 As Double = Val(tbUP3.Text)
        Dim unitprice4 As Double = Val(tbUp4.Text)

        Dim quantity1 As Integer = Val(tbQTY1.Text)
        Dim quantity2 As Integer = Val(tbQTY2.Text)
        Dim quantity3 As Integer = Val(tbQTY3.Text)
        Dim quantity4 As Integer = Val(tbQTY4.Text)

        Dim subtotal1 As Double = unitprice1 * quantity1
        Dim subtotal2 As Double = unitprice2 * quantity2
        Dim subtotal3 As Double = unitprice3 * quantity3
        Dim subtotal4 As Double = unitprice4 * quantity4

        TBsubtotal1.Text = subtotal1.ToString("c2")
        TBsubtotal2.Text = subtotal2.ToString("c2")
        TBsubtotal3.Text = subtotal3.ToString("c2")
        TBsubtotal4.Text = subtotal4.ToString("c2")

        totalparts = subtotal1 + subtotal2 + subtotal3 + subtotal4
        TBtoolParts.Text = totalparts.ToString("c2")

    End Sub


    Private Sub TBtotalLabor_Click(sender As Object, e As EventArgs) Handles TBtotalLabor.Click
        'jobs performed
        Dim jobprice1 As Double = Val(jpPrice1.Text)
        Dim jobprice2 As Double = Val(jpPrice2.Text)
        Dim jobprice3 As Double = Val(jpPrice3.Text)
        Dim jobprice4 As Double = Val(jpPrice4.Text)

        totaljp = jobprice1 + jobprice2 + jobprice3 + jobprice4
        TBtotalLabor.Text = totaljp.ToString("c2")

    End Sub

    Private Sub TBtaxRate_Click(sender As Object, e As EventArgs) Handles TBtaxRate.Click

        TBtaxRate.Text = tax2
    End Sub


    Private Sub TBtotalAmount_Click(sender As Object, e As EventArgs) Handles TBtotalAmount.Click

        totalaftertax = (totalparts + totaljp) * tax
        TBtotalAmount.Text = totalaftertax.ToString("c2")

    End Sub


    Private Sub TBTotalOrder_Click(sender As Object, e As EventArgs) Handles TBTotalOrder.Click
        Dim totalprice As Double
        totalprice = totalparts + totaljp + totalaftertax
        TBTotalOrder.Text = totalprice.ToString("c2")

    End Sub
End Class
