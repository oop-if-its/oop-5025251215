// File ini berisi TODO -- lihat SOAL.md untuk kontrak lengkap tiap level.
// Bagian bertanda TODO(Level N) adalah tugas kalian; kode lain sudah
// disediakan. Jangan mengubah nama/tipe yang sudah ada kecuali TODO
// memintanya secara eksplisit.

namespace Pertemuan06;

// Overloading (dipilih oleh KOMPILATOR berdasarkan tipe variabel) berbeda dari
// overriding (dipilih saat PROGRAM BERJALAN berdasarkan tipe objek sebenarnya).
public class Pemroses
{
    public string Proses(Item item)
    {
        return $"Item: {item.Judul}";
    }

    public string Proses(Buku buku)
    {
        return $"Buku: {buku.Judul}";
    }

    public string Proses(Majalah majalah)
    {
        return $"Majalah: {majalah.Judul}";
    }

    public string Kategori(Item item)
    {
        if (item is null)
            throw new ArgumentNullException(nameof(item));

        return item switch
        {
            Buku    => "Buku",
            Majalah => "Majalah",
            Dvd     => "DVD",
            _       => "Item"
        };
    }
}