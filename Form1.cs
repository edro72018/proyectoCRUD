namespace crudApi;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void btnNewProduct_Click(object sender, EventArgs e)
    {
        try
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al abrir el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}
