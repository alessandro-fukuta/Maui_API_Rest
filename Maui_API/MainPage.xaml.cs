using Newtonsoft.Json;
using System.Collections.ObjectModel;
using Maui_API.Models;

namespace Maui_API
{
    public partial class MainPage : ContentPage
    {
     
        private const string Url = "https://servicodados.ibge.gov.br/api/v1/localidades/estados";

        // OBJETO http para conexão e busca de dados
        private readonly HttpClient _client = new HttpClient();

        // Lista tipo Observable para listar UNIDADE FEDERATIVA da API
        private ObservableCollection<UF> _UFS;
        private ObservableCollection<Brands> _Brands;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnBuscarCeps(object sender, EventArgs e)
        {
            BuscaEstados();
        }

        private async void BuscaEstados()
        {
            var Dados = await _client.GetStringAsync(Url);

            // Dados = "[" + Dados.ToString().Trim() + "]";
            if (Dados != null)
            {
                List<UF> ListaEstados = JsonConvert.DeserializeObject<List<UF>>(Dados);
                _UFS = new ObservableCollection<UF>(ListaEstados);
                lvUsers2.ItemsSource = _UFS.OrderBy(x => x.nome);
            }
        }

        private async void btnBuscaBrands_Click(object sender, EventArgs e)
        {

            // para que as conexoes locais funcionem no MAUI
            // adicione a linha abaixo 
            //  [Application(UsesCleartextTraffic = true)]
            // em Platforms / Android / MainApplication.cs
            // substitua [Application] por [Application(UsesCleartextTraffic = true)]

            string UrlBrands = "http://192.168.1.8:3002/brands";

            var Dados = await _client.GetStringAsync(UrlBrands);
            // Dados = "[" + Dados.ToString().Trim() + "]";

            List<Brands> ListaBrands = JsonConvert.DeserializeObject<List<Brands>>(Dados);

            _Brands = new ObservableCollection<Brands>(ListaBrands);

            lvBrands.ItemsSource = _Brands.OrderBy(x => x.title);

        }



    }

}
