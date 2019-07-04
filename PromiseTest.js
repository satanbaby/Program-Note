// 參考 axios 的資料格式，繪製類似框架
// axios.get(URL, date).then(response=> response).catch(e=> e)

let axios = {
  get(url){
    return new Promise((resolve, reject)=> {
      const request  = new XMLHttpRequest();
      request.open("GET", url);
      request.onload = () => resolve(JSON.parse(request.responseText));
      request.onerror = () => reject(request.statusText);
      request.send();
    })
  }
}
