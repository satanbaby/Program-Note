// 隨便創建一個物件
var http ={
  request:'get',
  response:'',
  statusCode:200,
  message:'success'
}

// 原始物件名稱:新的別名
var {request:req, statusCode:status} = http
