namespace Common.Enumerations
{
    public enum AuthenticationMode
    {
        Network = 0,
        Application = 1,
        Both = 2,
        None = 3,
        BothSecure = 4
    }

    public enum DataExportType
    {
        FromPage,
        FromPopUp
    }

    public enum DataLoadType
    {
        AsPage,
        AsModalBox
    }
    public enum ColumnDataFormat
    {
        Default,
        Date,
        Money
    }

    public enum ColumnDataType
    {
        Text,
        LinkButton,
        ImageButton,
    }

    public enum DataSearchType
    {
        Text,
        Dropdown,
        DatePicker,
        DateRangePicker
    }

    public enum ExportType
    {
        Undefined = -1,
        Product = 0,
        Category = 1
    }

    public enum Status
    {
        Active,
        Passive,
        Suspended,
        Deleted
    }

    public enum Condition
    {
        Ok,
        Injured, // sakat
        Missing, //cezali
        Resting // dinlendiriliyor
    }

    public enum CatalogVersion
    {
        Demo,
        Standart,
        Professional
    }

    public enum TemplateType
    {
        Default,
        Food,
        WhiteAppliances // beyaz esya
    }

    public enum Key
    {
        Tag,
        Discount,
        Image,
        Video
    }

    public enum ResponseCode
    {
        Fail = -1,
        Success = 0,
        Warning = 1,
        Info = 2,
        NoEffect = 3
    }

    public enum WebMethodType
    {
        Null,
        Get,
        Post,
        Put,
        Info,
        NoEffect
    }

    public enum ContentType
    {
        Null,
        FormUrlencoded
    }

    public enum BettingType
    {
        All,
        Player
    }

    public enum BetSiteId
    {
        Rivalo = 1,
        TempoBet
    }

    public enum PredictonStake
    {
        Stake1 = 1,
        Stake2,
        Stake3,
        Stake4,
        Stake5,
        Stake6,
        Stake7,
        Stake8,
        Stake9,
        Stake10
    }

    public enum PredictionResult
    {
        Pending,
        Won,
        Lost,
        Canceled
    }

    public enum AccountType
    {
        Trial,
        Standart,
        Premium
    }
}