# Enumeração (enum)

- É um tipo especial que serve para especificar de forma literal um conjunto
de constantes relacionadas
- Palavra chave em C#: `enum`
  - >Nota: enum é um tipo valor
- Vantagem: melhor semântica, código mais legível e auxiliado pelo compilador
- Referência: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/enum

<br>

<p align="center">
  <img src="/img/1.png">
</p>

<br>

```c#
class Order
{
  public int Id { get; set; }
  public DateTime Moment { get; set; }
  public OrderStatus Status { get; set; }
}
```

```c#
enum OrderStatus : int 
{
  PendingPayment = 0,
  Processing = 1,
  Shipped = 2,
  Delivered = 3
}
```

<br>

### Conversão de string para enum
1. Convertemos de string para enumeração deste jeito:
```c#
OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
```

<br>

2. Se não funcionar na sua versão do C#, podemos tentar deste jeito:
```c#
OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
```

<br>


3. Há ainda uma terceira forma:
```c#
  OrderStatus os;
  Enum.TryParse("Delivered", out os);
```


# Composição

 É um tipo de associação que permite que um objeto contenha outro
- Relação "tem-um" ou "tem-vários"
- Vantagens
  - Organização: divisão de responsabilidades
  - Coesão
  - Flexibilidade
  - Reuso
- >Nota: embora o símbolo UML para composição (todo-parte) seja o diamante preto, neste contexto estamos chamando de composição qualquer associação tipo "tem-um" e "tem-muitos".

<br>

# Exercícios
1. Ler os dados de um trabalhador com N contratos (N fornecido pelo usuário). Depois, solicitar do usuário um mês e mostrar qual foi o salário do funcionário nesse mês, conforme exemplo.

<p align="center">
  <img src="/img/2.png">
</p>

<br>
  
<h3>SAÍDA:</h3>
<p align="center">
  <img src="/img/3.png">
</p>

2. 