private void btnCalculate_Click(object sender, EventArgs e)
{
    try
    {
        if (txtSubtotal.Text == "")
        {
            MessageBox.Show("Subtotal is a required field.", "Entry Error");
            txtSubtotal.Focus();
            return;
        }

        decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);

        if (subtotal <= 0 || subtotal >= 10000)
        {
            MessageBox.Show("Subtotal must be greater than 0 and less than 10,000.", "Entry Error");
            txtSubtotal.Focus();
            return;
        }

        decimal discountPct = .25m;
        decimal discountAmt = Math.Round(subtotal * discountPct, 2);
        decimal invoiceTotal = Math.Round(subtotal - discountAmt, 2);

        txtDiscountPct.Text = discountPct.ToString("p1");
        txtDiscountAmt.Text = discountAmt.ToString("c");
        txtTotal.Text = invoiceTotal.ToString("c");

        txtSubtotal.Focus();
    }
    catch (FormatException)
    {
        MessageBox.Show("Subtotal must be a valid number.", "Entry Error");
        txtSubtotal.Focus();
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message, ex.GetType().ToString());
        txtSubtotal.Focus();
    }
}