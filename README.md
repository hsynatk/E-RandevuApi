# E-Randevu API

Bu proje, .NET 9 ve Clean Architecture prensipleri kullanılarak geliştirilmiş bir **Elektronik Randevu Sistemi API'sidir**. Hastalar ve doktorlar sisteme giriş yaparak uygun zaman dilimlerine göre randevu oluşturabilir, görüntüleyebilir ve yönetebilir.

## 🔧 Teknolojiler

- ASP.NET Core 9
- Entity Framework Core
- Clean Architecture (Katmanlı Mimari)
- MSSQL
- AutoMapper
- JWT Authentication
- FluentValidation
- **Scalar UI** (API dokümantasyonu için)

## 🏗️ Proje Mimarisi

Proje Clean Architecture prensiplerine göre katmanlara ayrılmıştır:

- **Domain**: Temel iş kuralları ve varlıklar (Entities, Interfaces)
- **Application**: İş mantığı (UseCases, DTOs, Services)
- **Infrastructure**: Veritabanı ve dış servislerle etkileşim (EF Core, SMS servisi vb.)
- **WebAPI**: API endpoint'leri, middleware'ler ve konfigurasyonlar

## 📦 Özellikler

- 👤 Hasta ve Doktor kayıt/giriş sistemi
- 📅 Randevu oluşturma, görüntüleme ve iptal etme
- ⏰ Uygun zaman dilimlerine göre randevu planlama
- 🏥 Klinik ve doktor bilgileri yönetimi
- 📲 SMS bildirimi entegrasyonu
- 🔐 JWT ile kimlik doğrulama
- 📘 Scalar UI ile interaktif API dökümantasyonu

## 🚀 Kurulum

### Gereksinimler

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/)
- [Visual Studio 2022+](https://visualstudio.microsoft.com/) veya VS Code

### Adımlar

1. Repoyu klonlayın:

```bash
git clone https://github.com/hsynatk/E-RandevuApi.git
cd E-RandevuApi
