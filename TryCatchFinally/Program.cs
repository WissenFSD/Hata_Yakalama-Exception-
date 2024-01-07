


try
{

	//throw new NotImplementedException();

	try
	{
		throw new NotImplementedException("Test");
	}
	catch (Exception ex)
	{
		// yakalanan exception'ın tekrar fırlatılması
		//throw; ---yazım şekli 1
		//throw ex;  // yazım şekli 2conso

		throw new FileNotFoundException("Dosya bulunamadı", ex);

		//Console.WriteLine(ex.Message.ToString());


	}

}
catch(Exception ex)
{
    Console.WriteLine(ex.InnerException.Message.ToString());
}
finally
{

    //hata olsun yada olmasın her koşulda çalışacaktır.
    // açık olan bağlantıların kapatılması gibi kodları yazmak için kullanılmaktadır.
    Console.WriteLine("Finally bloğu çalıştı");

}