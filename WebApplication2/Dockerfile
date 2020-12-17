#FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
#WORKDIR /app
#EXPOSE 80
##EXPOSE 443
#
#FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
##WORKDIR /src
##COPY ["WebApplication2/WebApplication2.csproj", "WebApplication2/"]
#
#COPY ["WebApplication2.csproj", "./"]
#
##RUN dotnet restore "WebApplication2/WebApplication2.csproj"
#RUN dotnet restore "WebApplication2.csproj"
#
##COPY . .
#COPY . ./
#WORKDIR "/src/WebApplication2"
#RUN dotnet build "WebApplication2.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "WebApplication2.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "WebApplication2.dll"]


FROM mcr.microsoft.com/dotnet/core/sdk:3.0 as build-env
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore 

COPY . ./

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0
WORKDIR /app
EXPOSE 80
COPY --from=build-env /app/out .
ENTRYPOINT [ "dotnet", "WebApi.dll"]