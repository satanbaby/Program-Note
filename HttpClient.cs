//啟用串流、壓縮
public static IEnumerable<T> Get_API<T>(object model, string url)
{
    string json = JsonConvert.SerializeObject(model);
    var handler = new HttpClientHandler();
    handler.AutomaticDecompression = DecompressionMethods.GZip;
    //建立 HttpClient
    using (var client = new HttpClient(handler))
    using (var contentPost = new StringContent(json, Encoding.UTF8, "application/json"))
    using (var response = client.PostAsync(url, contentPost).Result)
    using (var stream = response.Content.ReadAsStreamAsync().Result)
    using (var sr = new StreamReader(stream))
    using (var reader = new JsonTextReader(sr))
    {
        var setting = new JsonSerializerSettings();
        setting.Converters.Add(new TrimmingConverter());
        var serializer = JsonSerializer.Create(setting);

        //判斷 StatusCode
        if (response.StatusCode != HttpStatusCode.BadRequest)
        {
            return serializer.Deserialize<IEnumerable<T>>(reader);
        }
        else
        {
            // 將回應結果內容取出並轉為 string 再透過 BadRequest 輸出
            var responseMessage = response.Content.ReadAsStringAsync().Result;
            throw new Exception(responseMessage);
        }
    }
}
