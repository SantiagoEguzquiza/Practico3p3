namespace API_LIBROS
{
    public class API
    {
        public string getLibros(string texto, string key, string pagina)
        {
            UriBuilder builder = new UriBuilder("https://www.googleapis.com/books/v1/volumes");
            builder.Query = $"?key{key}&startIndex={pagina}&q={texto}";

            //Create a query 
            HttpClient client = new HttpClient();
            var result = client.GetAsync(builder.Uri).Result;

            using (StreamReader sr = new StreamReader(result.Content.ReadAsStreamAsync().Result))
            {
                return sr.ReadToEnd();
            }
        }
       
    }
}