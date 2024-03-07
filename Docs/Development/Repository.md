[Home](README.md)

# $$\color{lightgreen}\mathbb{Repository}$$

---

O **padrão Repository** é uma abordagem importante no desenvolvimento de aplicações ASP.NET. Ele se origina do **Domain-Driven Design (DDD)** e propõe a criação de objetos chamados **Repositories**, que gerenciam coleções de dados persistidos. A principal característica dos Repositories é que eles são **agnósticos à tecnologia utilizada**, ou seja, não estão vinculados a um banco de dados específico, cache de memória ou qualquer outra fonte de dados.

Aqui estão alguns pontos essenciais sobre o padrão Repository:

1. **Separação de Responsabilidades**: O padrão Repository ajuda a separar a responsabilidade de acesso a dados das outras camadas da aplicação. Isso melhora a organização do código e facilita a manutenção.
    
2. **Menor Acoplamento**: Ao utilizar o padrão Repository, o acoplamento entre as camadas da aplicação é reduzido. Isso significa que as mudanças no acesso a dados não afetam diretamente outras partes do sistema.
    
3. **Testabilidade Aprimorada**: O uso de interfaces com o padrão Repository permite a criação de testes unitários mais eficientes. Isso ocorre porque podemos criar implementações de teste para os Repositories sem depender de um banco de dados real.

### Criando uma Interface Repository

vamos criar um Repository em nosso projeto, onde vamos criar um diretório novo com o nome Repository e criar a interface para o nosso objeto Person.

![[ASPNET_CreateFolders.png]]

Com o botão direito no novo diretório __Repository__ clicamos em __Add__ e depois __Class...__.

![[ASPNET_Create_Class.png]]

Definimos agora uma nova classe do tipo __Interface__ onde o nome de qualquer interface começa com `i`, no nosso exemplo o nome da interface vai ser _IPersonRepository_.

![[ASPNET_RepositoryPersonInterface.png]]

Agora vamos construir o modelo dos métodos que iremos utilizar para acessar o banco de dados, onde esses modelos são somente a estrutura base, as intruções que vão ser feitas se encontram nas implementações que faremos depois.

Os métodos são:

```csharp
// Create serve para criar novos objetos no banco
Person Create(Person person);

// FindbyId serve para buscar um dado pelo seu ID
Person FindbyId(long id);

// FindAll serve para trazer todos os dados salvos em banco
List<Person> FindAll();

// Update serve para atualizar um dado no banco de dados
Person Update(Person person);

// Delete serve para remover um dado do banco de dados
void Delete(long id);

// Exists é um método auxiliar para ver se já existe um objeto no banco pelo ID
bool Exists(long id);
```





