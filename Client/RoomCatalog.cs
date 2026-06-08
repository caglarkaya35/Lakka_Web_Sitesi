namespace Lakka_Mobilya_Web.Client;

public sealed record RoomInfo(string Slug, string Name, string[] Images);

public static class RoomCatalog
{
    public static readonly IReadOnlyList<RoomInfo> All = new[]
    {
        new RoomInfo("oturma-odasi",  "Oturma Odası",  new[]
        {
            "images/odalar/oturma-odasi/Oturma_Odasi_1.jpeg",
        }),
        new RoomInfo("yemek-odasi",   "Yemek Odası",   Array.Empty<string>()),
        new RoomInfo("yatak-odasi",   "Yatak Odası",   new[] { "images/odalar/yatak-odasi/Yatak_Odasi.jpeg" }),
        new RoomInfo("calisma-odasi", "Çalışma Odası", new[]
        {
            "images/odalar/calisma-odasi/calisma_odası_1.jpeg",
            "images/odalar/calisma-odasi/Calisma_Odasi_2.jpeg",
            "images/odalar/calisma-odasi/Calisma_Odasi_3.jpeg",
            "images/odalar/calisma-odasi/Calisma_Odasi_4.jpeg",
            "images/odalar/calisma-odasi/Calisma_Odasi_5.jpeg",
            "images/odalar/calisma-odasi/Calisma_Odasi_6.jpeg",
            "images/odalar/calisma-odasi/Calisma_Odasi_7.jpeg",
            "images/odalar/calisma-odasi/Calisma_Odasi_8.jpeg",
            "images/odalar/calisma-odasi/Calisma_Odasi_9.jpeg",
            "images/odalar/calisma-odasi/Calisma_Odasi_10.jpeg",
            "images/odalar/calisma-odasi/Calisma_Odasi_11.jpeg",
        }),
        new RoomInfo("cocuk-odasi",   "Çocuk Odası",   new[] { "images/odalar/cocuk-odasi/Cocuk_Odasi_1.jpg" }),
        new RoomInfo("antre",         "Antre",         new[] { "images/odalar/antre/Antre_1.jpeg" }),
        new RoomInfo("banyo",         "Banyo",         new[]
        {
            "images/odalar/banyo/Banyo_1.jpeg",
            "images/odalar/banyo/Banyo_2.jpg",
            "images/odalar/banyo/Banyo_3.jpg",
        }),
    };

    public static RoomInfo? FindBySlug(string? slug) =>
        string.IsNullOrWhiteSpace(slug)
            ? null
            : All.FirstOrDefault(r => string.Equals(r.Slug, slug, StringComparison.OrdinalIgnoreCase));
}
