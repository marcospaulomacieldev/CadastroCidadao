# Cadastro de Cidadãos

Aplicação desenvolvida em **C# (.NET Framework 4.8.1, WinForms)** como parte do desafio técnico.

---

## ?? Funcionalidades
- Cadastro de cidadão com **Nome completo** e **CPF**.
- Validação automática de CPF.
- Pesquisa por **Nome** ou **CPF**.
- Mensagens de sucesso/erro amigáveis.

---

## ?? Tecnologias
- C#  
- .NET Framework 4.8.1  
- Windows Forms (WinForms)  
- Programação Orientada a Objetos (POO)

---

## Como executar
1. Instale o **Visual Studio** (versão Community já serve).  
2. Garanta que o **.NET Framework 4.8.1 Developer Pack** está instalado.  
3. Abra a solução `CadastroCidadao.sln` no Visual Studio.  
4. Compile e execute (**Ctrl + F5**).  

---

## Como usar
- Na tela inicial:
  - Digite o **Nome completo** e o **CPF** ? clique em **Cadastrar**.
  - Para pesquisar, digite o **CPF** ou o **Nome** ? clique em **Pesquisar**.
- Retornos possíveis:
  - `Cadastrado com sucesso!`  
  - `Cidadão já cadastrado!`  
  - `CPF inválido!`  
  - `Cidadão não encontrado!`

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

## Observações
- O projeto não usa frameworks externos, apenas bibliotecas nativas do .NET.
- Código organizado seguindo POO.
