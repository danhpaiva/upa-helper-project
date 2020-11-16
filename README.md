<h1 align="center">:hospital: UPA Helper</h1>

<p align="center">
  <a href="#">
    <img src="images/logo.png" width="200" alt="UPA HELPER">
  </a>
</p>
<p align="center">
    Dois APP's desktop para auxiliar o atendimento das UPA's
</p>

<p align="center">
 <a href="#status">Status</a> • 
 <a href="#objetivo">Objetivo</a> •
 <a href="#upahelper">Upa Helper</a> •
 <a href="#upauser">Upa USER</a> •
 <a href="#instalacao">Instalação</a> • 
 <a href="#tecnologias">Tecnologias</a> • 
 <a href="#autor">Autor</a> • 
 <a href="#licenca">Licença</a>
</p>

<h2 align="center" id=status> 
	:beginner: Concluído :beginner:
</h2>

<h2 id=objetivo>:scroll: Objetivo</h2>

Este projeto foi desenvolvido para avaliação nas disciplinas:

- Práticas de Programação
- Modelagem e Desenvolvimento em Banco de Dados

Foi avaliado e recebeu nota total em ambas as disciplinas. <br>

Desenvolvemos dois sistemas na linguagem C#. 
Utilizamos Windows Forms para as duas aplicações e ambas fazem conexão em banco de dados SQL SERVER.<br>

O primeiro sistema é um APP para a UPA (Unidade de Pronto Atendimento),
onde serão cadastrados os pacientes que necessitam de atendimento.<br>
O segundo sistema é um APP para o paciente onde ele consultará qual UPA possui menor lotação.<br>

O projeto visa buscar um atendimento mais rápido para todas as pessoas que precisam do serviço da UPA.<br>
Consequentemente a UPA ganhará flexibilidade, pois caso esteja cheia de pessoas, não ficará superlotada.

<h2 id=upahelper>:hospital: UPA HELPER</h2>

<p align="center">
  <img src="https://i.imgur.com/kmsP0Qg.png">
</p>

Esta é a aplicação destinadas as UPA's.<br>
Após o login do funcionário da UPA (médico por exemplo), temos acesso a tela principal onde existem as funcionalidades:
- Atendimento ao paciente: cadastro de dados pessoais e descrição do problema de saúde 
- Concluir o atendimento: após o paciente ser liberado da UPA conseguimos dar baixa no sistema
- Local para acesso a telefones úteis da área de sáude
- Local para imprimir um folheto para boas práticas contra o COVID-19

<h2 id=upauser>:relaxed: UPA HELPER USER</h2>

<p align="center">
  <img src="https://i.imgur.com/vnTqmQs.png">
</p>

Esta é a aplicação destinada as pessoas que precisam se deslocar até uma UPA.<br>
Possui a funcionalidade principal de buscar a regional da UPA e obter as informações de lotação e endereço.

<h2 id=instalacao>:clipboard: Instalação</h2>
1. Faça download do repositório.

2. Execute o script sql para gerar o banco de dados local.
> database/UPA_HELPER.sql

3. Debug as aplicações nas respectivas pastas.

<h2 id=tecnologias>:toolbox: Tecnologias</h2>
As seguintes ferramentas foram usadas na construção do projeto:

- IDE: <a href="https://visualstudio.microsoft.com/pt-br/vs/">Visual Studio 2019</a>
- Estilos: <a href="https://www.canva.com/">Canva</a> | <a href="https://iconarchive.com/">IconArchive</a>
- Banco de Dados: <a href="https://www.microsoft.com/pt-br/sql-server/sql-server-downloads">SQL Server</a>
- Requisito: .Net FrameWork 4.7.2 <br>

<h2 id=autor>:grin: Autores</h2>
Desenvolvido por <a href="https://www.linkedin.com/in/danhpaiva/">Daniel Paiva</a>, 
<a href="https://www.linkedin.com/in/douglas-ramos-78362099/">Douglas Ramos</a>, 
<a href="https://www.linkedin.com/in/gabrielcmariano/">Gabriel Mariano</a> e 
<a href="https://www.linkedin.com/in/guilherme-pujoni-4921a0187/">Guilherme Pujoni</a>

<h2 id=licenca>:lock: Licença</h2>
<a href="https://github.com/danhpaiva/login-csharp-sqlServer/blob/master/LICENSE" target="_blank">MIT</a>