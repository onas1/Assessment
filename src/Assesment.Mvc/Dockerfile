
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Assesment.Mvc/HiresHoldingsAssesment.csproj", "src/Assesment.Mvc/"]
RUN dotnet restore "src/Assesment.Mvc/HiresHoldingsAssesment.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "HiresHoldingsAssesment.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HiresHoldingsAssesment.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /src/assessment.db .
COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet HiresHoldingsAssesment.dll
