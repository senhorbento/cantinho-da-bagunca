
namespace TesteBuscaArquivo;
public partial class BuscarArquivo : Form
{
    private List<String> lista = new List<String>();
    public BuscarArquivo()
    {
        InitializeComponent();
    }

    private bool VerificarExtensao()
    {
        int len;
        String[] arquivo1, arquivo2;
        len = BxTextLista1.Text.Length;
        arquivo1 = BxTextLista1.Text.Split(".");
        if (arquivo1[1] != "txt")
        {
            MessageBox.Show("O Formato " + arquivo1[1] + " não é suportado, apenas txt é suportado" , "Error");
            return false;
        }
        else
        {
            len = BxTextLista2.Text.Length;
            arquivo2 = BxTextLista2.Text.Split(".");
            if (arquivo2[1] != "txt")
            {
                MessageBox.Show("O Formato " + arquivo2[1] + " não é suportado, apenas txt é suportado", "Error");
                return false;
            }
        }
        return true;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (CxAbriArquivo.ShowDialog() == DialogResult.OK)
        {
            BxTextLista1.Text = CxAbriArquivo.FileName;
        }
    }

    private void BtLista2_Click(object sender, EventArgs e)
    {
        if (CxAbriArquivo.ShowDialog() == DialogResult.OK)
        {
            BxTextLista2.Text = CxAbriArquivo.FileName;
        }
    }

    private void BtLer_Click(object sender, EventArgs e)
    {
        lista = Arquivo.LerArquivo(BxTextLista1.Text);
        if(VerificarExtensao())
            MessageBox.Show("Arquivo lido com sucesso", "Info");
    }

    private void BtGravar_Click(object sender, EventArgs e)
    {
        Arquivo.GravarArquivo(lista,BxTextLista2.Text);
        MessageBox.Show("Arquivo gravado com sucesso", "Info");
    }
}