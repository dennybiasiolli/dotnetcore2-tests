FROM microsoft/aspnetcore-build

WORKDIR /app

CMD dotnet restore \
    && dotnet build \
    && dotnet watch run --server.urls http://*:80

EXPOSE 80/tcp
