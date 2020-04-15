// Group By
from f in FackData
group f by f.Gender into item
select item.Take(5)
// with lambda
FackData
   .GroupBy (f => f.Gender)
   .Select (item => item.Take (5))
