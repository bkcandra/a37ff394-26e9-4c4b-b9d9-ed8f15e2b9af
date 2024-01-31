# GetLIS Application

The GetLIS application is a .NET console application that returns the Longest Increasing Subsequence from a given string of number separated by whitespace.

## Using Docker Image

You can easily run the GetLIS application using Docker.

### Prerequisites

- Docker installed on your system. You can download Docker from [Docker's official website](https://www.docker.com/products/docker-desktop).

### Pulling the Image from Docker Hub

To pull the latest Docker image of GetLIS from Docker Hub, open your terminal or command prompt and run the following command:

```bash
docker pull bkcandra/getlis:latest
```

### Running the Application

After pulling the image, you can run the application using the following command:

```bash
docker run -it bkcandra/getlis:latest
```

### Exiting the Application
To exit the application, simply input 'exit'

---

# Project Notes

## Unit Testing
- All unit tests have been passed successfully, ensuring the robustness and reliability of the application.

## GitHub Actions
- Automated CI/CD pipeline is set up on the main branch, This pipeline is responsible for building, testing, and pushing the application to the Docker Hub repository.

## Code Linting
- Code linting is performed using VS Code Analysis and SonarLint.

## Code Coverage
![code coverage](https://github.com/bkcandra/a37ff394-26e9-4c4b-b9d9-ed8f15e2b9af/blob/dev/codecoverage.png)