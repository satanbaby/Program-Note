var Tonality = new Map();
Tonality.set('C', '1')
Tonality.set('D', '2')
Tonality.set('E', '3')
Tonality.set('F', '4')
Tonality.set('G', '5')
Tonality.set('A', '6')
Tonality.set('B', '7')

var chords = [...document.querySelectorAll(".tf")]
chords.forEach((item, index)=>{
  for(var [key, value] of Tonality){
    if(item.textContent.indexOf(key)>=0){
      item.innerHTML = item.innerHTML.replace(key, value)
      console.log(item.innerHTML)
    }
  }
})
