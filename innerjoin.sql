select HAREKETID,URUNAD,(ad+'' +soyad) as 'M��TER�',ADSOYAD,URUNAD  from tblhareket
inner join urunler on tblhareket.URUN=urunler.URUNID

inner join MUSTER� 
on tblhareket.MUSTER� = MUSTER�.ID

inner join PERSONEL 
on PERSONEL.ID =tblhareket.PERSONEL

