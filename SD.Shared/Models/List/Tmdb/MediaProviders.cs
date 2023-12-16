﻿namespace SD.Shared.Models.List.Tmdb
{
    public class ProviderBase
    {
        public int display_priority { get; set; }
        public string? logo_path { get; set; }
        public int provider_id { get; set; }
        public string? provider_name { get; set; }
        public string? provider_desciption { get; set; }
        public string? provider_link { get; set; }
    }

    public class Free : ProviderBase
    { }

    public class Ads : ProviderBase
    { }

    public class Flatrate : ProviderBase
    { }

    public class FlatrateAndBuy : ProviderBase
    { }

    public class Rent : ProviderBase
    { }

    public class Buy : ProviderBase
    { }

    public class CountryBase
    {
        public string? link { get; set; }
        public List<Free> free { get; set; } = [];
        public List<Ads> ads { get; set; } = [];
        public List<Flatrate> flatrate { get; set; } = [];
        public List<FlatrateAndBuy> flatrate_and_buy { get; set; } = [];
        public List<Rent> rent { get; set; } = [];
        public List<Buy> buy { get; set; } = [];
    }

    public class AE : CountryBase
    { }

    public class AR : CountryBase
    { }

    public class AT : CountryBase
    { }

    public class AU : CountryBase
    { }

    public class BE : CountryBase
    { }

    public class BG : CountryBase
    { }

    public class BR : CountryBase
    { }

    public class CA : CountryBase
    { }

    public class CH : CountryBase
    { }

    public class CI : CountryBase
    { }

    public class CL : CountryBase
    { }

    public class CO : CountryBase
    { }

    public class CZ : CountryBase
    { }

    public class DE : CountryBase
    { }

    public class DK : CountryBase
    { }

    public class EC : CountryBase
    { }

    public class EE : CountryBase
    { }

    public class ES : CountryBase
    { }

    public class FI : CountryBase
    { }

    public class FR : CountryBase
    { }

    public class GB : CountryBase
    { }

    public class HK : CountryBase
    { }

    public class HR : CountryBase
    { }

    public class GR : CountryBase
    { }

    public class HU : CountryBase
    { }

    public class ID : CountryBase
    { }

    public class IE : CountryBase
    { }

    public class IN : CountryBase
    { }

    public class IT : CountryBase
    { }

    public class JP : CountryBase
    { }

    public class KE : CountryBase
    { }

    public class KR : CountryBase
    { }

    public class LT : CountryBase
    { }

    public class LV : CountryBase
    { }

    public class MX : CountryBase
    { }

    public class MY : CountryBase
    { }

    public class NL : CountryBase
    { }

    public class NO : CountryBase
    { }

    public class NZ : CountryBase
    { }

    public class PE : CountryBase
    { }

    public class PH : CountryBase
    { }

    public class PL : CountryBase
    { }

    public class PT : CountryBase
    { }

    public class RS : CountryBase
    { }

    public class RO : CountryBase
    { }

    public class RU : CountryBase
    { }

    public class SE : CountryBase
    { }

    public class SK : CountryBase
    { }

    public class SG : CountryBase
    { }

    public class TH : CountryBase
    { }

    public class TR : CountryBase
    { }

    public class US : CountryBase
    { }

    public class VE : CountryBase
    { }

    public class ZA : CountryBase
    { }

    public class Results
    {
        public AE? AE { get; set; }
        public AR? AR { get; set; }
        public AT? AT { get; set; }
        public AU? AU { get; set; }
        public BE? BE { get; set; }
        public BG? BG { get; set; }
        public BR? BR { get; set; }
        public CA? CA { get; set; }
        public CH? CH { get; set; }
        public CI? CI { get; set; }
        public CL? CL { get; set; }
        public CO? CO { get; set; }
        public CZ? CZ { get; set; }
        public DE? DE { get; set; }
        public DK? DK { get; set; }
        public EC? EC { get; set; }
        public EE? EE { get; set; }
        public ES? ES { get; set; }
        public FI? FI { get; set; }
        public FR? FR { get; set; }
        public GB? GB { get; set; }
        public HK? HK { get; set; }
        public HR? HR { get; set; }
        public GR? GR { get; set; }
        public HU? HU { get; set; }
        public ID? ID { get; set; }
        public IE? IE { get; set; }
        public IN? IN { get; set; }
        public IT? IT { get; set; }
        public JP? JP { get; set; }
        public KE? KE { get; set; }
        public KR? KR { get; set; }
        public LT? LT { get; set; }
        public LV? LV { get; set; }
        public MX? MX { get; set; }
        public MY? MY { get; set; }
        public NL? NL { get; set; }
        public NO? NO { get; set; }
        public NZ? NZ { get; set; }
        public PE? PE { get; set; }
        public PH? PH { get; set; }
        public PL? PL { get; set; }
        public PT? PT { get; set; }
        public RS? RS { get; set; }
        public RO? RO { get; set; }
        public RU? RU { get; set; }
        public SE? SE { get; set; }
        public SK? SK { get; set; }
        public SG? SG { get; set; }
        public TH? TH { get; set; }
        public TR? TR { get; set; }
        public US? US { get; set; }
        public VE? VE { get; set; }
        public ZA? ZA { get; set; }
    }

    public class MediaProviders
    {
        public int id { get; set; }
        public Results? results { get; set; }

        public string? GetLink(Region region)
        {
            if (results == null) return "";

            return region switch
            {
                Region.AE => results.AE?.link,
                Region.AR => results.AR?.link,
                Region.AT => results.AT?.link,
                Region.AU => results.AU?.link,
                Region.BE => results.BE?.link,
                Region.BG => results.BG?.link,
                Region.BR => results.BR?.link,
                Region.CA => results.CA?.link,
                Region.CH => results.CH?.link,
                Region.CI => results.CI?.link,
                Region.CZ => results.CZ?.link,
                Region.DE => results.DE?.link,
                Region.DK => results.DK?.link,
                Region.EE => results.EE?.link,
                Region.ES => results.ES?.link,
                Region.FI => results.FI?.link,
                Region.FR => results.FR?.link,
                Region.GB => results.GB?.link,
                Region.HK => results.HK?.link,
                Region.HR => results.HR?.link,
                Region.HU => results.HU?.link,
                Region.ID => results.ID?.link,
                Region.IE => results.IE?.link,
                Region.IN => results.IN?.link,
                Region.IT => results.IT?.link,
                Region.JP => results.JP?.link,
                Region.KE => results.KE?.link,
                Region.KR => results.KR?.link,
                Region.LT => results.LT?.link,
                Region.MX => results.MX?.link,
                Region.NL => results.NL?.link,
                Region.NO => results.NO?.link,
                Region.NZ => results.NZ?.link,
                Region.PH => results.PH?.link,
                Region.PL => results.PL?.link,
                Region.PT => results.PT?.link,
                Region.RS => results.RS?.link,
                Region.RU => results.RU?.link,
                Region.SE => results.SE?.link,
                Region.SK => results.SK?.link,
                Region.TR => results.TR?.link,
                Region.US => results.US?.link,
                Region.ZA => results.ZA?.link,
                _ => default,
            };
        }

        public List<ProviderBase> GetFreeListProviders(Region region)
        {
            if (results == null) return [];

            return region switch
            {
                Region.AE => results.AE?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.AR => results.AR?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.AT => results.AT?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.AU => results.AU?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.BE => results.BE?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.BG => results.BG?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.BR => results.BR?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.CA => results.CA?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.CH => results.CH?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.CI => results.CI?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.CZ => results.CZ?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.DE => results.DE?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.DK => results.DK?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.EE => results.EE?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.ES => results.ES?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.FI => results.FI?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.FR => results.FR?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.GB => results.GB?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.HK => results.HK?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.HR => results.HR?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.HU => results.HU?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.ID => results.ID?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.IE => results.IE?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.IN => results.IN?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.IT => results.IT?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.JP => results.JP?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.KE => results.KE?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.KR => results.KR?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.LT => results.LT?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.MX => results.MX?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.NL => results.NL?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.NO => results.NO?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.NZ => results.NZ?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.PH => results.PH?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.PL => results.PL?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.PT => results.PT?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.RS => results.RS?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.RU => results.RU?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.SE => results.SE?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.SK => results.SK?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.TR => results.TR?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.US => results.US?.free.Cast<ProviderBase>().ToList() ?? [],
                Region.ZA => results.ZA?.free.Cast<ProviderBase>().ToList() ?? [],
                _ => [],
            };
        }

        public IEnumerable<ProviderBase> GetAdsListProviders(Region region)
        {
            if (results == null) return Array.Empty<ProviderBase>();

            return region switch
            {
                Region.AE => results.AE?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.AR => results.AR?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.AT => results.AT?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.AU => results.AU?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.BE => results.BE?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.BG => results.BG?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.BR => results.BR?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.CA => results.CA?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.CH => results.CH?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.CI => results.CI?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.CZ => results.CZ?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.DE => results.DE?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.DK => results.DK?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.EE => results.EE?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.ES => results.ES?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.FI => results.FI?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.FR => results.FR?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.GB => results.GB?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.HK => results.HK?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.HR => results.HR?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.HU => results.HU?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.ID => results.ID?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.IE => results.IE?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.IN => results.IN?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.IT => results.IT?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.JP => results.JP?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.KE => results.KE?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.KR => results.KR?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.LT => results.LT?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.MX => results.MX?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.NL => results.NL?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.NO => results.NO?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.NZ => results.NZ?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.PH => results.PH?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.PL => results.PL?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.PT => results.PT?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.RS => results.RS?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.RU => results.RU?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.SE => results.SE?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.SK => results.SK?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.TR => results.TR?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.US => results.US?.ads.Cast<ProviderBase>().ToList() ?? [],
                Region.ZA => results.ZA?.ads.Cast<ProviderBase>().ToList() ?? [],
                _ => [],
            };
        }

        public IEnumerable<ProviderBase> GetFlatRateListProviders(Region region)
        {
            if (results == null) return Array.Empty<ProviderBase>();

            return region switch
            {
                Region.AE => results.AE?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.AR => results.AR?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.AT => results.AT?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.AU => results.AU?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.BE => results.BE?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.BG => results.BG?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.BR => results.BR?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.CA => results.CA?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.CH => results.CH?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.CI => results.CI?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.CZ => results.CZ?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.DE => results.DE?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.DK => results.DK?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.EE => results.EE?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.ES => results.ES?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.FI => results.FI?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.FR => results.FR?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.GB => results.GB?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.HK => results.HK?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.HR => results.HR?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.HU => results.HU?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.ID => results.ID?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.IE => results.IE?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.IN => results.IN?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.IT => results.IT?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.JP => results.JP?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.KE => results.KE?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.KR => results.KR?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.LT => results.LT?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.MX => results.MX?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.NL => results.NL?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.NO => results.NO?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.NZ => results.NZ?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.PH => results.PH?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.PL => results.PL?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.PT => results.PT?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.RS => results.RS?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.RU => results.RU?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.SE => results.SE?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.SK => results.SK?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.TR => results.TR?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.US => results.US?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                Region.ZA => results.ZA?.flatrate.Cast<ProviderBase>().ToList() ?? [],
                _ => [],
            };
        }

        public IEnumerable<ProviderBase> GetFlatRateBuyListProviders(Region region)
        {
            if (results == null) return Array.Empty<ProviderBase>();

            return region switch
            {
                Region.AE => results.AE?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.AR => results.AR?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.AT => results.AT?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.AU => results.AU?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.BE => results.BE?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.BG => results.BG?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.BR => results.BR?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.CA => results.CA?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.CH => results.CH?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.CI => results.CI?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.CZ => results.CZ?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.DE => results.DE?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.DK => results.DK?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.EE => results.EE?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.ES => results.ES?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.FI => results.FI?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.FR => results.FR?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.GB => results.GB?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.HK => results.HK?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.HR => results.HR?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.HU => results.HU?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.ID => results.ID?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.IE => results.IE?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.IN => results.IN?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.IT => results.IT?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.JP => results.JP?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.KE => results.KE?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.KR => results.KR?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.LT => results.LT?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.MX => results.MX?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.NL => results.NL?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.NO => results.NO?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.NZ => results.NZ?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.PH => results.PH?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.PL => results.PL?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.PT => results.PT?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.RS => results.RS?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.RU => results.RU?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.SE => results.SE?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.SK => results.SK?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.TR => results.TR?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.US => results.US?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                Region.ZA => results.ZA?.flatrate_and_buy.Cast<ProviderBase>().ToList() ?? [],
                _ => [],
            };
        }

        public IEnumerable<ProviderBase> GetRentListProviders(Region region)
        {
            if (results == null) return Array.Empty<ProviderBase>();

            return region switch
            {
                Region.AE => results.AE?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.AR => results.AR?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.AT => results.AT?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.AU => results.AU?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.BE => results.BE?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.BG => results.BG?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.BR => results.BR?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.CA => results.CA?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.CH => results.CH?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.CI => results.CI?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.CZ => results.CZ?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.DE => results.DE?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.DK => results.DK?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.EE => results.EE?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.ES => results.ES?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.FI => results.FI?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.FR => results.FR?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.GB => results.GB?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.HK => results.HK?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.HR => results.HR?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.HU => results.HU?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.ID => results.ID?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.IE => results.IE?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.IN => results.IN?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.IT => results.IT?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.JP => results.JP?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.KE => results.KE?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.KR => results.KR?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.LT => results.LT?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.MX => results.MX?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.NL => results.NL?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.NO => results.NO?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.NZ => results.NZ?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.PH => results.PH?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.PL => results.PL?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.PT => results.PT?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.RS => results.RS?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.RU => results.RU?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.SE => results.SE?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.SK => results.SK?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.TR => results.TR?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.US => results.US?.rent.Cast<ProviderBase>().ToList() ?? [],
                Region.ZA => results.ZA?.rent.Cast<ProviderBase>().ToList() ?? [],
                _ => [],
            };
        }

        public IEnumerable<ProviderBase> GetBuyListProviders(Region region)
        {
            if (results == null) return Array.Empty<ProviderBase>();

            return region switch
            {
                Region.AE => results.AE?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.AR => results.AR?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.AT => results.AT?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.AU => results.AU?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.BE => results.BE?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.BG => results.BG?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.BR => results.BR?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.CA => results.CA?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.CH => results.CH?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.CI => results.CI?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.CZ => results.CZ?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.DE => results.DE?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.DK => results.DK?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.EE => results.EE?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.ES => results.ES?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.FI => results.FI?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.FR => results.FR?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.GB => results.GB?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.HK => results.HK?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.HR => results.HR?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.HU => results.HU?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.ID => results.ID?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.IE => results.IE?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.IN => results.IN?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.IT => results.IT?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.JP => results.JP?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.KE => results.KE?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.KR => results.KR?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.LT => results.LT?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.MX => results.MX?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.NL => results.NL?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.NO => results.NO?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.NZ => results.NZ?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.PH => results.PH?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.PL => results.PL?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.PT => results.PT?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.RS => results.RS?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.RU => results.RU?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.SE => results.SE?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.SK => results.SK?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.TR => results.TR?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.US => results.US?.buy.Cast<ProviderBase>().ToList() ?? [],
                Region.ZA => results.ZA?.buy.Cast<ProviderBase>().ToList() ?? [],
                _ => [],
            };
        }
    }

    public class TMDB_AllProviders
    {
        public List<ProviderBase> results { get; set; } = [];
    }
}