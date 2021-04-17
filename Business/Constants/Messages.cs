using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
  public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductDeleted= "Ürün Silindi.";
        public static string ProductUptaded= "Ürün Güncellendi.";

        public static string OrderAdded = "Siparis Eklendi.";
        public static string OrderDeleted = "Siparis Silindi.";
        public static string OrderUptaded = "Siparis Güncellendi.";

        public static string CategoryAdded = "Kategori Eklendi.";
        public static string CategoryDeleted = "Kategori Silindi.";
        public static string CategoryUptaded = "Kategori Güncellendi.";

        public static string CustomerAdded = "Müşteri Eklendi.";
        public static string CustomerDeleted = "Müşteri Silindi.";
        public static string CustomerUptated = "Müşteri Güncellendi.";

        public static string ProductNameInvalid = "Ürün İsmi Geçersizdir.";
        public static string MaintenanceTime = "Sistem Bakımdadır.";
        public static string ProductsListed = "Ürünler Listelendi.";

        public static string ProductCountOfCategoryError = "Bir Kategoride En Fazla 10 Ürün Olabilir.";
        public static string ProductNameAlreadyExists = "Aynı İsimde Bir Ürün Daha Var.";

        public static string PCategoryCountControlExceed = "Kategori Sayısı Aşıldığı İçin yeni Ürün Eklenemez.";
        public static string AuthorizationDenied = "Kullanıcın Yetkisi Yoktur.";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        
    }
}
