namespace Common.Constants
{
    public class ExportTypeText
    {
        public const string Category = "category";
        public const string Product = "product";
    }

    public static class BetBlogger
    {
        public const int ApiTokenValidDays = 30;
        public const string ApiKeyValue = "T.E.A.M"; // taylan.erdi.aliko.mute
        public static string ApiKeyHash = Helper.ApiKey.Instance.GetHashValue(ApiKeyValue);
    }

    public static class ErrorMessage
    {
        public const string IntegrationKeyError = "Application Integration key error.";
        public const string ApplicationExceptionMessage = "Uygulamada beklenmedik bir hata meydana geldi.\nLütfen data sonra tekrar deneyiniz.";
        public const string RecordNotFound = "Listelenecek kayıt bulunamadı.";
        public const string ApiKeyNotFound = "Api key not found.";
        public const string ApiKeyIncorrect = "Given api key is incorrect.";
        public const string UserNotFound = "The user name or password is incorrect.";
        public const string RequestInvalid = "Invalid request.";
        public const string RequestNotFound = "Request body not found";
    }

    public static class ApiResponseMessage
    {
        public const string IntegrationNotFound = "Integration not found";
        public const string ExportTypeNotFound = "Export type not found";
    }

    public static class HttpClientResponseMessage
    {
        public const string ContentNoFound = "Veri bulanamadi.";
        public const string ExportTypeNotFound = "Export type not found";
    }


    public static class BusinessResponseMessage
    {
        public const string BetProgramUpToDate = "Mevcut bülten daha önceden güncellenmiş.";
        public const string WeeksNotFound = "Bülten hafta kodlari bulunamadi.";
        public const string EventsNotFound = "{0} hafta kodlu bülten maclari bulunamadi.";
        public const string EventsParseError = "{0} hafta kodlu bülten maclari parse hatasi.";
        public const string EventsSaveError = "{0} hafta kodlu bülten maclari kaydetme hatasi.";
    }

    public static class ContentTpye
    {
        public const string FormUrlencoded = "application/x-www-form-urlencoded";
    }

    public static class WebMethod
    {
        public const string Get = "Get";
        public const string Post = "Post";
        public const string Put = "Put";
    }

    public static class ApplicationRole
    {
        public const string Admin = "Admin";
        public const string Author = "Author";
        public const string None = "None";
    }

    public static class ApplicationUserClaimType
    {
        public const string Role = "role";
        public const string AccountType = "account";
        public const string AccountExpiresAt = "accExpires";
    }

    public static class ApplicationUserClaimValue
    {
        public const string PremiumAccount = "Premium";
        public const string StandartAccount = "Standart";
        public const string TrialAccount = "Trial";
    }

    public static class DefaultAuthenticationTypes
    {
        public const string ApplicationCookie = "ApplicationCookie";
        public const string ExternalCookie = "ExternalCookie";
    }

    public static class ApiRequest
    {
        public const string ApplicationCookie = "ApplicationCookie";
        public const string ExternalCookie = "ExternalCookie";
    }

    #region UserMessageTypes

    public static class UserMessageType
    {
        public const string None = "none";
        public const string ServerError = "server-error";
        public const string Error = "error";
        public const string Warning = "warning";
        public const string Success = "success";
        public const string Info = "info";
    }

    #endregion  UserMessageTypes

    #region api urls

    public static class ApiUrl
    {
        public const string Register = "Account/Register";
        public const string GetToken = "Token";
        public const string Login = "Account/Login";
        public const string Logout = "Account/Logout";
        public const string BetProgramUpdate = "BetProgram/Update";
    }

    #endregion api urls

    #region Session

    public static class SessionVariables
    {
        public const string Breadcrumbs = "Breadcrumbs";
        public const string ApplcationUser = "ApplcationUser";
        public const string LeaguesDictionary = "LeaguesDictionary";
    }

    #endregion Session


    #region cookies

    public static class Cookies
    {
        public const string AccessToken = "AccessToken";
    }

    #endregion cookies

    #region cofig keys

    public static class ConfigKeys
    {
        public const string ApiUrl = "ApiUrl";
        public const string BetProgramReferer = "BetProgramReferer";
        public const string BetProgramUrl = "BetProgramUrl";
        public const string BetProgramUrlParams = "?type=6&sortValue=DATE&week={0}&day=-1&sort=-1&sortDir=1&groupId=-1&np=1&sport=1";
        public const string BetProgramWeekIdUrl = "BetProgramWeekIdUrl";
        public const string BetProgramWeekIdUrlParams = "?sport=1&type=6&sortValue=DATE&sortDir=-1&groupId=-1&np=0";
    }

    #endregion cofig keys

    #region request headers

    public static class RequestHeader
    {
        public const string Authorization = "Authorization";
        public const string ApiKey = "ApiKey";
    }

    #endregion request headers

    #region database Ids

    public static class DatabaseKey
    {
        public const int FootballCategoryId = 1;
        public const string DefaultLeagueCode = "NULL";

        public static class OddsTypeId
        {
            public const int FinalOver15 = 1;
            public const int FinalUnder15 = 2;
            public const int Over25 = 3;
            public const int Under25 = 4;
            public const int FinalOver35 = 5;
            public const int FinalUnder35 = 6;
            public const int Final12 = 7;
            public const int Final10 = 8;
            public const int Final02 = 9;
            public const int Final1 = 10;
            public const int Final0 = 11;
            public const int Final2 = 12;
            public const int SumOfGoals01 = 13;
            public const int SumOfGoals23 = 14;
            public const int SumOfGoals46 = 15;
            public const int SumOfGoals7 = 16;
            public const int Half1 = 20;
            public const int Half0 = 21;
            public const int Half2 = 22;
            public const int HalfTimeOver15 = 23;
            public const int HalfTimeUnder15 = 24;
            public const int Goal = 25;
            public const int NoGoal = 26;
        }
    }

    #endregion database Ids
}


