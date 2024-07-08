FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/NishilPort.Web.Host/NishilPort.Web.Host.csproj", "src/NishilPort.Web.Host/"]
COPY ["src/NishilPort.Web.Core/NishilPort.Web.Core.csproj", "src/NishilPort.Web.Core/"]
COPY ["src/NishilPort.Application/NishilPort.Application.csproj", "src/NishilPort.Application/"]
COPY ["src/NishilPort.Core/NishilPort.Core.csproj", "src/NishilPort.Core/"]
COPY ["src/NishilPort.EntityFrameworkCore/NishilPort.EntityFrameworkCore.csproj", "src/NishilPort.EntityFrameworkCore/"]
WORKDIR "/src/src/NishilPort.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/NishilPort.Web.Host", "src/NishilPort.Web.Host"]
COPY ["src/NishilPort.Web.Core", "src/NishilPort.Web.Core"]
COPY ["src/NishilPort.Application", "src/NishilPort.Application"]
COPY ["src/NishilPort.Core", "src/NishilPort.Core"]
COPY ["src/NishilPort.EntityFrameworkCore", "src/NishilPort.EntityFrameworkCore"]
WORKDIR "/src/src/NishilPort.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "NishilPort.Web.Host.dll"]
