// Três coisas a notar na assinatura:  
//  - O método tem um modificador async.   
//  - O tipo de retorno é Task ou Task <T>. (Veja a seção "Return Types".)  
//    .Aqui, é a Task<int> porque a instrução de retorno retorna um inteiro  
//  - O nome do método termina em "Async."  
async Task<int> AccessTheWebAsync()  
{   
    // Você precisa add System.Net.Http para fazer a declaração de client.  
    using (HttpClient client = new HttpClient())  
    {  
        // GetStringAsync retorna Task<string>. Isso significa que quando você espera a tarefa, 
		//você receberá uma string (urlContents).  
        Task<string> getStringTask = client.GetStringAsync("https://docs.microsoft.com");  
  
        // Você pode trabalhar aqui que não depende da string de GetStringAsync.  
        DoIndependentWork();  
  
        // O operador de espera suspende AccessTheWebAsync.  
        //  - AccessTheWebAsync não pode continuar até que o getStringTask esteja completo.  
        //  - Enquanto isso, o controle retorna ao chamador do AccessTheWebAsync.  
        //  - O controle é retomado aqui quando o getStringTask está completo.   
        //  - O operador await então recupera o resultado da string de getStringTask.  
        string urlContents = await getStringTask;  
  
        // A declaração de retorno especifica um resultado inteiro.  
        // Todos os métodos que estão aguardando o AccessTheWebAsync recuperam o valor do comprimento.  
        return urlContents.Length;  
    }  
}  