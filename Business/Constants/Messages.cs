using Core.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Ekleme işlemi başarılı";
        public static string Listed = "Listeleme işlemi başarılı";
        public static string Updated = "Güncelleme işlemi başarılı";
        public static string Deleted = "Silme işlemi başarılı";
        public static string CarAdded = "Araç başarıyla eklendi22.";
        public static string InvalidCarDetail = "Araç ismi 2 karakterden uzun olmalı ve günlük bedeli 0'dan büyük olmalıdır.";
        public static string InvalidCustomerName = "Şirket adı 2 karakterden uzun olmalıdır.";
        public static string CarsListed = "Araçlar listelendi";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarNameAlreadyExists = "Aynı isimde kayıt var";
        public static string UserRegistered = "Kayıt başarılı";
        public static string UserNotFound = "Kullanıcı bulanamadı.";
        public static string PasswordError = "Password yanlış";
        public static string AuthorizationDenied = "Authorization kabul edildi.";
        public static string AccessTokenCreated ="Token yapıldı.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut.";
    }
}
