// Group By
from f in FackData
group f by f.Gender into item
select item.Take(5)
// with lambda
FackData
   .GroupBy (f => f.Gender)
   .Select (item => item.Take (5))
// Select column
FackData.GroupBy(_=>_.Gender, (key, enumerable)=> new 
{
	key = key,
	First_Name = enumerable.Select(i=>i.First_name).Take(10)
})
