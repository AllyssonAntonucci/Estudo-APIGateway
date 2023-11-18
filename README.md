# Estudo-APIGateway

Trata-se de um projeto de estudo sobre a utilização de uma API Gateway. Em termos simplificados, uma API Gateway atua como intermediário, gerenciando todas as chamadas de API entre clientes e serviços. Ela estabelece uma entrada única para as múltiplas APIs de uma aplicação, oferecendo uma gama de funcionalidades que simplificam e otimizam a interação entre os componentes do sistema.

Neste projeto, foi utilizado o Ocelot, que é uma API Gateway para a plataforma .NET direcionada para quem trabalha com uma arquitetura orientada a microsserviços. A principal funcionalidade do Ocelot é pegar as requisições HTTP de entrada e encaminhá-las para um serviço downstream usado pelos projetos de microsserviços. Ele é um Gateway de API leve, rápido e escalonável, fornecendo roteamento e autenticação, sendo recomendado para abordagens mais simples.

---

O seguinte diagrama representa a interação entre o frontend, a API Gateway (Ocelot) e os backends desse projeto, demonstrando a centralização das chamadas de API e a distribuição eficiente para os serviços correspondentes:


<div align="center">
<img src="https://github.com/AllyssonAntonucci/Estudo-APIGateway/assets/125825975/73456c9e-8ed3-4049-a6ff-9f1a30aa2d79" alt="Diagrama API Gateway">
</div>
