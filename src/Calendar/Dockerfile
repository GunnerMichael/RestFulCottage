FROM microsoft/dotnet:2.2-aspnetcore-runtime-nanoserver-1809 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk-stretch AS build
WORKDIR /src
COPY ["RestFulCalendar/RestFulCalendar.csproj", "RestFulCalendar/"]
RUN dotnet restore "RestFulCalendar/RestFulCalendar.csproj"
COPY . .
WORKDIR "/src/RestFulCalendar"
RUN dotnet build "RestFulCalendar.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "RestFulCalendar.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "RestFulCalendar.dll"]
