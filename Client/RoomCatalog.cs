namespace Lakka_Mobilya_Web.Client;

public sealed record RoomInfo(string Slug, string Name, string[] Images);

public static class RoomCatalog
{
    public static readonly IReadOnlyList<RoomInfo> All = new[]
    {
        new RoomInfo("oturma-odasi",  "Oturma Odası",  Array.Empty<string>()),
        new RoomInfo("yemek-odasi",   "Yemek Odası",   Array.Empty<string>()),
        new RoomInfo("yatak-odasi",   "Yatak Odası",   new[] { "images/odalar/yatak-odasi/Yatak_Odasi.jpeg" }),
        new RoomInfo("calisma-odasi", "Çalışma Odası", new[] { "images/odalar/calisma-odasi/calisma_odası_1.jpeg" }),
        new RoomInfo("cocuk-odasi",   "Çocuk Odası",   new[] { "images/odalar/cocuk-odasi/Cocuk_Odasi_1.jpg" }),
        new RoomInfo("antre",         "Antre",         new[] { "images/odalar/antre/Antre_1.jpeg" }),
        new RoomInfo("banyo",         "Banyo",         new[] { "images/odalar/banyo/Banyo_1.jpeg" }),
    };

    public static RoomInfo? FindBySlug(string? slug) =>
        string.IsNullOrWhiteSpace(slug)
            ? null
            : All.FirstOrDefault(r => string.Equals(r.Slug, slug, StringComparison.OrdinalIgnoreCase));
}
