// File ini berisi TODO -- lihat SOAL.md untuk kontrak lengkap tiap level.
// Bagian bertanda TODO(Level N) adalah tugas kalian; kode lain sudah
// disediakan. Jangan mengubah nama/tipe yang sudah ada kecuali TODO
// memintanya secara eksplisit.

namespace Pertemuan06;

// SUDAH LENGKAP -- jangan diubah. Satu baris peminjaman yang terlambat.
public record Peminjaman(Item Item, int HariTerlambat);

// Kasir TIDAK perlu tahu jenis item apa pun: ia hanya memanggil
// item.HitungDenda(...) dan objek yang sebenarnya menentukan hasilnya.
public class Kasir
{
    public int TotalDenda(IEnumerable<Peminjaman> daftar)
    {
        if (daftar is null)
            throw new ArgumentNullException(nameof(daftar));

        int total = 0;
        foreach (var p in daftar)
        {
            total += p.Item.HitungDenda(p.HariTerlambat);
        }
        return total;
    }

    public Item? ItemDenganDendaTertinggi(IEnumerable<Peminjaman> daftar)
    {
        if (daftar is null)
            throw new ArgumentNullException(nameof(daftar));

        Item? hasil = null;
        int maxDenda = -1;

        foreach (var p in daftar)
        {
            int denda = p.Item.HitungDenda(p.HariTerlambat);
            if (denda > maxDenda)
            {
                maxDenda = denda;
                hasil = p.Item;
            }
        }
        return hasil;
    }
}