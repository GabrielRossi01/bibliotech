# 📖 Bibliotech

Bibliotech é um aplicativo de console em **C#** para gerenciamento de livros e revistas.

![LibraryStudyGIF](https://github.com/user-attachments/assets/21e1298b-1641-4a58-9e3a-7642b1245eb2) ![ElmoFireGIF](https://github.com/user-attachments/assets/d93e9293-76c5-4071-b9f5-959c6aaec82b)

## 💡 Funcionalidades

- Adicionar livros (título e autor)
- Adicionar revistas (título e edição)
- Listar todos os itens cadastrados
- Menu interativo com interface em console

---

## 🏛️ Estrutura do projeto

```
Bibliotech/ 
│
├── Bibliotech.Console/ 
│ ├── Program.cs
│ └── ...
│
├── Bibliotech.Lib/ 
│ ├── Modelos/
│ │ ├── ItemBiblioteca.cs
│ │ ├── Livro.cs
│ │ └── Revista.cs
│ └── ...
│
└── README.md
```

## 🏁 Execução do sistema

1. Clone este repositório:
```bash
git clone https://github.com/GabrielRossi01/bibliotech.git
```

2. Abra o projeto no Visual Studio.

3. Configure o projeto Fiap.Bibliotech como projeto de inicialização.

4. Compile e execute(`F5` ou `Ctrl + F5`).

5. O menu do console será exibido para interação.

## 🤔 Como usar

1. Escolha a opção desejada no menu:

```
┌──────────────────────┐
│         MENU         │
├──────────────────────|
| [1] Adicionar Livro  │
| [2] Adicionar Revista│
| [3] Listar Itens     │
| [4] Sair             │
└──────────────────────┘
```
2. Para adicionar livros, insira título e autor.

3. Para adicionar revistas, insira título e edição (números positivo).

4. Para listar itens, todos os livros e revistas cadastrados serão exibidos.
