## Criando o Projeto ASP.NET Core MVC
Antes de começar, é importante lembrar que é fortemente recomendado o uso da IDE Visual Studio 2022

<img src="https://visualstudio.microsoft.com/wp-content/uploads/2021/10/Product-Icon.svg" height="200px">

Caso você não utilize o sistema operacional Windows ou use mas tenha um PC fraco, é possível usar o VS Code:

<img src="https://images-eds-ssl.xboxlive.com/image?url=4rt9.lXDC4H_93laV1_eHM0OYfiFeMI2p9MWie0CvL99U4GA1gf6_kayTt_kBblFwHwo8BW8JXlqfnYxKPmmBRXp912Lw.0Yxg2DfVOh1gnKXRQeKb8m8DA2Jkx6Xwk0yYA23Ude.JrHx3QjJv9hvUNKZhFYJFJP2QtF6zREDZk-&format=source" height="200px">

A questão é que o Visual Studio 2022 é muito mais preparado para programar em C#. Caso ainda assim decida codar no VS Code, para criar o projeto digite no terminal o comando:
```shell
dotnet new mvc
```
Caso opte por usar o Visual Studio 2022, abra-o e selecione essa opção:
![Entrando no VS 2022](./2criandoProjeto/createProject.png)
Depois, procure essa opção de projeto:
![Tipo MVC](./2criandoProjeto/tipoDoProjeto.png)
Caso ela não apareceça, é preciso verificar se você tem instalado o pacote de desenvolvimento de aplicações Web no seu computador, abra o **Visual Studio Installer**:
![Installer do VS](./2criandoProjeto/vsInstaller.png)
Clique em modificar no Visual Studio:
![Modificar VS](./2criandoProjeto/modificar.png)
Selecione essa opção e clique em **Instalar durante o download**:
![Carga de Trabalho](./2criandoProjeto/pacoteASPNETCORE.png)

* Depois disso, aquela opção de projeto aparecerá, selecione-a.

* Nomeie o projeto, escolha o local onde ele ficará no seu PC.

* Selecione a versão .NET 8.0 (Long Term Support) e deixe o restante das coisas sem mexer, finalize apertando em Criar (Create).