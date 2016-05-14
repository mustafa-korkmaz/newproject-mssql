using Common.UIElements;
using System.Collections.Generic;
using System.Security.Policy;

namespace Common.Helper
{
    public static class Statics
    {

        #region set breadcrumbs
        //prjojeye eklenen ekranların breadcrumb  linklerini oluşturmak için o ekranların bağlantılarını aşağıdaki listeye eklemeliyiz.
        public static List<Breadcrumb> Breadcrumbs => new List<Breadcrumb>()
        {
            new Breadcrumb(){Id=0,ParentId=0,ControllerName="Home",ActionName="index",ViewTitle="Anasayfa", BackButtonText=""},
            new Breadcrumb(){Id=1,ParentId=0,ControllerName="",ActionName="",ViewTitle="Yazarlar", BackButtonText=""},
            new Breadcrumb(){Id=2,ParentId=1,ControllerName="Author",ActionName="index",ViewTitle="Yazar Bilgileri", BackButtonText=""},
            new Breadcrumb(){Id=3,ParentId=0,ControllerName="",ActionName="",ViewTitle="Yorumlar & Tahminler", BackButtonText=""},
            new Breadcrumb(){Id=4,ParentId=3,ControllerName="Tip",ActionName="index",ViewTitle="Yorum & Tahmin Bilgileri", BackButtonText=""},
            new Breadcrumb(){Id=5,ParentId=0,ControllerName="",ActionName="",ViewTitle="Coin Para İşlemleri", BackButtonText=""},
            new Breadcrumb(){Id=6,ParentId=5,ControllerName="Coin",ActionName="index",ViewTitle="Coin Para Bilgileri", BackButtonText=""},
            new Breadcrumb(){Id=7,ParentId=0,ControllerName="",ActionName="",ViewTitle="İddaa Bülteni", BackButtonText=""},
            new Breadcrumb(){Id=8,ParentId=7,ControllerName="BetProgram",ActionName="index",ViewTitle="Güncel Bülten Bilgileri", BackButtonText=""},
            new Breadcrumb(){Id=26,ParentId=0,ControllerName="",ActionName="",ViewTitle="Test İşlemleri", BackButtonText=""},
            new Breadcrumb(){Id=27,ParentId=26,ControllerName="Test",ActionName="Pjax1",ViewTitle="Pjax1", BackButtonText=""},
            new Breadcrumb(){Id=28,ParentId=26,ControllerName="Test",ActionName="Pjax2",ViewTitle="Pjax2", BackButtonText=""},
            new Breadcrumb(){Id=29,ParentId=26,ControllerName="home",ActionName="page1",ViewTitle="Page1", BackButtonText=""},
            new Breadcrumb(){Id=30,ParentId=26,ControllerName="home",ActionName="page2",ViewTitle="Page2", BackButtonText=""},
            new Breadcrumb(){Id=31,ParentId=26,ControllerName="test",ActionName="datagridsample",ViewTitle="Data Grid Sample", BackButtonText=""},
            new Breadcrumb(){Id=32,ParentId=26,ControllerName="test",ActionName="serversidedatagrid",ViewTitle="Partial Data Grid Sample", BackButtonText=""}
        };

        #endregion set breadcrumbs

        public static string GetApiUrl()
        {
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            return (string)configurationAppSettings.GetValue(Constants.ConfigKeys.ApiUrl, typeof(string));
        }

        /// <summary>
        /// return from web.config [key] value
        /// </summary>
        /// <param name="key">config app key</param>
        /// <returns></returns>
        public static string GetConfigKey(string key)
        {
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            return (string)configurationAppSettings.GetValue(key, typeof(string));
        }

    }
}