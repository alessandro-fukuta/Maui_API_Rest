PROJETO API_REST (MAUI)

ESTE PROJETO TEM COMO OBJETIVO, AJUDAR A COMUNIDADE A CONSUMIR UMA API REST UTILIZANDO O NET MAUI
NESTE PROJETO CONSUMIMOS 2 API´S

1) API DO IBGE ONDE RETORNAMOS OS ESTADOS
2) API PARTICULAR ONDE CONSUMIMOS UMA API REST EM NODE.JS

NESTE PROJETO UTILIZAMOS OS NOMES DEFAULT´S DO PROJETO
COMO: MainPage.xaml (pagina principal)

** Informação importante **
// para que as conexoes locais funcionem no MAUI
// adicione a linha abaixo 
//  [Application(UsesCleartextTraffic = true)]
// em Platforms / Android / MainApplication.cs
// substitua [Application] por [Application(UsesCleartextTraffic = true)]

na Pasta Models do Projeto, temos as classes que representam os Estados (ufs) e as Brands (marcas)

é necessário instalar a seguinte biblioteca via NUGET
  newtonsoft.json

Espero ter ajudado

Alessandro Fukuta

