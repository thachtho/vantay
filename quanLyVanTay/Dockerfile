


# Sử dụng một image .NET Core SDK để build ứng dụng
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Sao chép mã nguồn của ứng dụng vào container
COPY . .

# Build ứng dụng
RUN dotnet publish -c Release -o out

# Sử dụng image .NET Core Runtime nhẹ để chạy ứng dụng
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Sao chép output từ bước build trước vào container
COPY --from=build /app/out .

# Chạy ứng dụng
ENTRYPOINT ["dotnet", "quanLyVanTay.dll"]