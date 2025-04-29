# Projeto ASP.NET Core com Razor Pages

## 8 Constru��o de Aplica��o Web com Razor Pages

Aplicativos web baseados em Razor Pages s�o comuns em sistemas internos e portais administrativos.

**Tarefas:**

- Crie um novo projeto ASP.NET Core com Razor Pages.
- Crie uma p�gina inicial (Index.cshtml) que exiba uma lista com tr�s produtos (nome e pre�o).
- As informa��es podem estar fixas ou armazenadas em uma lista na p�gina.
- Configure navega��o b�sica entre as p�ginas.

Com este exerc�cio voc� come�a a construir aplica��es web completas com estrutura MVC simplificada.

![Exerc�cio 08](prints_readme/ex08.png)

---

## 9 Explora��o da Estrutura de Projeto ASP.NET Core

Compreender a estrutura do projeto ASP.NET Core � essencial para manuten��o e evolu��o de aplica��es.

**Tarefas:**

A partir do projeto criado no exerc�cio anterior, responda:

- Qual a fun��o da pasta Pages?
- O que faz o arquivo Program.cs?
- Onde s�o configurados os servi�os da aplica��o?
- Como � feito o roteamento de URLs?

Entregue as respostas em arquivo .docx ou .pdf.

---

## 10 Implementa��o de Formul�rio em Razor Pages

Cadastros s�o uma funcionalidade central em aplica��es web.

**Tarefas:**

- No projeto ProductCatalog, crie uma p�gina AddProduct.cshtml.
- Implemente um formul�rio com dois campos: Nome e Pre�o.
- Ao submeter o formul�rio, exiba os dados preenchidos de volta na p�gina.

Esse exerc�cio mostra o ciclo b�sico de entrada e exibi��o de dados no modelo Razor Pages.

---

## 11 Manipula��o de Strings com Delegates Encadeados

Transforma��es encadeadas s�o comuns em pipelines de processamento.

**Tarefas:**

- Crie um `Func<string, string, string>` que concatene nome e sobrenome.
- Encadeie mais dois m�todos no delegate:
  - Um que converta a string para mai�sculas.
  - Outro que remova espa�os em branco.
- Observe e analise o comportamento do resultado.

Esse exerc�cio ajuda a compreender o comportamento de retorno em delegates multicast.

---

## 12 Integra��o de Delegates e Eventos em Aplica��o Web

Sistemas modernos integram l�gica de neg�cio com eventos para rastrear opera��es de forma centralizada.

**Tarefas:**

- No projeto ASP.NET, crie uma entidade `Event` com T�tulo, Data e Local.
- Crie uma p�gina que permita cadastrar eventos.
- Sempre que um novo evento for criado, dispare um delegate `Action<Event>` que registre a cria��o no console.

Este exerc�cio conecta conceitos de eventos com aplica��es web reais.
