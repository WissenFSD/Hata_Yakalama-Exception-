
//try{
//
//
//}
//catch{
//
//
//
//}

using Microsoft.VisualBasic;

int sayi1 = 10;
int sayi2 = 0;
#region örnek1
//try
//{

//    // hata olması muhtemel kod bloklarını içermelidir
//    int sonuc = sayi1 / sayi2;
//    Console.WriteLine(sonuc);

//}
//catch (Exception e)
//{

//    // try içerisindeki kodlarda bir exception olur ise catch blogu çalışacaktır. Bu blok içerisinde kullanıcıya mesaj verme
//    // vb gibi işler yapılabilir.
//    Console.WriteLine(e.Message);
//}


//int a = 50;

//Console.WriteLine(a);
#endregion



// derleyiciyi hata verdircek hata üretir miyiz ?


//try
//{

//    throw new Exception("Manuel oluşturulan bir hata");



//}
//catch (Exception ex)    
//{

//    Console.WriteLine(ex.Message);

//}



try
{
        //bu yöntem ile kendimiz exception üretebiliyoruz !!!
        throw new InvalidOperationException("invalid operation");


}

catch (BadImageFormatException ex)
{
    // her bir catch bloğu kendi sorumluluk alanındaki hatayı yakalamak için yazılır


}
catch(InvalidOperationException ex)
{
    // her bir catch bloğu kendi sorumluluk alanındaki hatayı yakalamak için yazılır


}
catch (Exception ex)
{
    // exception her üst düzey hata olduğu için her zaman en altta olması gerekmektedir.
    Console.WriteLine(ex.Message);

}
