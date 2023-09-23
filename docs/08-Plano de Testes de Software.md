# Plano de Testes de Software

Os requisitos para realização dos testes de software são:
*	Site publicado na Internet
*	Navegador da Internet - Chrome, Firefox ou Edge
*	Conectividade de Internet para acesso às plataformas (APISs)
 </br>

 Os testes funcionais a serem realizados no aplicativo são descritos a seguir. 
 </br>
 
| **Caso de Teste** 	| **CT-01 - Cadastro de Usuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| O site deve permitir que os usuários se cadastrem para agendar banhos de pet. |
| Objetivo do Teste 	| Verificar se o cadastro de usuário está funcionando corretamente. |
| Passos 	| 1) Acessar a página de cadastro de usuário. </br> 2) Preencher os campos obrigatórios (nome, e-mail, senha, etc.).</br> 3)Clicar no botão de cadastro.</br> 4)Verificar se o usuário é redirecionado para a página de sucesso de cadastro.</br> |
|Critério de Êxito | O usuário é redirecionado para a página de sucesso de cadastro e os dados do usuário são armazenados corretamente no banco de dados. |
</br>

 | **Caso de Teste** 	| **CT-02 - Agendamento de Banho** 	|
|:---:	|:---:	|
|	Requisito Associado 	|  O site deve permitir que os usuários agendem banhos para seus pets. |
| Objetivo do Teste 	|  Verificar se o agendamento de banho está funcionando corretamente. |
| Passos 	|  1) Acessar a página de agendamentos.</br> 2) Selecionar o banhista para o qual deseja agendar o banho.</br> 3) Escolher a data e horário desejados.</br> 4)Clicar no botão de agendar. </br> 5)Verificar se o usuário é redirecionado para a página de sucesso de agendamento. |
|Critério de Êxito |O usuário é redirecionado para a página de sucesso de agendamento e o agendamento é registrado corretamente no sistema. |
