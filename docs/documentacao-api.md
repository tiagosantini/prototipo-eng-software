# **Conta**

## **Get**
  - https://localhost:44387/conta/

Retorna uma coleção de contas disponíveis utilizando o método **GET**

**parâmetros**: nenhum

**Output em JSON:**
>[
>>	{
>>		"nome": "Testando API",
>>		"email": "teste@emailaddress.com",
>>		"cpf": "000.000.000-00",
>>		"senha": "ExO12aeb",
>>		"movimentacoes": null,
>>		"id": 2
>>	},

>>	{
>>		"nome": "Teste da rota Update",
>>		"email": "teste@emailaddress.com",
>>		"cpf": "000.000.000-00",
>>		"senha": "ExO12aeb",
>>		"movimentacoes": null,
>>		"id": 3
>>	},

>>	{
>>		"nome": "Testando API",
>>		"email": "teste@emailaddress.com",
>>		"cpf": "000.000.000-00",
>>		"senha": "ExO12aeb",
>>		"movimentacoes": null,
>>		"id": 4
>>	},

>>	{
>>		"nome": "Testando API",
>>		"email": "teste@emailaddress.com",
>>		"cpf": "000.000.000-00",
>>		"senha": "ExO12aeb",
>>		"movimentacoes": null,
>>		"id": 5
>>	}
>
>]

<br>

---
## **GetConta**
  - https://localhost:44387/conta/**id**

Obtenha uma conta especificada por Id utilizando o método **GET** 

**parâmetros**: Id da conta à ser selecionada

**Output em JSON:**
>{
>	"nome": "Testando API",
>	"email": "teste@emailaddress.com",
>	"cpf": "000.000.000-00",
>	"senha": "ExO12aeb",
>	"movimentacoes": null,
>	"id": 4
>}

<br>


---
## **Post** 
  - https://localhost:44387/conta/

Crie uma nova conta utilizando o método **POST**

**Corpo do request:**
>{
>	
>       "nome": "Testando API",
>
>	    "email": "teste@emailaddress.com",
>
>	    "cpf": "000.000.000-00",
>
>	    "senha": "ExO12aeb"
>
>}

**Output em JSON:**

>{
>	"nome": "Testando API",
>	"email": "teste@emailaddress.com",
>	"cpf": "000.000.000-00",
>	"senha": "ExO12aeb",
>	"movimentacoes": null,
>	"id": 5
>}

<br>

---
## **Put**
  - https://localhost:44387/conta/**id**

Edita as informações de uma conta especificada por Id utilizando o método **PUT**

**parâmetros**: Id da conta à ser editada


**Corpo do request:**
- É necessário informar o id novamente no corpo do request
>{
>
>       "id": 3,
> 
>       "nome": "Testando API",
>
>	    "email": "teste@emailaddress.com",
>
>	    "cpf": "000.000.000-00",
>
>	    "senha": "ExO12aeb"
>
>}

**Esse request não retorna JSON.**

<br>

---
## **Delete**
  - https://localhost:44387/conta/**id**

Exclui uma conta especificada por Id utilizando o método **DELETE**

**parâmetros**: Id da conta à ser excluída

**Esse request não retorna JSON.**