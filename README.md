Caching Demo – In-Memory ve Distributed (Redis)

Bu proje, .NET üzerinde iki farklı önbellekleme yaklaşımını göstermektedir:

In-Memory Cache (IMemoryCache)

Distributed Cache (Redis + IDistributedCache)

Amaç, tek sunuculu ve dağıtık mimarilerde cache kullanım farklarını uygulamalı olarak göstermektir.

1. In-Memory Caching

Amaç: Uygulama içi (RAM tabanlı) geçici veri saklama mekanizmasını göstermek.

Kullanılan Teknolojiler:

IMemoryCache

MemoryCacheEntryOptions

AbsoluteExpiration

SlidingExpiration

Kullanım Senaryoları:

Tek sunuculu uygulamalar

Kısa süreli veri saklama

Yüksek performans gerektiren işlemler

Session bağımsız geçici veriler

Temel Özellikler:

Thread-safe çalışma

TTL (Time To Live) desteği

Absolute ve Sliding expiration yönetimi

RAM seviyesinde hızlı veri erişimi

Sınırlamalar:

Uygulama restart olursa veri silinir

Çoklu sunucu ortamında veri paylaşılmaz

Mikroservis mimarisi için uygun değildir

2. Distributed Caching (Redis)

Amaç: Redis kullanarak merkezi ve dağıtık cache mekanizması oluşturmak.

Kullanılan Teknolojiler:

Redis

StackExchange.Redis

IDistributedCache

Kullanım Senaryoları:

Mikroservis mimarileri

Load-balanced uygulamalar

Çoklu sunucu ortamları

Session paylaşımı gereken sistemler

Temel Özellikler:

Merkezi cache yönetimi

String ve binary veri desteği

TTL desteği

Multi-instance uyumluluğu

Yüksek ölçeklenebilirlik

Avantajlar:

Uygulama restart sonrası veri kaybolmaz

Tüm servisler aynı cache’i kullanabilir

Dağıtık sistemlerde tutarlılık sağlar
