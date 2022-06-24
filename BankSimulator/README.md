## How To Run The App

There are 2 ways:
- Run locally
- Use Docker

##API Documentation
Open API (Swagger) is used.

### Run Locally
- Navigate to the Project Folder in your terminal, CKOPaymentGatewaySolution -> CKOPaymentGateway
- To start the app type 'dotnet run' and press Enter
- To stop the app hold the keys 'Ctrl-C'

### Use Docker
- Navigate to the Project Folder in your terminal, CKOPaymentGatewaySolution -> CKOPaymentGateway, make sure you are in the same directory as the file docker-compose.yml
- Type 'docker-compose up' and press Enter
- To stop the app open a new terminal, Navigate to the Project Folder in your terminal, CKOPaymentGatewaySolution -> CKOPaymentGateway, make sure you are in the same directory as the file docker-compose.yml
- Type 'docker-compose down' and press Enter

### Cloud Technologies
I would use AWS or Azure, because:
- they both offer many services compared to other cloud providers
- they also offer flexible pricing

### Extra Points
- Use of Polly to handle transient faults when calling external services
- Containerised application using Docker
- API Documenation using Open API (Swagger)
