# Sistema de Cadastro de Usuários - C# Windows Forms

Este projeto é uma aplicação de cadastro de usuários desenvolvida em C# utilizando o .NET Framework e Windows Forms. A aplicação permite que o usuário preencha seus dados (nome, sobrenome, idade, bairro, número e e-mail) e visualize as informações inseridas. Além disso, o projeto possui funcionalidades de troca de tema, controle de campos, validação e interação via teclado.

## Funcionalidades

- **Cadastro de dados**: O usuário pode inserir informações como Nome, Sobrenome, Idade, Bairro, Número e E-mail.
- **Exibição de dados**: Os dados inseridos podem ser visualizados em um rótulo (`Lbl_Result`) após o clique de um botão.
- **Troca de temas**: O aplicativo oferece diferentes temas para a interface, incluindo um padrão e outros três temas personalizados.
- **Validação de campos**: Alguns campos, como a Idade e o Número de telefone, possuem validações para garantir que apenas números sejam inseridos.
- **Ativação/desativação de campos**: O formulário pode ser ativado ou desativado, controlando se os campos estão habilitados ou não para edição.
- **Limpeza de campos**: Há uma opção para limpar todos os campos do formulário.
- **Avançar entre campos com Enter**: O usuário pode avançar para o próximo campo pressionando a tecla "Enter", facilitando a navegação no formulário.

## Tecnologias Utilizadas

- **C#**: Linguagem de programação.
- **.NET Framework**: Framework utilizado para o desenvolvimento da aplicação desktop.
- **Windows Forms**: Biblioteca para construção da interface gráfica.
- **Eventos e Validações**: Uso de eventos `KeyPress`, `KeyDown` e `Click` para controlar interações e validações do formulário.

## Estrutura do Projeto

O projeto é composto por um formulário principal que contém:

- **Campos de texto** para entrada de dados (`Txt_Name`, `Txt_Last_Name`, `Txt_Age`, `Txt_Neighborhood`, `Txt_Number`, `Txt_Email`).
- **Botões** para acionar ações, como salvar os dados e trocar temas.
- **Labels** para exibir resultados e instruções ao usuário.
- **RadioButtons** para selecionar o tema da interface (padrão ou temas personalizados).
- **GroupBox** para agrupar controles relacionados ao tema e personalização da interface.

### Componentes Importantes

- **Eventos de Validação**: Campos como Idade e Número de telefone têm validações para garantir que apenas valores numéricos sejam inseridos.
- **Eventos de Navegação**: A navegação entre campos é controlada através da tecla "Enter". Cada campo é validado e o próximo é focado automaticamente.
- **Troca de Tema**: O usuário pode mudar o tema da interface através de `RadioButtons`, o que altera a aparência do formulário, incluindo a cor dos controles e o fundo.

## Como Executar

1. **Clone o repositório**:
   ```bash
   git clone https://github.com/seu-usuario/cadastro-de-usuarios.git
