// 隨便創建一個物件
var http ={
  request:'get',
  response:'',
  statusCode:200,
  message:'success'
}

// 原始物件名稱:新的別名
var {request:req, statusCode:status} = http

// babel compiler:
var http ={
  request:'get',
  response:'',
  statusCode:200,
  message:'success'
};
var req = http.request,
 status = http.statusCode



// 實用情景
const url = `https://raw.githubusercontent.com/BensonRUEI/CSUMIS/master/gallery.json`;

(async function(){
  var {response: data} = await axios.get(url)  
  console.log('data', data)
})()
