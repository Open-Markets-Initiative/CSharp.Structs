// C# Structs For Nasdaq Psx Itch TotalView 5.0 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Authenticity Values
/// </summary>
public enum Authenticity : byte {
    LiveProduction = (byte)'P',
    Test = (byte)'T',
};

/// <summary>
///  Breached Level Values
/// </summary>
public enum BreachedLevel : byte {
    Level1 = (byte)'1',
    Level2 = (byte)'2',
    Level3 = (byte)'3',
};

/// <summary>
///  Buy Sell Indicator Values
/// </summary>
public enum BuySellIndicator : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
};

/// <summary>
///  Cross Type Values
/// </summary>
public enum CrossType : byte {
    OpeningCross = (byte)'O',
    ClosingCross = (byte)'C',
    CrossHaltedOrPaused = (byte)'H',
    IntradayCrossAndPostCloseCross = (byte)'I',
};

/// <summary>
///  Etp Flag Values
/// </summary>
public enum EtpFlag : byte {
    Etp = (byte)'Y',
    NotEtp = (byte)'N',
    Na = (byte)' ',
};

/// <summary>
///  Event Code Values
/// </summary>
public enum EventCode : byte {
    StartOfMessages = (byte)'O',
    StartOfSystemHours = (byte)'S',
    StartOfMarketHours = (byte)'Q',
    EndOfMarketHours = (byte)'M',
    EndOfSystemHours = (byte)'E',
    EndOfMessages = (byte)'C',
};

/// <summary>
///  Financial Status Indicator Values
/// </summary>
public enum FinancialStatusIndicator : byte {
    Deficient = (byte)'D',
    Delinquent = (byte)'E',
    Bankrupt = (byte)'Q',
    Suspended = (byte)'S',
    DeficientAndBankrupt = (byte)'G',
    DeficientAndDelinquent = (byte)'H',
    DelinquentAndBankrupt = (byte)'J',
    DeficientDelinquentAndBankrupt = (byte)'K',
    CreationsAndRedemptionsSuspended = (byte)'C',
    Normal = (byte)'N',
    Na = (byte)' ',
};

/// <summary>
///  Imbalance Direction Values
/// </summary>
public enum ImbalanceDirection : byte {
    Buy = (byte)'B',
    Sell = (byte)'S',
    NoImbalance = (byte)'N',
    InsufficientOrders = (byte)'O',
};

/// <summary>
///  Inverse Indicator Values
/// </summary>
public enum InverseIndicator : byte {
    InverseEtp = (byte)'Y',
    NotInverseEtp = (byte)'N',
};

/// <summary>
///  Ipo Flag Values
/// </summary>
public enum IpoFlag : byte {
    NasdaqListedInstrument = (byte)'Y',
    NasdaqListedInstrument = (byte)'N',
    Na = (byte)' ',
};

/// <summary>
///  Luld Reference Price Tier Values
/// </summary>
public enum LuldReferencePriceTier : byte {
    Tier1 = (byte)'1',
    Tier2 = (byte)'2',
    Na = (byte)' ',
};

/// <summary>
///  Market Category Values
/// </summary>
public enum MarketCategory : byte {
    NasdaqGlobalSelectMarket = (byte)'Q',
    NasdaqGlobalMarket = (byte)'G',
    NasdaqCapitalMarket = (byte)'S',
    Nyse = (byte)'N',
    NyseMkt = (byte)'A',
    NyseArca = (byte)'P',
    BatsZ = (byte)'Z',
    InvestorsExchange = (byte)'V',
    Na = (byte)' ',
};

/// <summary>
///  Market Code Values
/// </summary>
public enum MarketCode : byte {
    Nasdaq = (byte)'Q',
    Bx = (byte)'B',
    Psx = (byte)'X',
};

/// <summary>
///  Market Maker Mode Values
/// </summary>
public enum MarketMakerMode : byte {
    Normal = (byte)'N',
    Passive = (byte)'P',
    Syndicate = (byte)'S',
    PreSyndicate = (byte)'R',
    Penalty = (byte)'L',
};

/// <summary>
///  Market Participant State Values
/// </summary>
public enum MarketParticipantState : byte {
    Active = (byte)'A',
    ExcusedWithdrawn = (byte)'E',
    Withdrawn = (byte)'W',
    Suspended = (byte)'S',
    Deleted = (byte)'D',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    SystemEventMessage = (byte)'S',
    StockDirectoryMessage = (byte)'R',
    StockTradingActionMessage = (byte)'H',
    RegShoShortSalePriceTestRestrictedIndicatorMessage = (byte)'Y',
    MarketParticipantPositionMessage = (byte)'L',
    MwcbDeclineLevelMessage = (byte)'V',
    MwcbStatusLevelMessage = (byte)'W',
    LuldAuctionCollarMessage = (byte)'J',
    OperationalHaltMessage = (byte)'h',
    AddOrderNoMpidAttributionMessage = (byte)'A',
    AddOrderWithMpidAttributionMessage = (byte)'F',
    OrderExecutedMessage = (byte)'E',
    OrderExecutedWithPriceMessage = (byte)'C',
    OrderCancelMessage = (byte)'X',
    OrderDeleteMessage = (byte)'D',
    OrderReplaceMessage = (byte)'U',
    TradeMessageNonCross = (byte)'P',
    CrossTradeMessage = (byte)'Q',
    BrokenTradeMessage = (byte)'B',
    NetOrderImbalanceIndicatorMessage = (byte)'I',
};

/// <summary>
///  Operational Halt Action Values
/// </summary>
public enum OperationalHaltAction : byte {
    Halted = (byte)'H',
    Resumed = (byte)'T',
};

/// <summary>
///  Price Variation Indicator Values
/// </summary>
public enum PriceVariationIndicator : byte {
    LessThan1 = (byte)'L',
    1To199 = (byte)'1',
    2To299 = (byte)'2',
    3To399 = (byte)'3',
    4To499 = (byte)'4',
    5To599 = (byte)'5',
    6To699 = (byte)'6',
    7To799 = (byte)'7',
    8To899 = (byte)'8',
    9To999 = (byte)'9',
    10To1999 = (byte)'A',
    20To2999 = (byte)'B',
    30OrGreater = (byte)'C',
    NoCalculation = (byte)' ',
};

/// <summary>
///  Primary Market Maker Values
/// </summary>
public enum PrimaryMarketMaker : byte {
    Primary = (byte)'Y',
    NonPrimary = (byte)'N',
};

/// <summary>
///  Printable Values
/// </summary>
public enum Printable : byte {
    NonPrintable = (byte)'N',
    Printable = (byte)'Y',
};

/// <summary>
///  Reg Sho Action Values
/// </summary>
public enum RegShoAction : byte {
    NoPriceTest = (byte)'0',
    RegShoShortSalePriceTestRestriction = (byte)'1',
    TestRestrictionRemains = (byte)'2',
};

/// <summary>
///  Round Lots Only Values
/// </summary>
public enum RoundLotsOnly : byte {
    NasdaqPsx = (byte)'Y',
    NasdaqPsx = (byte)'N',
};

/// <summary>
///  Short Sale Threshold Indicator Values
/// </summary>
public enum ShortSaleThresholdIndicator : byte {
    Restricted = (byte)'Y',
    NotRestricted = (byte)'N',
    Na = (byte)' ',
};

/// <summary>
///  Trading State Values
/// </summary>
public enum TradingState : byte {
    Halted = (byte)'H',
    Paused = (byte)'P',
    QuotationOnlyPeriod = (byte)'Q',
    Trading = (byte)'T',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Add Order No Mpid Attribution Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddOrderNoMpidAttributionMessage {
    public ushort StockLocate;
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong OrderReferenceNumber;
    public BuySellIndicator BuySellIndicator;
    public uint Shares;
    public fixed sbyte Stock[8];
    public int Price;
};

/// <summary>
///  Struct for Add Order With Mpid Attribution Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct AddOrderWithMpidAttributionMessage {
    public ushort StockLocate;
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong OrderReferenceNumber;
    public BuySellIndicator BuySellIndicator;
    public uint Shares;
    public fixed sbyte Stock[8];
    public int Price;
    public fixed sbyte Attribution[4];
};

/// <summary>
///  Struct for Broken Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct BrokenTradeMessage {
    public ushort StockLocate;
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong MatchNumber;
};

/// <summary>
///  Struct for Cross Trade Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossTradeMessage {
    public ushort StockLocate;
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong CrossShares;
    public fixed sbyte Stock[8];
    public int CrossPrice;
    public ulong MatchNumber;
    public CrossType CrossType;
};

/// <summary>
///  Struct for Luld Auction Collar Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LuldAuctionCollarMessage {
    public ushort StockLocate;
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public fixed sbyte Stock[8];
    public int AuctionCollarReferencePrice;
    public int UpperAuctionCollarPrice;
    public int LowerAuctionCollarPrice;
    public uint AuctionCollarExtension;
};

/// <summary>
///  Struct for Market Participant Position Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MarketParticipantPositionMessage {
    public ushort StockLocate;
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public fixed sbyte Mpid[4];
    public fixed sbyte Stock[8];
    public PrimaryMarketMaker PrimaryMarketMaker;
    public MarketMakerMode MarketMakerMode;
    public MarketParticipantState MarketParticipantState;
};

/// <summary>
///  Struct for Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Message {
    public fixed byte MessageHeader[0];
};

/// <summary>
///  Struct for Message Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MessageHeader {
    public ushort Length;
    public MessageType MessageType;
};

/// <summary>
///  Struct for Mwcb Decline Level Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MwcbDeclineLevelMessage {
    public ushort StockLocate;
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public long Level1;
    public long Level2;
    public long Level3;
};

/// <summary>
///  Struct for Mwcb Status Level Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MwcbStatusLevelMessage {
    public ushort StockLocate;
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public BreachedLevel BreachedLevel;
};

/// <summary>
///  Struct for Net Order Imbalance Indicator Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NetOrderImbalanceIndicatorMessage {
    public ushort StockLocate;
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong PairedShares;
    public ulong ImbalanceShares;
    public ImbalanceDirection ImbalanceDirection;
    public fixed sbyte Stock[8];
    public int FarPrice;
    public int NearPrice;
    public int CurrentReferencePrice;
    public CrossType CrossType;
    public PriceVariationIndicator PriceVariationIndicator;
};

/// <summary>
///  Struct for Operational Halt Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OperationalHaltMessage {
    public ushort StockLocate;
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public fixed sbyte Stock[8];
    public MarketCode MarketCode;
    public OperationalHaltAction OperationalHaltAction;
};

/// <summary>
///  Struct for Order Cancel Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelMessage {
    public ushort StockLocate;
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong OrderReferenceNumber;
    public uint CanceledShares;
};

/// <summary>
///  Struct for Order Delete Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderDeleteMessage {
    public ushort StockLocate;
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong OrderReferenceNumber;
};

/// <summary>
///  Struct for Order Executed Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutedMessage {
    public ushort StockLocate;
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong OrderReferenceNumber;
    public uint ExecutedShares;
    public ulong MatchNumber;
};

/// <summary>
///  Struct for Order Executed With Price Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutedWithPriceMessage {
    public ushort StockLocate;
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong OrderReferenceNumber;
    public uint ExecutedShares;
    public ulong MatchNumber;
    public Printable Printable;
    public int ExecutionPrice;
};

/// <summary>
///  Struct for Order Replace Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderReplaceMessage {
    public ushort StockLocate;
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong OriginalOrderReferenceNumber;
    public ulong NewOrderReferenceNumber;
    public uint Shares;
    public int Price;
};

/// <summary>
///  Struct for Packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct Packet {
    public fixed byte PacketHeader[0];
};

/// <summary>
///  Struct for Packet Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PacketHeader {
    public fixed sbyte Session[10];
    public ulong Sequence;
    public ushort Count;
};

/// <summary>
///  Struct for Reg Sho Short Sale Price Test Restricted Indicator Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RegShoShortSalePriceTestRestrictedIndicatorMessage {
    public ushort LocateCode;
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public fixed sbyte Stock[8];
    public RegShoAction RegShoAction;
};

/// <summary>
///  Struct for Stock Directory Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StockDirectoryMessage {
    public ushort StockLocate;
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public fixed sbyte Stock[8];
    public MarketCategory MarketCategory;
    public FinancialStatusIndicator FinancialStatusIndicator;
    public uint RoundLotSize;
    public RoundLotsOnly RoundLotsOnly;
    public fixed sbyte IssueClassification[1];
    public fixed sbyte IssueSubType[2];
    public Authenticity Authenticity;
    public ShortSaleThresholdIndicator ShortSaleThresholdIndicator;
    public IpoFlag IpoFlag;
    public LuldReferencePriceTier LuldReferencePriceTier;
    public EtpFlag EtpFlag;
    public uint EtpLeverageFactor;
    public InverseIndicator InverseIndicator;
};

/// <summary>
///  Struct for Stock Trading Action Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct StockTradingActionMessage {
    public ushort StockLocate;
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public fixed sbyte Stock[8];
    public TradingState TradingState;
    public fixed sbyte Reserved[1];
    public fixed sbyte Reason[4];
};

/// <summary>
///  Struct for System Event Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct SystemEventMessage {
    public ushort StockLocate;
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public EventCode EventCode;
};

/// <summary>
///  Struct for Trade Message Non Cross
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeMessageNonCross {
    public ushort StockLocate;
    public ushort TrackingNumber;
    public fixed byte Timestamp;
    public ulong OrderReferenceNumber;
    public BuySellIndicator BuySellIndicator;
    public uint Shares;
    public fixed sbyte Stock[8];
    public int Price;
    public ulong MatchNumber;
};

