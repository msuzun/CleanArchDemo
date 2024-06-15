
# 🏗️ Katmanlı Mimari .NET Core Projesi

![Project Banner](https://via.placeholder.com/800x200.png?text=Katmanlı+Mimari+.NET+Core+Projesi)

## 📋 İçindekiler

- [Proje Hakkında](#-proje-hakkında)
- [Özellikler](#-özellikler)
- [Kurulum](#-kurulum)
- [Katmanlar](#-katmanlar)
- [Kullanılan Teknolojiler](#-kullanılan-teknolojiler)
- [Katkıda Bulunanlar](#-katkıda-bulunanlar)

## 💡 Proje Hakkında

Bu proje, .NET Core ile geliştirilmiş katmanlı mimaride bir uygulamadır. SOLID ve Clean Code prensiplerine uygun olarak tasarlanmıştır. MediatR kütüphanesi kullanılarak CQRS (Command Query Responsibility Segregation) design pattern uygulanmış ve Automapper kütüphanesi ile veriler modellere maplenmiştir. 

Proje 7 ana katmandan oluşmaktadır:

1. **Api**
2. **Application**
3. **Domain**
4. **Infra.Bus**
5. **Infra.Data**
6. **Infra.IoC**
7. **Presentation**

## ✨ Özellikler

- Katmanlı Mimari ile yüksek seviyede modülerlik
- SOLID ve Clean Code prensiplerine uygun yapı
- CQRS design pattern kullanımı ile komut ve sorgu işlemlerinin ayrıştırılması
- MediatR kütüphanesi ile kolayca genişletilebilir yapı
- Automapper ile kolay veri mapleme
- Entity Framework Core ile güçlü veri erişim katmanı
- .NET Core Identity ile güvenlik işlemleri
- Responsive template ile kullanıcı dostu arayüz

## 🚀 Kurulum

### Gereksinimler

- [.NET Core 3.0 SDK](https://dotnet.microsoft.com/download/dotnet-core/3.0)
- [Visual Studio 2019 veya üzeri](https://visualstudio.microsoft.com/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Adımlar

1. Bu repository'yi klonlayın:
   
   git clone https://github.com/yourusername/yourprojectname.git
   
2. Proje dizinine gidin:
   
   cd yourprojectname
   
3. Gerekli bağımlılıkları yükleyin:

   dotnet restore

4. Veritabanı bağlantı ayarlarını appsettings.json dosyasında yapılandırın.
5. Veritabanını güncelleyin:

   dotnet ef database update

6. Projeyi çalıştırın:

   dotnet run


## 📂 Katmanlar

### Api

Uygulamanın ana giriş noktasıdır. HTTP isteklerini alır ve yönlendirir.

### Application

Uygulama iş mantığının yer aldığı katmandır. MediatR ile komut ve sorgu işlemleri burada yönetilir.

### Domain

Domain sınıfları ve domain servislerinin yer aldığı katmandır. İş kuralları burada tanımlanır.

### Infra.Bus

Uygulamanın mesajlaşma altyapısını sağlar. MediatR burada yapılandırılır.

### Infra.Data

Veritabanı işlemleri ve Entity Framework Core yapılandırmaları burada bulunur.

### Infra.IoC

Dependency Injection (bağımlılık enjeksiyonu) işlemlerinin yönetildiği katmandır.

### Presentation

Uygulamanın kullanıcı arayüzü katmanıdır. Responsive template kullanılarak geliştirilmiştir.

## 🛠️ Kullanılan Teknolojiler

- .NET Core 3.0
- Entity Framework Core
- MediatR
- Automapper
- .NET Core Identity

## 👥 Katkıda Bulunanlar

- [msuzun](https://github.com/msuzun)


## 📄 Lisans

Bu şablonu kendi projenize uyacak şekilde düzenleyebilirsiniz.
