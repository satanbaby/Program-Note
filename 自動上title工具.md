## 自動上 Title

每次都點網站 sideBar 才能看到文件的詳細敘述，很麻煩，寫了一些 javascript，做成標籤執行後，可以使用滑鼠移入快速預覽  
目前寫死的，以後再活化他

``` javascript
var el = [...document.querySelectorAll("h2")]
var result = []
el.forEach(item => result.push(
  {
    // H2 的 id 屬性
    key:item.id,
    // 選取相鄰 H2 的 p 標籤
    value:item.nextSibling.nextElementSibling.outerText
  }
))


var sidebar = document.querySelectorAll("#app > div > div.sidebar > ul > li:nth-child(4) > ul > li > a")
result.forEach(r=>{
    sidebar.forEach(s=>{
        if(s.text.toLowerCase() == r.key){
            s.title = r.value
        }
    })
})
```
