// File ini berisi TODO -- lihat SOAL.md untuk kontrak lengkap tiap level.
// Bagian bertanda TODO(Level N) adalah tugas kalian; kode lain sudah
// disediakan. Jangan mengubah nama/tipe yang sudah ada kecuali TODO
// memintanya secara eksplisit.

using System.Linq;

namespace Pertemuan06;

// Type casting & type checking: mengambil kembali tipe turunan dari variabel
// bertipe induk.
public static class PemilahItem
{
    // Level 7
    public static List<Buku> AmbilBuku(IEnumerable<Item> daftar)
    {
        if (daftar is null)
            throw new ArgumentNullException(nameof(daftar));

        return daftar.OfType<Buku>().ToList();
    }

    // Level 7
    public static string? PenulisAtauNull(Item item)
    {
        if (item is Buku b)
            return b.Penulis;
        return null;
    }

    // Level 8 (BELUM — biarkan dulu)
    public static Buku KeBuku(Item item)
    {
        throw new NotImplementedException("Level 8 belum diimplementasikan");
    }

    // Level 8 (BELUM — biarkan dulu)
    public static bool CobaKeBuku(Item? item, out Buku? buku)
    {
        throw new NotImplementedException("Level 8 belum diimplementasikan");
    }
}