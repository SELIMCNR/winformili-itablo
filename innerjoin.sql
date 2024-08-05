select HAREKETID,URUNAD,(ad+'' +soyad) as 'MÜÞTERÝ',ADSOYAD,URUNAD  from tblhareket
inner join urunler on tblhareket.URUN=urunler.URUNID

inner join MUSTERÝ 
on tblhareket.MUSTERÝ = MUSTERÝ.ID

inner join PERSONEL 
on PERSONEL.ID =tblhareket.PERSONEL

