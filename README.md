# aws_ex4
Exercício de API Gateway da disciplina API e Web Services (AWS), Prof: Marco Mendes; Curso: Desenvolvimento Web Full Stack

* Autores: 
    * André Guilherme de Almeida Santos  
    * Lucas de Paula Barbosa

#### Implementação de 3 serviços autônomos:  
1. Cadastro de produtos (CRUD) - NODE.JS - rodando na porta 2000  
To run the server, run:
    ```
    npm start
    ```
2. Gestão de um carrinho de compra (CRUD) - NODE.JS - rodando na porta 3000  
To run the server, run:
    ```
    npm start
    ```
3. Gestão de pedidos (Pagamento de pedidos, cancelamento de pedidos, listagem de pedidos) - .NET Core - rodando na porta 4000  
    To run the server, run:
    ```
    dotnet run
    ```

#### Implementação de 2 Gateways:
1. Gateway Público (permitido apenas GET) - .NET Core com Ocelot - rodando na porta 5000  
    To run the server, run:
    ```
    dotnet run
    ```
2. Gateway Privado (permitido GET, POST, PUT, DELETE) - .NET Core com Ocelot - rodando na porta 8000  
    To run the server, run:
    ```
    dotnet run
    ```

### To access web services:  

* Gateway Público  
  ---- PEDIDOS -------------------------------------------------------
  * Recupera todos os pedidos:
    ```
    GET http://localhost:5000/pedidos/api/values
    ```
  * Recupera um pedido específico:
    ```
    GET http://localhost:5000/pedidos/api/values/{idPedido}
    ```
  ---- CARRINHO -------------------------------------------------------    
  * Recupera todos os produtos do carrinho:
    ```
    GET http://localhost:5000/carrinho/api/values
    ```
  * Recupera um pedido específico do carrinho:
    ```
    GET http://localhost:5000/carrinho/api/values/{idPedido}
    ```
   ---- PRODUTOS------------------------------------------------------- 
   * Recupera todos os produtos:
    ```
    GET http://localhost:5000/produtos/api/values
    ```
  * Recupera um pedido específico:
    ```
    GET http://localhost:5000/produtos/api/values/{idPedido}
    ```
    
* Gateway Privado  
  ---- PEDIDOS -------------------------------------------------------
  * Recupera todos os pedidos:
    ```
    GET http://localhost:8000/pedidos/api/values
    ```
  * Recupera um pedido específico:
    ```
    GET http://localhost:8000/pedidos/api/values/{idPedido}
    ```
  * Operação para criar um pedido (JSON necessário, ex: "{teste : teste}"):
    ```
    POST http://localhost:8000/pedidos/api/values
    ```
  * Operação para alterar um pedido (JSON necessário):
    ```
    PUT http://localhost:8000/pedidos/api/values/{idPedido}
    ```
  * Operação para deletar um pedido:
    ```
    DELETE http://localhost:8000/pedidos/api/values/{idPedido}
    ```
  * Operação para pagar um pedido:
    ```
    POST http://localhost:8000/pedidos/api/pagamentos/{idPedido}
    ```    
   * Operação para cancelar um pedido:
        ```
        POST http://localhost:8000/pedidos/api/cancelamentos/{idPedido}
        ```   
   ---- CARRINHO -------------------------------------------------------    
  * Recupera todos os produtos do carrinho:
    ```
    GET http://localhost:8000/carrinho/api/values
    ```
  * Recupera um pedido específico do carrinho:
    ```
    GET http://localhost:8000/carrinho/api/values/{idPedido}
    ```
  * Operação para adicionar um produto no carrinho:
    ```
    POST http://localhost:8000/carrinho/api/values
    ```
  * Operação para alterar um produto no carrinho:
    ```
    PUT http://localhost:8000/carrinho/api/values/{idPedido}
    ```
  * Operação para deletar um produto no carrinho:
    ```
    DELETE http://localhost:8000/carrinho/api/values/{idPedido}
    ```
   ---- PRODUTOS------------------------------------------------------- 
   * Recupera todos os produtos:
    ```
    GET http://localhost:8000/produtos/api/values
    ```
  * Recupera um pedido específico:
    ```
    GET http://localhost:8000/produtos/api/values/{idPedido}
    ```
  * Operação para adicionar um produto:
    ```
    POST http://localhost:8000/produtos/api/values
    ```
  * Operação para alterar um produto:
    ```
    PUT http://localhost:8000/produtos/api/values/{idPedido}
    ```
  * Operação para deletar um produto:
    ```
    DELETE http://localhost:8000/produtos/api/values/{idPedido}
    ```
    

