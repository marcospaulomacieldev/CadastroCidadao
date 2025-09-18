# Cadastro de Cidad�os

Aplica��o desenvolvida em **C# (.NET Framework 4.8.1, WinForms)** como parte do desafio t�cnico.

---

## ?? Funcionalidades
- Cadastro de cidad�o com **Nome completo** e **CPF**.
- Valida��o autom�tica de CPF.
- Pesquisa por **Nome** ou **CPF**.
- Mensagens de sucesso/erro amig�veis.

---

## ?? Tecnologias
- C#  
- .NET Framework 4.8.1  
- Windows Forms (WinForms)  
- Programa��o Orientada a Objetos (POO)

---

## Como executar
1. Instale o **Visual Studio** (vers�o Community j� serve).  
2. Garanta que o **.NET Framework 4.8.1 Developer Pack** est� instalado.  
3. Abra a solu��o `CadastroCidadao.sln` no Visual Studio.  
4. Compile e execute (**Ctrl + F5**).  

---

## Como usar
- Na tela inicial:
  - Digite o **Nome completo** e o **CPF** ? clique em **Cadastrar**.
  - Para pesquisar, digite o **CPF** ou o **Nome** ? clique em **Pesquisar**.
- Retornos poss�veis:
  - `Cadastrado com sucesso!`  
  - `Cidad�o j� cadastrado!`  
  - `CPF inv�lido!`  
  - `Cidad�o n�o encontrado!`

---

## Estrutura do projeto
CadastroCidadao/
? Models/
? ? Cidadao.cs
? Services/
? ? CadastroService.cs
? Utils/
? ? ValidadorCPF.cs
? UI/
? ? FormMain.cs
? ? FormMain.Designer.cs
? Program.cs
? README.md

## Observa��es
- O projeto n�o usa frameworks externos, apenas bibliotecas nativas do .NET.
- C�digo organizado seguindo POO.
