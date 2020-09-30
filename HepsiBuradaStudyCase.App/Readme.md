#Açıklama

	Marsa öncü bir uydu indiriliyor. İnilen yüzey dikdörtgen şeklinde ve gezici aracın üzerindeki kamera kullanılarak inilen yüzeyin tam görüntüsünü dünyaya iletecekler. 

	Gezicinin yönü ve konumu sırasıyla X,Y ve Yön belirtilecek şekilde kurgulanmış. Aracın gezeceği alan bir koordinat düzlemi olarak kurgulanmış ve koordinat düzleminde aracın konumu ve yönü ilk aşamada alınmaktadır. Sonraki aşamada ise aracın yönünü belirlemek için çeşitli harf dizinleri verilecektir. Bu harf dizinlerine göre;

	'M' : Araç bir birim ileri gidecek.
	'L' : Araç 90 derece sola dönecek. 
	'R' : Araç 90 derece sağa dönecek.

	Dikkat edilmesi gereken en önemli nokta şu, sol alt kısım orjin noktası (0,0) olarak kabul ediliyor ve sonrasında sağ üst kısmın koordinatları belirtiliyor. Yani sınırın ne olacağı belirleniyor ve bu sınırı geçmemesi gerekmektedir.

#Sonuç

		1 - İlk olarak sağ üst kısmın input değerleri girilecek.
		2 - Sonrasında kaç tane öncü araç gönderileceği girilecek.
		3 - Sırasıyla bu öncü araçlar için
			3.1 - Aracın mevcut konumu x y Yön ile belirtilecek.
			3.2 - Sonrasında belirtilen yön hamleleleri aralarında boşluk olmayacak şekilde alınır. 
			3.3	- (0,0) veya (maxX,maxY) koordinatları aşılırsa hata verilir varsa bir sonraki araca geçilir, yoksa devam edilir X,Y ve Yön koordinatları belirtilir.
		4 - Son olarak girilen aracın son konumu ekrana yazdırılır.