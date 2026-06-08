namespace Lakka_Mobilya_Web.Client;

public sealed record FurnitureInfo(string Slug, string Name, string[] Images, string?[]? HoverImages = null);

public static class FurnitureCatalog
{
    public static readonly IReadOnlyList<FurnitureInfo> All = new[]
    {
        new FurnitureInfo("koltuklar",       "Koltuklar",      Array.Empty<string>()),
        new FurnitureInfo("berjerler",       "Berjerler",      Array.Empty<string>()),
        new FurnitureInfo("yemek-masalari",  "Yemek Masaları", Array.Empty<string>()),
        new FurnitureInfo("sandalyeler",     "Sandalyeler",    Array.Empty<string>()),
        new FurnitureInfo("yatak-bazalari",  "Yatak Bazaları", Array.Empty<string>()),
        new FurnitureInfo("gardiroplar",     "Gardıroplar",    Array.Empty<string>()),
        new FurnitureInfo("komodinler",      "Komodinler",     Array.Empty<string>()),
        new FurnitureInfo("sehpalar",        "Sehpalar",
            new[] { "images/mobilya/sehpalar/sehpa.png" },
            HoverImages: new string?[] { "images/mobilya/sehpalar/sehpa_2.png" }),
        new FurnitureInfo("tv-uniteleri",    "TV Üniteleri",   Array.Empty<string>()),
    };

    public static FurnitureInfo? FindBySlug(string? slug) =>
        string.IsNullOrWhiteSpace(slug)
            ? null
            : All.FirstOrDefault(f => string.Equals(f.Slug, slug, StringComparison.OrdinalIgnoreCase));
}
