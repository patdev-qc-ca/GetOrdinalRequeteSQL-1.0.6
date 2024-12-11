using ADODB;
using System.IO;
namespace GetOrdinalRequeteSQL
{
    public partial class Form1 : Form
    {
        public static Connection odbc = new Connection();
        public Form1() => InitializeComponent();
        public  void InitialiserODBC()
        {
            if (odbc.State == 0)
            {
                odbc.Open($"Provider=SQLOLEDB;Data Source={$"{Environment.MachineName}\\SQLEXPRESS"};Initial Catalog=autogrb;", "sa", "Password01$", -1);
            }
        }
        public Recordset SqlLinkODBC(Recordset record, string Requete)
        {
            InitialiserODBC();
            record.Open(Requete, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            return record;
        }
        public string ConvertToUSDate(DateTime now) => $"{now.Year}-{now.Month.ToString().PadLeft(2, '0')}-{now.Day.ToString().PadLeft(2, '0')}";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtSQL.Text.Length > 0)
            {
                linkLabel3.Enabled = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Text = Application.ProductName + " " + Application.ProductVersion;
            groupBox1.Text = "Listeur ordinal pour requète sql";
        }
        private void button4_Click(object sender, EventArgs e) => Application.Exit();
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSQL.Text) == false)
            {
                txtSQL.Focus();
                Recordset test = new Recordset();
                Recordset output = SqlLinkODBC(test, txtSQL.Text);
                if (!test.EOF)
                {
                    groupBox1.Text = $"{test.Fields[0].Properties[0].Value}.{test.Fields[0].Properties[3].Value}";
                    for (int x = 0; x < test.Fields.Count; x++)
                    {
                        ListBox1.Items.Add($" ID {x} : {test.Fields[x].Name}");
                    }
                }
                linkLabel4.Visible = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            txtSQL.Text = string.Empty;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Voulez vous sauvegarder l'analyse pour {groupBox1.Text} ?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                StreamWriter sw = new StreamWriter(groupBox1.Text + "_" + ConvertToUSDate(DateTime.Now).Replace("-", "") + "_" + DateTime.Now.ToShortTimeString().Replace(":", "") + ".txt");
                sw.WriteLine($"Généré par {Text} \n © Patrice Waechter-Ebling 2024\n\n");
                Recordset test = new Recordset();
                Recordset output = SqlLinkODBC(test, txtSQL.Text);
                if (!test.EOF)
                {
                    sw.WriteLine($"Base de données {test.Fields[0].Properties[0].Value}\n");
                    sw.WriteLine(txtSQL.Text);
                    sw.WriteLine();
                    for (int x = 0; x < ListBox1.Items.Count; x++)
                    {
                        sw.WriteLine(ListBox1.Items[x]);
                    }
                    for (int a = 0; a < test.Fields.Count; a++)
                    {
                        sw.WriteLine($"\nPropriétés de {test.Fields[a].Name}");
                        for (int b = 1; b < test.Fields[a].Properties.Count; b++)
                        {
                            sw.WriteLine($"\tID= {b} {test.Fields[a].Properties[b].Name} {test.Fields[a].Properties[b].Value}");
                        }
                    }
                }
                sw.Close();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string flux = $"/* Généré par {Text} \n © Patrice Waechter-Ebling 2024";
            for (int x = 0; x < ListBox1.Items.Count; x++)
            {
                flux += "\r" + ListBox1.Items[x].ToString();
            }
            flux += "\n*/";
            Clipboard.SetText(flux);
        }
        private void cmbServeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (odbc.State == 0)
            {
                odbc.Open($"Provider=SQLOLEDB;Data Source=.\\sqlexpress;Initial Catalog=autogrb;", "sa", "Password01$", -1);
            }
        }
    }
}
